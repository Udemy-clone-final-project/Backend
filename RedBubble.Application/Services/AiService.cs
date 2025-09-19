using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using RedBubble.Application.Interfaces;
using RedBubble.Application.Interfaces.Services;
using RedBubble.Application.Interfaces.Products;
using System.Text.RegularExpressions;

namespace RedBubble.Application.Services
{
    public class AiService : IAiService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        private readonly IBaseProductService _baseProductService;
        private readonly IProductVariantService _productVariantService;

        public AiService(IHttpClientFactory httpClientFactory, IConfiguration configuration, IBaseProductService baseProductService, IProductVariantService productVariantService)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
            _baseProductService = baseProductService;
            _productVariantService = productVariantService;
        }

        public async Task<string> GenerateChatResponseAsync(string message, string? userId, CancellationToken cancellationToken = default)
        {
            var apiKey = _configuration["Ai:OpenAiApiKey"];
            var model = _configuration["Ai:Model"] ?? "gpt-4o-mini";
            var endpoint = _configuration["Ai:Endpoint"] ?? "https://api.openai.com/v1/chat/completions";

            if (string.IsNullOrWhiteSpace(apiKey))
            {
                return "AI is not configured.";
            }

            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);

            // Fetch relevant products from catalog to ground the answer
            string catalogContext = string.Empty;
            try
            {
                var matches = await _baseProductService.SearchBaseProductsAsync(message);
                var top = matches.Take(5).ToList();

                // Parse color/size/price from the query
                var msgLower = message.ToLowerInvariant();
                var sizeMatch = Regex.Match(msgLower, "\\b(xxl|xl|l|m|s|xs)\\b", RegexOptions.IgnoreCase);
                var size = sizeMatch.Success ? sizeMatch.Groups[1].Value : string.Empty;
                var colors = new[] {"black","white","red","blue","green","yellow","pink","purple","orange","gray","grey","brown","beige"};
                var color = colors.FirstOrDefault(c => msgLower.Contains(c));
                var priceMatch = Regex.Match(msgLower, @"(?:under|below|less than|<=|<|maximum|max|upto|up to|under\\s*\\$?)\\s*(\\d{2,6})");
                if (!priceMatch.Success) priceMatch = Regex.Match(msgLower, @"\\$(\\d{2,6})");
                decimal? maxPrice = priceMatch.Success && decimal.TryParse(priceMatch.Groups[1].Value, out var pmax) ? pmax : null;

                if (top.Count == 0)
                {
                    // Use variants search for broader fetch (no search term), then filter locally
                    var variantsPage = await _productVariantService.GetActiveVariantsAsync(null, null, null, null, page: 1, pageSize: 200);
                    var variants = variantsPage.Items.AsEnumerable();

                    // Normalize synonyms/keywords
                    var tshirtKeywords = new[] { "t-shirt", "tshirt", "tee", "shirt" };
                    bool wantsTshirt = tshirtKeywords.Any(k => msgLower.Contains(k));
                    if (wantsTshirt)
                    {
                        variants = variants.Where(v =>
                            (v.BaseProductName != null && tshirtKeywords.Any(k => v.BaseProductName.ToLower().Contains(k))) ||
                            (v.DesignTitle != null && tshirtKeywords.Any(k => v.DesignTitle.ToLower().Contains(k)))
                        );
                    }

                    if (!string.IsNullOrEmpty(color))
                    {
                        // map grey -> gray etc.
                        var normalizedColor = color.Replace("grey", "gray");
                        variants = variants.Where(v => v.ColorName != null && v.ColorName.ToLower().Contains(normalizedColor));
                    }
                    if (!string.IsNullOrEmpty(size))
                    {
                        variants = variants.Where(v => v.SizeName != null && v.SizeName.ToLower().Contains(size));
                    }
                    if (maxPrice.HasValue)
                    {
                        variants = variants.Where(v => v.Price <= maxPrice.Value);
                    }

                    var list = variants.Take(5).ToList();
                    if (list.Count > 0)
                    {
                        var sbv = new StringBuilder();
                        sbv.AppendLine("Catalog variants (only use these facts):");
                        int i = 1;
                        foreach (var v in list)
                        {
                            sbv.AppendLine($"{i}. Name: {v.BaseProductName}; Color: {v.ColorName}; Size: {v.SizeName}; Price: {v.Price}");
                            i++;
                        }
                        catalogContext = sbv.ToString();
                    }
                }

                if (top.Count > 0 && string.IsNullOrEmpty(catalogContext))
                {
                    var sb = new StringBuilder();
                    sb.AppendLine("Catalog items (only use these facts):");
                    int i = 1;
                    foreach (var p in top)
                    {
                        sb.AppendLine($"{i}. Name: {p.Name}; Category: {p.CategoryName}; BasePrice: {p.BasePrice}; HasSizes: {p.HasSizes}; HasColors: {p.HasColors}");
                        i++;
                    }
                    catalogContext = sb.ToString();
                }
            }
            catch
            {
                // If catalog lookup fails, continue without grounding
            }

            var messages = new List<object>
            {
                new { role = "system", content = "You are a helpful e-commerce assistant for a RedBubble-like store. Always respond in English. Keep answers concise and practical. If the user asks about products, ONLY use the provided catalog context. If you don't find a matching product in the context, say you couldn't find matching products and suggest using the site search." }
            };

            if (!string.IsNullOrWhiteSpace(catalogContext))
            {
                messages.Add(new { role = "system", content = catalogContext });
            }

            messages.Add(new { role = "user", content = message });

            var payload = new
            {
                model,
                messages = messages.ToArray(),
                temperature = 0.5
            };

            var json = JsonSerializer.Serialize(payload);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            using var response = await client.PostAsync(endpoint, content, cancellationToken);
            response.EnsureSuccessStatusCode();
            using var stream = await response.Content.ReadAsStreamAsync(cancellationToken);
            using var doc = await JsonDocument.ParseAsync(stream, cancellationToken: cancellationToken);
            var root = doc.RootElement;
            var text = root.GetProperty("choices")[0].GetProperty("message").GetProperty("content").GetString();
            return text ?? string.Empty;
        }
    }
}


