using System.Collections.Generic;

namespace GM.Model.ExternalInterface.FloatingIndexSummit
{
    public class FloatingIndexEntity
    {
        public int seq { get; set; }
        public string as_of_date { get; set; }
        public string curve_id { get; set; }
        public string ccy { get; set; }
        public string index { get; set; }
        public List<money_market> money_market { get; set; }
        public List<swap_spread> swap_spread { get; set; }
        public List<zero_rate> zero_rate { get; set; }
    }
}
