using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using RedBubble.Application.Interfaces;
using RedBubble.Application.Interfaces.Products;
using RedBubble.Application.DTOs.Products;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using System.IO;
using System.Threading.Tasks;
namespace RedBubble.Infrastructure.Services
{
    public class ImageService : IImageService
    {
        private readonly IHostEnvironment _hostEnvironment;

        public ImageService(IHostEnvironment hostEnvironment)
        {
            _hostEnvironment = hostEnvironment;
        }

        public async Task<(int width, int height)> GetImageDimensionsAsync(IFormFile file)
        {
            if (file == null || file.Length == 0)
                throw new ArgumentException("File is required", nameof(file));

            using var stream = file.OpenReadStream();
            using var image = await Image.LoadAsync<Rgba32>(stream);
            return (image.Width, image.Height);
        }

        public async Task<(int width, int height)> GetImageDimensionsAsync(string imagePath)
        {
            if (string.IsNullOrWhiteSpace(imagePath))
                throw new ArgumentException("Image path is required", nameof(imagePath));

            // Handle both relative URLs and absolute paths
            string fullPath;
            if (imagePath.StartsWith("/"))
            {
                // Relative URL - convert to physical path
                fullPath = Path.Combine(_hostEnvironment.ContentRootPath, "wwwroot", imagePath.TrimStart('/'));
            }
            else
            {
                // Assume it's already a physical path
                fullPath = imagePath;
            }

            if (!File.Exists(fullPath))
                throw new FileNotFoundException($"Image file not found: {fullPath}");

            using var image = await Image.LoadAsync<Rgba32>(fullPath);
            return (image.Width, image.Height);
        }

        public async Task<Application.DTOs.Products.ImageInfo> GetImageInfoAsync(IFormFile file)
        {
            if (file == null || file.Length == 0)
                throw new ArgumentException("File is required", nameof(file));

            using var stream = file.OpenReadStream();
            using var image = await Image.LoadAsync<Rgba32>(stream);

            return new Application.DTOs.Products.ImageInfo
            {
                Width = image.Width,
                Height = image.Height,
                FileName = Path.GetFileNameWithoutExtension(file.FileName),
                FileExtension = Path.GetExtension(file.FileName),
                FileSize = file.Length,
                ContentType = file.ContentType
            };
        }

        public bool ValidatePrintAreaBounds(int templateWidth, int templateHeight,
            int printAreaX, int printAreaY, int printAreaWidth, int printAreaHeight)
        {
            // Check if print area fits within template bounds
            return printAreaX >= 0 &&
                   printAreaY >= 0 &&
                   (printAreaX + printAreaWidth) <= templateWidth &&
                   (printAreaY + printAreaHeight) <= templateHeight;
        }
    }
}