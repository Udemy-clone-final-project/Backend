using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace RedBubble.Application.Interfaces
{
    public interface IFileService
    {
        Task<string> UploadImageAsync(IFormFile file, string folder);
        bool DeleteImage(string imageUrl);
        bool IsValidImageFile(IFormFile file);
        string GetImagePath(string imageUrl);
    }
}