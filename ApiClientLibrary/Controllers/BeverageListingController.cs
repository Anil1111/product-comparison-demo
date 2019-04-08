using System.Linq;
using System.Web.Http;

using ApiClientLibrary.DTOs;
using ApiClientLibrary.Models;
using ApiClientLibrary.Providers;

namespace ApiClientLibrary.Controllers
{
    [RoutePrefix("api/beverage-listing")]
    public sealed class BeverageListingController : ApiControllerBase
    {
        [HttpGet, Route("all")]
        public IHttpActionResult GetBeverageListing()
        {
            var beverageProvider = new BeverageProvider();
            var beverageListing = new BeverageListing();

            var beverages = beverageProvider.Get();

            if (beverages.Beers.Any())
            {
                beverageListing.Beverages
                    .AddRange(beverages.Beers.Select(x => 
                        (BeverageListItemDto)x).ToList());
            }

            if (beverages.Sodas.Any())
            {
                beverageListing.Beverages
                    .AddRange(beverages.Sodas.Select(x =>
                        (BeverageListItemDto)x).ToList());
            }

            return Json(beverageListing);
        }
    }
}