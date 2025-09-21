using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Domain.Entities.Models.Orders
{
    public class VariantItemOrdered
    {
       
        private VariantItemOrdered() { }

        public VariantItemOrdered(int variantId, string designTitle, string productName, string pictureUrl, string? colorName = null, string? sizeName = null)
        {
            VariantId = variantId;
            DesignTitle = designTitle;
            ProductName = productName;
            PictureUrl = pictureUrl;
            ColorName = colorName;
            SizeName = sizeName;
        }

        public int VariantId { get; private set; }
        public string DesignTitle { get; private set; }
        public string ProductName { get; private set; }
        public string PictureUrl { get; private set; }
        public string? ColorName { get; private set; }
        public string? SizeName { get; private set; }
    }
}
