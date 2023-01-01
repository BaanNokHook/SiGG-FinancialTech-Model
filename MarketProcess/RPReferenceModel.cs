using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GM.Model.Common;

namespace GM.Model.MarketProcess
{
    public class RPReferenceModel
    {
        [Display(Name = "No")]
        public int? RowNumber { get; set; }

        [Required]
        [Display(Name = "Price Source")]
        public string price_source { get; set; }

        [Required]
        [Display(Name = "Asof Date")]
        public DateTime? asof_date { get; set; }

        [Required]
        [StringLength(25)]
        public string instrument_id { get; set; }

        [Display(Name = "Instrument Code")]
        public string instrument_code { get; set; }

        [Display(Name = "Maturity Date")]
        public DateTime? maturity_date { get; set; }

        [Display(Name = "Avg Bidding")]
        [DisplayFormat(DataFormatString = "{0:0.00###########################}", ApplyFormatInEditMode = true)]
        public Nullable<decimal> avgbidding { get; set; }

        [Display(Name = "Govtinterpolated Yield")]
        [DisplayFormat(DataFormatString = "{0:0.00###########################}", ApplyFormatInEditMode = true)]
        public Nullable<decimal> govtinterpolatedyield { get; set; }

        [Display(Name = "TTM")]
        [DisplayFormat(DataFormatString = "{0:0.00###########################}", ApplyFormatInEditMode = true)]
        public Nullable<decimal> ttm { get; set; }

        [Display(Name = "SpreadQuoted Date")]
        public DateTime? spreadquoteddate { get; set; }

        [Display(Name = "Spread")]
        [DisplayFormat(DataFormatString = "{0:0.00###########################}", ApplyFormatInEditMode = true)]
        public Nullable<decimal> spread { get; set; }

        [Display(Name = "Reference Yield")]
        [DisplayFormat(DataFormatString = "{0:0.00###########################}", ApplyFormatInEditMode = true)]
        public Nullable<decimal> referenceyield { get; set; }

        [Display(Name = "Settlement Date")]
        public DateTime? settlementdate { get; set; }

        [Display(Name = "AI %")]
        [DisplayFormat(DataFormatString = "{0:0.00###########################}", ApplyFormatInEditMode = true)]
        public Nullable<decimal> ai { get; set; }

        [Display(Name = "Gross Price %")]
        [DisplayFormat(DataFormatString = "{0:0.00###########################}", ApplyFormatInEditMode = true)]
        public Nullable<decimal> gross_price { get; set; }

        [Display(Name = "Clean Price %")]
        [DisplayFormat(DataFormatString = "{0:0.00###########################}", ApplyFormatInEditMode = true)]
        public Nullable<decimal> clean_price { get; set; }

        [Display(Name = "Modified Duration")]
        [DisplayFormat(DataFormatString = "{0:0.00###########################}", ApplyFormatInEditMode = true)]
        public Nullable<decimal> modifiedduration { get; set; }

        [Display(Name = "Convexity")]
        [DisplayFormat(DataFormatString = "{0:0.00###########################}", ApplyFormatInEditMode = true)]
        public Nullable<decimal> convexity { get; set; }

        [Display(Name = "Process Date")]
        public DateTime? processdate { get; set; }

        [StringLength(50)]
        [Display(Name = "Bond Type")]
        public string bondtype { get; set; }

        [Required]
        [StringLength(1)]
        [Display(Name = "Market Date (T+x)")]
        public string marketdate_t { get; set; }

        public DateTime? create_date { get; set; }

        [StringLength(255)]
        public string create_by { get; set; }

        public DateTime? update_date { get; set; }

        [StringLength(255)]
        public string update_by { get; set; }

        public virtual PagingModel paging { get; set; }

        public virtual List<OrderByModel> ordersby { get; set; }

        [Display(Name = "Page Name")]
        public string page_name { get; set; }
    }
}
