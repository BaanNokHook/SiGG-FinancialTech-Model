using System.Collections.Generic;

namespace GM.Model.ExternalInterface.ExchRateCounterRate
{
    public class ResGetCounterRates
    {
        public string status { get; set; }
        public string message { get; set; }
        public string exDate { get; set; }
        public string exTime { get; set; }
        public string exRound { get; set; }
        public List<ResCounterRateList> counterRateList { get; set; }
    }

    public class ResCounterRateList
    {
        public string currency { get; set; }
        public string bankNoteDenom { get; set; }
        public string sightBillRate { get; set; }
        public string ttRate { get; set; }
        public string sellingRate { get; set; }
        public string bankNoteBuying { get; set; }
        public string bankNoteSelling { get; set; }
    }
}
