using System.Collections.Generic;

namespace GM.Model.InterfaceNavPrice
{
    public class ReqNavPriceHeader
    {
        public string channel_id;
        public string asof_date;
        public string asof_time;
        public int total_rec;
        public List<ReqNavPriceList> NavPrice { get; set; }
        public string ref_no;
        public string create_by;
    }
}
