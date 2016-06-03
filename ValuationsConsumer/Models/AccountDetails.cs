using System;
using System.Collections.Generic;

namespace ValuationsConsumer.Models
{
    [Serializable]
    public class AccountDetails
    {
        public int ReykerClientId { get; set; }
        public string ExternalClientId { get; set; }
        public DateTime ValuationDate { get; set; }
        public List<AccountPlanDetails> AccountPlans { get; set; }
    }

    public class AccountPlanDetails
    {
        public double TotalPortfolioValue { get; set; }
        public double StockValue { get; set; }
        public double CashAvailable { get; set; }
        public int AccessNumber { get; set; }
        public string PlanType { get; set; }
        public string Ifa { get; set; }
        public string PlanName { get; set; }
        public string Provider { get; set; }
        public int ProviderId { get; set; }
        public double? CurrentYearIsaSubscription { get; set; }
        public List<PlanPortfolioValuation> PortfolioValuations { get; set; }
        public List<PlanNetInvestmentIncome> NetInvestmentIncomeDetails { get; set; }
        public List<PlanInvestmentTransaction> InvestmentTransactionDetails { get; set; }
        public List<PlanCashTransaction> CashTransactionDetails { get; set; }
    }

    public class PlanPortfolioValuation
    {
        public string Name { get; set; }
        public double? Quantity { get; set; }
        public double? Value { get; set; }
        public double? BookCost { get; set; }
        public double? Price { get; set; }
        public DateTime? PriceDate { get; set; }
        public string Isin { get; set; }
    }

    public class PlanNetInvestmentIncome
    {
        public string Name { get; set; }
        public double TransactionId { get; set; }
        public DateTime TransactionDate { get; set; }
        public double Value { get; set; }
        public string Type { get; set; }
        public string Isin { get; set; }
    }

    public class PlanInvestmentTransaction
    {
        public DateTime TransactionDate { get; set; }
        public double TransactionId { get; set; }
        public string TransactionType { get; set; }
        public string Name { get; set; }
        public string Isin { get; set; }
        public double Quantity { get; set; }
    }

    public class PlanCashTransaction
    {
        public DateTime? TransactionDate { get; set; }
        public double TransactionId { get; set; }
        public string TransactionType { get; set; }
        public double Amount { get; set; }
        public string Isin { get; set; }
    }
}