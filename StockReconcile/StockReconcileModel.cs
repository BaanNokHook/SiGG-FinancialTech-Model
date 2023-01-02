using GM.Model.Common;
using System;
using System.Collections.Generic;

namespace GM.Model.StockReconcile
{
    public class StockReconcileModel
    {
        public int RowNumber { get; set; }
        public DateTime? as_of_date { get; set; }
        public int? instrument_id { get; set; }
        public string instrument_code { get; set; }
        public decimal afs_unit { get; set; }
        public decimal htm_unit { get; set; }
        public decimal memo_bnk_unit { get; set; }
        public decimal memo_trd_unit { get; set; }
        public decimal total_unit { get; set; }
        public decimal outstanding_unit { get; set; }
        public decimal obligate_unit { get; set; }
        public decimal diff_unit { get; set; }
        public string remark { get; set; }
        public string import_id { get; set; }
        public string recorded_by { get; set; }
        public virtual PagingModel Paging { get; set; }
        public virtual List<OrderByModel> OrdersBy { get; set; }
    }
}
