using GM.Model.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GM.Model.Static
{
    public class BusinessDateModel
    {
        [Display(Name = "No")]
        public int? RowNumber { get; set; }

        [Display(Name = "Business Date")]
        public DateTime business_date { get; set; }
        [Display(Name = "Prev Business Date")]
        public DateTime? prev_business_date { get; set; }
        [Display(Name = "Next Business Date")]
        public DateTime? next_business_date { get; set; }
        [Display(Name = "Next Date")]
        public DateTime? next_date { get; set; }

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
