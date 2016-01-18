using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ValuationsConsumer.Models
{
    public class AccountPlanDetails
    {
        public double TotalPortfolioValue { get; set; }
        public double StockValue { get; set; }
        public double CashAvailable { get; set; }
        public string PlanType { get; set; }
        public int IFA { get; set; }
        public string PlanName { get; set; }
        public int Provider { get; set; }
        public IList<PlanPortfolioValuation> PortfolioValuations { get; set; }
        public IList<PlanNetInvestmentIncome> NetInvestmentIncomeDetails { get; set; }
        public IList<PlanFee> Fees { get; set; }
        public IList<PlanInvestmentTransaction> InvestmentTransactionDetails { get; set; }
        public IList<PlanCashTransaction> CashTransactionDetails { get; set; }
        public BalanceCarriedForward BalanceCarriedForward { get; set; }
        public BalanceBoughtForward BalanceBoughtForward { get; set; }
    }
}