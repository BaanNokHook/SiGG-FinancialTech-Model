using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GM.Model.Common;

namespace GM.Model.RPTransaction
{
    public class RPTransCollateralModel
    {
        public string status { get; set; }
        public string datafrom { get; set; }
        public string action { get; set; }
        public string port_name { get; set; }
        public decimal? haircut_rate { get; set; }
        public string rp_price_date { get; set; }
        public string rp_source { get; set; }
        public string purchase_price { get; set; }
        public string counter_party_id { get; set; }
        public string terminate_amount { get; set; }
        public string interest_total { get; set; }
        public string deal_period { get; set; }
        public string basis_code { get; set; }
        public string wht_tax { get; set; }
        public string formula { get; set; }

        [Display(Name = "DM")]
        [DisplayFormat(DataFormatString = "{0:n16}", ApplyFormatInEditMode = true)]
        public decimal? dm { get; set; }

        [Display(Name = "No")]
        public int? RowNumber { get; set; }

        [Display(Name = "Colateral ID")]
        public string colateral_id { get; set; }

        [StringLength(15)]
        [Display(Name = "Trans No")]
        public string trans_no { get; set; }

        [Display(Name = "Instrument ID")]
        public int? instrument_id { get; set; }

        [Display(Name = "Instrument Code")]
        public string instrument_code { get; set; }

        [Display(Name = "ISIN Code")]
        public string isin_code { get; set; }

        [Display(Name = "Bilat/Private")]
        public string repo_deal_type { get; set; }

        [Display(Name = "Trade Date")]
        public DateTime? trade_date { get; set; }

        [Display(Name = "Settlemen Date")]
        public DateTime? settlement_date { get; set; }

        [Display(Name = "Maturity Date")]
        public DateTime? maturity_date { get; set; }

        [Display(Name = "Coupon Rate")]
        public decimal coupon_rate { get; set; }

        [Display(Name = "Par/Unit")]
        public decimal? par_unit { get; set; }

        [StringLength(3)]
        [Display(Name = "Curr")]
        public string cur { get; set; }

        [Required]
        [StringLength(15)]
        [Display(Name = "Port in Bond Collateral")]
        public string port { get; set; }

        [Display(Name = "Port")]
        public string port_for_label { get; set; }

        [Display(Name = "Colateral Type")]
        public int? colateral_type { get; set; }

        [Display(Name = "Par Value")]
        public decimal? par { get; set; }

        [Display(Name = "Unit")]
        public decimal? unit { get; set; }

        [Display(Name = "YTM")]
        [DisplayFormat(DataFormatString = "{0:n8}", ApplyFormatInEditMode = true)]
        public decimal? ytm { get; set; }

        [Display(Name = "Clean Price")]
        [DisplayFormat(DataFormatString = "{0:n8}", ApplyFormatInEditMode = true)]
        public decimal? clean_price { get; set; }

        [Display(Name = "Dirty Price")]
        [DisplayFormat(DataFormatString = "{0:n8}", ApplyFormatInEditMode = true)]
        public decimal? dirty_price { get; set; }

        [Display(Name = "Cash Amount")]
        public decimal? cash_amount { get; set; }

        public decimal? sum_cash_amount { get; set; }
        public decimal? sum_interest_amount { get; set; }
        public decimal? sum_wht_amount { get; set; }
        public decimal? sum_temination_value { get; set; }

        [Display(Name = "Mar. Value")]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public decimal? market_value { get; set; }

        [Display(Name = "Interest Amount")]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public decimal? interest_amount { get; set; }

        [Display(Name = "WHT")]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public decimal? wht_amount { get; set; }

        [Display(Name = "Margin Type")]
        public int? margin_type_id { get; set; }

        [Display(Name = "Temination Value")]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public int? margin_in_term_id { get; set; }

        [Display(Name = "Margin In Type")]
        public int? margin_in_type_id { get; set; }

        [Display(Name = "Init Margin")]
        public int? init_margin_id { get; set; }

        [Display(Name = "Temination Value")]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public decimal? temination_value { get; set; }

        [Display(Name = "Dirty Price After H/C")]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public decimal dirty_price_after_hc { get; set; }

        [Display(Name = "HC")]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public decimal? haircut { get; set; }

        [Display(Name = "VM")]
        public decimal? variation { get; set; }

        [Display(Name = "Birat")]
        public decimal? birat_flag { get; set; }

        public string trigger { get; set; }

        public DateTime? create_date { get; set; }

        [StringLength(255)]
        public string create_by { get; set; }

        public DateTime? update_date { get; set; }

        [StringLength(255)]
        public string update_by { get; set; }

        public virtual PagingModel paging { get; set; }

        public virtual List<OrderByModel> ordersby { get; set; }

        public string message { get; set; }

        public bool isLastRecord { get; set; }

        public int special_case_id { get; set; }
    }
}
