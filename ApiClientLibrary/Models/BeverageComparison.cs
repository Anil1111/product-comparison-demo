using System.Collections.Generic;

using ApiClientLibrary.DTOs;

namespace ApiClientLibrary.Models
{
    public sealed class BeverageComparison
    {
        public BeverageComparison()
        {
            Beverages = new List<BeverageComparisonProductDto>();
        }

        public List<BeverageComparisonProductDto> Beverages { get; set; }
    }
}