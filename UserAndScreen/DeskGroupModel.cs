using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GM.Model.Common;

namespace GM.Model.UserAndScreen
{
    public class DeskGroupModel
    {
        public DeskGroupModel()
        {
            active_flag = true;
        }

        [Display(Name = "No")]
        public int? row_no { get; set; }

        [Display(Name = "Group ID")]
        public int? desk_group_id { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Desk Group Name")]
        public string desk_group_name { get; set; }

        [Required]
        [Display(Name = "Active Flag")]
        public bool active_flag { get; set; }

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
