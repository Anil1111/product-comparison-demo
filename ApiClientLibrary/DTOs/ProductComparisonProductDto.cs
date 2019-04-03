using ApiClientLibrary.Linq;
using ApiClientLibrary.Models;

namespace ApiClientLibrary.DTOs
{
    public sealed class ProductComparisonProductDto
    {
        public static explicit operator ProductComparisonProductDto(Product product)
        {
            return new ProductComparisonProductDto
            {
                Calories = product.GetProperty(dto => ((ProductComparisonProductDto)dto).Calories),
                Carbohydrate = product.GetProperty(dto => ((ProductComparisonProductDto)dto).Carbohydrate),
                Cholesterol = product.GetProperty(dto => ((ProductComparisonProductDto)dto).Cholesterol),
                Fat = product.GetProperty(dto => ((ProductComparisonProductDto)dto).Fat),
                Fiber = product.GetProperty(dto => ((ProductComparisonProductDto)dto).Fiber),
                MarketingName = product.GetProperty(dto => ((ProductComparisonProductDto)dto).MarketingName),
                PrimaryImage = string.IsNullOrWhiteSpace(product.GetProperty(dto => ((ProductComparisonProductDto)dto).PrimaryImage))
                    ? Constants.ImagePaths.DefaultPrimaryImage : product.GetProperty(dto => ((ProductComparisonProductDto)dto).PrimaryImage),
                Protein = product.GetProperty(dto => ((ProductComparisonProductDto)dto).Protein),
                Size = product.GetProperty(dto => ((ProductComparisonProductDto)dto).Size),
                Sku = product.Sku,
                Sodium = product.GetProperty(dto => ((ProductComparisonProductDto)dto).Sodium),
                Sugar = product.GetProperty(dto => ((ProductComparisonProductDto)dto).Sugar)
            };
        }

        private ProductComparisonProductDto()
        {
        }

        public string Calories { get; private set; }
        public string Carbohydrate { get; private set; }
        public string Cholesterol { get; private set; }
        public string Fat { get; private set; }
        public string Fiber { get; private set; }
        public string MarketingName { get; private set; }
        public string PrimaryImage { get; private set; }
        public string Protein { get; private set; }
        public string Size { get; private set; }
        public string Sku { get; private set; }
        public string Sodium { get; private set; }
        public string Sugar { get; private set; }
    }
}