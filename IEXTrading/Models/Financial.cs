using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations.Schema;

namespace IEXTrading.Models
{
    public class FinancialWrapper
    {
        public List<Financial> financials;
        public List<Financial> convert(string symbol)
        {
            foreach (Financial f in financials)
            {
                f.symbol = symbol;
            }
            return financials;
        }
    }

    public class Financial
    {
        public string symbol { get; set; }
        public string reportDate { get; set; }
        public long grossProfit { get; set; }
        public long costOfRevenue { get; set; }
        public long operatingRevenue { get; set; }
        public long totalRevenue { get; set; }
        public long operatingIncome { get; set; }
        public long netIncome { get; set; }
        public long researchAndDevelopment { get; set; }
        public long operatingExpense { get; set; }
        public long currentAssets { get; set; }
        public long totalAssets { get; set; }
        public long totalLiabilities { get; set; }
        public long currentCash { get; set; }
        public long currentDebt { get; set; }
        public long totalCash { get; set; }
        public long totalDebt { get; set; }
        public long shareholderEquity { get; set; }
        public long cashChange  { get; set; }
        public long cashFlow { get; set; }
        public long operatingGainsLosses  { get; set; }
    }
}
