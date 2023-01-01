using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace GM.Model.InterfaceEodReconcile
{
    public class ReqEodReconcilePti
    {
        public string filename { get; set; }
        public string trans_date { get; set; }
        public string matched_id { get; set; }
        public string mt { get; set; }
        public string status { get; set; }
        public string counter_party_bic { get; set; }
        public string delv_acct { get; set; }
        public string security_symbol { get; set; }
        public string isin_code { get; set; }
        public string face_amt { get; set; }
        public string currency { get; set; }
        public string volume { get; set; }
        public string create_time { get; set; }
        public string settle_date { get; set; }
        public string sender_ref { get; set; }
        public string bt { get; set; }
        public string error { get; set; }
        public string count_sender_ref { get; set; }
        public string recv_acct { get; set; }
        public string cash_acct { get; set; }
        public string settle_amt { get; set; }
        public string currency2 { get; set; }
        public string channel { get; set; }
        public string time { get; set; }
        public DateTime? create_date { get; set; }
        public string create_by { get; set; }
        public DateTime? update_date { get; set; }
        public string update_by { get; set; }
    }
}
