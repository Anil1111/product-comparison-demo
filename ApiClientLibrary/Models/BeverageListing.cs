using System.Collections.Generic;

using ApiClientLibrary.DTOs;

namespace ApiClientLibrary.Models
{
    public sealed class BeverageListing
    {
        public BeverageListing()
        {
            Beverages = new List<BeverageListItemDto>();
        }

       public List<BeverageListItemDto> Beverages { get; set; }
    }
}