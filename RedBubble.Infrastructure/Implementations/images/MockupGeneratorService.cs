using RedBubble.Application.Interfaces;
using RedBubble.Application.Interfaces.Products;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Drawing.Processing;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;
using System;
using System.IO;
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
            string? colorSpecificMockupUrl,
            int posX, int posY,
            int width, int height,
            string outputFolderRelative = "/uploads/generated/variants")
        {
            if (!string.IsNullOrEmpty(colorSpecificMockupUrl))
            {
                return await GenerateWithColorSpecificMockup(
                    designImageUrl, templateUrl, colorSpecificMockupUrl,
                    posX, posY, width, height, outputFolderRelative);
            }

            throw new InvalidOperationException("Use GenerateMockupWithColorAsync for programmatic color changes");
        }

        public async Task<string> GenerateMockupLegacyAsync(
            string designImageUrl,
            string templateUrl,
            string mockupUrl,
            string colorHex,
            int posX, int posY,
            int width, int height,
            string outputFolderRelative = "/uploads/generated/variants")
        {
            return await GenerateMockupWithColorAsync(
                designImageUrl, templateUrl, mockupUrl, colorHex,
                posX, posY, width, height, outputFolderRelative);
        }

        public async Task<string> GenerateMockupWithColorAsync(
            string designImageUrl,
            string templateUrl,
            string mockupUrl,
            string colorHex,
            int posX, int posY,
            int width, int height,
            string outputFolderRelative = "/uploads/generated/variants")
        {
            var designPath = _fileService.GetImagePath(designImageUrl);
            var mockupPath = !string.IsNullOrEmpty(mockupUrl) ? _fileService.GetImagePath(mockupUrl) : null;

            var outputFolder = _fileService.GetImagePath(outputFolderRelative);
            if (!Directory.Exists(outputFolder))
                Directory.CreateDirectory(outputFolder);

            using var design = await Image.LoadAsync<Rgba32>(designPath);

            if (string.IsNullOrEmpty(mockupPath) || !File.Exists(mockupPath))
            {
                throw new FileNotFoundException($"Mockup file not found: {mockupPath}");
            }

            using var mockup = await Image.LoadAsync<Rgba32>(mockupPath);

            // Create the final canvas
            using var canvas = new Image<Rgba32>(mockup.Width, mockup.Height);
            canvas.Mutate(ctx => ctx.Fill(Color.Transparent));

            // Step 1: Create a mask that identifies t-shirt pixels
            var tshirtMask = CreateTshirtMask(mockup);

            // Step 2: Apply color only to masked areas
            var coloredTshirt = ApplyColorWithMask(mockup, tshirtMask, colorHex);

            // Step 3: Draw the colored t-shirt
            canvas.Mutate(ctx => ctx.DrawImage(coloredTshirt, new Point(0, 0), 1f));

            // Step 4: Resize and draw design on top
            design.Mutate(x => x.Resize(width, height));
            canvas.Mutate(ctx => ctx.DrawImage(design, new Point(posX, posY), 1f));

            var filename = $"variant_{Guid.NewGuid():N}.png";
            var outputPath = Path.Combine(outputFolder, filename);
            await canvas.SaveAsPngAsync(outputPath);

            tshirtMask.Dispose();
            coloredTshirt.Dispose();

            var relativeUrl = $"{outputFolderRelative.TrimEnd('/')}/{filename}";
            return relativeUrl.Replace("\\", "/");
        }

        private Image<L8> CreateTshirtMask(Image<Rgba32> mockup)
        {
            // Create a grayscale mask where white = t-shirt fabric, black = everything else
            var mask = new Image<L8>(mockup.Width, mockup.Height);

            // Process row by row to avoid nested accessor issues
            for (int y = 0; y < mockup.Height; y++)
            {
                var mockupRow = new Rgba32[mockup.Width];
                var maskRow = new L8[mask.Width];

                // Extract mockup row
                mockup.ProcessPixelRows(accessor =>
                {
                    accessor.GetRowSpan(y).CopyTo(mockupRow);
                });

                // Process each pixel in the row
                for (int x = 0; x < mockup.Width; x++)
                {
                    var pixel = mockupRow[x];

                    // If pixel is transparent, it's not t-shirt
                    if (pixel.A < 10)
                    {
                        maskRow[x] = new L8(0); // Black = not t-shirt
                        continue;
                    }

                    // Check if this pixel looks like t-shirt fabric
                    if (IsTshirtFabricPixel(pixel))
                    {
                        maskRow[x] = new L8(255); // White = t-shirt fabric
                    }
                    else
                    {
                        maskRow[x] = new L8(0); // Black = not t-shirt
                    }
                }

                // Write the processed row back to mask
                mask.ProcessPixelRows(accessor =>
                {
                    maskRow.CopyTo(accessor.GetRowSpan(y));
                });
            }

            // Apply morphological operations to clean up the mask
            mask.Mutate(ctx => ctx
                .GaussianBlur(1f) // Smooth edges
                .BinaryThreshold(0.5f)); // Re-binarize

            return mask;
        }

        private bool IsTshirtFabricPixel(Rgba32 pixel)
        {
            // For your white t-shirt mockup with transparent background,
            // t-shirt pixels should be:
            // 1. Not transparent
            // 2. Relatively bright (light fabric)
            // 3. Relatively neutral in color (not strongly tinted)

            // Must have some opacity
            if (pixel.A < 50)
                return false;

            // Should be relatively bright (fabric is light colored)
            int brightness = pixel.R + pixel.G + pixel.B;
            if (brightness < 400) // Adjust this value based on your mockup
                return false;

            // Should be relatively neutral (not strongly colored)
            int maxChannel = Math.Max(Math.Max(pixel.R, pixel.G), pixel.B);
            int minChannel = Math.Min(Math.Min(pixel.R, pixel.G), pixel.B);
            int colorVariation = maxChannel - minChannel;

            // If too much color variation, it's probably not base fabric
            if (colorVariation > 50) // Adjust this value based on your mockup
                return false;

            return true;
        }

        private Image<Rgba32> ApplyColorWithMask(Image<Rgba32> original, Image<L8> mask, string colorHex)
        {
            var targetColor = Color.ParseHex(colorHex).ToPixel<Rgba32>();
            var result = original.Clone();

            // Process row by row to avoid nested accessor issues
            for (int y = 0; y < original.Height; y++)
            {
                var originalRow = new Rgba32[original.Width];
                var maskRow = new L8[mask.Width];
                var resultRow = new Rgba32[result.Width];

                // Extract rows from each image
                original.ProcessPixelRows(accessor =>
                {
                    accessor.GetRowSpan(y).CopyTo(originalRow);
                });

                mask.ProcessPixelRows(accessor =>
                {
                    accessor.GetRowSpan(y).CopyTo(maskRow);
                });

                result.ProcessPixelRows(accessor =>
                {
                    accessor.GetRowSpan(y).CopyTo(resultRow);
                });

                // Process the row
                for (int x = 0; x < original.Width; x++)
                {
                    var originalPixel = originalRow[x];
                    var maskValue = maskRow[x].PackedValue;

                    if (maskValue > 128) // This pixel is marked as t-shirt fabric
                    {
                        // Apply color transformation preserving lighting
                        resultRow[x] = BlendColorPreservingLighting(originalPixel, targetColor);
                    }
                    else
                    {
                        // Keep original pixel unchanged
                        resultRow[x] = originalPixel;
                    }
                }

                // Write the processed row back to result
                result.ProcessPixelRows(accessor =>
                {
                    resultRow.CopyTo(accessor.GetRowSpan(y));
                });
            }

            return result;
        }

        private Rgba32 BlendColorPreservingLighting(Rgba32 originalPixel, Rgba32 targetColor)
        {
            // Calculate the lighting factor from the original pixel
            float lightingFactor = (originalPixel.R + originalPixel.G + originalPixel.B) / (3f * 255f);

            // Apply the lighting factor to the target color
            byte newR = (byte)Math.Min(255, Math.Max(0, targetColor.R * lightingFactor));
            byte newG = (byte)Math.Min(255, Math.Max(0, targetColor.G * lightingFactor));
            byte newB = (byte)Math.Min(255, Math.Max(0, targetColor.B * lightingFactor));

            return new Rgba32(newR, newG, newB, originalPixel.A);
        }

        private async Task<string> GenerateWithColorSpecificMockup(
            string designImageUrl, string templateUrl, string colorSpecificMockupUrl,
            int posX, int posY, int width, int height, string outputFolderRelative)
        {
            var designPath = _fileService.GetImagePath(designImageUrl);
            var mockupPath = _fileService.GetImagePath(colorSpecificMockupUrl);

            var outputFolder = _fileService.GetImagePath(outputFolderRelative);
            if (!Directory.Exists(outputFolder))
                Directory.CreateDirectory(outputFolder);

            using var design = await Image.LoadAsync<Rgba32>(designPath);
            using var mockup = await Image.LoadAsync<Rgba32>(mockupPath);

            using var canvas = new Image<Rgba32>(mockup.Width, mockup.Height);
            canvas.Mutate(ctx => ctx.Fill(Color.Transparent));
            canvas.Mutate(ctx => ctx.DrawImage(mockup, new Point(0, 0), 1f));

            design.Mutate(x => x.Resize(width, height));
            canvas.Mutate(ctx => ctx.DrawImage(design, new Point(posX, posY), 1f));

            var filename = $"variant_{Guid.NewGuid():N}.png";
            var outputPath = Path.Combine(outputFolder, filename);
            await canvas.SaveAsPngAsync(outputPath);

            var relativeUrl = $"{outputFolderRelative.TrimEnd('/')}/{filename}";
            return relativeUrl.Replace("\\", "/");
        }
    }
}