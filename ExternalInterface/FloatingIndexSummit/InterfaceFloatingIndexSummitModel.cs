using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GM.Model.Common;
using GM.Model.Static;

namespace GM.Model.ExternalInterface.FloatingIndexSummit
{
    public class InterfaceFloatingIndexSummitModel
    {
        public string ticket { get; set; }

        public string ref_id { get; set; }

        public string request_date { get; set; }

        public string request_time { get; set; }

        public string mode { get; set; }

        public string content_type { get; set; }

        public string url_ticket { get; set; }

        public string url_rate { get; set; }

        public string authorization { get; set; }

        public string data_type { get; set; }

        public string as_of_date { get; set; }

        public string curve_id { get; set; }

        public string ccy { get; set; }

        public string index { get; set; }

        public int FloatingIndex_Item { get; set; }

        public virtual List<RpConfigModel> RpConfigModel { get; set; }


        public DateTime? create_date { get; set; }

        [StringLength(50)]
        public string create_by { get; set; }

        public DateTime? update_date { get; set; }

        [StringLength(50)]
        public string update_by { get; set; }

        public virtual PagingModel paging { get; set; }

        public virtual List<OrderByModel> ordersby { get; set; }
    }
}
