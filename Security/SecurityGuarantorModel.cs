using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GM.Model.Common;

namespace GM.Model.Security
{
    public class SecurityGuarantorModel
    {
        public string rowstatus { get; set; }

        [Key, Column(Order = 0)]
        [Required]
        [Display(Name = "Instrument Code")]
        public int instrument_id { get; set; }

        [Key, Column(Order = 1)]
        //[Required]
        [StringLength(25)]
        [Display(Name = "Guarantor Code")]
        public string guarantor_code { get; set; }

        //!!!! Remove it before save
        public string guarantor_name { get; set; }

        [Required]
        [Display(Name = "Percent")]
        public decimal guarantor_percent { get; set; }


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
