using System.Collections.Generic;

namespace GM.Model.InterfaceSecurity
{
    public class ReqSecurityList
    {
        public string instrument_id { get; set; }
        public string instrument_code { get; set; }
        public string instrument_desc { get; set; }
        public string ISIN_code { get; set; }
        public string product_code { get; set; }
        public string instrumenttype { get; set; }
        public string sub_product_code { get; set; }
        public string second_instrumenttype { get; set; }
        public string issue_date { get; set; }
        public string maturity_date { get; set; }
        public string include_issue_date_flag { get; set; }
        public string xa_day { get; set; }
        public string xi_day { get; set; }
        public string issuer_id { get; set; }
        public string issuer_code { get; set; }
        public string register_id { get; set; }
        public string cur { get; set; }
        public string begining_par { get; set; }
        public string ending_par { get; set; }
        public string min_unit { get; set; }
        public string max_unit { get; set; }
        public string incremental_unit { get; set; }
        public string secured_bond_flag { get; set; }
        public string holiday_rule_cur { get; set; }
        public string TBMA_listed_reference { get; set; }
        public string redemption_method_id { get; set; }
        public string redemption_freq { get; set; }
        public string redemption_day { get; set; }
        public string redemption_month { get; set; }
        public string redemption_date_rule { get; set; }
        public string redemption_payment_date_rule { get; set; }
        public string redemption_value { get; set; }
        public string redemption_percent { get; set; }
        public string coupon_type { get; set; }
        public string coupon_freq { get; set; }
        public string coupon_freq_time { get; set; }
        public string coupon_day { get; set; }
        public string coupon_month { get; set; }
        public string coupon_date_rule { get; set; }
        public string coupon_payment_date_rule { get; set; }
        public string coupon_rate { get; set; }
        public string floating_index_code { get; set; }
        public string spread { get; set; }
        public string accrued_calc_rule_id { get; set; }
        public string accrued_basis { get; set; }
        public string year_basis { get; set; }
        public string floating_index_cur { get; set; }
        public string option_type { get; set; }
        public string seniority_type { get; set; }
        public string tax_on_coupon_flag { get; set; }
        public string ex_coupon_flag { get; set; }
        public string accumulate_interest_flag { get; set; }
        public string payment_freq { get; set; }
        public string issue_size { get; set; }
        public string active_flag { get; set; }
        public string check_mat_coupon_flag { get; set; }
        public string int_cf_flag { get; set; }
        public string create_date { get; set; }
        public string create_by { get; set; }
        public string update_date { get; set; }
        public string update_by { get; set; }
        public string boomberg_code { get; set; }
        public string verify_flag { get; set; }
        public string int_cf_manual_flag { get; set; }
        public string redemption_type { get; set; }
        public string instrument_owner { get; set; }
        public string crm_code { get; set; }
        public string ISIN_code_Thai { get; set; }
        public string verify_flag_bo { get; set; }
        public string check_merge_flag { get; set; }
        public string market_code { get; set; }
        public string default_flag { get; set; }
        public string instrument_group { get; set; }
        public string source_system { get; set; }
        public List<ReqSecurityRatingList> reqSecurityRatingList { get; set; }
        public List<ReqCashFlowList> reqCashFlowList { get; set; }
        public string ref_code { get; set; }
    }
}
