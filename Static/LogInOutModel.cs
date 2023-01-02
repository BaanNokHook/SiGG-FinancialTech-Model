using System;
using System.Collections.Generic;
using System.ComponentModel;
using GM.Model.Common;

namespace GM.Model.Static
{
    public class LogInOutModel
    {
        [DisplayName("No")]
        public int? RowNumber { get; set; }

        [DisplayName("SVC ID")]
        public string svc_id { get; set; }

        [DisplayName("GUID")]
        public string guid { get; set; }

        [DisplayName("SVC REQ")]
        public string svc_req { get; set; }

        [DisplayName("SVC RES")]
        public string svc_res { get; set; }

        [DisplayName("Type")]
        public string svc_type { get; set; }

        [DisplayName("Module Name")]
        public string module_name { get; set; }

        [DisplayName("Action Name")]
        public string action_name { get; set; }

        [DisplayName("Ref ID")]
        public string ref_id { get; set; }

        [DisplayName("Status")]
        public string status { get; set; }

        [DisplayName("Description")]
        public string status_desc { get; set; }

        [DisplayName("Create Date")]
        public DateTime? create_date { get; set; }

        [DisplayName("Create By")]
        public string create_by { get; set; }

        public virtual PagingModel paging { get; set; }

        public virtual List<OrderByModel> ordersby { get; set; }
    }
}
