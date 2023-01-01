using GM.Model.Common;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GM.Model.CounterParty
{
    public class CounterPartyHaircutModel
    {
        public string rowstatus { get; set; }

        //[Required]
        public int? counter_party_id { get; set; }

        //[Required]
        [StringLength(3)]
        [Display(Name = "Currency")]
        public string cur { get; set; }
        public string cur_name { get; set; }

        //[Required]
        [StringLength(10)]
        [Display(Name = "Formula to cal collateral")]
        public string formula { get; set; }
        public string formula_name { get; set; }

        //[Required]
        [StringLength(20)]
        [Display(Name = "Calculate Type")]
        public string calculate_type { get; set; }
        public string calculate_type_name { get; set; }

        [StringLength(255)]
        public string create_by { get; set; }

        public virtual PagingModel paging { get; set; }

        public virtual List<OrderByModel> ordersby { get; set; }
    }
}
