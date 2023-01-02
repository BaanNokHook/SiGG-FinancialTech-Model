using GM.Model.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GM.Model.Static
{
    public class CountryModel
    {
        public CountryModel()
        {
            active_flag = true;
        }

        //[Display(Name = "No")]
        //public int? row_no { get; set; }
        [Display(Name = "No")]
        public int? RowNumber { get; set; }

        //[Required]
        [Display(Name = "Country ID")]
        public int? country_id { get; set; }

        [Required]
        [StringLength(2)]
        [Display(Name = "Country Code")]
        public string country_code { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Country Desc")]
        public string country_desc { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Domicile Code")]
        public string domicile_code { get; set; }

        [StringLength(255)]
        [Display(Name = "Domicile Desc")]
        public string domicile_desc { get; set; }

        [Display(Name = "Active Flag")]
        public Nullable<bool> active_flag { get; set; }

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

