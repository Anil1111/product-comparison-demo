using ApiClientLibrary.Linq;
using ApiClientLibrary.Models;

namespace ApiClientLibrary.DTOs
{
    public sealed class ProductListItemDto
    {
        public static explicit operator ProductListItemDto(Product product)
        {
            return new ProductListItemDto
            {
                Calories = product.GetProperty(dto => ((ProductListItemDto)dto).Calories),
                MarketingName = product.GetProperty(dto => ((ProductListItemDto)dto).MarketingName),
                PrimaryImage = string.IsNullOrEmpty(product.GetProperty(dto => ((ProductListItemDto)dto).PrimaryImage)) ? Constants.ImagePaths.DefaultPrimaryImage :
                    product.GetProperty(dto => ((ProductListItemDto)dto).PrimaryImage),
                Size = product.GetProperty(dto => ((ProductListItemDto)dto).Size),
                Sku = product.Sku,
                Sugar = product.GetProperty(dto => ((ProductListItemDto)dto).Sugar)
            };
        }

        private ProductListItemDto()
        {
        }

        public string Calories { get; private set; }
        public string MarketingName { get; private set; }
        public string PrimaryImage { get; private set; }
        public string Size { get; private set; }
        public string Sku { get; private set; }
        public string Sugar { get; private set; }
    }
}