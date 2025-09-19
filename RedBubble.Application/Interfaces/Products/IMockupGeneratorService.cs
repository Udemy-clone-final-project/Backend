using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Application.Interfaces.Products
{
    // IMockupGeneratorService.cs (Application)
    public interface IMockupGeneratorService
    {
        /// <summary>
        /// Generates a composite mockup (design applied to template + mockup, with optional color overlay).
        /// Returns the relative URL (e.g. /uploads/generated/variants/xxx.png).
        /// </summary>
        Task<string> GenerateMockupAsync(
            string designImageUrl,   // relative path from DB (/uploads/designs/abc.png)
            string templateUrl,      // transparent template (optional)
            string mockupUrl,        // background/mockup (optional)
            string colorHex,         // "#FFFFFF"
            int posX, int posY,      // placement of design
            int width, int height,   // design size in px
            string outputFolderRelative = "/uploads/generated/variants");
    }

}
