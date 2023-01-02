using GM.Model.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GM.Model.Static
{
    public class PaymentMethodModel
    {
        [Display(Name = "No")]
        public int? RowNumber { get; set; }

        [Required]
        [Display(Name = "Payment Method")]
        [StringLength(100)]
        public string payment_method { get; set; }

        [Required]
        [Display(Name = "Payment Flag")]
        public int? payment_flag { get; set; }

        [Display(Name = "Payment Flag")]
        public string payment_flag_item { get; set; }

        [StringLength(255)]
        [Display(Name = "Description")]
        public string description { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "System Type")]
        public string system_type { get; set; }

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
