using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GM.Model.Common;

namespace GM.Model.UserAndScreen
{
    public class ScreenModel
    {
        public ScreenModel()
        {
            active_flag = true;
        }

        [Display(Name = "No")]
        public int? row_no { get; set; }

        [Required]
        [Display(Name = "Screen ID")]
        public int? screen_id { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Screen Name")]
        public string screen_name { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Controller")]
        public string controller { get; set; }

        [StringLength(255)]
        [Display(Name = "Action")]
        public string action { get; set; }

        [Required]
        [Display(Name = "Operation")]
        public int? operation_id { get; set; }

        [StringLength(255)]
        [Display(Name = "Operation Name")]
        public string operation_name { get; set; }

        [Display(Name = "Parent")]
        public int? parent_screen_id { get; set; }

        [StringLength(255)]
        [Display(Name = "Parent Name")]
        public string parent_screen_name { get; set; }

        [StringLength(255)]
        [Display(Name = "Icon Menu")]
        public string icon { get; set; }

        [StringLength(6)]
        [Display(Name = "Stored No")]
        public string storeproc_no { get; set; }

        [Required]
        [Display(Name = "Active Flag")]
        public bool active_flag { get; set; }

        [Required]
        [Display(Name = "Row Order")]
        public int? row_order { get; set; }

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
