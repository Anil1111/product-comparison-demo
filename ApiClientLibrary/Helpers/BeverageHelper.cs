using System.Linq;

using ApiClientLibrary.Models;

namespace ApiClientLibrary.Helpers
{
    public static class BeverageHelper
    {
        public static Beverage FindBeverage(Beverages beverages, string sku)
        {
            var soda = beverages.Sodas.SingleOrDefault(x => x.Sku.Equals(sku));

            if (soda != null)
            {
                return soda;
            }

            var beer = beverages.Beers.SingleOrDefault(x => x.Sku.Equals(sku));

            return beer;
        }
    }
}