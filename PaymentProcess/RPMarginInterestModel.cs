using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GM.Model.Common;

namespace GM.Model.PaymentProcess
{
    public class RPMarginInterestModel
    {
        //Gen ใน Stored Procedures
        [Display(Name = "As Of Date")]
        public DateTime? asof_date { get; set; }

        [Required]
        [Display(Name = "Trans Number")]
        public string trans_no { get; set; }

        [Display(Name = "CounterParty ID")]
        public string counter_party_id { get; set; }

        [Display(Name = "CounterParty Code")]
        public string counter_party_code { get; set; }

        [Required]
        [Display(Name = "Currency")]
        [StringLength(3)]
        public string cur { get; set; }

        [Required]
        [Display(Name = "Trans Deal Type")]
        [StringLength(20)]
        public string trans_deal_type { get; set; }

        [Required]
        [Display(Name = "Trade Date")]
        public DateTime? trade_date { get; set; }

        [Required]
        [Display(Name = "Settlement Date")]
        public DateTime? settlement_date { get; set; }

        [Required]
        [Display(Name = "Maturity Date")]
        public DateTime? maturity_date { get; set; }

        [Required]
        [Display(Name = "Purchase Price")]
        public decimal purchase_price { get; set; }

        [Required]
        [Display(Name = "Repo Interest Rate")]
        public decimal repo_int_rate { get; set; }

        [Required]
        public decimal repo_int_return { get; set; }

        [Display(Name = "Period")]
        public int? period { get; set; }

        public int? remain_period { get; set; }

        [Required]
        public decimal prev_int_amt { get; set; }

        [Required]
        [Display(Name = "Interest Amount")]
        public decimal int_amt { get; set; }

        [Required]
        public decimal int_amt_perday { get; set; }

        public int? year_basis { get; set; }

        [Required]
        [Display(Name = "Interest Tax")]
        public decimal int_tax { get; set; }

        public DateTime? prev_int_payment { get; set; }

        public DateTime? next_int_payment { get; set; }

        [Required]
        [Display(Name = "Total Interest Period")]
        public decimal total_int_period { get; set; }

        [Required]
        public decimal accum_int_period { get; set; }

        [Required]
        [Display(Name = "Interest Tax Period")]
        public decimal int_tax_period { get; set; }

        [Required]
        public decimal total_int_paid { get; set; }

        [Required]
        [Display(Name = "Total Interest Received")]
        public decimal total_int_received { get; set; }

        [Required]
        [Display(Name = "Total Interest Paid Adjust")]
        public decimal total_int_paid_adj { get; set; }

        [Required]
        [Display(Name = "Total Interest Receive Adjust")]
        public decimal total_int_received_adj { get; set; }

        [Required]
        public decimal accum_int_paid { get; set; }

        [Required]
        public decimal accum_int_reveived { get; set; }

        [Required]
        [Display(Name = "Total Interest Tax Adjust")]
        public decimal total_int_tax_adj { get; set; }

        [StringLength(100)]
        [Display(Name = "Payment Method")]
        public string payment_method { get; set; }

        [StringLength(20)]
        public string mt_code { get; set; }

        public DateTime? create_date { get; set; }

        [Required]
        [StringLength(255)]
        public string create_by { get; set; }

        public DateTime? update_date { get; set; }

        [StringLength(255)]
        public string update_by { get; set; }

        public virtual PagingModel paging { get; set; }

        public virtual List<OrderByModel> ordersby { get; set; }

        [Display(Name = "No")]
        public int? RowNumber { get; set; }

    }
}
