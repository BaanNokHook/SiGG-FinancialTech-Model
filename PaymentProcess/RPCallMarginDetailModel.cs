using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GM.Model.Common;

namespace GM.Model.PaymentProcess
{
    public class RPCallMarginDetailModel
    {
        [Display(Name = "No")]
        public int? RowNumber { get; set; }
        public string BusinessDate { get; set; }
        public virtual PagingModel paging { get; set; }
        public virtual List<OrderByModel> ordersby { get; set; }

        [StringLength(15)]
        public string trans_no { get; set; }
        public string brp_contract_no { get; set; }
        public string lend_borrow { get; set; }
        public DateTime purchase_date { get; set; }
        public DateTime repurchase_date { get; set; }
        public int DAY { get; set; }
        public decimal trans_margin_call { get; set; }

        [StringLength(255)]
        public string remark { get; set; }

        [Required]
        public DateTime create_date { get; set; }

        [Required]
        [StringLength(50)]
        public string create_by { get; set; }

        public DateTime? update_date { get; set; }

        [StringLength(50)]
        public string update_by { get; set; }
    }
}
