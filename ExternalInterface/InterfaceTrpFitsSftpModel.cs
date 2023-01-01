using GM.Model.Common;
using GM.Model.Static;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GM.Model.ExternalInterface
{
    public class InterfaceTrpFitsSftpModel
    {
        public DateTime asof_date { get; set; }

        public string file_trans_name { get; set; }

        public string file_collateral_name { get; set; }

        public string file_path { get; set; }

        public virtual List<RpConfigModel> RpConfigModel { get; set; }

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