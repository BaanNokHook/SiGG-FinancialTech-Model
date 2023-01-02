using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GM.Model.Common;

namespace GM.Model.UserAndScreen
{
    public class UserModel
    {
        public UserModel()
        {
            active_flag = true;
        }

        [Display(Name = "No")]
        public int? RowNumber { get; set; }

        [Required]
        [Key]
        [StringLength(255)]
        [Column("user_id")]
        [Display(Name = "User ID")]
        public string user_id { get; set; }

        [StringLength(255)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string password { get; set; }

        [Required]
        [Display(Name = "LDAP")]
        public bool? ldap_user_flag { get; set; }

        //[Display(Name = "Trader Role")]
        //public int? trader_role_id { get; set; }

        //[StringLength(255)]
        //[Display(Name = "Trader Role Name")]
        //public string trader_role_name { get; set; }

        [Display(Name = "Title")]
        public int? title_master_id { get; set; }

        [Display(Name = "Title Name")]
        public string title_master_name { get; set; }

        [Display(Name = "Role")]
        public int? role_id { get; set; }

        [StringLength(255)]
        [Display(Name = "Role Name")]
        public string role_name { get; set; }

        [Display(Name = "Desk Group")]
        public int? desk_group_id { get; set; }

        [StringLength(255)]
        [Display(Name = "Desk Group Name")]
        public string desk_group_name { get; set; }

        [StringLength(25)]
        [Display(Name = "Trader ID")]
        public string trader_id { get; set; }

        public string trader_id_text { get; set; }

        [StringLength(50)]
        [Display(Name = "Thai Name")]
        public string user_thai_name { get; set; }

        [StringLength(50)]
        [Display(Name = "English Name")]
        public string user_eng_name { get; set; }

        [Required]
        [Display(Name = "Active Flag")]
        public bool active_flag { get; set; }

        [StringLength(25)]
        [Display(Name = "Cost Center")]
        public string costcenter_code { get; set; }

        [Display(Name = "Login Flag")]
        public bool? login_flag { get; set; }
        [Display(Name = "Login Date")]
        public DateTime? login_dt { get; set; }
        [Display(Name = "Last Active Date")]
        public DateTime? last_active_dt { get; set; }
        [Display(Name = "Logout Date")]
        public DateTime? logout_dt { get; set; }

        [StringLength(25)]
        [Display(Name = "IP Address")]
        public string ip_address { get; set; }

        [StringLength(1)]
        [Display(Name = "Logout Flag")]
        public string logout_flag { get; set; }

        [StringLength(25)]
        [Display(Name = "Sub Desk")]
        public string desk_sub_group { get; set; }
        public string desk_book_name { get; set; }
        public int? desk_book_id { get; set; }
        public string port { get; set; }
        public string port_name { get; set; }
        public string wizard_page { get; set; }
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
