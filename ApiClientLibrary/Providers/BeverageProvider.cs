using System;
using System.IO;
using System.Runtime.Caching;
using System.Text;
using System.Web.Hosting;

using ApiClientLibrary.Models;
using ApiClientLibrary.Serialization;

namespace ApiClientLibrary.Providers
{
    public sealed class BeverageProvider : ProductProviderBase<Beverages>
    {
        private readonly Encoding _encoding = Encoding.UTF8;
        private const string CacheKey = "beverages";

        public override Beverages Get()
        {
            Beverages beverages;
            var cache = MemoryCache.Default;

            if (cache.Contains(CacheKey))
            {
                beverages = (Beverages)cache.Get(CacheKey);
            }
            else
            {
                var path = HostingEnvironment.MapPath(@"~\App_Data\beverages.json");
                var serializationProvider = new JsonSerializationProvider<Beverages>(_encoding);

                using (var reader = new StreamReader(path ?? throw new InvalidOperationException()))
                {
                    var json = reader.ReadToEnd();
                    beverages = serializationProvider.Deserialize(json);
                }

                var cacheItemPolicy = new CacheItemPolicy
                {
                    AbsoluteExpiration = DateTime.Now.AddHours(1.0)
                };

                cache.Add(CacheKey, beverages, cacheItemPolicy);
            }
            
            return beverages;
        }
    }
}