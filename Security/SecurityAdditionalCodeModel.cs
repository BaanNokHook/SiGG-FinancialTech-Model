using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GM.Model.Common;

namespace GM.Model.Security
{
    public class SecurityAdditionalCodeModel
    {
        public string rowstatus { get; set; }

        [Key]
        [Required]
        [StringLength(25)]
        [Display(Name = "New Instrument Code")]
        public string new_instrument_code { get; set; }

        [Required]
        [Display(Name = "Instrument Code")]
        public int instrument_id { get; set; }

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
