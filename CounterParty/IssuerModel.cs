using GM.Model.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GM.Model.CounterParty
{
    public class IssuerModel
    {
        [Display(Name = "No")]
        public int? RowNumber { get; set; }

        public int? issuer_id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Issuer Code")]
        public string issuer_code { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Issuer Short Name")]
        public string issuer_shortname { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Issuer Name")]
        public string issuer_name { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Issuer Thai Name")]
        public string issuer_thainame { get; set; }

        [StringLength(255)]
        [Display(Name = "Title Name")]
        public string title_name { get; set; }

        [Display(Name = "Title Desc")]
        public string title_des { get; set; }

        [Required]
        [StringLength(25)]
        [Display(Name = "Issuer Type")]
        public string issuer_type_code { get; set; }

        [Display(Name = "Issuer Desc")]
        public string issuer_type_desc { get; set; }

        [Display(Name = "Issuer Group")]
        public Nullable<int> issuer_group_id { get; set; }

        [Display(Name = "Group Desc")]
        public string group_desc { get; set; }

        [Display(Name = "CIF")]
        public string cif_no { get; set; }

        [Display(Name = "Contact Person")]
        public string contact_person { get; set; }

        [Display(Name = "Contact Email")]
        public string contact_email { get; set; }

        [Display(Name = "Tax Identity")]
        public string tax_identity_no { get; set; }

        [Display(Name = "Address 1")]
        public string address_line1 { get; set; }

        [Display(Name = "Address 2")]
        public string address_line2 { get; set; }

        [Display(Name = "Address 3")]
        public string address_line3 { get; set; }

        [Display(Name = "Address 4")]
        public string address_line4 { get; set; }

        [Display(Name = "Province")]
        public Nullable<int> province_id { get; set; }

        [Display(Name = "Province")]
        public string province_name { get; set; }

        [Display(Name = "District")]
        public Nullable<int> district_id { get; set; }

        [Display(Name = "District")]
        public string district_name { get; set; }

        [Display(Name = "Sub District")]
        public Nullable<int> sub_district_id { get; set; }

        [Display(Name = "Sub District")]
        public string sub_district_name { get; set; }

        [Display(Name = "Zipcode")]
        public string zipcode { get; set; }

        [Display(Name = "Country")]
        public Nullable<int> country_id { get; set; }

        [Display(Name = "Country")]
        public string country_name { get; set; }

        [Display(Name = "Country Desc")]
        public string country_desc { get; set; }

        //[Required]
        [Display(Name = "Domicile Code")]
        public string domicile_code { get; set; }

        [StringLength(50)]
        [Display(Name = "Tel No")]
        public string tel_no { get; set; }

        [StringLength(50)]
        [Display(Name = "Fax No")]
        public string fax_no { get; set; }

        [Display(Name = "WHT Tax Pay")]
        public decimal? wht_tax_pay { get; set; }

        [Display(Name = "WHT Tax Rec")]
        public decimal? wht_tax_rec { get; set; }

        [StringLength(25)]
        [Display(Name = "TBMA Code")]
        public string tbma_code { get; set; }

        [StringLength(50)]
        [Display(Name = "BB Firm Acc No")]
        public string bb_firm_acc_no { get; set; }

        [StringLength(50)]
        [Display(Name = "AO ID")]
        public string ao_id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "BOT Identify")]
        public string bot_def_code { get; set; }

        [Required]
        [Display(Name = "KTB ISIC Code")]
        public string ktbisic_code { get; set; }
        [Display(Name = "KTB ISIC Desc")]
        public string ktb_isic_desc { get; set; }
        [Display(Name = "Open Date")]
        public DateTime? open_date { get; set; }
        [Display(Name = "Close Date")]
        public DateTime? close_date { get; set; }
        [Display(Name = "Signed Date")]
        public DateTime? signed_date { get; set; }
        [Display(Name = "Custodian Flag")]
        public Nullable<bool> custodian_flag { get; set; }
        [Display(Name = "Custodian")]
        public Nullable<int> custodian_id { get; set; }
        [Display(Name = "Custodian Code")]
        public string custodian_code { get; set; }

        [StringLength(80)]
        [Display(Name = "SA No.")]
        public string sa_no { get; set; }

        [StringLength(80)]
        [Display(Name = "CA No.")]
        public string ca_no { get; set; }
        [Display(Name = "Netting")]
        public Nullable<bool> netting_flag { get; set; }
        [Display(Name = "Verify FO")]
        public Nullable<bool> verify_flag_fo { get; set; }
        [Display(Name = "Verify BO")]
        public Nullable<bool> verify_flag_bo { get; set; }
        [Display(Name = "Default Flag")]
        public Nullable<bool> default_flag { get; set; }

        public Nullable<bool> active_flag { get; set; }

        public string statusdata { get; set; }

        public DateTime create_date { get; set; }

        public string create_by { get; set; }

        public Nullable<DateTime> update_date { get; set; }

        [StringLength(255)]
        public string update_by { get; set; }

        public virtual PagingModel paging { get; set; }

        public virtual List<OrderByModel> ordersby { get; set; }

        public virtual List<IssuerIdentifyModel> Identify { get; set; }

        public virtual List<IssuerRatingModel> Rating { get; set; }

        public virtual IssuerIdentifyModel IdentifyRightModal { get; set; }

        public virtual IssuerRatingModel RatingRightModal { get; set; }
    }

}
