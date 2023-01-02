using GM.Model.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GM.Model.Static
{
    public class CurrencyModel
    {
        public CurrencyModel()
        {
            active_flag = true;
        }

        [Display(Name = "No")]
        public int? RowNumber { get; set; }

        [Required]
        [StringLength(3)]
        [Display(Name = "Cur")]
        public string cur { get; set; }

        [Required]
        [StringLength(2)]
        [Display(Name = "Cur Code")]
        public string cur_code { get; set; }

        //[Required]
        [StringLength(255)]
        [Display(Name = "Cur Desc")]
        public string cur_desc { get; set; }

        //[Required]
        [Display(Name = "Active Flag")]
        public bool active_flag { get; set; }

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
