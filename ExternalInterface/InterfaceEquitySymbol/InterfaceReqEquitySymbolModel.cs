using GM.Model.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GM.Model.ExternalInterface.InterfaceEquitySymbol
{
    public class InterfaceReqEquitySymbolModel
    {
        public string url_service { get; set; }

        public string ref_no { get; set; }

        [Display(Name = "Channel")]
        public string channel { get; set; }

        [Display(Name = "RequestDate")]
        public string request_date { get; set; }

        [Display(Name = "RequestTime")]
        public string request_time { get; set; }

        [Display(Name = "AsofDate")]
        public DateTime asof_date { get; set; }

        [Display(Name = "Code")]
        public string code { get; set; }

        [Display(Name = "IssuerCode")]
        public string issuer_code { get; set; }

        [Display(Name = "ParFrom")]
        public decimal? par_from { get; set; }

        [Display(Name = "ParTo")]
        public decimal? par_to { get; set; }

        [Display(Name = "IssueDate")]
        public string issue_date { get; set; }

        [Display(Name = "Type")]
        public string type { get; set; }

        [Display(Name = "Product")]
        public string product { get; set; }

        [Display(Name = "SubProductCode")]
        public int? sub_product_code { get; set; }

        [Display(Name = "Cur")]
        public string cur { get; set; }

        public int return_code { get; set; }

        public string return_msg { get; set; }

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
