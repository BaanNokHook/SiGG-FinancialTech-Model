using System.ComponentModel.DataAnnotations;

namespace GM.Model.PaymentProcess
{
    public class RPConfirmationModel
    {
        public RPConfirmationModel()
        {
            recorded_flag = 'C';
        }

        public string trans_no { get; set; }
        public string[] arr_trans_no { get; set; }

        public string print_confirm_bo1_by { get; set; }

        [Display(Name = "Sign name(L)")]
        public string sign_name_1 { get; set; }

        [Display(Name = "Position(L)")]
        public string position_name_1 { get; set; }

        public string print_confirm_bo2_by { get; set; }

        [Display(Name = "Sign name(R)")]
        public string sign_name_2 { get; set; }

        [Display(Name = "Position(R)")]
        public string position_name_2 { get; set; }

        public char recorded_flag { get; set; }
        public string create_by { get; set; }
        public string update_by { get; set; }
    }
}
