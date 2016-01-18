using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ValuationsConsumer.Models
{
    public class PlanCashTransaction
    {
        public DateTime? TransactionDate { get; set; }
        public double TransactionId { get; set; }
        public string TransactionType { get; set; }
        public decimal Amount { get; set; }
    }
}