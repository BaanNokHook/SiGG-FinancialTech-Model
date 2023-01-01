using System.Collections.Generic;

namespace GM.Model.InterfaceIssuer
{
    public class reqIssuer
    {
        public reqIssuerHeader reqIssuerHeader = null;
        public List<reqIssuerList> reqIssuerList = null;
        public string RefCode { get; set; }
        public string Function { get; set; }
    }
}
