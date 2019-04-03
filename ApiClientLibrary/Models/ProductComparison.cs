using System.Collections.Generic;

using ApiClientLibrary.DTOs;

namespace ApiClientLibrary.Models
{
    public sealed class ProductComparison
    {
        public ProductComparison()
        {
            Products = new List<ProductComparisonProductDto>();
        }

        public List<ProductComparisonProductDto> Products { get; set; }
    }
}