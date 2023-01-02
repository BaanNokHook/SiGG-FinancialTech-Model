﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GM.Model.Common;

namespace GM.Model.PaymentProcess
{
    public class RPCouponDetailModel
    {
        public RPCouponDetailModel()
        {
            unit = 0;
            interest_amount = 0;
            interest_amount_adj = 0;
            wht_int_amount = 0;
            wht_int_amount_adj = 0;
        }


        //[Required]
        [Display(Name = "Trans Coupon No.")]
        [StringLength(15)]
        public string trans_cno { get; set; }

        [Required]
        [Display(Name = "Instrument Id")]
        public int instrument_id { get; set; }

        //[Required]
        [StringLength(255)]
        [Display(Name = "Instrument Code")]
        public string instrument_code { get; set; }

        [Required]
        [Display(Name = "Payment Date")]
        public DateTime payment_date { get; set; }

        [Required]
        [Display(Name = "Event Date")]
        public DateTime event_date { get; set; }

        [Display(Name = "CouterParty")]
        public int? counter_party_id { get; set; }

        //[Required]
        [Display(Name = "CouterParty Code")]
        public string counter_party_code { get; set; }

        [Display(Name = "CouterPartyFund")]
        public Nullable<int> counter_party_fund_id { get; set; }

        [Display(Name = "CouterPartyFund Code")]
        public string fund_code { get; set; }

        [StringLength(3)]
        [Display(Name = "Currency")]
        public string cur { get; set; }

        [Required]
        [Display(Name = "Ending Par")]
        public decimal ending_par { get; set; }

        [Required]
        [Display(Name = "Coupon Rate")]
        public decimal coupon_rate { get; set; }

        [Display(Name = "Port")]
        [StringLength(10)]
        public string port { get; set; }

        [Required]
        [Display(Name = "Unit")]
        public decimal unit { get; set; }

        //[Required]
        [Display(Name = "Face Value")]
        public decimal face_value { get; set; }

        [Required]
        [Display(Name = "AI Amount")]
        public decimal interest_amount { get; set; }

        [Required]
        [Display(Name = "Adjust AI Amount")]
        public decimal interest_amount_adj { get; set; }

        [Required]
        [Display(Name = "WHT TAX")]
        public decimal wht_int_amount { get; set; }

        [Required]
        [Display(Name = "Adjust WHT TAX")]
        public decimal wht_int_amount_adj { get; set; }

        [StringLength(100)]
        [Display(Name = "Payment Method")]
        public string payment_method { get; set; }

        [StringLength(100)]
        [Display(Name = "MT Code")]
        public string mt_code { get; set; }

        [StringLength(255)]
        [Display(Name = "Remark")]
        public string remark { get; set; }

        //[Required]
        public DateTime create_date { get; set; }

        [StringLength(50)]
        public string create_by { get; set; }

        public Nullable<DateTime> update_date { get; set; }

        [StringLength(50)]
        public string update_by { get; set; }

        public virtual PagingModel paging { get; set; }

        public virtual List<OrderByModel> ordersby { get; set; }

    }
}
