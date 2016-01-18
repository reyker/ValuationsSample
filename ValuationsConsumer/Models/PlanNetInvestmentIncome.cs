using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ValuationsConsumer.Models
{
    public class PlanNetInvestmentIncome
    {
        public string Name { get; set; }
        public double TransactionId { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal Value { get; set; }
    }
}