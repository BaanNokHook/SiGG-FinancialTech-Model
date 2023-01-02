using System;
using System.ComponentModel.DataAnnotations;

namespace GM.Model.Static
{
    public class ConfigModel
    {
        [StringLength(255)]
        [Display(Name = "Category")]
        public string category { get; set; }

        [StringLength(255)]
        [Display(Name = "Item Code")]
        public string item_code { get; set; }

        [StringLength(255)]
        [Display(Name = "Item Desc")]
        public string item_desc { get; set; }
        [Display(Name = "Item Value")]
        public string item_value { get; set; }

        [Required]
        [Display(Name = "Display Flag")]
        public bool display_flag { get; set; }

        [Required]
        [Display(Name = "Order Flag")]
        public int order_flag { get; set; }

        [Required]
        public DateTime create_date { get; set; }

        public Nullable<DateTime> update_date { get; set; }
    }

}
