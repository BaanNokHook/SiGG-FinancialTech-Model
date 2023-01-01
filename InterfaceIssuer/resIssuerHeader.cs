using System.Collections.Generic;

namespace GM.Model.InterfaceIssuer
{
    public class resIssuerHeader
    {
        public string channel;
        public string ref_code;
        public string mode;
        public string response_date;
        public string response_time;
        public string response_code;
        public string response_message;
        public List<resIssuerList> response_details;

        public resIssuerHeader()
        {
            response_details = new List<resIssuerList>();
        }
    }
}
