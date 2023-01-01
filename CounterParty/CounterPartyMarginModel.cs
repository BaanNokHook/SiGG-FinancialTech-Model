using GM.Model.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GM.Model.CounterParty
{
    public class CounterPartyMarginModel
    {
        public CounterPartyMarginModel()
        {
            borrow_only_flag = true;
            except_margin_flag = true;
        }

        public string margin_type_name { get; set; }

        public string margin_in_type_name { get; set; }

        public string margin_in_term_name { get; set; }
        //[Required]
        public int? counter_party_id { get; set; }

        //[Required]
        [Display(Name = "Margin Type")]
        public int? margin_type_id { get; set; }

        //[Required]
        [Display(Name = "Margin In Type")]
        public int? margin_in_type_id { get; set; }
        
        //[Required]
        [Display(Name = "Margin In Term")]
        public int? margin_in_term_id { get; set; }

        //[Required]
        [Display(Name = "Threshold")]
        public decimal? threshold { get; set; }

        [Display(Name = "Borrow Only")]
        public bool borrow_only_flag { get; set; }

        [Display(Name = "Except Margin")]
        public bool except_margin_flag { get; set; }
        public decimal? minimum_transfer { get; set; }

        public DateTime? create_date { get; set; }

        [Display(Name = "Call margin method")]
        public string margin_method { get; set; }

        [StringLength(255)]
        public string create_by { get; set; }

        public Nullable<DateTime> update_date { get; set; }

        [StringLength(255)]
        public string update_by { get; set; }

        public virtual PagingModel paging { get; set; }

        public virtual List<OrderByModel> ordersby { get; set; }
    }

}

