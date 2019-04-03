using System.Collections.Generic;

using ApiClientLibrary.DTOs;

namespace ApiClientLibrary.Models
{
    public sealed class ProductListing
    {
       public List<ProductListItemDto> Products { get; set; }
    }
}