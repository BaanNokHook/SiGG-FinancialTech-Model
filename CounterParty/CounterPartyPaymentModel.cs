using GM.Model.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GM.Model.CounterParty
{
    public class CounterPartyPaymentModel
    {
        public string rowstatus { get; set; }


        [StringLength(255)]
        public string bank_name { get; set; }

        [StringLength(255)]
        public string nosto_vosto_name { get; set; }

        [StringLength(255)]
        public string payment_method_name { get; set; }

        //-----------------------------
        // [Required]
        public int? counter_party_id { get; set; }

        //[Required]
        [Display(Name = "Bank Name")]
        [StringLength(35)]
        public string bank_code { get; set; }

        //[Required]
        [Display(Name = "Account No")]
        [StringLength(255)]
        public string account_number { get; set; }

        //[Required]
        [Display(Name = "Payment Method")]
        [StringLength(100)]
        public string payment_method { get; set; }

        //[Required]
        [StringLength(10)]
        [Display(Name = "Account Type")]
        public string nosto_vosto_code { get; set; }

        [StringLength(80)]
        [Display(Name = "C/A No.")]
        public string ca_no { get; set; }

        [StringLength(80)]
        [Display(Name = "S/A No.")]
        public string sa_no { get; set; }

        [StringLength(3)]
        [Display(Name = "Participant ID")]
        public string participant_id { get; set; }

        [StringLength(30)]
        [Display(Name = "A/C No.")]
        public string acc_clearstream { get; set; }

        [StringLength(50)]
        [Display(Name = "Security Agent")]
        public string security_agent { get; set; }

        [StringLength(50)]
        [Display(Name = "Imtermediary")]
        public string intermediary { get; set; }

        [StringLength(50)]
        [Display(Name = "Account with Institution")]
        public string accWithInst { get; set; }

        [StringLength(50)]
        [Display(Name = "Beneficiary Institution")]
        public string Beneficial { get; set; }

        // [Required]
        [Display(Name = "Default Flag")]
        public bool default_flag { get; set; }

        public DateTime? create_date { get; set; }

        [StringLength(255)]
        public string create_by { get; set; }

        public DateTime? update_date { get; set; }

        [StringLength(255)]
        public string update_by { get; set; }

        public virtual PagingModel paging { get; set; }

        public virtual List<OrderByModel> ordersby { get; set; }
    }

}
