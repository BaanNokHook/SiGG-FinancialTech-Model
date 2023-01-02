using GM.Model.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GM.Model.Static
{
    public class HolidayModel
    {
        public HolidayModel()
        {
            eventYear = new EventYear();
        }

        //[Required]
        [StringLength(3)]
        [Display(Name = "CUR")]
        public string cur { get; set; }

        [Required]
        [Display(Name = "Holiday Date")]
        public DateTime? holiday_date { get; set; }

        //[Required]
        [StringLength(100)]
        [Display(Name = "Description")]
        public string holiday_desc { get; set; }

        public DateTime? create_date { get; set; }

        [StringLength(255)]
        public string create_by { get; set; }

        public DateTime? update_date { get; set; }

        [StringLength(255)]
        public string update_by { get; set; }

        [StringLength(4)]
        public string year { get; set; }

        [StringLength(4)]
        public string yearCalendar { get; set; }

        [StringLength(4)]
        public string yearEvent { get; set; }

        public string curSearch { get; set; }

        private EventYear eventYear;
        public EventYear EventYear
        {
            set { eventYear = value; }
            get { return eventYear; }
        }

        public int TotalEventDays { get; set; }

        public virtual PagingModel paging { get; set; }

        public virtual List<OrderByModel> ordersby { get; set; }

        public bool HolidayType { get; set; }

        public string ModeCalendar { get; set; }
        public string ModeEvent { get; set; }

        public bool Tap { get; set; }

        [Display(Name = "Holiday Start")]
        public DateTime? HolidayStart { get; set; }

        [Display(Name = "Holiday End")]
        public DateTime? HolidayEnd { get; set; }
    }

    public class EventDay
    {
        private string mode = "muted";
        public string Mode
        {
            get { return mode; }
            set { mode = value; }
        }

        private string day = "";
        public string Day
        {
            get { return day; }
            set { day = value; }
        }

        private string date = "";
        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        public string Key { get; set; }

        private string description = "";
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
    }

    public class EventWeek
    {
        private List<EventDay> days;
        public List<EventDay> Days
        {
            set { days = value; }
            get { return days; }
        }
    }

    public class EventMonth
    {
        public EventMonth()
        {
            weeks = new List<EventWeek>();
        }
        private List<EventWeek> weeks;
        public List<EventWeek> Weeks
        {
            set { weeks = value; }
            get { return weeks; }
        }

        private List<EventDay> days = new List<EventDay>();
        public List<EventDay> Days
        {
            set { days = value; }
            get { return days; }
        }

        public string Name { get; set; }
    }

    public class EventYear
    {
        public EventYear()
        {
            months = new List<EventMonth>();
        }
        private List<EventMonth> months;
        public List<EventMonth> Months
        {
            set { months = value; }
            get { return months; }
        }
    }
}
