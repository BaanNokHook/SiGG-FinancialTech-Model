using GM.Model.Common;
using System;
using System.Collections.Generic;

namespace GM.Model.Static
{
    public class RpDateModel
    {
        public DateTime RpDate { get; set; }

        public string Type { get; set; }

        //========================================================

        public DateTime? create_date { get; set; }

        public string create_by { get; set; }

        public DateTime? update_date { get; set; }

        public string update_by { get; set; }

        public virtual PagingModel paging { get; set; }

        public virtual List<OrderByModel> ordersby { get; set; }
    }
}
