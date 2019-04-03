using ApiClientLibrary.Linq;
using ApiClientLibrary.Models;

namespace ApiClientLibrary.DTOs
{
    public sealed class ProductComparisonPartialDto
    {
        public static explicit operator ProductComparisonPartialDto(Product product)
        {
            return new ProductComparisonPartialDto
            {
                MarketingName = product.GetProperty(dto => ((ProductComparisonProductDto)dto).MarketingName),
                Sku = product.Sku,
                Thumbnail = string.IsNullOrWhiteSpace(product.GetProperty(dto => ((ProductComparisonPartialDto)dto).Thumbnail))
                    ? Constants.ImagePaths.DefaultThumbnailImage : product.GetProperty(dto => ((ProductComparisonPartialDto)dto).Thumbnail)
            };
        }

        private ProductComparisonPartialDto()
        {
        }
        
        public string MarketingName { get; private set; }
        public string Sku { get; private set; }
        public string Thumbnail { get; private set; }
    }
}