using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ValuationsConsumer.Models
{
    public class PlanPortfolioValuation
    {
        public string Name { get; set; }
        public double? Quantity { get; set; }
        public decimal? Value { get; set; }
        public decimal? BookCost { get; set; }
        public decimal? Price { get; set; }
    }
}