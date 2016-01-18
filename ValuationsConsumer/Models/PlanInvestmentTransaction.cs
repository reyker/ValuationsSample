using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ValuationsConsumer.Models
{
    public class PlanInvestmentTransaction
    {
        public DateTime TransactionDate { get; set; }
        public double TransactionId { get; set; }
        public string TransactionType { get; set; }
        public string Name { get; set; }
        public double Quantity { get; set; }
    }
}