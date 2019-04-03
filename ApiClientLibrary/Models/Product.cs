using Newtonsoft.Json;

namespace ApiClientLibrary.Models
{
    public class Product
    {
        [JsonProperty("calories")]
        public string Calories { get; set; }

        [JsonProperty("carbohydrate")]
        public string Carbohydrate { get; set; }

        [JsonProperty("cholesterol")]
        public string Cholesterol { get; set; }

        [JsonProperty("fat")]
        public string Fat { get; set; }
        
        [JsonProperty("fiber")]
        public string Fiber { get; set; }

        [JsonProperty("marketing_name")]
        public string MarketingName { get; set; }

        [JsonProperty("primary_image")]
        public string PrimaryImage { get; set; }

        [JsonProperty("protein")]
        public string Protein { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }
        
        [JsonProperty("sodium")]
        public string Sodium { get; set; }

        [JsonProperty("sugar")]
        public string Sugar { get; set; }

        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }
    }
}