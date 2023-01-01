using System;
using System.Collections.Generic;
using System.Text;

namespace GM.Model.ExternalInterface.ExchRateMidRate
{
    public class ResGetMidRates
    {
        public string status { get; set; }
        public string message { get; set; }
        public string exDate { get; set; }
        public string exRound { get; set; }
        public List<ResMidRateList> midRateList { get; set; }
    }

    public class ResMidRateList
    {
        public string currency { get; set; }
        public string currency2 { get; set; }
        public string midRate { get; set; }
        public string mos1 { get; set; }
        public string mos2 { get; set; }
        public string mos3 { get; set; }
        public string mos6 { get; set; }
        public string mos9 { get; set; }
        public string yr1 { get; set; }
        public string yr2 { get; set; }
        public string yr3 { get; set; }
        public string yr4 { get; set; }
        public string yr5 { get; set; }
        public string yr6 { get; set; }
        public string yr7 { get; set; }
        public string yr8 { get; set; }
        public string yr9 { get; set; }
        public string yr10 { get; set; }
    }
}
