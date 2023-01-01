using System;
using System.ComponentModel.DataAnnotations;

namespace GM.Model.GLProcess
{
    public class GLGenerateModel
    {
        [Display(Name = "Currency")]
        public string cur { get; set; }

        [Display(Name = "Event")]
        public string event_generate { get; set; }

        [Display(Name = "From Date")]
        public DateTime? from_date { get; set; }

        [Display(Name = "To")]
        public DateTime? to_date { get; set; }
    }
}
