using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GM.Model.Common;

namespace GM.Model.PaymentProcess
{
    public class RPCallMarginPRPModel
    {
        [Display(Name = "No")]
        public int? RowNumber { get; set; }
        public string BusinessDate { get; set; }
        public virtual PagingModel paging { get; set; }
        public virtual List<OrderByModel> ordersby { get; set; }

        public DateTime? trade_date { get; set; }
        public decimal? interes_rate { get; set; }
        public int? counter_party_id { get; set; }
        public string counter_party_code { get; set; }
        public string counter_party_name { get; set; }
        public string cur { get; set; }
        public decimal exposure { get; set; }
        public decimal prev_position_margin { get; set; }
        public decimal position_yesterday { get; set; }
        public decimal accrue_int_yesterday { get; set; }
        public decimal net_exposure { get; set; }
        public decimal call_margin { get; set; }
        public decimal close_margin { get; set; }
        public decimal interest_receive { get; set; }
        public decimal wh_tax { get; set; }
        public decimal interest_paid { get; set; }
        public decimal margin_balance { get; set; }
        public decimal int_rate { get; set; }
        public decimal int_per_day { get; set; }
        public decimal net_accrue_int_today { get; set; }
        public decimal net_accrue_int_yesterday { get; set; }
        public string remark { get; set; }
        public decimal threshold { get; set; }
        public decimal margin { get; set; }
        public decimal Int_Recv_Disp { get; set; }
        public decimal TOTAL_INT_REC { get; set; }
        public decimal Int_Tax_Disp { get; set; }
        public decimal INT_REC_TAX { get; set; }
        public decimal Int_Paid_Disp { get; set; }
        public decimal TOTAL_INT_PAY { get; set; }
        public decimal IntRateToday { get; set; }
        public decimal IntPerDay { get; set; }

        public string call_date { get; set; }
        public string asof_date { get; set; }
        public string instrument { get; set; }
        public string event_seq { get; set; }

        public decimal ORG_TODAY_EXPOSURE { get; set; }
        public decimal ORG_TOTAL_INT_REC { get; set; }
        public decimal ORG_TOTAL_INT_PAY { get; set; }
        public decimal ORG_TOTAL_INT_REC_TAX { get; set; }

        public decimal? minimum_transfer { get; set; }
        public int isCall { get; set; }
        public decimal? client_margin { get; set; }

        public string eom_int_flag { get; set; }

        public DateTime? payment_date { get; set; }

        public RPCallMarginPRPModel()
        {

        }
    }
}
