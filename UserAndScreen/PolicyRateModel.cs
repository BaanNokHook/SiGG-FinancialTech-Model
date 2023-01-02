using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GM.Model.Common;

namespace GM.Model.UserAndScreen
{
    public class PolicyRateModel
    {
        [Display(Name = "No")]
        public int? RowNumber { get; set; }

        [Display(Name = "Policy Date")]
        public DateTime? policy_date { get; set; }

        [StringLength(3)]
        [Display(Name = "Currency")]
        public string cur { get; set; }

        [Display(Name = "Cost Of Fund Date")]
        public DateTime? cost_of_fund_date { get; set; }

        [Required]
        [Display(Name = "Cost Of Fund Rate")]
        [DisplayFormat(DataFormatString = "{0:n6}", ApplyFormatInEditMode = true)]
        public decimal cost_of_fund_rate { get; set; }

        [Display(Name = "Remark")]
        public string remark { get; set; }

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
