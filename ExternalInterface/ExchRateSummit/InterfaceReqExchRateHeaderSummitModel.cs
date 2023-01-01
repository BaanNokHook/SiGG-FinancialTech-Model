namespace GM.Model.ExternalInterface.ExchRateSummit
{
    public class InterfaceReqExchRateHeaderSummitModel
    {
        public string ticket { get; set; }
        public string ref_id { get; set; }
        public string content_type { get; set; }
        public string request_date { get; set; }
        public string request_time { get; set; }
        public string mode { get; set; }
        public string url_ticket { get; set; }
        public string url_rate { get; set; }
        public string authorization { get; set; }

        public InterfaceReqExchRateBodySummitModel reqbody { get; set; }
    }
}
