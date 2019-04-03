using System.Linq;
using System.Web.Http;

using ApiClientLibrary.DTOs;
using ApiClientLibrary.Models;
using ApiClientLibrary.Providers;

namespace ApiClientLibrary.Controllers
{
    [RoutePrefix("api/product-listing")]
    public sealed class ProductListingController : ApiControllerBase
    {
        [HttpGet, Route("all")]
        public IHttpActionResult GetProductListing()
        {
            var productProvider = new ProductProvider();

            var products = productProvider.GetProductListing().Products;

            if (!products.Any())
            {
                return NotFound();
            }

            var productListing = new ProductListing
            {
               Products = products
                   .Select(x => (ProductListItemDto)x)
                   .ToList()
            };

            return Json(productListing);
        }
    }
}