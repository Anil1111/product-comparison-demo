using System.Collections.Generic;

using Newtonsoft.Json;

namespace ApiClientLibrary.Models
{
    public sealed class ProductSet
    {
        public ProductSet()
        {
            Products = new List<Product>();
        }

        public ProductSet(List<Product> products)
        {
            Products = products;
        }

        [JsonProperty("products")]
        public List<Product> Products { get; set; }
    }
}