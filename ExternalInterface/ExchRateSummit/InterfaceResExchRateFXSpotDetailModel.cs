namespace GM.Model.ExternalInterface.ExchRateSummit
{
    public class InterfaceResExchRateFXSpotDetailModel
    {
        public int seq { get; set; }
        public string as_of_date { get; set; }
        public string curve_id { get; set; }
        public string ccy1 { get; set; }
        public string ccy2 { get; set; }
        public string date { get; set; }
        public string tenor { get; set; }
        public decimal bid_value { get; set; }
        public decimal ask_value { get; set; }
        public decimal rate_bid { get; set; }
        public decimal rate_offer { get; set; }
        public decimal rate_avg { get; set; }
    }
}
