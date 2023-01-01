using System;
using System.Collections.Generic;
using System.Text;

namespace GM.Model.ExternalInterface.InterfaceEquityPledge
{
    public class ResInterfaceEquityPledgeModel
    {
        public string asof_date { get; set; }
        public string instrument_code { get; set; }
        public string port { get; set; }
        public string pledge_coll_unit { get; set; }
        public string pledge_coll_cost { get; set; }
        public string pledge_coll_booking { get; set; }
    }
}
