using GM.Model.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GM.Model.Static
{
    public class InitialMarginModel
    {
        [Display(Name = "No")]
        public int RowNumber { get; set; }

        public decimal? ID { get; set; }

        [Display(Name = "Sec Type")]
        public string SECURITYTYPE { get; set; }
        [Required]
        public string SECURITYTYPE_ID { get; set; }

        [Display(Name = "Coupon Type")]
        public string COUPONTYPE { get; set; }
        [Required]
        public string COUPONTYPE_ID { get; set; }

        [Required]
        [Display(Name = "Haircut")]
        public decimal HAIRCUTMARGIN { get; set; }

        [Required]
        [Display(Name = "Ver. Margin")]
        public decimal VARIATIONMARGIN { get; set; }

        [Required]
        [Display(Name = "Year Start")]
        public int YearStart { get; set; }

        [Required]
        [Display(Name = "Year End")]
        public int YearEnd { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Description")]
        public string DESCRIPTION { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Description 2")]
        public string DESCRIPTION2 { get; set; }

        public int BOTTYPEID { get; set; }

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
