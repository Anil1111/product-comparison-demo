using Newtonsoft.Json;

namespace ApiClientLibrary.Models
{
    public class Soda : Beverage
    {
        [JsonProperty("caffeine")]
        public string Caffeine { get; private set; }

        public override string Warning { get; } = "This is a caffeinated beverage!";
    }
}