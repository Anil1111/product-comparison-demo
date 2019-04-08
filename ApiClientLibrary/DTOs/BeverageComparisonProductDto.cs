using ApiClientLibrary.Linq;
using ApiClientLibrary.Models;

namespace ApiClientLibrary.DTOs
{
    public sealed class BeverageComparisonProductDto
    {
        public static explicit operator BeverageComparisonProductDto(Beverage beverage)
        {
            return new BeverageComparisonProductDto
            {
                Calories = beverage.GetProperty(dto => ((BeverageComparisonProductDto)dto).Calories),
                Carbohydrate = beverage.GetProperty(dto => ((BeverageComparisonProductDto)dto).Carbohydrate),
                Cholesterol = beverage.GetProperty(dto => ((BeverageComparisonProductDto)dto).Cholesterol),
                Fat = beverage.GetProperty(dto => ((BeverageComparisonProductDto)dto).Fat),
                Fiber = beverage.GetProperty(dto => ((BeverageComparisonProductDto)dto).Fiber),
                MarketingName = beverage.GetProperty(dto => ((BeverageComparisonProductDto)dto).MarketingName),
                PrimaryImage = string.IsNullOrWhiteSpace(beverage.GetProperty(dto => ((BeverageComparisonProductDto)dto).PrimaryImage))
                    ? Constants.ImagePaths.DefaultPrimaryImage : beverage.GetProperty(dto => ((BeverageComparisonProductDto)dto).PrimaryImage),
                Protein = beverage.GetProperty(dto => ((BeverageComparisonProductDto)dto).Protein),
                Size = beverage.GetProperty(dto => ((BeverageComparisonProductDto)dto).Size),
                Sku = beverage.Sku,
                Sodium = beverage.GetProperty(dto => ((BeverageComparisonProductDto)dto).Sodium),
                Sugar = beverage.GetProperty(dto => ((BeverageComparisonProductDto)dto).Sugar)
            };
        }

        private BeverageComparisonProductDto()
        {
        }

        public int Calories { get; private set; }
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