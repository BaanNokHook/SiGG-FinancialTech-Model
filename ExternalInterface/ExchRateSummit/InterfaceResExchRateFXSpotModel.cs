using System.Collections.Generic;

namespace GM.Model.ExternalInterface.ExchRateSummit
{
    public class InterfaceResExchRateFXSpotModel
    {
        public string channel { get; set; }
        public string ref_id { get; set; }
        public string content_type { get; set; }
        public string response_date { get; set; }
        public string response_time { get; set; }
        public string response_code { get; set; }
        public string response_message { get; set; }
        public string data_type { get; set; }
        public string total_number { get; set; }
        public string error_message { get; set; }
        public bool is_error { get; set; }
        public List<InterfaceResExchRateFXSpotDetailModel> listdetail { get; set; }
    }
}
