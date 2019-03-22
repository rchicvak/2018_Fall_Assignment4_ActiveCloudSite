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
        public float marketPercent { get; set; }
        public int bidSize { get; set; }
        public float bidPrice { get; set; }
        public float spread { get; set;}
        public int askSize { get; set; }
        public float askPrice { get; set; }
        public int volume { get; set; }
        public float lastSalePrice { get; set; }
        public int lastSaleSize { get; set; }
      //  [JsonConverter(typeof(UnixDateTimeConverter))]
      //  public long lastSaleTime { get; set; }
      //  [JsonConverter(typeof(UnixDateTimeConverter))]
      //  public long lastUpdated { get; set; }
        public string sector { get; set; }
        public string securityType { get; set; }
    }
}
