using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GM.Model.Common;

namespace GM.Model.PaymentProcess
{
    public class RPReleaseMessageModel
    {
        public int message_no { get; set; }
        public string event_type { get; set; }

        public string payment_method { get; set; }

        public string mt_code { get; set; }

        public string ref_no { get; set; }

        public string file_path { get; set; }

        public string file_name { get; set; }

        public string result { get; set; }

        public string mt_message { get; set; }
        public string isin_code { get; set; }

        public string Enable { get; set; }

        public string customer_ref { get; set; }

        public string swift_channel { get; set; }

        //===================================================================

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
