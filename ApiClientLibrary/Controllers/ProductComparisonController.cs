using System.Linq;
using System.Web.Http;

using ApiClientLibrary.DTOs;
using ApiClientLibrary.Models;
using ApiClientLibrary.Providers;

namespace ApiClientLibrary.Controllers
{
    [RoutePrefix("api/compare")]
    public sealed class ProductComparisonController : ApiControllerBase
    {
        [HttpGet, Route("product")]
        public IHttpActionResult GetComparableProduct(string sku)
        {
            var productProvider = new ProductProvider();

            var products = productProvider.GetProductListing().Products;

            var product = products.SingleOrDefault(x => x.Sku == sku);

            if (product == null)
            {
                return NotFound();
            }

            var productComparisonDto = (ProductComparisonPartialDto)product;

            return Json(productComparisonDto);
        }
        
        [HttpGet, Route("products")]
        public IHttpActionResult GetComparableProducts([FromUri] string[] skus)
        {
            if (skus == null || skus.Length <= 0)
            {
                return NotFound();
            }

            var productComparisonPageDto = new ProductComparison();
            var productProvider = new ProductProvider();

            var products = productProvider.GetProductListing().Products;

            foreach (var sku in skus)
            {
                var product = products.SingleOrDefault(x => x.Sku == sku);

                if (product == null) continue;
                var productComparisonFullDto = (ProductComparisonProductDto)product;
                productComparisonPageDto.Products.Add(productComparisonFullDto);
            }

            return Json(productComparisonPageDto);
        }
    }
}