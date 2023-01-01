using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using GM.Model.Common;

namespace GM.Model.GLProcess
{
    public class GLAdjustModel
    {
        [Display(Name = "No")]
        public int? RowNumber { get; set; }

        [Display(Name = "Adjust No.")]
        public string adjust_num { get; set; }

        public int sequence_id { get; set; }

        public int sequence_num { get; set; }

        public int sub_seq_num { get; set; }

        [Display(Name = "Posting Date")]
        public DateTime? posting_date { get; set; }

        public DateTime? value_date { get; set; }

        [Display(Name = "DR/CR")]
        public string dr_cr { get; set; }

        [Display(Name = "Account No")]
        public string account_no { get; set; }

        [Display(Name = "Account Name")]
        public string account_name { get; set; }

        [Display(Name = "Port")]
        public string trans_port { get; set; }

        [Display(Name = "Transaction No.")]
        public string trans_no { get; set; }

        [Display(Name = "Adjust Currency")]
        public string cur { get; set; }

        [Display(Name = "Amount")]
        public decimal amount { get; set; }

        [Display(Name = "Item Count")]
        public int item_count { get; set; }

        [Display(Name = "Cost Center")]
        public string cost_center { get; set; }

        [Display(Name = "Note")]
        public string note { get; set; }

        [Display(Name = "Type")]
        public string adjust_type { get; set; }

        public string counter_party_id { get; set; }

        public string counter_party_name { get; set; }

        public DateTime? create_date { get; set; }

        [StringLength(255)]
        public string create_by { get; set; }

        public DateTime? update_date { get; set; }

        [StringLength(255)]
        public string update_by { get; set; }

        public virtual PagingModel paging { get; set; }

        public virtual List<OrderByModel> ordersby { get; set; }
    }
}
