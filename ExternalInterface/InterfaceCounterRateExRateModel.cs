using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GM.Model.Common;
using GM.Model.Static;

namespace GM.Model.ExternalInterface
{
    public class InterfaceCounterRateExRateModel
    {
        public string ref_id { get; set; }

        public string request_date { get; set; }

        public string request_time { get; set; }

        public string exCurrency { get; set; }

        public DateTime asof_date { get; set; }

        public string exDate { get; set; }
        public string exTime { get; set; }

        public string channel { get; set; }

        public string requestID { get; set; }

        public string serviceID { get; set; }

        public int exRound { get; set; }

        public string ServiceUrl { get; set; }

        public int ServiceTimeOut { get; set; }

        public string ServiceType { get; set; }
        public string ApiAuthenUrl { get; set; }
        public string ApiRateUrl { get; set; }
        public string ApiUsername { get; set; }
        public string ApiPassword { get; set; }

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
