namespace GM.Model.ExternalInterface.ExchRateSummit
{
    public class InterfaceReqExchRateBodySummitModel
    {
        public string data_type { get; set; }
        public string as_of_date { get; set; }
        public string curve_id { get; set; }
        public string ccy1 { get; set; }
        public string ccy2 { get; set; }
    }
}
