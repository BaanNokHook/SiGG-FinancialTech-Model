using GM.Model.Common;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GM.Model.CounterParty
{
    public class CounterPartyExchRateModel
    {
        //[Required]
        public int? counter_party_id { get; set; }

        //[Required]
        [Display(Name = "Source Type")]
        public string source_type { get; set; }
        public string source_type_name { get; set; }

        //[Required]
        //[StringLength(3)]
        [Display(Name = "Exchange Type")]
        public string exchange_type { get; set; }
        public string exchange_type_name { get; set; }

        //[Required]
        //[StringLength(3)]
        [Display(Name = "Currency")]
        public string cur { get; set; }
        public string cur_name { get; set; }

        [StringLength(255)]
        public string create_by { get; set; }
        public string rowstatus { get; set; }
        public virtual PagingModel paging { get; set; }
        public virtual List<OrderByModel> ordersby { get; set; }
    }
}