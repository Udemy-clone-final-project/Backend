using global::RedBubble.Application.Interfaces.Products;
using global::RedBubble.Domain.Entities.Models;
using global::RedBubble.Domain.Entities.Models.Products;
using global::RedBubble.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using RedBubble.Application.Interfaces;
using RedBubble.Domain.Entities.Models;
using RedBubble.Domain.Entities.Models.Products;
using RedBubble.Domain.Interfaces;
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;
namespace RedBubble.Application.Services.Products
{
 

    
        public class VariantGeneratorService : IVariantGeneratorService
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMockupGeneratorService _mockupGenerator;

            public VariantGeneratorService(
                IUnitOfWork unitOfWork,
                IMockupGeneratorService mockupGenerator)
            {
                _unitOfWork = unitOfWork;
                _mockupGenerator = mockupGenerator;
            }

        public async Task GenerateVariantsAsync(int designId, int baseProductId)
        {
            var designRepo = _unitOfWork.GetRepository<Design, int>();
            var baseProductRepo = _unitOfWork.GetRepository<BaseProduct, int>();
            var variantRepo = _unitOfWork.GetRepository<ProductVariant, int>();
            var variantImageRepo = _unitOfWork.GetRepository<ProductVariantImages, int>();

            var design = await designRepo.GetByIdAsync(designId);
            //var baseProduct = await baseProductRepo.GetByIdAsync(baseProductId);
            var baseProduct = await baseProductRepo.GetAll()
    .Include(bp => bp.AvailableSizes).ThenInclude(s => s.Size)
    .Include(bp => bp.AvailableColors).ThenInclude(c => c.Color)
    .Include(bp => bp.Templates)
    .Include(bp => bp.PrintAreas)
    .FirstOrDefaultAsync(bp => bp.Id == baseProductId);

            if (design == null || baseProduct == null)
                throw new ArgumentException("Design or BaseProduct not found.");

            // Load sizes and colors
            //var availableSizes = baseProduct.AvailableSizes?.Where(s => s.IsActive).Select(s => s.Size).ToList() ?? new();
            //var availableColors = baseProduct.AvailableColors?.Where(c => c.IsActive).Select(c => c.Color).ToList() ?? new();
            var availableSizes = baseProduct.HasSizes
    ? baseProduct.AvailableSizes?.Where(s => s.IsActive).Select(s => s.Size).ToList()
    : new List<Size?> { null };

            var availableColors = baseProduct.HasColors
                ? baseProduct.AvailableColors?.Where(c => c.IsActive).Select(c => c.Color).ToList()
                : new List<Color?> { null };

            // fallback if none
            if (!availableSizes.Any()) availableSizes.Add(null);
            if (!availableColors.Any()) availableColors.Add(null);

            // Load existing variants once
            var existingVariants = await variantRepo.GetAll()
                .Where(v => v.DesignId == design.Id && v.BaseProductId == baseProduct.Id)
                .Select(v => new { v.SizeId, v.ColorId })
                .ToListAsync();

            var existingSet = new HashSet<(int? SizeId, int? ColorId)>(
                existingVariants.Select(v => (v.SizeId, v.ColorId)));
            var newVariants = new List<ProductVariant>();
            foreach (var size in availableSizes)
            {
                foreach (var color in availableColors)
                {
                    var sizeId = size?.Id;
                    var colorId = color?.Id;

                    if (existingSet.Contains((sizeId, colorId)))
                        continue;

                    var variant = new ProductVariant
                    {
                        BaseProductId = baseProduct.Id,
                        DesignId = design.Id,
                        SizeId = sizeId,
                        ColorId = colorId,
                        Price = baseProduct.BasePrice + design.Price,
                        IsActive = true
                    };


                    newVariants.Add(variant);
                    

                    // also add it into set so it doesn’t regenerate later in the loop
                    existingSet.Add((sizeId, colorId));
                }
            }
            using var transaction = await _unitOfWork.BeginTransactionAsync();

            try
            {
                // 1. Insert all variants
                if (newVariants.Any())
                {
                    await variantRepo.AddRangeAsync(newVariants);
                    await _unitOfWork.CompleteAsync();
                }

                // 2. Generate all mockups & insert images
                if (newVariants.Any())
                {
                    var variantImages = new List<ProductVariantImages>();

                    foreach (var variant in newVariants)
                    {
                        var template = baseProduct.Templates
                            .Where(t => t.IsActive)
                            .OrderByDescending(t => t.IsPrimary)
                            .ThenBy(t => t.DisplayOrder)
                            .FirstOrDefault();

                        var printArea = baseProduct.PrintAreas
                            .Where(pa => pa.IsActive &&
                                         pa.AreaName.Equals(template.ViewName, StringComparison.OrdinalIgnoreCase))
                            .OrderBy(pa => pa.DisplayOrder)
                            .FirstOrDefault();

                        if (template == null || printArea == null)
                            continue;

                        var mockupUrl = await _mockupGenerator.GenerateMockupAsync(
                            design.ImageUrl,
                            template.TemplateUrl,
                            template.MockupUrl,
                            variant.Color?.ColorCode ?? "#FFFFFF",
                            printArea.PositionX,
                            printArea.PositionY,
                            (int)printArea.Width,
                            (int)printArea.Height,
                            "/uploads/generated/variants"
                        );

                        variantImages.Add(new ProductVariantImages
                        {
                            ProductVariantId = variant.Id,
                            ImageUrl = mockupUrl,
                            FileName = $"variant_{variant.Id}.png",
                            AltText = $"{design.Title} on {baseProduct.Name}",
                            IsPrimary = true,
                            IsActive = true
                        });
                    }

                    if (variantImages.Any())
                    {
                        await variantImageRepo.AddRangeAsync(variantImages);
                        await _unitOfWork.CompleteAsync();
                    }
                }

                // 3. Commit everything
                await transaction.CommitAsync();
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                throw; // bubble up error for logging/handling
            }



        }

    }
}
    


