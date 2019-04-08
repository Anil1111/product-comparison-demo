using ApiClientLibrary.Linq;
using ApiClientLibrary.Models;

namespace ApiClientLibrary.DTOs
{
    public sealed class BeverageComparisonPartialDto
    {
        public static explicit operator BeverageComparisonPartialDto(Beverage beverage)
        {
            return new BeverageComparisonPartialDto
            {
                MarketingName = beverage.GetProperty(dto => ((BeverageComparisonPartialDto)dto).MarketingName),
                Sku = beverage.Sku,
                Thumbnail = string.IsNullOrWhiteSpace(beverage.GetProperty(dto => ((BeverageComparisonPartialDto)dto).Thumbnail))
                    ? Constants.ImagePaths.DefaultThumbnailImage : beverage.GetProperty(dto => ((BeverageComparisonPartialDto)dto).Thumbnail)
            };
        }

        private BeverageComparisonPartialDto()
        {
        }
        
        public string MarketingName { get; private set; }
        public string Sku { get; private set; }
        public string Thumbnail { get; private set; }
    }
}