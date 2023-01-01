using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GM.Model.Common;
using GM.Model.Static;

namespace GM.Model.ExternalInterface
{
    public class InterfaceDwhSftpModel
    {
        [Display(Name = "No")]
        public int? RowNumber { get; set; }

        [Display(Name = "Id")]
        public int dwh_id { get; set; }

        [Display(Name = "DWH Name")]
        public string dwh_name { get; set; }

        [Display(Name = "File Title")]
        public string file_title { get; set; }

        [Display(Name = "File Type")]
        public string file_type { get; set; }

        [Display(Name = "Type")]
        public string type { get; set; }

        [Display(Name = "Curency Type")]
        public string cur_type { get; set; }

        [Display(Name = "Enable Flag")]
        public bool enable_flag { get; set; }

        [Display(Name = "Order No")]
        public int order_no { get; set; }

        public DateTime asof_date { get; set; }
        public string flag_ctrl { get; set; }

        public virtual List<RpConfigModel> RpConfigModel { get; set; }

        //=======================================================

        public DateTime? create_date { get; set; }

        [StringLength(50)]
        public string create_by { get; set; }

        public DateTime? update_date { get; set; }

        [StringLength(50)]
        public string update_by { get; set; }

        public virtual PagingModel paging { get; set; }

        public virtual List<OrderByModel> ordersby { get; set; }
    }
}
