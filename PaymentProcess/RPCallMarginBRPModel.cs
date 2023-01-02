using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GM.Model.Common;

namespace GM.Model.PaymentProcess
{
    public class RPCallMarginBRPModel
    {
        [Display(Name = "No")]
        public int? RowNumber { get; set; }
        public string BusinessDate { get; set; }
        public virtual PagingModel paging { get; set; }
        public virtual List<OrderByModel> ordersby { get; set; }
        public string contract_no { get; set; }
        public string cur { get; set; }
        public decimal exposure { get; set; }
        public string position_yesterday { get; set; }
        public string call_margin { get; set; }
        public string close_margin { get; set; }
        public string interest_receive { get; set; }
        public string wh_tax { get; set; }
        public string interest_paid { get; set; }
        public string Margin_Disp { get; set; }
        public string margin_balance { get; set; }
        public string int_rate { get; set; }
        public string IntPerDay { get; set; }
        public string IntRecToday { get; set; }
        public string IntRecYesterday { get; set; }
        public string IntPayToday { get; set; }
        public string IntPayYesterday { get; set; }
        public string BRP_REMARK { get; set; }
        public decimal threshold { get; set; }
        public string trans_no { get; set; }
        public DateTime asof_date { get; set; }
        public DateTime call_date { get; set; }
        public string counter_party_code { get; set; }
        public decimal Int_Recv_Disp { get; set; }
        public decimal Int_Tax_Disp { get; set; }
        public decimal Int_Paid_Disp { get; set; }
        public int event_seq { get; set; }
        public decimal footer_margin_call { get; set; }
        public string footer_margin_status { get; set; }
        public decimal footer_margin_balance { get; set; }
        public decimal TRANS_MARGIN_INT_REC { get; set; }
        public decimal TRANS_MARGIN_INT_PAY { get; set; }
        public decimal TRANS_MARGIN_INT_TAX { get; set; }
        public decimal ORG_TRANS_EXPOSURE { get; set; }
        public decimal ORG_TRANS_MARGIN_INT_REC { get; set; }
        public decimal ORG_TRANS_MARGIN_INT_PAY { get; set; }
        public decimal ORG_TRANS_MARGIN_INT_TAX { get; set; }
        public int counter_party_id { get; set; }
        public string bond_id { get; set; }

        public RPCallMarginBRPModel()
        {
        }
    }
}
