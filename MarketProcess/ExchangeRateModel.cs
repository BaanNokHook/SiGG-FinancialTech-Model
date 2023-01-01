using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GM.Model.Common;

namespace GM.Model.MarketProcess
{
    public class ExchangeRateModel
    {
        [Display(Name = "No")]
        public int? RowNumber { get; set; }

        [Display(Name = "Source Type")]
        public string source_type { get; set; }
        [Display(Name = "Source Type")]
        public string source_desc { get; set; }
        public string source_type_desc { get; set; }

        [Display(Name = "Exchange Type")]
        public string exchange_type { get; set; }
        [Display(Name = "Exchange Type")]
        public string exchange_desc { get; set; }

        [Display(Name = "Asof Date")]
        public DateTime? asof_date { get; set; }

        [Display(Name = "Cur1")]
        public string cur1 { get; set; }

        [Display(Name = "Cur2")]
        public string cur2 { get; set; }

        [Display(Name = "Rate")]
        [DisplayFormat(DataFormatString = "{0:n6}", ApplyFormatInEditMode = true)]
        public decimal? exch_rate { get; set; }

        [Display(Name = "MOS1")]
        [DisplayFormat(DataFormatString = "{0:n6}", ApplyFormatInEditMode = true)]
        public decimal? MOS1 { get; set; }

        [Display(Name = "MOS2")]
        [DisplayFormat(DataFormatString = "{0:n6}", ApplyFormatInEditMode = true)]
        public decimal? MOS2 { get; set; }

        [Display(Name = "MOS3")]
        [DisplayFormat(DataFormatString = "{0:n6}", ApplyFormatInEditMode = true)]
        public decimal? MOS3 { get; set; }

        [Display(Name = "MOS6")]
        [DisplayFormat(DataFormatString = "{0:n6}", ApplyFormatInEditMode = true)]
        public decimal? MOS6 { get; set; }

        [Display(Name = "MOS9")]
        [DisplayFormat(DataFormatString = "{0:n6}", ApplyFormatInEditMode = true)]
        public decimal? MOS9 { get; set; }

        [Display(Name = "YR1")]
        [DisplayFormat(DataFormatString = "{0:n6}", ApplyFormatInEditMode = true)]
        public decimal? YR1 { get; set; }

        [Display(Name = "YR2")]
        [DisplayFormat(DataFormatString = "{0:n6}", ApplyFormatInEditMode = true)]
        public decimal? YR2 { get; set; }

        [Display(Name = "YR3")]
        [DisplayFormat(DataFormatString = "{0:n6}", ApplyFormatInEditMode = true)]
        public decimal? YR3 { get; set; }

        [Display(Name = "YR4")]
        [DisplayFormat(DataFormatString = "{0:n6}", ApplyFormatInEditMode = true)]
        public decimal? YR4 { get; set; }

        [Display(Name = "YR5")]
        [DisplayFormat(DataFormatString = "{0:n6}", ApplyFormatInEditMode = true)]
        public decimal? YR5 { get; set; }

        [Display(Name = "YR6")]
        [DisplayFormat(DataFormatString = "{0:n6}", ApplyFormatInEditMode = true)]
        public decimal? YR6 { get; set; }

        [Display(Name = "YR7")]
        [DisplayFormat(DataFormatString = "{0:n6}", ApplyFormatInEditMode = true)]
        public decimal? YR7 { get; set; }

        [Display(Name = "YR8")]
        [DisplayFormat(DataFormatString = "{0:n6}", ApplyFormatInEditMode = true)]
        public decimal? YR8 { get; set; }

        [Display(Name = "YR9")]
        [DisplayFormat(DataFormatString = "{0:n6}", ApplyFormatInEditMode = true)]
        public decimal? YR9 { get; set; }

        [Display(Name = "YR10")]
        [DisplayFormat(DataFormatString = "{0:n6}", ApplyFormatInEditMode = true)]
        public decimal? YR10 { get; set; }

        [Display(Name = "Tenor")]
        public string tenor { get; set; }

        [Display(Name = "Bid Value")]
        [DisplayFormat(DataFormatString = "{0:n6}", ApplyFormatInEditMode = true)]
        public decimal? bid_value { get; set; }

        [Display(Name = "Ask Value")]
        [DisplayFormat(DataFormatString = "{0:n6}", ApplyFormatInEditMode = true)]
        public decimal? ask_value { get; set; }

        [Display(Name = "Rate Bid")]
        [DisplayFormat(DataFormatString = "{0:n6}", ApplyFormatInEditMode = true)]
        public decimal? rate_bid { get; set; }

        [Display(Name = "Rate Offer")]
        [DisplayFormat(DataFormatString = "{0:n6}", ApplyFormatInEditMode = true)]
        public decimal? rate_offer { get; set; }

        [Display(Name = "Avg Rate")]
        [DisplayFormat(DataFormatString = "{0:n6}", ApplyFormatInEditMode = true)]
        public decimal? rate_avg { get; set; }

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
