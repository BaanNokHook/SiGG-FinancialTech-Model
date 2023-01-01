using System.Collections.Generic;

namespace GM.Model.ExternalInterface.InterfaceEquitySymbol
{
    public class ReqEquitySymbolHeader
    {
        public string channel_id;
        public string asof_date;
        public string asof_time;
        public int total_rec;
        public List<ReqEquitySymbolList> EquitySymbol { get; set; }
        public string ref_no;
        public string create_by;
        public string url_service;
    }
}
