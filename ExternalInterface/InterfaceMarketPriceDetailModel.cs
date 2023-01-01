namespace GM.Model.ExternalInterface
{
    public class InterfaceMarketPriceDetailModel
    {
        public string source_name { get; set; }
        public string security_code { get; set; }
        public string currency { get; set; }
        public string asof_date { get; set; }
        public string maturity_date { get; set; }
        public string avg_bid_yield { get; set; }
        public string ttm { get; set; }
        public string spread { get; set; }
        public string ref_yield { get; set; }
        public string ai_price { get; set; }
        public string clean_price { get; set; }
        public string gross_price { get; set; }
        public string modified_duration { get; set; }
        public string coupon_rate { get; set; }
        public string bond_type { get; set; }
        public string coupon_type { get; set; }
        public string last_trade_date { get; set; }
        public string last_exec_Yield { get; set; }
        public string quoted_date { get; set; }
        public string quoted_yield { get; set; }
        public string model_yield { get; set; }
        public string market_yield { get; set; }
        public string dm { get; set; }
        public string par { get; set; }
    }
}
