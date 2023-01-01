using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GM.Model.Common;
using GM.Model.Static;

namespace GM.Model.ExternalInterface
{
    public class InterfaceDmsSftpModel
    {
        [Display(Name = "No")]
        public int? RowNumber { get; set; }

        public string dms_name { get; set; }

        public string file_name { get; set; }

        public string file_path { get; set; }

        public DateTime asof_date { get; set; }

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
