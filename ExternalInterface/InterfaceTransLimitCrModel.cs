using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GM.Model.Common;

namespace GM.Model.ExternalInterface
{
    public class InterfaceTransLimitCrModel
    {
        public string ServiceUrl { get; set; }

        public string ChannelId { get; set; }

        public string RegisterCode { get; set; }

        public int ServiceTimeOut { get; set; }

        public DateTime AsOfDate { get; set; }

        public string RefNo { get; set; }

        public int TransTotal { get; set; }

        public int TransCancelTotal { get; set; }

        public int TransSuccess { get; set; }

        public int TransFail { get; set; }

        public virtual List<ResponsTransLimitCr> List_RespTrans { get; set; }

        //=======================================================

        public DateTime? create_date { get; set; }

        [StringLength(50)]
        public string create_by { get; set; }

        public DateTime? update_date { get; set; }

        [StringLength(50)]
        public string update_by { get; set; }

        public virtual PagingModel paging { get; set; }

        public virtual List<OrderByModel> ordersby { get; set; }

        public InterfaceTransLimitCrModel()
        {
            List_RespTrans = new List<ResponsTransLimitCr>();
        }

        public class ResponsTransLimitCr
        {
            public string TransNo { get; set; }

            public string Action { get; set; }

            public int TotalColl { get; set; }

            public string ReturnCode { get; set; }

            public string ReturnMsg { get; set; }

        }
    }
}
