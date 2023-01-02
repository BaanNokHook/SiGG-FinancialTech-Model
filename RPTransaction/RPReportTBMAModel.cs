using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GM.Model.Common;

namespace GM.Model.RPTransaction
{
    public class RPReportTBMAModel
    {
        public string FileName { get; set; }

        public string PathDes { get; set; }

        public string SheetName { get; set; }

        public DateTime? create_date { get; set; }

        [StringLength(50)]
        public string create_by { get; set; }

        public DateTime? update_date { get; set; }

        [StringLength(50)]
        public string update_by { get; set; }

        public virtual PagingModel paging { get; set; }

        public virtual List<OrderByModel> ordersby { get; set; }

        public virtual List<RPReportTBMADetailModel> ReportTBMAList { get; set; }
    }
}
