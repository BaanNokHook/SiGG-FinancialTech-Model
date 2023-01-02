using System.ComponentModel.DataAnnotations;

namespace GM.Model.UserAndScreen
{
    public class LoginModel
    {
        [Required]
        //[StringLength(255)]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required]
        //[StringLength(255)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember on this computer")]
        public bool RememberMe { get; set; }

        public string user_eng_name { get; set; }

        public string trader_id { get; set; }

        public string desk_book_name { get; set; }

        public string desk_book_id { get; set; }

        public string desk_group_name { get; set; }

        public string desk_group_id { get; set; }

        public string port { get; set; }

        public string port_name { get; set; }

        public string token { get; set; }

        public string role_id { get; set; }

        public bool isOnline { get; set; }

        public string IPaddress { get; set; }

        public string sessionID { get; set; }

        public bool isKick { get; set; }
    }
}
