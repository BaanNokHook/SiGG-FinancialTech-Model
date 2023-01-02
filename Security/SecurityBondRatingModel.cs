using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GM.Model.Common;

namespace GM.Model.Security
{
    public class SecurityBondRatingModel
    {
        public string rowstatus { get; set; }

        [Key, Column(Order = 0)]
        [Required]
        public int instrument_id { get; set; }

        [Key, Column(Order = 1)]
        [Required]
        [StringLength(255)]
        [Display(Name = "Aegncy")]
        public string agency_code { get; set; }
        public string agency_name { get; set; }

        [Required]
        [StringLength(1)]
        [Display(Name = "Term")]
        public string short_long_term { get; set; }
        public string short_long_term_text { get; set; }

        [StringLength(10)]
        [Display(Name = "Local Rating")]
        public string local_rating { get; set; }
        public string local_rating_text { get; set; }

        [StringLength(10)]
        [Display(Name = "Foreign Rating")]
        public string foreign_rating { get; set; }
        public string foreign_rating_text { get; set; }

        public DateTime? create_date { get; set; }

        [StringLength(255)]
        public string create_by { get; set; }

        public DateTime? update_date { get; set; }

        [StringLength(255)]
        public string update_by { get; set; }

        [Required]
        [Display(Name = "Assess Date")]
        public DateTime? assess_date { get; set; }

        public virtual PagingModel paging { get; set; }

        public virtual List<OrderByModel> ordersby { get; set; }
    }
}
