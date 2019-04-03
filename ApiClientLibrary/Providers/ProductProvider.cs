using System;
using System.IO;
using System.Runtime.Caching;
using System.Text;
using System.Web.Hosting;

using ApiClientLibrary.Models;
using ApiClientLibrary.Serialization;

namespace ApiClientLibrary.Providers
{
    public sealed class ProductProvider
    {
        private readonly Encoding _encoding = Encoding.UTF8;
        private const string CacheKey = "products";

        public ProductSet GetProductListing()
        {
            ProductSet products;
            var cache = MemoryCache.Default;

            if (cache.Contains(CacheKey))
            {
                products = (ProductSet)cache.Get(CacheKey);
            }
            else
            {
                var path = HostingEnvironment.MapPath(@"~\App_Data\products.json");
                var serializationProvider = new JsonSerializationProvider<ProductSet>(_encoding);

                using (var reader = new StreamReader(path ?? throw new InvalidOperationException()))
                {
                    var json = reader.ReadToEnd();
                    products = serializationProvider.Deserialize(json);
                }

                var cacheItemPolicy = new CacheItemPolicy
                {
                    AbsoluteExpiration = DateTime.Now.AddHours(1.0)
                };

                cache.Add(CacheKey, products, cacheItemPolicy);
            }
            
            return products;
        }
    }
}