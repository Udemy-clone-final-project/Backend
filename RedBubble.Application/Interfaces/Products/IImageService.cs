using Microsoft.AspNetCore.Http;
using RedBubble.Application.DTOs.Products;
using System.Threading.Tasks;

namespace RedBubble.Application.Interfaces.Products
{
    public interface IImageService
    {
        /// <summary>
        /// Get image dimensions from uploaded file
        /// </summary>
        Task<(int width, int height)> GetImageDimensionsAsync(IFormFile file);

        /// <summary>
        /// Get image dimensions from file path (physical or relative URL)
        /// </summary>
        Task<(int width, int height)> GetImageDimensionsAsync(string imagePath);

        /// <summary>
        /// Get comprehensive image information from uploaded file
        /// </summary>
        Task<ImageInfo> GetImageInfoAsync(IFormFile file);

        /// <summary>
        /// Validate that a print area fits within template bounds
        /// </summary>
        bool ValidatePrintAreaBounds(int templateWidth, int templateHeight,
            int printAreaX, int printAreaY, int printAreaWidth, int printAreaHeight);
    }
}

// Shared DTO class in Application layer
namespace RedBubble.Application.DTOs.Products
{
    public class ImageInfo
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public string FileName { get; set; } = string.Empty;
        public string FileExtension { get; set; } = string.Empty;
        public long FileSize { get; set; }
        public string ContentType { get; set; } = string.Empty;
    }
}