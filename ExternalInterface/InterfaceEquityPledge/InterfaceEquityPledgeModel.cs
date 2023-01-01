using GM.Model.Common;
using GM.Model.Static;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GM.Model.ExternalInterface
{
    public class InterfaceEquityPledgeModel
    {
        public InterfaceEquityPledgeModel()
        {
            RPConfigModel = new List<RpConfigModel>();
            Paging = new PagingModel();
            OrdersBy = new List<OrderByModel>();
        }

        public DateTime AsOfDate { get; set; }

        public int BondPledgeTotal { get; set; }

        public string ServiceUrl { get; set; }

        public int ServiceTimeOut { get; set; }

        public virtual List<RpConfigModel> RPConfigModel { get; set; }

        public DateTime? create_date { get; set; }

        [StringLength(50)]
        public string create_by { get; set; }

        public DateTime? update_date { get; set; }

        [StringLength(50)]
        public string update_by { get; set; }

        public virtual PagingModel Paging { get; set; }

        public virtual List<OrderByModel> OrdersBy { get; set; }
    }
}
