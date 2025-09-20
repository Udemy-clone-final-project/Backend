using System.Threading.Tasks;

namespace RedBubble.Application.Interfaces.Products
{
    public interface IMockupGeneratorService
    {
        /// <summary>
        /// Generates a mockup with optional color-specific mockup support
        /// </summary>
        Task<string> GenerateMockupAsync(
            string designImageUrl,
            string templateUrl,
            string mockupUrl,
            string? colorSpecificMockupUrl,
            int posX, int posY,
            int width, int height,
            string outputFolderRelative = "/uploads/generated/variants");

        /// <summary>
        /// Legacy method for backward compatibility - uses colorHex parameter (deprecated)
        /// </summary>
        Task<string> GenerateMockupLegacyAsync(
            string designImageUrl,
            string templateUrl,
            string mockupUrl,
            string colorHex,
            int posX, int posY,
            int width, int height,
            string outputFolderRelative = "/uploads/generated/variants");

        /// <summary>
        /// Generates mockup with programmatic color changing
        /// </summary>
        Task<string> GenerateMockupWithColorAsync(
            string designImageUrl,
            string templateUrl,
            string mockupUrl,
            string colorHex,
            int posX, int posY,
            int width, int height,
            string outputFolderRelative = "/uploads/generated/variants");
    }
}