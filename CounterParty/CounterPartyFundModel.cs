using GM.Model.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GM.Model.CounterParty
{
    public class CounterPartyFundModel 
    {
        public string statusdata { get; set; }  

        public CounterPartyFundModel()    
        {
            active_flag = true;
        }
        public string page_name { get; set; }   

        [Display(Name = "No")]   
        public int? RowNumber { get; set; }   

        [Required]    
        [Display(Name = "Counter Party Code")]  
        public string counter_party_code { get; set; }
        [Display(Name = "Counter Party Name")]
        public string counter_party_name { get; set; }
        [Display(Name = "Title Name")]
        [StringLength(100)]
        public string title_name { get; set; }
        [Display(Name = "Title Name 2")]
        [StringLength(100)]
        public string title_name2 { get; set; }
        [Display(Name = "Custodian Code")]
        public string custodian_code_name { get; set; }
        [Display(Name = "Group Tax Code")]
        public string group_tax_code_name { get; set; }
        [Display(Name = "Fund")]
        public int? fund_id { get; set; }

        [Required]
        [Display(Name = "Counter Party Code")]
        public int? counter_party_id { get; set; }

        [StringLength(50)]
        [Display(Name = "Fund Code")]
        public string fund_code { get; set; }

        [Required]
        [Display(Name = "Fund Name (Th)")]
        public string fund_thainame { get; set; }

        [StringLength(255)]
        [Display(Name = "Fund Name (Eng)")]
        public string fund_engname { get; set; }

        [Display(Name = "Custodian Code")]
        public int? custodian_id { get; set; }

        [Display(Name = "Custodian Code")]
        public string custodian_code { get; set; }

        [Display(Name = "Swift Code")]
        public string swift_code { get; set; }

        [StringLength(50)]
        [Display(Name = "BB Firm Acc")]
        public string bb_firm_acc { get; set; }

        [StringLength(50)]
        [Display(Name = "Bic Code Fund")]
        public string bic_code_fund { get; set; }

        [StringLength(15)]
        [Display(Name = "SA Account")]
        public string sa_account_no { get; set; }

        [StringLength(80)]
        [Display(Name = "CA Account")]
        public string ca_account_no { get; set; }

        [StringLength(20)]
        [Display(Name = "Group Tax")]
        public string group_tax_code { get; set; }

        [Display(Name = "WTH Tax Percent")]
        public int? wth_tax_percent { get; set; }

        [StringLength(13)]
        [Display(Name = "Tax ID")]
        public string tax_id { get; set; }

        [Display(Name = "Title")]
        [StringLength(100)]
        public string title { get; set; }

        [Display(Name = "First Name")]
        public string first_name { get; set; }

        [Display(Name = "Middle Name")]
        public string middle_name { get; set; }
        [Display(Name = "Last Name")]
        public string last_name { get; set; }

        public Boolean active_flag { get; set; }
        
        public DateTime? create_date { get; set; }
        
        [StringLength(50)]
        public string create_by { get; set; }
        
        public DateTime? update_date { get; set; }
        
        [StringLength(50)]
        public string update_by { get; set; }

        public virtual PagingModel paging { get; set; }

        public virtual List<OrderByModel> ordersby { get; set; }
        
        public virtual List<CounterPartyFundIdentifyModel> Identify { get; set; }
        public virtual CounterPartyFundIdentifyModel IdentifyRightModal { get; set; }

        public virtual CounterPartyFundPaymentModel PaymentRightModal { get; set; }
        public virtual List<CounterPartyFundPaymentModel> Payment { get; set; }

        public virtual CounterPartyFundMarginModel Margin { get; set; }

        [Required]
        [Display(Name = "Margin Type")]
        public int? margin_type_id { get; set; }

        [Required]
        [Display(Name = "Margin In Type")]
        public int? margin_in_type_id { get; set; }

        [Required]
        [Display(Name = "Margin In Term")]
        public int? margin_in_term_id { get; set; }

        [Required]
        [Display(Name = "Threshold")]
        public decimal? threshold { get; set; }

        [Display(Name = "Borrow Only")]
        public bool borrow_only_flag { get; set; }

        [Display(Name = "Except Margin")]
        public bool except_margin_flag { get; set; }

        [Display(Name = "Margin Type")]
        public string margin_type_name { get; set; }

        [Display(Name = "Margin In Type")]
        public string margin_in_type_name { get; set; }

        [Display(Name = "Margin In Term")]
        public string margin_in_term_name { get; set; }

        [StringLength(15)]
        [Display(Name = "CIF No")]
        public string cif_no { get; set; }
    }

}
