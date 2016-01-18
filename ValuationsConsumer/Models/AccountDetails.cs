using System;
using System.Collections.Generic;

namespace ValuationsConsumer.Models
{
    public class AccountDetails
    {
        public string id { get; set; }
        public int PartyId { get; set; }
        public DateTime ValuationDate { get; set; }
        public IList<AccountPlanDetails> AccountPlans { get; set; }
    }
}