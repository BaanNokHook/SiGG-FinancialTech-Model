using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GM.Model.Common;

namespace GM.Model.Static
{
    public class PurposeModel
    {
        public PurposeModel()
        {
            display_flag = '1';
        }

        [Display(Name = "No")]
        public int? RowNumber { get; set; }

        [Required]
        [Display(Name = "Purpose Code")]
        public string purpose { get; set; }

        [Display(Name = "Description")]
        public string description { get; set; }

        [Display(Name = "Active Flag")]
        public char display_flag { get; set; }

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
