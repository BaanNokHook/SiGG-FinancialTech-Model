using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GM.Model.Common;

namespace GM.Model.GLProcess
{
    public class GLAccountCodeModel
    {
        [Display(Name = "No")]
        public int? RowNumber { get; set; }

        [Required]
        [Display(Name = "Account Num")]
        [StringLength(50)]
        public string account_num { get; set; }

        [StringLength(255)]
        [Display(Name = "Account Name")]
        public string account_name { get; set; }

        [Display(Name = "Account Port")]
        public string acct_port { get; set; }

        [Display(Name = "Account Port Name")]
        public string acct_port_name { get; set; }

        [Display(Name = "Exp Acct Num")]
        [StringLength(50)]
        public string exp_acct_num { get; set; }

        [Display(Name = "Acct Remark")]
        [StringLength(255)]
        public string acct_remark { get; set; }

        public DateTime? create_date { get; set; }

        [StringLength(255)]
        public string create_by { get; set; }

        public DateTime? update_date { get; set; }

        [StringLength(255)]
        public string update_by { get; set; }

        [StringLength(25)]
        public string sec_type { get; set; }

        public virtual PagingModel paging { get; set; }

        public virtual List<OrderByModel> ordersby { get; set; }
    }
}
