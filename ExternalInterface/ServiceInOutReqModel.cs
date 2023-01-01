using System;

namespace GM.Model.ExternalInterface
{
    public class ServiceInOutReqModel
    {
        public string guid { get; set; }
        public string svc_req { get; set; }
        public string svc_res { get; set; }
        public string svc_type { get; set; }
        public string module_name { get; set; }
        public string action_name { get; set; }
        public string ref_id { get; set; }
        public string status { get; set; }
        public string status_desc { get; set; }
        public string create_by { get; set; }
        public DateTime create_date { get; set; }
    }
}
