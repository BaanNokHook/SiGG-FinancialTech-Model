namespace GM.Model.ExternalInterface.InterfaceThorRate
{
    public class InterfaceResTicketHeaderThorRateModel
    {
        public string channel { get; set; }
        public string ref_id { get; set; }
        public string Content_Type { get; set; }
        public string response_date { get; set; }
        public string response_time { get; set; }
        public string response_code { get; set; }
        public string response_message { get; set; }

        public bool is_error { get; set; }
        public string error_message { get; set; }

        public InterfaceResTicketBodyThorRateModel resBody { get; set; }
    }
}
