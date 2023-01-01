using System;
using System.Collections.Generic;
using System.Text;

namespace GM.Model.InterfaceEodReconcile
{
    public class ReqEodReconcileBahtnet
    {
        public string filename { get; set; }
        public string bn_trans_id { get; set; }
        public string sender_ref { get; set; }
        public string mt { get; set; }
        public string bt { get; set; }
        public string dr_bic { get; set; }
        public string dr_acc { get; set; }
        public string cr_bic { get; set; }
        public string cr_acc { get; set; }
        public string dr_amt { get; set; }
        public string cr_amt { get; set; }
        public string status { get; set; }
        public string error { get; set; }
        public string time { get; set; }
        public string ch { get; set; }
        public string transmission_type { get; set; }
        public string value_date { get; set; }

        public DateTime? create_date { get; set; }
        public string create_by { get; set; }
        public DateTime? update_date { get; set; }
        public string update_by { get; set; }
    }
}
