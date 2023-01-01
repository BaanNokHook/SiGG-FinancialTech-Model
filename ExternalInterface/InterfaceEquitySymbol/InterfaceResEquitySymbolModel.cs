using System;
using System.Collections.Generic;
using System.Text;

namespace GM.Model.ExternalInterface.InterfaceEquitySymbol
{
    public class InterfaceResEquitySymbolModel
    {
        public string Channel { get; set; }
        public string ResponseDate { get; set; }
        public string ResponseTime { get; set; }
        public string Code { get; set; }
        public int ReturnCode { get; set; }
        public string ReturnMsg { get; set; }
        public int TotalRows { get; set; }
        public List<ReqEquitySymbolList> Detail { get; set; }
    }
}
