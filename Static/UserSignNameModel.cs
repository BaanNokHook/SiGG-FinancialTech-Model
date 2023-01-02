using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using GM.Model.Common;

namespace GM.Model.Static
{
    public class UserSignNameModel
    {
        public UserSignNameModel()
        {
            active_flag = true;
        }

        [Display(Name = "No")]
        public int? RowNumber { get; set; }

        public int? id { get; set; }

        [Required]
        [Display(Name = "Full Name")]
        public string fname { get; set; }

        [Display(Name = "Position")]
        public string position { get; set; }

        [Display(Name = "Active")]
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
