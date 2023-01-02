using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GM.Model.Common;

namespace GM.Model.PaymentProcess
{
    public class RPCallMarginModel
    {
        [Display(Name = "No")]
        public int? RowNumber { get; set; }
        public string BusinessDate { get; set; }
        public virtual PagingModel paging { get; set; }
        public virtual List<OrderByModel> ordersby { get; set; }
        [Display(Name = "Margin Type")]
        public string margin_type { get; set; }
        [Display(Name = "Counter Party Name")]
        public string counter_party_name { get; set; }
        [Display(Name = "Counter Party Code")]
        public string counter_party_code { get; set; }
        [Display(Name = "Margin Amt")]
        public decimal margin_amt { get; set; }
        [Display(Name = "Int. Cash Margin")]
        public decimal int_cash_margin { get; set; }
        public string status { get; set; }
        [Display(Name = "Payment Method")]
        public string payment_method { get; set; }
        public string payment_method_name { get; set; }
        public string mt_code { get; set; }
        public string mt_code_name { get; set; }
        public decimal? interes_rate { get; set; }
        public int isCall { get; set; }

        [Display(Name = "Total Exposure")]
        public decimal totalExposure { get; set; }

        List<RPCallMarginPRPModel> RPCallMarginPRPList { get; set; }
        List<RPCallMarginBRPModel> RPCallMarginBRPList { get; set; }

        [Required]
        [StringLength(15)]
        public string trans_no { get; set; }

        [Required]
        [Display(Name = "As of Date")]
        public DateTime asof_date { get; set; }

        [Required]
        [Display(Name = "Call Date")]
        public DateTime? call_date { get; set; }

        [Required]
        public int? counter_party_id { get; set; }

        public int? counter_party_fund_id { get; set; }

        [Required]
        [StringLength(3)]
        [Display(Name = "CCY")]
        public string cur { get; set; }
        public string cur_name { get; set; }

        [Required]
        [Display(Name = "Threshold")]
        public decimal threshold { get; set; }

        [Required]
        public decimal margin_int_rate { get; set; }

        [Required]
        public decimal today_exposure { get; set; }

        [Required]
        public decimal today_net_exposure { get; set; }

        [Required]
        [StringLength(1)]
        public string margin_status { get; set; }

        [Required]
        public decimal today_call_margin { get; set; }

        [Required]
        public decimal prev_position_margin { get; set; }

        [Required]
        public decimal position_margin { get; set; }

        [Required]
        public decimal today_int_pay { get; set; }

        [Required]
        public decimal today_int_rec { get; set; }

        [Required]
        public decimal total_int_pay { get; set; }

        [Required]
        public decimal total_int_rec { get; set; }

        [Required]
        public decimal combine_int_amt { get; set; }

        [Required]
        public decimal prev_combine_int { get; set; }

        [Required]
        public decimal accom_int_pay { get; set; }

        [Required]
        public decimal accom_int_rec { get; set; }

        [Required]
        public decimal int_rec_tax { get; set; }

        [Required]
        [StringLength(1)]
        public string margin_int_status { get; set; }

        [Required]
        [StringLength(1)]
        public string transfer_status { get; set; }

        public decimal? org_today_exposure { get; set; }

        public decimal? org_total_int_rec { get; set; }

        public decimal? org_total_int_pay { get; set; }

        public decimal? org_int_rec_tax { get; set; }

        [StringLength(255)]
        public string remark { get; set; }

        [Required]
        public DateTime create_date { get; set; }

        [Required]
        [StringLength(50)]
        public string create_by { get; set; }

        public DateTime? update_date { get; set; }

        [StringLength(50)]
        public string update_by { get; set; }

        [Required]
        [StringLength(1)]
        public string close_status { get; set; }
        [Display(Name = "Event Type")]
        public string event_type { get; set; }
        [Display(Name = "Call Date From")]
        public DateTime? from_call_date { get; set; }
        [Display(Name = "Call Date To")]
        public DateTime? to_call_date { get; set; }
        [Display(Name = "As of Date From")]
        public DateTime? from_as_of_date { get; set; }
        [Display(Name = "As of Date To")]
        public DateTime? to_as_of_date { get; set; }

        [Display(Name = "Instrument")]
        public string repo_deal_type { get; set; }
        [Display(Name = "Trans Deal Type")]
        public string trans_deal_type_name { get; set; }
        [Display(Name = "Port")]
        public string port { get; set; }
        [Display(Name = "Trade Date")]
        public DateTime trade_date { get; set; }
        [Display(Name = "Settlement Date")]
        public DateTime settlement_date { get; set; }
        [Display(Name = "Maturity Date")]
        public DateTime maturity_date { get; set; }
        public string trans_mt_code { get; set; }
        [Display(Name = "Why Tax Pay")]
        public decimal wht_tax_pay { get; set; }
        public string trade_type { get; set; }
        public string brp_contract_no { get; set; }
        public string eom_int_flag { get; set; }

        public DateTime? payment_date_from { get; set; }
        public DateTime? payment_date_to { get; set; }

        public string swift_channel { get; set; }

        public bool isSyncCyberPay { get; set; }
    }
}
