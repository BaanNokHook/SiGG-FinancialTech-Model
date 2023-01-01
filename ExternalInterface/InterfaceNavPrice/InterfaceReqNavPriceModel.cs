using GM.Model.Common;
using GM.Model.Static;
using System;
using System.Collections.Generic;
using System.Text;

namespace GM.Model.ExternalInterface.InterfaceNavPrice
{
    public class InterfaceReqNavPriceModel
    {
        public string url_service { get; set; }
        public string channel { get; set; }
        public string asof_date { get; set; }
        public string insuer_code { get; set; }
        public string insument_type { get; set; }
        public string request_date { get; set; }
        public string request_time { get; set; }
        public string ref_no { get; set; }
        public int return_code { get; set; }
        public string return_msg { get; set; }
        public virtual List<RpConfigModel> RpConfigModel { get; set; }

        public DateTime? create_date { get; set; }

        public string create_by { get; set; }

        public DateTime? update_date { get; set; }

        public string update_by { get; set; }

        public virtual PagingModel paging { get; set; }

        public virtual List<OrderByModel> ordersby { get; set; }
    }
}
