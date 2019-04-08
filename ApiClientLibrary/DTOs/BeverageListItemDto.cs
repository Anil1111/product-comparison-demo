using ApiClientLibrary.Linq;
using ApiClientLibrary.Models;

namespace ApiClientLibrary.DTOs
{
    public sealed class BeverageListItemDto
    {
        public static explicit operator BeverageListItemDto(Beverage beverage)
        {
            return new BeverageListItemDto
            {
                Alcohol = beverage.GetProperty(dto => ((BeverageListItemDto)dto).Alcohol),
                Caffeine = beverage.GetProperty(dto => ((BeverageListItemDto)dto).Caffeine),
                Calories = beverage.GetProperty(dto => ((BeverageListItemDto)dto).Calories),
                Carbohydrate = beverage.GetProperty(dto => ((BeverageListItemDto)dto).Carbohydrate),
                MarketingName = beverage.GetProperty(dto => ((BeverageListItemDto)dto).MarketingName),
                PrimaryImage = string.IsNullOrEmpty(beverage.GetProperty(dto => ((BeverageListItemDto)dto).PrimaryImage))
                    ? Constants.ImagePaths.DefaultPrimaryImage :
                    beverage.GetProperty(dto => ((BeverageListItemDto)dto).PrimaryImage),
                Size = beverage.GetProperty(dto => ((BeverageListItemDto)dto).Size),
                Sku = beverage.Sku,
                Warning = beverage.Warning
            };
        }

        private BeverageListItemDto()
        {
        }

        public string Alcohol { get; private set; }
        public string Caffeine { get; private set; }
        public int Calories { get; private set; }
        public string Carbohydrate { get; private set; }
        public string MarketingName { get; private set; }
        public string PrimaryImage { get; private set; }
        public string Size { get; private set; }
        public string Sku { get; private set; }
        public string Warning { get; private set; }
    }
}