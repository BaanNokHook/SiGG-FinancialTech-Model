using System.Collections.Generic;

namespace GM.Model.InterfaceRpReference
{
    public class ReqRpReferenceHeader
    {
        public string channel_id;
        public string asof_date;
        public string asof_time;
        public int total_rec;
        public List<ReqRpReferenceList> rp { get; set; }
        public string ref_id;
    }
}
