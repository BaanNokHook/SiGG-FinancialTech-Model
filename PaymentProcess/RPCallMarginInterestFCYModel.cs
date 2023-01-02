using GM.Model.Common;
using System;
using System.Collections.Generic;

namespace GM.Model.PaymentProcess
{
    public class RPMarginInterestFCYModel
    {
        public int? RowNumber { get; set; }
        public string BusinessDate { get; set; }
        public virtual PagingModel paging { get; set; }
        public virtual List<OrderByModel> ordersby { get; set; }

        public DateTime? eom_date { get; set; }
        public DateTime? int_rec_pay_date { get; set; }

        public DateTime? payment_date { get; set; }

        public int? counter_party_id { get; set; }
        public string counter_party_code { get; set; }
        public string counter_party_name { get; set; }
        public string cur { get; set; }
        public string margin_status { get; set; }
        public string rec_pay_status { get; set; }
        public string rec_pay { get; set; }
        public string eom_int_flag { get; set; }
        public DateTime? eom_date_from { get; set; }
        public DateTime? eom_date_to { get; set; }
        public decimal margin_balance { get; set; }
        public decimal position_margin { get; set; }
        public decimal total_int_rec { get; set; }
        public decimal total_int_pay { get; set; }
        public decimal int_rec_tax { get; set; }
        public DateTime? create_date { get; set; }

        public string create_by { get; set; }

        public DateTime? update_date { get; set; }
        public string update_by { get; set; }

        public RPMarginInterestFCYModel()
        {

        }
    }
}
