using GM.Model.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GM.Model.Static
{
    //For Criteria Report : General Ledger
    public class AccountingModel
    {
        public AccountingModel()
        {
            active_flag = true;
        }

        [Display(Name = "No")]
        public int? RowNumber { get; set; }

        //[Required]
        [Display(Name = "Group ID")]
        public int? group_id { get; set; }

        [Required]
        [StringLength(2)]
        [Display(Name = "Group Name")]
        public string group_name { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Account Number")]
        public string account_num { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Account Name")]
        public string account_nane { get; set; }

        [Display(Name = "Active Flag")]
        public Nullable<bool> active_flag { get; set; }

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


