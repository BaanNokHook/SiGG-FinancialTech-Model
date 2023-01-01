using System.Collections.Generic;

namespace GM.Model.InterfaceSecurity
{
    public class ReqSecurity
    {
        public ReqSecurityHeader reqSecurityHeader { get; set; }
        public List<ReqSecurityList> reqSecurityList { get; set; }

        public string RefCode { get; set; }
        public string Function { get; set; }
    }
}
