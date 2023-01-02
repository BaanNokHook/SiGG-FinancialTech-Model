using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GM.Model.Common;

namespace GM.Model.RPTransaction
{
    public class RPTransModel
    {
        public RPTransModel()
        {
            ismanual_cal = false;
        }
        //Start Use in ui
        public string statusdata { get; set; }
        public string username { get; set; }
        public string port_name { get; set; }
        public string desk_group_name { get; set; }
        public string trans_in_term_id_name { get; set; }
        [Display(Name = "Swift Code")]
        public string swift_code { get; set; }
        [Display(Name = "WHT")]
        public decimal? wht_tax { get; set; }
        public string absorb { get; set; }
        public string swift_code_label { get; set; }
        public string wht_tax_pay_label { get; set; }
        [Display(Name = "Counter Party Fund Name")]
        public string counter_party_fund_name { get; set; }
        [Display(Name = "Instrument Code")]
        public string instrument_code { get; set; }
        public string rp_price_date_text { get; set; }
        public string rp_price_date_value { get; set; }
        public string rp_source_text { get; set; }
        public string rp_source_value { get; set; }
        public string isin_code { get; set; }
        public string instrument_code_name { get; set; }
        public string isin_code_name { get; set; }
        public DateTime? maturity_date_search { get; set; }
        public string basis_code_name { get; set; }
        public string page_name { get; set; }
        public string desk_book_name { get; set; }
        public string trigger { get; set; }
        public string message { get; set; }

        [Required]
        [Display(Name = "Desk Book")]
        public int? desk_book_id { get; set; }
        public string trans_type_name { get; set; }
        public string error_flag { get; set; }
        public DateTime? asofdate { get; set; }
        public string reportpath { get; set; }

        //END Use in ui

        public bool btn_Previous { get; set; }
        public bool btn_Next { get; set; }
        public bool btn_Approve { get; set; }
        public bool btn_UnApprove { get; set; }

        [Display(Name = "Event Type")]
        public string event_type { get; set; }

        [Display(Name = "No")]
        public int? RowNumber { get; set; }

        //[Required]
        [StringLength(15)]
        [Display(Name = "Trans No")]
        public string trans_no { get; set; }

        [Display(Name = "Trans No From")]
        public string from_trans_no { get; set; }

        [Display(Name = "Trans No To")]
        public string to_trans_no { get; set; }

        [StringLength(20)]
        [Display(Name = "Ticket No")]
        public string ticket_no { get; set; }

        //[Required]
        [StringLength(10)]
        [Display(Name = "OurRef")]
        public string our_ref { get; set; }

        //[Required]
        [StringLength(25)]
        [Display(Name = "Instrument")]
        public string repo_deal_type { get; set; }
        [Display(Name = "Instrument")]
        public string repo_deal_type_name { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "Trans Deal Type")]
        public string trans_deal_type { get; set; }

        [Display(Name = "Trans Deal Type")]
        public string trans_deal_type_name { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "Trans Type")]
        public string trans_type { get; set; }

        [Required]
        [StringLength(15)]
        [Display(Name = "Portfolio")]
        public string port { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "Purpose")]
        public string purpose { get; set; }
        public string purpose_name { get; set; }

        [Required]
        [Display(Name = "Counter Party")]
        public int? counter_party_id { get; set; }

        [Display(Name = "Fund Code")]
        public int? counter_party_fund_id { get; set; }

        //[Required]
        [Display(Name = "Counter Party Name")]
        public string counter_party_name { get; set; }

        //[Required]
        [Display(Name = "Counter Party Code")]
        public string counter_party_code { get; set; }

        [Required]
        [Display(Name = "Trade Date")]
        public DateTime? trade_date { get; set; }

        //[Required]
        [Display(Name = "Trade Date From")]
        public DateTime? from_trade_date { get; set; }

        //[Required]
        [Display(Name = "Trade Date To")]
        public DateTime? to_trade_date { get; set; }

        [Required]
        [Display(Name = "Settlement Date")]
        public DateTime? settlement_date { get; set; }

        //[Required]
        [Display(Name = "Settlement Date From")]
        public DateTime? from_settlement_date { get; set; }

        //[Required]
        [Display(Name = "Settlement Date To")]
        public DateTime? to_settlement_date { get; set; }

        [Required]
        [Display(Name = "Maturity Date")]
        public DateTime? maturity_date { get; set; }

        [Display(Name = "Maturity Date From")]
        public DateTime? from_maturity_date { get; set; }

        [Display(Name = "Maturity Date To")]
        public DateTime? to_maturity_date { get; set; }

        [Required]
        [Display(Name = "Basis Code")]
        public int basis_code { get; set; }

        [Required]
        [Display(Name = "Period")]
        public int? deal_period { get; set; }
        public int? business_period { get; set; }

        [Required]
        [Display(Name = "Purchase Price")]
        [DisplayFormat(DataFormatString = "{0:C0}")]
        public decimal? purchase_price { get; set; }

        //[Required]
        [Display(Name = "Repurchase Price")]
        public decimal? repurchase_price { get; set; }

        [Required]
        [StringLength(15)]
        [Display(Name = "Interest Type")]
        public string interest_type { get; set; }

        [Required]
        [Display(Name = "Repo Int. Rate")]
        [DisplayFormat(DataFormatString = "{0:n8}", ApplyFormatInEditMode = true)]
        public decimal? interest_rate { get; set; }

        [Required]
        [Display(Name = "Repo Int. Rate")]
        public string interest_floating_index_code { get; set; }

        [Display(Name = "Total Int.")]
        [DisplayFormat(DataFormatString = "{0:n8}", ApplyFormatInEditMode = true)]
        public decimal? interest_total { get; set; }

        //[Required]
        [Display(Name = "Int. Spread")]
        [DisplayFormat(DataFormatString = "{0:n8}", ApplyFormatInEditMode = true)]
        public decimal? interest_spread { get; set; }

        //[Required]
        [Display(Name = "Interest Amount")]
        public decimal? interest_amount { get; set; }

        //[Required]
        [Display(Name = "WHT Amount")]
        public decimal? withholding_amount { get; set; }
        public string withholding_amount_text { get; set; }

        //[Required]
        [Display(Name = "Unwind Fees")]
        public decimal? fee_amount { get; set; }

        [Required]
        [Display(Name = "Cost Of Fund")]
        [DisplayFormat(DataFormatString = "{0:n8}", ApplyFormatInEditMode = true)]
        public decimal? cost_of_fund { get; set; }

        public string cost_floating_index_code { get; set; }

        //[Required]
        [StringLength(15)]
        [Display(Name = "Cost Type")]
        public string cost_type { get; set; }

        //[Required]
        [Display(Name = "Cost Spread")]
        [DisplayFormat(DataFormatString = "{0:n8}", ApplyFormatInEditMode = true)]
        public decimal? cost_spread { get; set; }

        //[Required]
        [Display(Name = "Total Cost")]
        [DisplayFormat(DataFormatString = "{0:n8}", ApplyFormatInEditMode = true)]
        public decimal? cost_total { get; set; }

        //[Required]
        [StringLength(15)]
        [Display(Name = "Trans Status")]
        public string trans_status { get; set; }
        [Display(Name = "Status Desc")]
        public string status_desc { get; set; }

        //[Required]
        [StringLength(50)]
        [Display(Name = "Trans State")]
        public string trans_state { get; set; }
        [Display(Name = "State Desc")]
        public string state_desc { get; set; }

        //[StringLength(100)]
        [Required]
        [Display(Name = "Payment Method")]
        public string payment_method { get; set; }
        public string payment_method_text { get; set; }
        [Required]
        [Display(Name = "MT Code")]
        public string trans_mt_code { get; set; }

        //[StringLength(100)]
        [Display(Name = "MGP Method")]
        public string margins_payment_method { get; set; }
        public string margins_mt_code { get; set; }

        [Display(Name = "Threshold")]
        public decimal? threshold { get; set; }

        [Required]
        [StringLength(25)]
        [Display(Name = "Trader Id")]
        public string trader_id { get; set; }

        [Required]
        [StringLength(3)]
        [Display(Name = "Cur")]
        public string cur { get; set; }

        //[Required]
        [StringLength(3)]
        [Display(Name = "Cur Pair 1")]
        public string cur_pair1 { get; set; }

        //[Required]
        [StringLength(3)]
        [Display(Name = "Cur Pair 2")]
        public string cur_pair2 { get; set; }

        [Display(Name = "Exchange Rate")]
        [DisplayFormat(DataFormatString = "{0:n8}", ApplyFormatInEditMode = true)]
        public decimal? exch_rate { get; set; }

        [Display(Name = "Market Date")]
        public DateTime? market_date { get; set; }

        [StringLength(1)]
        [Display(Name = "Marketdate T")]
        public string marketdate_t { get; set; }

        [Display(Name = "MarketPrice")]
        public decimal? market_price { get; set; }

        //[Required]
        [StringLength(255)]
        [Display(Name = "User")]
        public string user_id { get; set; }

        //[Required]
        [Display(Name = "Desk Group")]
        public int? desk_group_id { get; set; }

        [Required]
        [Display(Name = "Repo Int Term: ")]
        public int? trans_in_term_id { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Bilat. Contract")]
        public string bilateral_contract_no { get; set; }

        [Display(Name = "Remark")]
        public string remark_id { get; set; }
        [Display(Name = "Remark Name")]
        public string remark_name { get; set; }
        [Display(Name = "Remark Desc")]
        public string remark_desc { get; set; }
        [Display(Name = "Deal Remark")]
        public int? deal_remark_id { get; set; }

        [StringLength(8000)]
        [Display(Name = "Deal Remark")]
        public string deal_remark { get; set; }
        [Display(Name = "Correct Remark")]
        public int? correct_remark_id { get; set; }

        [StringLength(8000)]
        [Display(Name = "Correct Remark Desc")]
        public string correct_remark { get; set; }

        [Display(Name = "Cancel Remark")]
        public int? cancel_remark_id { get; set; }

        [StringLength(8000)]
        [Display(Name = "Cancel Remark Desc")]
        public string cancel_remark { get; set; }

        [Display(Name = "FO Reject Remark")]
        public int? fo_reject_remark_id { get; set; }

        [StringLength(8000)]
        [Display(Name = "FO Reject Remark Desc")]
        public string fo_reject_remark { get; set; }

        public int? bo_reject_remark_id { get; set; }

        [StringLength(8000)]
        public string bo_reject_remark { get; set; }

        [Display(Name = "Commentaries")]
        public string commentaries { get; set; }

        [Required]
        //[Display(Name = "Hair Cut")]
        [Display(Name = "Formula to cal collateral")]
        public string formula { get; set; }
        public string formula_name { get; set; }

        [Display(Name = "Extend")]
        public string extend { get; set; }
        public string extend_name { get; set; }

        [Display(Name = "Over Limit")]
        public bool? isover_limit { get; set; }

        [Display(Name = "Manual Cal.")]
        public bool? ismanual_cal { get; set; }

        [Display(Name = "Terminate Date")]
        public DateTime? terminate_date { get; set; }

        public string nosto_vosto_code { get; set; }

        //[Required]
        public DateTime? create_date { get; set; }

        //[Required]
        [StringLength(255)]
        public string create_by { get; set; }

        public DateTime? update_date { get; set; }

        [StringLength(255)]
        public string update_by { get; set; }

        public virtual PagingModel paging { get; set; }

        public virtual List<OrderByModel> ordersby { get; set; }

        //TODO change name 'ColateralList' to 'CollateralList'
        [Required]
        public virtual List<RPTransCollateralModel> ColateralList { get; set; }

        //TODO change name 'ColateralList' to 'CollateralList'
        public virtual RPTransCollateralModel RPTransColateralModel { get; set; }

        public string SessionName { get; set; }

        public bool? isAmend { get; set; }

        public char tenor_type { get; set; }

        public bool holiday_flag { get; set; }

        public string message_type { get; set; }

        public string policy_date { get; set; }
        public string print_type { get; set; }
        public bool isCopy { get; set; }
        public string release_printed { get; set; }
        public bool isSwift { get; set; }

        public DateTime? asof_date { get; set; }
        public bool terminate_flag { get; set; }

        [Display(Name = "Net Settlement")]
        public bool? net_settement_flag { get; set; }
        public string ref_trans_no { get; set; }
        public int ref_trans_seq { get; set; }
        public string ref_trans_group { get; set; }
        public int special_case_id { get; set; }

        [Display(Name = "Swift Channel")]
        public string swift_channel { get; set; }
        public string swift_channel_desc { get; set; }

        public bool isSyncCyberPay { get; set; }
    }
}
