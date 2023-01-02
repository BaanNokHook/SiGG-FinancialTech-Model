using System;
using System.Collections.Generic;
using GM.Model.Common;

namespace GM.Model.Static
{
    public class TestPageModel
    {
        public string text { get; set; }

        public DateTime? create_date { get; set; }

        public string create_by { get; set; }

        public DateTime? update_date { get; set; }

        public string update_by { get; set; }

        public virtual PagingModel paging { get; set; }

        public virtual List<OrderByModel> ordersby { get; set; }
    }
}
