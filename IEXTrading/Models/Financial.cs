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
                f.percentRD = (double)f.researchAndDevelopment / f.totalRevenue;  // division forced non-integer
                f.debtEquity = (double)f.totalDebt / f.shareholderEquity;  // division forced non-integer
            }
            return financials;
        }
    }

    public class Financial
    {
        public string symbol { get; set; }
        public string reportDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:N0}")]
        public long grossProfit { get; set; }
        [DisplayFormat(DataFormatString = "{0:N0}")]
        public long costOfRevenue { get; set; }
        [DisplayFormat(DataFormatString = "{0:N0}")]
        public long operatingRevenue { get; set; }
        [DisplayFormat(DataFormatString = "{0:N0}")]
        public long totalRevenue { get; set; }
        [DisplayFormat(DataFormatString = "{0:N0}")]
        public long operatingIncome { get; set; }
        [DisplayFormat(DataFormatString = "{0:N0}")]
        public long netIncome { get; set; }
        [DisplayFormat(DataFormatString = "{0:N0}")]
        public long researchAndDevelopment { get; set; }
        [DisplayFormat(DataFormatString = "{0:N0}")]
        public long operatingExpense { get; set; }
        [DisplayFormat(DataFormatString = "{0:N0}")]
        public long currentAssets { get; set; }
        [DisplayFormat(DataFormatString = "{0:N0}")]
        public long totalAssets { get; set; }
        [DisplayFormat(DataFormatString = "{0:N0}")]
        public long totalLiabilities { get; set; }
        [DisplayFormat(DataFormatString = "{0:N0}")]
        public long currentCash { get; set; }
        [DisplayFormat(DataFormatString = "{0:N0}")]
        public long currentDebt { get; set; }
        [DisplayFormat(DataFormatString = "{0:N0}")]
        public long totalCash { get; set; }
        [DisplayFormat(DataFormatString = "{0:N0}")]
        public long totalDebt { get; set; }
        [DisplayFormat(DataFormatString = "{0:N0}")]
        public long shareholderEquity { get; set; }
        [DisplayFormat(DataFormatString = "{0:N0}")]
        public long cashChange  { get; set; }
        [DisplayFormat(DataFormatString = "{0:N0}")]
        public long cashFlow { get; set; }
        [DisplayFormat(DataFormatString = "{0:N0}")]   // numeric, commas, zero decimal places
        public long operatingGainsLosses  { get; set; }
        [DisplayFormat(DataFormatString = "{0:P2}")]  // p = percent   2  = 2 decimals
        public double percentRD { get; set; }
        [DisplayFormat(DataFormatString = "{0:P2}")]  // p = percent   2  = 2 decimals
        public double debtEquity { get; set; }
    }
}
