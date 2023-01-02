using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GM.Model.Common;

namespace GM.Model.UserAndScreen
{
    public class BookModel
    {
        public BookModel()
        {
            active_flag = true;
        }

        public string port_name { get; set; }

        //[Required]
        [Display(Name = "Book Id")]
        public int? book_id { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Book Name (Eng)")]
        public string book_name_en { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Book Name (Th)")]
        public string book_name_th { get; set; }

        [StringLength(255)]
        [Display(Name = "User Id")]
        public string user_id { get; set; }

        [Required]
        [StringLength(15)]
        [Display(Name = "Port")]
        public string port { get; set; }

        [StringLength(20)]
        [Display(Name = "Repo Deal Type")]
        public string repo_deal_type { get; set; }

        [StringLength(255)]
        public string system_type { get; set; }

        public DateTime? create_date { get; set; }

        [StringLength(255)]
        public string create_by { get; set; }

        public DateTime? update_date { get; set; }

        [StringLength(255)]
        public string update_by { get; set; }

        [Display(Name = "Active")]
        public bool active_flag { get; set; }

        public virtual PagingModel paging { get; set; }

        public virtual List<OrderByModel> ordersby { get; set; }
    }
}
