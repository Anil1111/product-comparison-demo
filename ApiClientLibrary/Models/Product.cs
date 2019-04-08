using Newtonsoft.Json;

namespace ApiClientLibrary.Models
{
    public class Product
    {
        [JsonProperty("marketing_name")]
        public string MarketingName { get; private set; }

        [JsonProperty("primary_image")]
        public string PrimaryImage { get; private set; }
        
        [JsonProperty("sku")]
        public string Sku { get; private set; }

        [JsonProperty("thumbnail")]
        public string Thumbnail { get; private set; }
    }
}