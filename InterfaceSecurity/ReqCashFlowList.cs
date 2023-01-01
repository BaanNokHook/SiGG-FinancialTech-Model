namespace GM.Model.InterfaceSecurity
{
    public class ReqCashFlowList
    {
        public string instrument_id { get; set; }
        public string event_date { get; set; }
        public string event_type { get; set; }
        public string round_no { get; set; }
        public string complete_flag { get; set; }
        public string coupon_date { get; set; }
        public string next_coupon_date { get; set; }
        public string payment_date { get; set; }
        public string coupon_type { get; set; }
        public string coupon_rate { get; set; }
        public string coupon_floating_index_code { get; set; }
        public string coupon_cur { get; set; }
        public string coupon_spread { get; set; }
        public string redemption_value { get; set; }
        public string redemption_percent { get; set; }
        public string redemption_trans_no { get; set; }
        public string order_index { get; set; }
        public string interest { get; set; }
        public string principal { get; set; }
        public string total_payment { get; set; }
        public string begining_par { get; set; }
        public string ending_par { get; set; }
        public string xi_date { get; set; }
        public string create_date { get; set; }
        public string create_by { get; set; }
        public string update_date { get; set; }
        public string update_by { get; set; }
        public string ref_code { get; set; }
    }
}
