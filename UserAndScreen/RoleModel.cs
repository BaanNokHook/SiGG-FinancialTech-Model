using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GM.Model.Common;

namespace GM.Model.UserAndScreen
{
    public class RoleModel
    {

        public RoleModel()
        {
            active_flag = true;
        }

        [Display(Name = "No")]
        public int? RowNumber { get; set; }

        //[Required]
        [Display(Name = "Role ID")]
        public int? role_id { get; set; }

        //[Required]
        [Display(Name = "Role Code")]
        [StringLength(255)]
        public string role_code { get; set; }

        //[Required]
        [Display(Name = "Role Name")]
        [StringLength(255)]
        public string role_name { get; set; }

        //[Required]
        [Display(Name = "Active Flag")]
        public bool active_flag { get; set; }

        //[Required]
        [Display(Name = "Create Date")]
        public DateTime create_date { get; set; }

        //[Required]
        [Display(Name = "Create By")]
        [StringLength(255)]
        public string create_by { get; set; }

        [Display(Name = "Update Date")]
        public Nullable<DateTime> update_date { get; set; }

        [Display(Name = "Update By")]
        [StringLength(255)]
        public string update_by { get; set; }

        public virtual PagingModel paging { get; set; }

        public virtual List<OrderByModel> ordersby { get; set; }

    }
}