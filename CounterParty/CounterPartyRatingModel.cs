using GM.Model.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GM.Model.CounterParty
{
    public class CounterPartyRatingModel
    {
        public string rowstatus { get; set; }
        public string agency_name { get; set; }
        public string local_rating_text { get; set; }
        public string foreign_rating_text { get; set; }
        public string short_long_term_text { get; set; }

        //[Required]
        public int? counter_party_id { get; set; }

        // [Required]
        [Display(Name ="Agency")]
        [StringLength(255)]
        public string agency_code { get; set; }

        [Display(Name = "Term")]
        [StringLength(1)]
        public string short_long_term { get; set; }

        [Display(Name = "Local Rating")]
        [StringLength(10)]
        public string local_rating { get; set; }

        [Display(Name = "Foreign Rating")]
        [StringLength(10)]
        public string foreign_rating { get; set; }

        //[Required]
        public DateTime? create_date { get; set; }

        //[Required]
        [StringLength(255)]
        public string create_by { get; set; }

        public DateTime? update_date { get; set; }

        [StringLength(255)]
        public string update_by { get; set; }

        public virtual PagingModel paging { get; set; }

        public virtual List<OrderByModel> ordersby { get; set; }
    }

}

