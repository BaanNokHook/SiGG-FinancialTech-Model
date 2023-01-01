using System;
using System.Collections.Generic;
using System.Text;

namespace GM.Model.ExternalInterface.ExchRateMidRate
{
    public class ReqGetMidRates
    {
        public string exDate { get; set; }
        public string[] ccyCodes { get; set; }
    }
}
