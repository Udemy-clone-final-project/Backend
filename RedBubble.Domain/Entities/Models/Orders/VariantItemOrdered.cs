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

        public VariantItemOrdered(int variantId, string designTitle, string productName, string pictureUrl)
        {
            VariantId = variantId;
            DesignTitle = designTitle;
            ProductName = productName;
            PictureUrl = pictureUrl;
        }

        public int VariantId { get; private set; }
        public string DesignTitle { get; private set; }
        public string ProductName { get; private set; }
        public string PictureUrl { get; private set; }
    }
}
