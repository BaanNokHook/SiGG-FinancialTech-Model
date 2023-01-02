using System;
using System.Collections.Generic;
using System.Text;

namespace GM.Model.Report
{
    public class EodReconcileReportModel
    {
        public string repo_deal_type_name { get; set; }
        public string bo_state { get; set; }
        public string mt_code { get; set; }
        public string trans_no { get; set; }
        public string security { get; set; }
        public DateTime trade_date { get; set; }
        public DateTime settlement_date { get; set; }
        public DateTime maturity_date { get; set; }
        public string trans_state { get; set; }
        public decimal purchase_price { get; set; }
        public decimal interest_amount { get; set; }
        public decimal holdingTax_amt { get; set; }
        public decimal termination_value { get; set; }
        public string payment_method { get; set; }
    }
}
