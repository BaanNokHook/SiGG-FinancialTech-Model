using System;
using System.Collections.Generic;
using GM.Model.Common;
using GM.Model.Static;

namespace GM.Model.ExternalInterface
{
    public class InterfaceMarketPriceModel
    {
        public string channel { get; set; }
        public string ref_no { get; set; }
        public string response_date { get; set; }
        public string response_time { get; set; }
        public string request_date { get; set; }
        public string request_time { get; set; }
        public int mode { get; set; }
        public string asof_date { get; set; }
        public string source_type { get; set; }
        public string security_code { get; set; }
        public int return_code { get; set; }
        public string return_msg { get; set; }
        public int total_rows { get; set; }
        public string urlservice { get; set; }

        public string cur { get; set; }

        public List<InterfaceMarketPriceDetailModel> detail { get; set; }

        public virtual List<RpConfigModel> RpConfigModel { get; set; }

        public DateTime? create_date { get; set; }

        public string create_by { get; set; }

        public DateTime? update_date { get; set; }

        public string update_by { get; set; }

        public virtual PagingModel paging { get; set; }

        public virtual List<OrderByModel> ordersby { get; set; }
    }
}
