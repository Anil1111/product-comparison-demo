using System.Collections.Generic;

using Newtonsoft.Json;

namespace ApiClientLibrary.Models
{
    public sealed class Beverages
    {
        public Beverages()
        {
            Beers = new List<Beer>();
            Sodas = new List<Soda>();
        }

        public Beverages(List<Beer> beers, List<Soda> sodas)
        {
            Beers = beers;
            Sodas = sodas;
        }

        [JsonProperty("beers")]
        public List<Beer> Beers { get; private set; }

        [JsonProperty("sodas")]
        public List<Soda> Sodas { get; private set; }
    }
}