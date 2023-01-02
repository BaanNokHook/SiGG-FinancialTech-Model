using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GM.Model.Common;

namespace GM.Model.Security
{
    public class SecurityEventModel
    {
        public SecurityEventModel()
        {
            complete_flag = true;
        }

        [Required]
        [Display(Name = "Start Date")]
        public DateTime? start_date { get; set; }

        //[Required]
        [Display(Name = "End Date")]

        public DateTime? end_date { get; set; }
        [Display(Name = "AI Amount")]
        public decimal? ai_amount { get; set; }
        [Display(Name = "Datafrom")]
        public string datafrom { get; set; }
        [Display(Name = "Row No")]
        public string rowno { get; set; }
        [Display(Name = "Action")]
        public string action { get; set; }

        [Key, Column(Order = 0)]
        [Required]
        [Display(Name = "Instrument Code")]
        public int instrument_id { get; set; }

        //[Key, Column(Order = 1)]
        [Required]
        [Display(Name = "Event Date")]
        public DateTime? event_date { get; set; }

        [Key, Column(Order = 2)]
        [Required]
        [StringLength(255)]
        [Display(Name = "Event Type")]
        public string event_type { get; set; }

        [Required]
        [Display(Name = "Round No")]
        public int? round_no { get; set; }

        [Display(Name = "Status")]
        public Boolean complete_flag { get; set; }

        [Display(Name = "Coupon Date")]
        public DateTime? coupon_date { get; set; }

        [Display(Name = "Next Coupon Date")]
        public DateTime? next_coupon_date { get; set; }

        [Required]
        [Display(Name = "Payment Date")]
        public DateTime? payment_date { get; set; }

        [StringLength(15)]
        [Display(Name = "Coupon Type")]
        public string coupon_type { get; set; }

        [Required]
        [Display(Name = "Coupon Rate")]
        public decimal? coupon_rate { get; set; }

        [StringLength(25)]
        [Display(Name = "Coupon Floating Idex Code")]
        public string coupon_floating_index_code { get; set; }

        [StringLength(3)]
        [Display(Name = "Coupon Currency")]
        public string coupon_cur { get; set; }

        [Display(Name = "Coupon Spread")]
        public decimal? coupon_spread { get; set; }

        [Display(Name = "Redemption Value")]
        public decimal? redemption_value { get; set; }

        [Display(Name = "Redemption Percent")]
        public decimal? redemption_percent { get; set; }

        [StringLength(12)]
        [Display(Name = "Redemption Trans")]
        public string redemption_trans_no { get; set; }

        [StringLength(1)]
        public string order_index { get; set; }

        [Display(Name = "Interest")]
        public decimal? interest { get; set; }

        [Display(Name = "Principal")]
        public decimal? principal { get; set; }

        [Display(Name = "Total Payment")]
        public decimal? total_payment { get; set; }

        [Required]
        [Display(Name = "Begining Par")]
        public decimal? begining_par { get; set; }

        [Required]
        [Display(Name = "Ending Par")]
        public decimal? ending_par { get; set; }

        [Display(Name = "XI Date")]
        public DateTime? xi_date { get; set; }

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
