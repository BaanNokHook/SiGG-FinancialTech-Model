using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GM.Model.Common;

namespace GM.Model.UserAndScreen
{
    public class TraderLimitModel
    {
        [Display(Name = "No")]
        public int? RowNumber { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "User Id")]
        public string user_id { get; set; }

        [Display(Name = "User Eng Name")]
        public string user_eng_name { get; set; }

        [Required]
        [Display(Name = "Desk Group")]
        public int desk_group_id { get; set; }

        [Display(Name = "Desk Group Name")]
        public string desk_group_name { get; set; }

        [Required]
        [Display(Name = "Limit Amount")]
        public decimal limit_amount { get; set; }

        [Required]
        [Display(Name = "Used Amount")]
        public decimal used_amount { get; set; }

        [Required]
        [Display(Name = "Available Amount")]
        public decimal available_amount { get; set; }

        [Required]
        [StringLength(3)]
        [Display(Name = "Cur")]
        public string cur { get; set; }

        [Required]
        [Display(Name = "Start Date")]
        public DateTime? start_date { get; set; }

        [Required]
        [Display(Name = "Expire Date")]
        public DateTime? expire_date { get; set; }

        [Required]
        [Display(Name = "Threshold Amount")]
        public decimal threshold_amount { get; set; }

        [Required]
        [Display(Name = "Threshold Percent(%)")]
        public decimal threshold_percent { get; set; }

        [Required]
        [Display(Name = "Active Flag")]
        public bool active_flag { get; set; }

        [Display(Name = "Last Reset Date")]
        public DateTime? last_reset_date { get; set; }

        public DateTime? create_date { get; set; }

        public string create_by { get; set; }

        public DateTime? update_date { get; set; }

        public string update_by { get; set; }

        public virtual PagingModel paging { get; set; }

        public virtual List<OrderByModel> ordersby { get; set; }
    }
}
