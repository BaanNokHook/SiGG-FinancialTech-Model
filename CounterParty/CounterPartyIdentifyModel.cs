using GM.Model.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GM.Model.CounterParty
{
    public class CounterPartyIdentifyModel
    {
        public string rowstatus { get; set; }
        public string unique_name { get; set; }

        public string identify_type_text { get; set; }

       // [Required]
        public int?counter_party_id { get; set; }

        [Required]
        [Display(Name = "Unique")]
        [StringLength(6)]
        public string unique_id { get; set; }

        [Display(Name = "Identify No")]
        [StringLength(50)]
        public string identify_no { get; set; }

        [StringLength(255)]
        [Display(Name = "Reg Bus Name(Th)")]
        public string reg_bus_tname { get; set; }

        [StringLength(255)]
        [Display(Name = "Reg Bus Name(Eng)")]
        public string reg_bus_ename { get; set; }
        
        [Display(Name = "Juristic Reg Date")]
        public string juris_reg_date { get; set; }

        [Display(Name = "Identify Type")]
        [StringLength(255)]
        public string identify_type { get; set; }

        [StringLength(20)]
        [Display(Name = "Citizen ID")]
        public string citizen_id { get; set; }

        [StringLength(20)]
        [Display(Name = "Tax ID")]
        public string tax_id { get; set; }

        [StringLength(20)]
        [Display(Name = "Password Number")]
        public string password_Number { get; set; }
        
        public DateTime? create_date { get; set; }
        
        [StringLength(255)]
        public string create_by { get; set; }

        public Nullable<DateTime> update_date { get; set; }

        [StringLength(255)]
        public string update_by { get; set; }

        public virtual PagingModel paging { get; set; }

        public virtual List<OrderByModel> ordersby { get; set; }
    }

}
