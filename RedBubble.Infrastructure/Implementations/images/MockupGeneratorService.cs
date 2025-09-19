using RedBubble.Application.Interfaces;
using RedBubble.Application.Interfaces.Products;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Drawing.Processing;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RedBubble.Infrastructure.Implementations.images
{


    public class MockupGeneratorService : IMockupGeneratorService
    {
        private readonly IFileService _fileService;

        public MockupGeneratorService(IFileService fileService)
        {
            _fileService = fileService;
        }

        public async Task<string> GenerateMockupAsync(
            string designImageUrl,
            string templateUrl,
            string mockupUrl,
            string colorHex,
            int posX, int posY,
            int width, int height,
            string outputFolderRelative = "/uploads/generated/variants")
        {
            // Resolve physical paths from relative URLs
            var designPath = _fileService.GetImagePath(designImageUrl);
            var templatePath = !string.IsNullOrEmpty(templateUrl) ? _fileService.GetImagePath(templateUrl) : null;
            var mockupPath = !string.IsNullOrEmpty(mockupUrl) ? _fileService.GetImagePath(mockupUrl) : null;

            // Ensure output folder exists
            var outputFolder = _fileService.GetImagePath(outputFolderRelative);
            if (!Directory.Exists(outputFolder))
                Directory.CreateDirectory(outputFolder);

            // Load images
            using var design = await Image.LoadAsync<Rgba32>(designPath);
            Image<Rgba32>? template = null;
            Image<Rgba32>? mockup = null;

            if (!string.IsNullOrEmpty(templatePath) && File.Exists(templatePath))
                template = await Image.LoadAsync<Rgba32>(templatePath);

            if (!string.IsNullOrEmpty(mockupPath) && File.Exists(mockupPath))
                mockup = await Image.LoadAsync<Rgba32>(mockupPath);

            // Canvas size (prefer mockup → template → design)
            int canvasW = mockup?.Width ?? template?.Width ?? design.Width;
            int canvasH = mockup?.Height ?? template?.Height ?? design.Height;

            // Background color (default transparent if no color given)
            var bgColor = SixLabors.ImageSharp.Color.Transparent;
            if (!string.IsNullOrWhiteSpace(colorHex))
                bgColor = SixLabors.ImageSharp.Color.ParseHex(colorHex);

            using var canvas = new Image<Rgba32>(canvasW, canvasH);
            canvas.Mutate(ctx => ctx.Fill(bgColor));

            // Draw base mockup if exists
            if (mockup != null)
                canvas.Mutate(ctx => ctx.DrawImage(mockup, new Point(0, 0), 1f));

            // Resize and draw design into print area
            design.Mutate(x => x.Resize(width, height));
            canvas.Mutate(ctx => ctx.DrawImage(design, new Point(posX, posY), 1f));

            // Draw template overlay (shading/folds) if exists
            if (template != null)
                canvas.Mutate(ctx => ctx.DrawImage(template, new Point(0, 0), 1f));

            // Save output
            var filename = $"variant_{Guid.NewGuid():N}.png";
            var outputPath = Path.Combine(outputFolder, filename);
            await canvas.SaveAsPngAsync(outputPath);

            // Return relative URL (DB-safe)
            var relativeUrl = $"{outputFolderRelative.TrimEnd('/')}/{filename}";
            return relativeUrl.Replace("\\", "/");
        }
    }

}
