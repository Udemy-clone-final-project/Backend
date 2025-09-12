using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using RedBubble.Application.Interfaces;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RedBubble.Infrastructure.Services
{
    public class FileService : IFileService
    {
        private readonly IHostEnvironment _hostEnvironment;
        private readonly string[] _allowedExtensions = { ".jpg", ".jpeg", ".png", ".gif", ".webp" };
        private const long MaxFileSize = 5 * 1024 * 1024;

        public FileService(IHostEnvironment hostEnvironment)
        {
            _hostEnvironment = hostEnvironment;
        }

        public async Task<string> UploadImageAsync(IFormFile file, string folder)
        {
            if (file == null || file.Length == 0)
                throw new ArgumentException("File is required");

            if (!IsValidImageFile(file))
                throw new ArgumentException("Invalid file format or size");

            // Create unique filename
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(file.FileName).ToLowerInvariant()}";

            // Create upload directory if it doesn't exist
            var uploadPath = Path.Combine(_hostEnvironment.ContentRootPath, "wwwroot", "uploads", folder);
            if (!Directory.Exists(uploadPath))
            {
                Directory.CreateDirectory(uploadPath);
            }

            var filePath = Path.Combine(uploadPath, fileName);

            // Save file
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            // Return relative URL for database storage
            return $"/uploads/{folder}/{fileName}";
        }

        public bool DeleteImage(string imageUrl)
        {
            if (string.IsNullOrEmpty(imageUrl))
                return false;

            try
            {
                var filePath = Path.Combine(_hostEnvironment.ContentRootPath, "wwwroot", imageUrl.TrimStart('/'));
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Log exception here
                Console.WriteLine($"Error deleting file: {ex.Message}");
            }

            return false;
        }

        public bool IsValidImageFile(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return false;

            if (file.Length > MaxFileSize)
                return false;

            var extension = Path.GetExtension(file.FileName).ToLowerInvariant();
            return _allowedExtensions.Contains(extension);
        }

        public string GetImagePath(string imageUrl)
        {
            if (string.IsNullOrEmpty(imageUrl))
                return string.Empty;

            return Path.Combine(_hostEnvironment.ContentRootPath, "wwwroot", imageUrl.TrimStart('/'));
        }
    }
}