using System;
using System.Collections.Generic;
using System.Text;

namespace GM.Model.StockReconcile
{
    public class StockReconcileImportModel
    {
        public string import_id { get; set; }
        public string filename { get; set; }
        public DateTime asOfDate { get; set; }
        public string participant { get; set; }
        public string accno { get; set; }
        public string instrumentCode { get; set; }
        public string isincode { get; set; }
        public decimal? unit { get; set; }
        public decimal? pending_withdrawal { get; set; }
        public decimal? pending_deposit { get; set; }
        public decimal? pending_sec { get; set; }
        public string broker { get; set; }
        public DateTime? create_date { get; set; }
        public string create_by { get; set; }
        public DateTime? update_date { get; set; }
        public string update_by { get; set; }
    }
}
