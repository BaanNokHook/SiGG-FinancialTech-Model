using System.Collections.Generic;

namespace GM.Model.ExternalInterface.InterfaceThorRate
{
    public class InterfaceResRateBodyThorRateModel
    {
        public int seq { get; set; }
        public string as_of_date { get; set; }
        public string curve_id { get; set; }
        public string ccy { get; set; }
        public string index { get; set; }

        public List<InterfaceResRateBodyDetailThorRateModel> money_market { get; set; }
    }
}
