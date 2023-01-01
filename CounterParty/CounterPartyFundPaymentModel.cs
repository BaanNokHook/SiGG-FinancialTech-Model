using GM.Model.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GM.Model.CounterParty
{
    public class CounterPartyFundPaymentModel
    {
        public CounterPartyFundPaymentModel()
        {
            default_flag = true;
        }
        public string rowstatus { get; set; }


        [StringLength(255)]
        public string bank_name { get; set; }

        [StringLength(255)]
        public string nosto_vosto_name { get; set; }

        [StringLength(255)]
        public string payment_method_name { get; set; }

        //-----------------------------
        [Required]
        public int? fund_id { get; set; }

        // [Required]
        public int? counter_party_id { get; set; }

        //  [Required]
        [Display(Name = "Bank Name")]
        [StringLength(35)]
        public string bank_code { get; set; }

        //  [Required]
        [Display(Name = "Account No")]
        [StringLength(255)]
        public string account_number { get; set; }

        // [Required]
        [Display(Name = "Payment Method")]
        [StringLength(100)]
        public string payment_method { get; set; }

        //  [Required]
        [Display(Name = "Account Type")]
        [StringLength(10)]
        public string nosto_vosto_code { get; set; }

        [StringLength(80)]
        [Display(Name = "CA No.")]
        public string ca_no { get; set; }

        [StringLength(80)]
        [Display(Name = "SA No.")]
        public string sa_no { get; set; }

        [StringLength(3)]
        [Display(Name = "Participant")]
        public string participant_id { get; set; }

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
