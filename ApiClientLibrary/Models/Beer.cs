using Newtonsoft.Json;

namespace ApiClientLibrary.Models
{
    public class Beer : Beverage
    {
        [JsonProperty("alcohol")]
        public string Alcohol { get; private set; }

        public override string Warning { get; } = "This is an alcoholic beverage!";
    }
}