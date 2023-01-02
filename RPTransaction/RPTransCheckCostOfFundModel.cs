using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GM.Model.Common;

namespace GM.Model.RPTransaction
{
    public class RPTransCheckCostOfFundModel
    {
        [Display(Name = "Trans No")]
        public string trans_no { get; set; }
        [Display(Name = "Period")]
        public string period { get; set; }
        [Display(Name = "Day Period")]
        public string day_period { get; set; }
        [Display(Name = "Costoffund Rate")]
        public string costoffund_rate { get; set; }
        [Display(Name = "Costoffund Spread")]
        public string costoffund_spread { get; set; }
        [Display(Name = "Costoffund Total Rate")]
        public string costoffund_total_rate { get; set; }
        [Display(Name = "Costoffund Amount")]
        public string costoffund_amount { get; set; }

        public virtual List<OrderByModel> ordersby { get; set; }

        public decimal? cost_of_fund_rate { get; set; }
    }
}
