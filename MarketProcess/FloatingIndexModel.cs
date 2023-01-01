using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GM.Model.Common;

namespace GM.Model.MarketProcess
{
    public class FloatingIndexModel
    {
        [Display(Name = "No")]
        public int? RowNumber { get; set; }

        [Display(Name = "Floating Index Date")]
        public DateTime? floating_index_date { get; set; }

        [Display(Name = "Floating Index Code")]
        public string floating_index_code { get; set; }

        [Display(Name = "Cur")]
        public string cur { get; set; }

        [Display(Name = "Effective Date")]
        public DateTime? effective_date { get; set; }

        [Display(Name = "Rate On")]
        [DisplayFormat(DataFormatString = "{0:0.00###########################}", ApplyFormatInEditMode = true)]
        public Nullable<decimal> rate_on { get; set; }

        [Display(Name = "Rate 1 Week")]
        [DisplayFormat(DataFormatString = "{0:0.00###########################}", ApplyFormatInEditMode = true)]
        public Nullable<decimal> rate_1week { get; set; }

        [Display(Name = "Rate 1 Month")]
        [DisplayFormat(DataFormatString = "{0:0.00###########################}", ApplyFormatInEditMode = true)]
        public Nullable<decimal> rate_1month { get; set; }

        [Display(Name = "Rate 2 Month")]
        [DisplayFormat(DataFormatString = "{0:0.00###########################}", ApplyFormatInEditMode = true)]
        public Nullable<decimal> rate_2month { get; set; }

        [Display(Name = "Rate 3 Month")]
        [DisplayFormat(DataFormatString = "{0:0.00###########################}", ApplyFormatInEditMode = true)]
        public Nullable<decimal> rate_3month { get; set; }

        [Display(Name = "Rate 6 Month")]
        [DisplayFormat(DataFormatString = "{0:0.00###########################}", ApplyFormatInEditMode = true)]
        public Nullable<decimal> rate_6month { get; set; }

        [Display(Name = "Rate 9 Month")]
        [DisplayFormat(DataFormatString = "{0:0.00###########################}", ApplyFormatInEditMode = true)]
        public Nullable<decimal> rate_9month { get; set; }

        [Display(Name = "Rate 1 Year")]
        [DisplayFormat(DataFormatString = "{0:0.00###########################}", ApplyFormatInEditMode = true)]
        public Nullable<decimal> rate_1year { get; set; }

        [Display(Name = "Create Date")]
        public DateTime? create_date { get; set; }

        [Display(Name = "Create By")]
        [StringLength(255)]
        public string create_by { get; set; }

        [Display(Name = "Update Date")]
        public DateTime? update_date { get; set; }

        [Display(Name = "Update By")]
        [StringLength(255)]
        public string update_by { get; set; }

        public string page_name { get; set; }

        public virtual PagingModel paging { get; set; }

        public virtual List<OrderByModel> ordersby { get; set; }
    }
}
