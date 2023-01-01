using GM.Model.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GM.Model.ExternalInterface.InterfaceThorRate
{
    public class ThorRateModel
    {
        public DateTime? asof_date { get; set; }

        [StringLength(10)]
        public string curve_id { get; set; }

        [StringLength(3)]
        public string ccy { get; set; }

        [StringLength(10)]
        public string index_type { get; set; }

        [StringLength(10)]
        public string tenor { get; set; }

        public Nullable<decimal> rate { get; set; }

        public Nullable<decimal> spread { get; set; }

        public System.DateTime create_date { get; set; }

        [StringLength(255)]
        public string create_by { get; set; }

        public Nullable<System.DateTime> update_date { get; set; }

        [StringLength(255)]
        public string update_by { get; set; }


        #region For Search
        public int RowNumber { get; set; }
        public DateTime? asof_date_from { get; set; }
        public DateTime? asof_date_to { get; set; }
        public virtual PagingModel paging { get; set; }
        public virtual List<OrderByModel> ordersby { get; set; }

        public string mode { get; set; }
        #endregion


    }
}
