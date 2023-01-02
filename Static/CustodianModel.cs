using GM.Model.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GM.Model.Static
{
    public class CustodianModel
    {
        [Display(Name = "No")]
        public int? RowNumber { get; set; }

        [Required]
        public int custodian_id { get; set; }

        [Required]
        [Display(Name = "Custodian Code")]
        public string custodian_code { get; set; }

        [Required]
        [Display(Name = "Custodian Shortname")]
        public string custodian_shortname { get; set; }

        [Display(Name = "Custodian Name")]
        public string custodian_name { get; set; }

        [Display(Name = "Contact")]
        public string contact { get; set; }

        [Display(Name = "Address 1")]
        public string address1 { get; set; }

        [Display(Name = "Address 2")]
        public string address2 { get; set; }

        [Display(Name = "Address 3")]
        public string address3 { get; set; }

        [Display(Name = "Address 4")]
        public string address4 { get; set; }

        [Display(Name = "Tel No.")]
        public string tel_no { get; set; }

        [Display(Name = "Fax No.")]
        public string fax_no { get; set; }

        [Display(Name = "S/A Account No.")]
        public string sa_acc_no { get; set; }

        [Display(Name = "C/A Account No.")]
        public string ca_acc_no { get; set; }

        [Display(Name = "Swift Code")]
        public string swift_code { get; set; }
        
        public int? province_id { get; set; }
        [Display(Name = "Province")]
        public string province_name { get; set; }

        public int? district_id { get; set; }
        [Display(Name = "District")]
        public string district_name { get; set; }

        public int? sub_district_id { get; set; }
        [Display(Name = "Sub District")]
        public string sub_district_name { get; set; }

        [Display(Name = "Post code")]
        public string post_code { get; set; }

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
