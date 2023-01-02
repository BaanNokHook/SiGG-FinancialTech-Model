using GM.Model.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GM.Model.Report
{
    public class ReportCriteriaModel
    {
        [Display(Name = "As Of Date")]
        public DateTime? asofdate { get; set; }

        [Display(Name = "As Of Date")]
        public DateTime? asofdate_from { get; set; }

        [Display(Name = "As Of Date To")]
        public DateTime? asofdate_to { get; set; }

        [Display(Name = "Trade Date")]
        public DateTime? trade_date { get; set; }

        [Display(Name = "Trade Date")]
        public DateTime? trade_date_from { get; set; }

        [Display(Name = "Call Date")]
        public DateTime? call_date_from { get; set; }

        [Display(Name = "Call Date To")]
        public DateTime? call_date_to { get; set; }

        [Display(Name = "Trade Date To")]
        public DateTime? trade_date_to { get; set; }

        [Display(Name = "Settlement Date")]
        public DateTime? settlement_date { get; set; }

        [Display(Name = "Settlement Date")]
        public DateTime? settlement_date_from { get; set; }

        [Display(Name = "Settlement Date To")]
        public DateTime? settlement_date_to { get; set; }

        [Display(Name = "Maturity Date")]
        public DateTime? maturity_date { get; set; }

        [Display(Name = "Maturity Date")]
        public DateTime? maturity_date_from { get; set; }

        [Display(Name = "Maturity Date To")]
        public DateTime? maturity_date_to { get; set; }

        [Display(Name = "Start Date")]
        public DateTime? start_date { get; set; }

        [Display(Name = "Expire Date")]
        public DateTime? expire_date { get; set; }

        [Display(Name = "Date From")]
        public DateTime? from_date { get; set; }

        [Display(Name = "To")]
        public DateTime? to_date { get; set; }

        [Display(Name = "XI Date")]
        public DateTime? xi_date { get; set; }

        [Display(Name = "Payment Date")]
        public DateTime? payment_date { get; set; }

        public string asofdate_string { get; set; }
        public string asofdate_from_string { get; set; }
        public string asofdate_to_string { get; set; }
        public string asofdate_max_string { get; set; }
        public string trade_date_string { get; set; }
        public string trade_date_from_string { get; set; }
        public string trade_date_to_string { get; set; }
        public string settlement_date_string { get; set; }
        public string settlement_date_from_string { get; set; }
        public string settlement_date_to_string { get; set; }
        public string maturity_date_string { get; set; }
        public string maturity_date_from_string { get; set; }
        public string maturity_date_to_string { get; set; }
        public string excel_category { get; set; }
        public string start_date_string { get; set; }
        public string expire_date_string { get; set; }
        public string from_date_string { get; set; }
        public string to_date_string { get; set; }

        public string call_date_from_string { get; set; }
        public string call_date_to_string { get; set; }

        public string xi_date_string { get; set; }
        public string payment_date_string { get; set; }

        [Display(Name = "Monthly")]
        public string monthly_year { get; set; }

        [Display(Name = "Date From")]
        public string day_from { get; set; }

        [Display(Name = "TO")]
        public string day_to { get; set; }

        [Display(Name = "Instrument")]
        public string repo_deal_type { get; set; }
        public string repo_deal_type_name { get; set; }

        [Display(Name = "Repo Type")]
        public string obligate_type { get; set; }
        public string obligate_type_name { get; set; }

        [Display(Name = "Trans Status.")]
        public string trans_status { get; set; }
        public string trans_status_name { get; set; }

        [Display(Name = "Customer Type.")]
        public string cust_type { get; set; }
        public string cust_type_name { get; set; }

        [Display(Name = "Report Type.")]
        public string report_type { get; set; }
        public string report_type_name { get; set; }

        [Display(Name = "Trans No.")]
        public string trans_no { get; set; }

        [Display(Name = "Trans No. From")]
        public string trans_no_from { get; set; }

        [Display(Name = "Trans No. To")]
        public string trans_no_to { get; set; }

        [Display(Name = "Instrument Code")]
        public string instrument_id { get; set; }
        public string instrument_code_name { get; set; }

        public string counterparty_id { get; set; }

        [Display(Name = "Counter Party")]
        public string counterparty_code { get; set; }
        public string counterparty_code_name { get; set; }

        [Display(Name = "Counter Party Fund")]
        public string counterparty_fund_id { get; set; }
        public string counterparty_fund_name { get; set; }

        [Display(Name = "Cur")]
        public string currency { get; set; }

        [Display(Name = "Portfolio")]
        public string port { get; set; }
        public string port_name { get; set; }

        [Display(Name = "Trans Deal Type")]
        public string instrument_type { get; set; }
        public string instrument_type_name { get; set; }

        [Display(Name = "Int Type")]
        public string int_type { get; set; }
        public string int_type_name { get; set; }

        [Display(Name = "Cost Type")]
        public string cost_type { get; set; }
        public string cost_type_name { get; set; }

        [Display(Name = "Trader ID")]
        public string trader_id { get; set; }
        public string trader_id_text { get; set; }

        [Display(Name = "User ID")]
        public string user_id { get; set; }
        public string user_id_text { get; set; }

        [Display(Name = "Status")]
        public string event_type { get; set; }
        public string event_type_id { get; set; }

        [Display(Name = "Account Code")]
        public string account_code { get; set; }
        public string account_code_name { get; set; }

        public string account_code_from { get; set; }
        public string account_code_to { get; set; }

        [Display(Name = "Account Group")]
        public string account_group { get; set; }
        public string account_group_name { get; set; }

        public string type_date { get; set; }

        [Display(Name = "Type")]
        public string type_report { get; set; }

        public string execute_type { get; set; }

        [Display(Name = "Trans Deal Type")]
        public string trans_deal_type { get; set; }

        [Display(Name = "Trans Deal Type")]
        public string trans_deal_type_name { get; set; }

        [Display(Name = "Security")]
        public string security_code { get; set; }
        public string security_code_name { get; set; }

        [Display(Name = "Terminate Date")]
        public DateTime? terminate_date { get; set; }
        public string terminate_date_from_string { get; set; }
        public string terminate_date_to_string { get; set; }
        public DateTime? terminate_date_from { get; set; }
        public DateTime? terminate_date_to { get; set; }

        public int numDays { get; set; }
        public string is_full_date { get; set; }

        public virtual PagingModel paging { get; set; }

        public virtual List<OrderByModel> ordersby { get; set; }
    }
}
