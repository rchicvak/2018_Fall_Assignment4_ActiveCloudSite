using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace IEXTrading.Models
{
    public class Top
    {
        [Key]
        public string symbol { get; set; }
        public double marketPercent { get; set; }
        public int bidSize { get; set; }
        public double bidPrice { get; set; }
        public int askSize { get; set; }
        public double askPrice { get; set; }
        public int volume { get; set; }
        public double lastSalePrice { get; set; }
        public int lastSaleSize { get; set; }
      //  [JsonConverter(typeof(UnixDateTimeConverter))]
      //  public long lastSaleTime { get; set; }
      //  [JsonConverter(typeof(UnixDateTimeConverter))]
      //  public long lastUpdated { get; set; }
        public string sector { get; set; }
        public string securityType { get; set; }
        [DisplayFormat(DataFormatString = "{0:P2}")]  // p = percent   2  = 2 decimals
        public Nullable<double> spread { get; set; }

        public void calculateSpread()
        {
            if (this.bidPrice == 0)
            {
                this.spread = null;
            }
            else
            {
                this.spread = (this.bidPrice - this.askPrice) / this.bidPrice;
            }
            return;
        }
    }
}
