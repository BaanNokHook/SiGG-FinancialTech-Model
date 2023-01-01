namespace GM.Model.ExternalInterface.InterfaceThorRate
{
    public class InterfaceReqThorRateModel
    {
        public string ticket { get; set; }
        public string ref_id { get; set; }
        public string content_type { get; set; }
        public string request_date { get; set; }
        public string request_time { get; set; }
        public string mode { get; set; }
        public string url_ticket { get; set; }
        public string url_rate { get; set; }
        public string authorization { get; set; }
        public int time_out { get; set; }

        public InterfaceReqThorRateModel() 
        {
            reqBody = new InterfaceReqBodyThorRateModel();
        }

        public InterfaceReqBodyThorRateModel reqBody { get; set; }
    }
}
