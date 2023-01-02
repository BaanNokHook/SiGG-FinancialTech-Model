using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GM.Model.Common;
using GM.Model.CounterParty;

namespace GM.Model.Security
{
    public class SecurityModel
    {
        public SecurityModel()
        {
            ex_coupon_flag = true;
            tax_on_coupon_flag = true;
            verify_flag = true;
            verify_flag_bo = true;
            default_flag = true;
        }

        public string statusdata { get; set; }

        public Guid? instrument_id_temp { get; set; }

        [Display(Name = "Product_code")]
        public string product_code_text { get; set; }
        [Display(Name = "Sub Product_code")]
        public string sub_product_code_text { get; set; }
        [Display(Name = "Instrument Type")]
        public string instrumenttype_text { get; set; }
        [Display(Name = "Second Instrument Type")]
        public string second_instrumenttypee_text { get; set; }

        [Display(Name = "Register Name")]
        public string register_name { get; set; }

        [Display(Name = "Market Name")]
        public string market_name { get; set; }

        [Display(Name = "Option Type Name")]
        public string option_type_name { get; set; }

        [Display(Name = "Seniority Type Name")]
        public string seniority_type_name { get; set; }

        public string page_name { get; set; }

        [Display(Name = "No")]
        public int? RowNumber { get; set; }

        [Display(Name = "Instrument Id")]
        public int? instrument_id { get; set; }

        //[Key]
        [Required]
        [StringLength(25)]
        [Display(Name = "Instrument Code")]
        public string instrument_code { get; set; }

        [StringLength(255)]
        [Required]
        [Display(Name = "Description")]
        public string instrument_desc { get; set; }

        [StringLength(25)]
        [Required]
        [Display(Name = "ISIN Code")]
        public string ISIN_code { get; set; }

        [Required]
        [Display(Name = "Product")]
        public int? product_code { get; set; }

        // [Required]
        [Display(Name = "Sub Product ")]
        public int? sub_product_code { get; set; }

        [Required]
        [StringLength(25)]
        [Display(Name = "Bond Type")]
        public string instrumenttype { get; set; }

        //[Required]
        [StringLength(25)]
        [Display(Name = "Bond Sub Type")]
        public string second_instrumenttype { get; set; }

        [Required]
        [Display(Name = "Issue Date")]
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? issue_date { get; set; }

        [Required]
        [Display(Name = "Maturity Date")]
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime? maturity_date { get; set; }

        [Required]
        [Display(Name = "Include Issue Date")]
        public bool? include_issue_date_flag { get; set; }

        //[Required]
        [StringLength(3)]
        [Display(Name = "Xa Day")]
        public string xa_day { get; set; }

        [Display(Name = "Xa Day Unit")]
        public string xa_day_unit_text { get; set; }

        [Display(Name = "Xa Day Value")]
        public string xa_day_unit_value { get; set; }

        //[Required]
        [StringLength(3)]
        [Display(Name = "Xi Day")]
        public string xi_day { get; set; }
        [Display(Name = "Xi Day Unit")]
        public string xi_day_unit_text { get; set; }
        [Display(Name = "Xi Day Value")]
        public string xi_day_unit_value { get; set; }

        [Required]
        [Display(Name = "Issuer")]
        public int? issuer_id { get; set; }

        public string issuer_code { get; set; }

        //[Required]
        [Display(Name = "Issuer")]
        public string issuer_name { get; set; }

        [Required]
        [Display(Name = "Register Name")]
        public int? register_id { get; set; }

        [Required]
        [StringLength(3)]
        [Display(Name = "Cur")]
        public string cur { get; set; }
        public string cur_text { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:n0}")]
        [Display(Name = "Begining Par")]
        public decimal? begining_par { get; set; }

        //[Required]
        [Display(Name = "Ending Par")]
        [DisplayFormat(DataFormatString = "{0:n0}")]
        public decimal? ending_par { get; set; }

        [Required]
        [Display(Name = "Min Unit")]
        public int? min_unit { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:0.###}")]
        [Display(Name = "Max Unit")]
        public int? max_unit { get; set; }

        [Required]
        [Display(Name = "Incremental")]
        public int? incremental_unit { get; set; }

        //[Required]
        [Display(Name = "Secured Bond")]
        public bool? secured_bond_flag { get; set; }

        //[Required]
        [StringLength(3)]
        [Display(Name = "Holiday Rule")]
        public string holiday_rule_cur { get; set; }
        public string holiday_rule_cur_text { get; set; }

        // [Required]
        [StringLength(255)]
        [Display(Name = "Listed")]
        public string TBMA_listed_reference { get; set; }
        public string TBMA_listed_reference_text { get; set; }

        //[Required]
        [Display(Name = "Redemption Method ID")]
        public int? redemption_method_id { get; set; }

        [Display(Name = "Redemption Method")]
        public string redemp_method { get; set; }

        [Display(Name = "Redemption Freq")]
        public int? redemption_freq { get; set; }

        [Display(Name = "Redemption Day")]
        public int? redemption_day { get; set; }

        [Display(Name = "Redemption Month")]
        public int? redemption_month { get; set; }

        [Display(Name = "Redemption Date Rule")]
        [StringLength(100)]
        public string redemption_date_rule { get; set; }

        // [Required]
        [StringLength(100)]
        [Display(Name = "Redemtion Payment Rule")]
        public string redemption_payment_date_rule { get; set; }

        [Display(Name = "Redemtion Value")]
        [DisplayFormat(DataFormatString = "{0:n0}")]
        public decimal? redemption_value { get; set; }

        [Display(Name = "Redemtion Percent")]
        [DisplayFormat(DataFormatString = "{0:n0}")]
        public decimal? redemption_percent { get; set; }

        [StringLength(15)]
        [Display(Name = "Coupon Type")]
        public string coupon_type { get; set; }

        //[Required]
        [Display(Name = "Coupon Freq")]
        public int? coupon_freq { get; set; }

        //[Required]
        [Display(Name = "Coupon Freq Time")]
        public int? coupon_freq_time { get; set; }

        [Display(Name = "Coupon Day")]
        public int? coupon_day { get; set; }

        [Display(Name = "Coupon Month")]
        public int? coupon_month { get; set; }

        [Display(Name = "Coupon Date Rule")]
        [StringLength(100)]
        public string coupon_date_rule { get; set; }

        //[Required]
        [StringLength(100)]
        [Display(Name = "Coupon Payment Rule")]
        public string coupon_payment_date_rule { get; set; }

        //[Required]
        [DisplayFormat(DataFormatString = "{0:n0}")]
        [Display(Name = "Coupon Rate")]
        public decimal? coupon_rate { get; set; }

        //[Required]
        [StringLength(25)]
        [Display(Name = "Floating Index Code")]
        public string floating_index_code { get; set; }

        [Display(Name = "Spread")]
        [DisplayFormat(DataFormatString = "{0:n0}")]
        public decimal? spread { get; set; }

        [Display(Name = "Accrued Calc Rule")]
        public int? accrued_calc_rule_id { get; set; }

        [Display(Name = "Accrued Basis")]
        public int? accrued_basis { get; set; }

        [Required]
        [Display(Name = "Year Basis")]
        public int? year_basis { get; set; }

        [Display(Name = "Year Basis")]
        public string year_basis_text { get; set; }

        [StringLength(3)]
        [Display(Name = "Floating Index Cur")]
        public string floating_index_cur { get; set; }

        [StringLength(255)]
        [Display(Name = "Option Type")]
        public string option_type { get; set; }

        [Display(Name = "Seniority Type")]
        [StringLength(255)]
        public string seniority_type { get; set; }

        [Required]
        [Display(Name = "Tax On Coupon")]
        public bool tax_on_coupon_flag { get; set; }

        [Required]
        [Display(Name = "Ex Coupon")]
        public bool ex_coupon_flag { get; set; }

        [Required]
        [Display(Name = "Accumulate Interest")]
        public bool accumulate_interest_flag { get; set; }

        //[Required]
        [StringLength(255)]
        [Display(Name = "Payment Freq")]
        public string payment_freq { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:n0}")]
        [Display(Name = "Issue Size")]
        public decimal? issue_size { get; set; }

        //[Required]
        [Display(Name = "Check Mat Coupon")]
        public bool check_mat_coupon_flag { get; set; }

        //[Required]
        [Display(Name = "Int Cf")]
        public bool int_cf_flag { get; set; }

        [StringLength(15)]
        [Display(Name = "Boomberg Code")]
        public string boomberg_code { get; set; }

        [Display(Name = "Verify")]
        public bool? verify_flag { get; set; }

        [Display(Name = "Int Cf Manual")]
        public bool? int_cf_manual_flag { get; set; }

        //[Required]
        [StringLength(15)]
        [Display(Name = "Redemption Type")]
        public string redemption_type { get; set; }

        [Required]
        [StringLength(5)]
        [Display(Name = "Instrument Owner")]
        public string instrument_owner { get; set; }

        [Display(Name = "Instrument Owner")]
        public string instrument_owner_text { get; set; }

        [StringLength(1)]
        [Display(Name = "CRM Code")]
        public string crm_code { get; set; }

        //[Required]
        [Display(Name = "ISIN Code Thai")]
        [StringLength(25)]
        public string ISIN_code_Thai { get; set; }

        [Display(Name = "Verify BO")]
        public bool? verify_flag_bo { get; set; }

        [Display(Name = "Active")]
        public bool active_flag { get; set; }

        [Display(Name = "Check Merge")]
        public bool? check_merge_flag { get; set; }

        //[Required]
        [StringLength(20)]
        [Display(Name = "CRM Code")]
        public string market_code { get; set; }

        [Display(Name = "Default Flag")]
        public bool? default_flag { get; set; }

        [StringLength(25)]
        [Display(Name = "Instrument Group")]
        public string instrument_group { get; set; }

        [StringLength(255)]
        [Display(Name = "Source System")]
        public string source_system { get; set; }

        [Display(Name = "Bot Type")]
        public int bottype_id { get; set; }

        public DateTime? create_date { get; set; }

        [StringLength(255)]
        public string create_by { get; set; }

        public DateTime? update_date { get; set; }

        [StringLength(255)]
        public string update_by { get; set; }

        public virtual PagingModel paging { get; set; }

        public virtual List<OrderByModel> ordersby { get; set; }

        public virtual List<SecurityGuarantorModel> Guarantors { get; set; }
        public virtual List<SecurityBondRatingModel> BondRating { get; set; }
        public virtual List<IssuerRatingModel> IssuerRatingList { get; set; }
        public virtual List<SecurityEventModel> Events { get; set; }
        public virtual List<SecurityAdditionalCodeModel> AdditionalCodes { get; set; }

        public virtual SecurityGuarantorModel GuarantorsRightModal { get; set; }
        public virtual SecurityBondRatingModel BondRatingRightModal { get; set; }
        public virtual IssuerRatingModel IssuerRating { get; set; }
        public virtual SecurityEventModel SecurityEventRightModal { get; set; }
        public virtual SecurityAdditionalCodeModel AdditionalCodeRightModal { get; set; }
    }
}
