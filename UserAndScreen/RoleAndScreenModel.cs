using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GM.Model.Common;

namespace GM.Model.UserAndScreen
{
    public class RoleAndScreenModel
    {
        public RoleAndScreenModel()
        {
            view_flag = true;
            create_flag = true;
            update_flag = true;
            delete_flag = true;
        }
        [Display(Name = "No")]
        public int? RowNumber { get; set; }

        //[Required]
        [Display(Name = "Role ID")]
        public int? role_id { get; set; }

        //[Required]
        [Display(Name = "Screen ID")]
        public int? screen_id { get; set; }

        //[Required]
        [Display(Name = "Role Name")]
        [StringLength(255)]
        public string role_name { get; set; }

        //[Required]
        [Display(Name = "Screen Name")]
        [StringLength(255)]
        public string screen_name { get; set; }

        public int? parent_screen_id { get; set; }

        [Display(Name = "Parent Screen")]
        [StringLength(255)]
        public string parent_screen { get; set; }

        [Display(Name = "View Flag")]
        public Nullable<bool> view_flag { get; set; }

        [Display(Name = "Create Flag")]
        public Nullable<bool> create_flag { get; set; }

        [Display(Name = "Update Flag")]
        public Nullable<bool> update_flag { get; set; }

        [Display(Name = "Delete Flag")]
        public Nullable<bool> delete_flag { get; set; }

        //[Required]
        [Display(Name = "Create Date")]
        public DateTime create_date { get; set; }

        public int row_order { get; set; }

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

        public virtual RoleAndScreenModel RoleAndScreenRightModal { get; set; }
    }
}
