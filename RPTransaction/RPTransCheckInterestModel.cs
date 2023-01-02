using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GM.Model.Common;

namespace GM.Model.RPTransaction
{
    public class RPTransCheckInterestModel
    {
        [Display(Name = "Trans No")]
        public string trans_no { get; set; }
        [Display(Name = "Period")]
        public string period { get; set; }
        [Display(Name = "Day Period")]
        public string day_period { get; set; }
        [Display(Name = "Coupon Rate")]
        public string coupon_rate { get; set; }
        [Display(Name = "Coupon Spread")]
        public string coupon_spread { get; set; }
        [Display(Name = "interest Total Rate")]
        public string interest_total_rate { get; set; }
        [Display(Name = "interest Amount")]
        public string interest_amount { get; set; }

        public virtual List<OrderByModel> ordersby { get; set; }
    }
}
