using Newtonsoft.Json;

namespace ApiClientLibrary.Models
{
    public class Beverage : Product
    {
        [JsonProperty("calories")]
        public string Calories { get; private set; }

        [JsonProperty("carbohydrate")]
        public string Carbohydrate { get; private set; }

        [JsonProperty("cholesterol")]
        public string Cholesterol { get; private set; }

        [JsonProperty("fat")]
        public string Fat { get; private set; }

        [JsonProperty("fiber")]
        public string Fiber { get; private set; }

        [JsonProperty("protein")]
        public string Protein { get; private set; }

        [JsonProperty("size")]
        public string Size { get; private set; }

        [JsonProperty("sodium")]
        public string Sodium { get; private set; }

        [JsonProperty("sugar")]
        public string Sugar { get; private set; }

        public virtual string Warning { get; } = "This beverage is boring!";
    }
}