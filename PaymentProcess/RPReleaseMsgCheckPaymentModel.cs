using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GM.Model.Common;

namespace GM.Model.PaymentProcess
{
    public class RPReleaseMsgCheckPaymentModel
    {

        public string from_page { get; set; }

        public string event_type { get; set; }

        public string trans_deal_type { get; set; }

        public string payment_method { get; set; }

        public string mt_code { get; set; }

        public string repo_deal_type { get; set; }

        public bool is_payment { get; set; }
        //========================================================

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
