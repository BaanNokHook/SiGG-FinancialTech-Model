using GM.Model.Common;
using System;
using System.Collections.Generic;

namespace GM.Model.Static
{
    public class RpConfigModel
    {
        public string category { get; set; }

        public string item_code { get; set; }

        public string item_desc { get; set; }

        public string item_value { get; set; }

        public bool display_flag { get; set; }

        public int order_flag { get; set; }

        //========================================================

        public DateTime? create_date { get; set; }

        public string create_by { get; set; }

        public DateTime? update_date { get; set; }

        public string update_by { get; set; }

        public virtual PagingModel paging { get; set; }

        public virtual List<OrderByModel> ordersby { get; set; }
    }
}
