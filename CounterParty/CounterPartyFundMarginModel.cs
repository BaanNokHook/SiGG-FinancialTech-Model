using GM.Model.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GM.Model.CounterParty
{
    public class CounterPartyFundMarginModel
    {
        public CounterPartyFundMarginModel()
        {
            borrow_only_flag = true;
            except_margin_flag = true;
        }

        [Required]
        [Display(Name = "Fund")]
        public int? fund_id { get; set; }

        [Display(Name = "Margin Type Name")]
        public string margin_type_name { get; set; }

        [Display(Name = "Margin In Type")]
        public string margin_in_type_name { get; set; }
        [Display(Name = "Margin In Term")]
        public string margin_in_term_name { get; set; }
        
        [Display(Name = "Counter Party")]
        public int? counter_party_id { get; set; }

        [Display(Name = "Margin Type")]
        public int? margin_type_id { get; set; }

        [Display(Name = "Margin In Type")]
        public int? margin_in_type_id { get; set; }

        [Display(Name = "Margin In Term")]
        public int? margin_in_term_id { get; set; }

        [Display(Name = "Threshold")]
        public decimal? threshold { get; set; }

        public bool borrow_only_flag { get; set; }

        public bool except_margin_flag { get; set; }

        public System.DateTime? create_date { get; set; }

        [StringLength(255)]
        public string create_by { get; set; }

        public Nullable<System.DateTime> update_date { get; set; }

        [StringLength(255)]
        public string update_by { get; set; }


        public virtual PagingModel paging { get; set; }

        public virtual List<OrderByModel> ordersby { get; set; }
    }

}

