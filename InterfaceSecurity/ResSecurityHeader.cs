using System.Collections.Generic;

namespace GM.Model.InterfaceSecurity
{
    public class resSecurityHeader
    {
        public resSecurityHeader()
        {
            response_details = new List<ResSecurityList>();
        }
        public string channel { get; set; }
        public string ref_code { get; set; }
        public string mode { get; set; }
        public string response_date { get; set; }
        public string response_time { get; set; }
        public string response_code { get; set; }
        public string response_message { get; set; }
        public List<ResSecurityList> response_details { get; set; }
    }
}
