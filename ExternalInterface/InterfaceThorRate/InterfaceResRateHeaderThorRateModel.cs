using GM.Model.Common;
using System;
using System.Collections.Generic;

namespace GM.Model.ExternalInterface.InterfaceThorRate
{
    public class InterfaceResRateHeaderThorRateModel
    {
        public string channel { get; set; }
        public string ref_id { get; set; }
        public string Content_Type { get; set; }
        public string response_date { get; set; }
        public string response_time { get; set; }
        public string response_code { get; set; }
        public string response_message { get; set; }
        public string data_type { get; set; }
        public string total_number { get; set; }
        public bool is_error { get; set; }
        public string error_message { get; set; }

        public InterfaceResRateBodyThorRateModel resBody { get; set; }

        public List<InterfaceResRateBodyThorRateModel> listResBody { get; set; }

        public string recorded_by { get; set; }
    }
}
