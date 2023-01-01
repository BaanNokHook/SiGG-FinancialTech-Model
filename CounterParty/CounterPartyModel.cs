using GM.Model.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GM.Model.CounterParty
{
    public class CounterPartyModel
    {
        public CounterPartyModel()
        {
            active_flag = true;
            custodian_flag = true;
            netting_flag = true;
            verify_flag_fo = true;
            verify_flag_bo = true;
            default_flag = true;
            tax_examtion_flag = false;
            tax_examtion_amt = 0;
        }

        public string statusdata { get; set; }

        public string province_name { get; set; }

        public string district_name { get; set; }

        public string sub_district_name { get; set; }

        public string country_name { get; set; }

        public string title_des { get; set; }

        public string counter_party_type_desc { get; set; }

        public string counter_party_group_desc { get; set; }

        public string corp_type_desc { get; set; }

        public string ktb_isic_desc { get; set; }

        public string custodian_code { get; set; }

        //   [Required]
        public int? counter_party_id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "CP Code")]
        public string counter_party_code { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "CP Short Name")]
        public string counter_party_shortname { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "CP Long Name")]
        public string counter_party_name { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "CP Thai Name")]
        public string counter_party_thainame { get; set; }

        [StringLength(255)]
        [Display(Name = "Title Name")]
        public string title_name { get; set; }

        [Display(Name = "Fund Type")]
        public int? fundtypeid { get; set; }
        public string fundtypename { get; set; }

        [Required]
        [StringLength(25)]
        [Display(Name = "CP Party Type")]
        public string counter_party_type_code { get; set; }

        //[Required]
        [Display(Name = "CP Group ID")]
        public Nullable<int> counter_party_group_id { get; set; }

        [Required]
        [StringLength(15)]
        [Display(Name ="CIF No")]
        public string cif_no { get; set; }

        [Required]
        [Display(Name = "Contact Person")]
        [StringLength(50)]
        public string contact_person { get; set; }

        [StringLength(50)]
        [Display(Name = "Contact Email")]
        public string contact_email { get; set; }

        [StringLength(50)]
        [Display(Name = "Tax Identity")]
        public string tax_identity_no { get; set; }

        [Required]
        [Display(Name = "Address Line 1")]
        [StringLength(255)]
        public string address_line1 { get; set; }

        [Display(Name = "Address Line 2")]
        [StringLength(255)]
        public string address_line2 { get; set; }

        [Display(Name = "Address Line 3")]
        [StringLength(255)]
        public string address_line3 { get; set; }

        [Display(Name = "Address Line 4")]
        [StringLength(255)]
        public string address_line4 { get; set; }

        [Required]
        [Display(Name ="Province")]
        public Nullable<int> province_id { get; set; }

        [Required]
        [Display(Name = "District")]
        public Nullable<int> district_id { get; set; }

        [Display(Name = "Sub District")]
        public Nullable<int> sub_district_id { get; set; }

        [Required]
        [Display(Name ="Zip Code")]
        [StringLength(50)]
        public string zipcode { get; set; }

        [Required]
        [Display(Name = "Country")]
        public int? country_id { get; set; }

        [StringLength(50)]
        [Display(Name = "Tel No")]
        public string tel_no { get; set; }

        [StringLength(50)]
        [Display(Name = "Fax No")]
        public string fax_no { get; set; }

        [Required]
        [Display(Name = "WHT Tax Pay")]
        public decimal? wht_tax_pay { get; set; }

        [Required]
        [Display(Name = "WHT Tax Rec")]
        public decimal? wht_tax_rec { get; set; }

        [StringLength(25)]
        [Display(Name = "TBMA Code")]
        public string tbma_code { get; set; }

        [StringLength(50)]
        [Display(Name = "BB Firm Acc")]
        public string bb_firm_acc_no { get; set; }

        [Display(Name ="AO ID")]
        public int? ao_id { get; set; }

        [StringLength(50)]
        [Display(Name = "BOT Def")]
        public string bot_def_code { get; set; }

        [StringLength(10)]
        [Display(Name = "Corp Type")]
        public string corp_type { get; set; }

        [StringLength(80)]
        [Display(Name = "KTB ISIC Code")]
        public string ktbisic_code { get; set; }
        [Display(Name = "Open Date")]
        public DateTime? open_date { get; set; }
        [Display(Name = "Close Date")]
        public DateTime? close_date { get; set; }
        [Display(Name = "GMRA Signed Date")]
        public DateTime? signed_date { get; set; }
        [Display(Name = "Custodian Flag")]
        public bool custodian_flag { get; set; }
        [Display(Name = "Custodian ID")]
        public Nullable<int> custodian_id { get; set; }

        
        [Display(Name = "Tax Absorb")]
        public bool? tax_examtion_flag { get; set; }
        [Display(Name = "Tax Examtion Amt")]
        public decimal? tax_examtion_amt { get; set; }

        [Display(Name = "Interest Compound")]
        public bool? int_compound { get; set; }
        [Display(Name = "Minimum Transfer")]
        [DisplayFormat(DataFormatString = "{0:n6}", ApplyFormatInEditMode = true)]
        public decimal? minimum_transfer { get; set; }

        //[StringLength(80)]
        //public string sa_no { get; set; }

        //[StringLength(80)]
        //public string ca_no { get; set; }
        [Display(Name = "Netting")]
        public bool netting_flag { get; set; }
        [Display(Name = "Verify FO")]
        public bool verify_flag_fo { get; set; }
        [Display(Name = "Verify BO")]
        public bool verify_flag_bo { get; set; }
        [Display(Name = "Default Flag")]
        public bool default_flag { get; set; }

        public bool active_flag { get; set; }

        public DateTime? create_date { get; set; }

        [StringLength(255)]
        public string create_by { get; set; }

        public DateTime? update_date { get; set; }

        [StringLength(255)]
        public string update_by { get; set; }

        public virtual PagingModel paging { get; set; }

        public virtual List<OrderByModel> ordersby { get; set; }

        public virtual List<CounterPartyPaymentModel> Payment { get; set; }
        public virtual List<CounterPartyIdentifyModel> Identify { get; set; }
        public virtual List<CounterPartyRatingModel> Rating { get; set; }
        public virtual List<CounterPartyHaircutModel> Haircut { get; set; }
        public virtual List<CounterPartyExchRateModel> Exchange { get; set; }

        public virtual CounterPartyMarginModel Margin { get; set; }
        public virtual CounterPartyPaymentModel PaymentRightModal { get; set; }
        public virtual CounterPartyIdentifyModel IdentifyRightModal { get; set; }
        public virtual CounterPartyRatingModel RatingRightModal { get; set; }
        public virtual CounterPartyHaircutModel HaircutRightModel { get; set; }
        public virtual CounterPartyExchRateModel ExchangeRightModel { get; set; }

        [Required]
        [Display(Name = "Margin Type")]
        public int? margin_type_id { get; set; }

        [Required]
        [Display(Name = "Margin Int Type")]
        public int? margin_in_type_id { get; set; }

        [Required]
        [Display(Name = "Margin Int Term")]
        public int? margin_in_term_id { get; set; }

        [Required]
        [Display(Name = "Threshold")]
        public decimal? threshold { get; set; }

        [Display(Name = "Borrow Only")]
        public bool borrow_only_flag { get; set; }
        [Display(Name = "Except Margin")]
        public bool except_margin_flag { get; set; }

        [Display(Name = "Call margin method")]
        public string margin_method { get; set; }

        public string margin_type_name { get; set; }

        public string margin_in_type_name { get; set; }

        public string margin_in_term_name { get; set; }

        [Display(Name = "No")]
        public int? RowNumber { get; set; }
    }
}
