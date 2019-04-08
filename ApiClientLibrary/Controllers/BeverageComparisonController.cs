using System.Web.Http;

using ApiClientLibrary.DTOs;
using ApiClientLibrary.Helpers;
using ApiClientLibrary.Models;
using ApiClientLibrary.Providers;

namespace ApiClientLibrary.Controllers
{
    [RoutePrefix("api/compare")]
    public sealed class BeverageComparisonController : ApiControllerBase
    {
        [HttpGet, Route("beverage")]
        public IHttpActionResult GetBeverage(string sku)
        {
            var beverageProvider = new BeveragesProvider();

            var beverages = beverageProvider.Get();

            var beverage = BeverageHelper.FindBeverage(beverages, sku);

            if (beverage == null)
            {
                return NotFound();
            }

            var productComparisonDto = (BeverageComparisonPartialDto)beverage;

            return Json(productComparisonDto);
        }
        
        [HttpGet, Route("beverages")]
        public IHttpActionResult GetBeverages([FromUri] string[] skus)
        {
            if (skus == null || skus.Length <= 0)
            {
                return NotFound();
            }

            var productComparisonPageDto = new BeverageComparison();
            var beverageProvider = new BeveragesProvider();

            var beverages = beverageProvider.Get();

            foreach (var sku in skus)
            {
                var beverage = BeverageHelper.FindBeverage(beverages, sku);

                if (beverage == null) continue;
                var productComparisonFullDto = (BeverageComparisonProductDto)beverage;
                productComparisonPageDto.Beverages.Add(productComparisonFullDto);
            }

            return Json(productComparisonPageDto);
        }
    }
}