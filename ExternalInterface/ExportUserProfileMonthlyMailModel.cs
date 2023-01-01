using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using GM.Model.Common;
using GM.Model.Static;

namespace GM.Model.ExternalInterface
{
    public class ExportUserProfileMonthlyMailModel
    {
        public DateTime AsofDate { get; set; }

        public string FileName { get; set; }

        public string FilePath { get; set; }

        public string Monthly { get; set; }

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
