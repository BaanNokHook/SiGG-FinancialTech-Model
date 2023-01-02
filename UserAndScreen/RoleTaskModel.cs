using System;
using System.ComponentModel.DataAnnotations;

namespace GM.Model.UserAndScreen
{
    public class RoleTaskModel
    {
        [Required]
        public int task_id { get; set; }

        [Required]
        public int role_id { get; set; }

        [Required]
        public int task_seq { get; set; }

        [Required]
        [StringLength(100)]
        public string task_name { get; set; }

        [Required]
        [StringLength(255)]
        public string task_condition { get; set; }

        [Required]
        [StringLength(255)]
        public string task_condition_complete { get; set; }

        [StringLength(255)]
        public string task_link { get; set; }

        [StringLength(255)]
        public string task_store { get; set; }

        public int remaining { get; set; }

        public int complete { get; set; }

        public DateTime BusinessDate { get; set; }

        public bool task_enable { get; set; }
    }
}
