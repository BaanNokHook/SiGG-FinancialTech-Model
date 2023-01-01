namespace GM.Model.ExternalInterface.ExchRateSummit
{
    public class InterfaceReqHeaderTicketSummitModel
    {
        public string ref_id { get; set; }
        public string Content_Type { get; set; }
        public string request_date { get; set; }
        public string request_time { get; set; }
        public string mode { get; set; }
        public string ticket_url { get; set; }
        public InterfaceReqBodyTicketSummitModel req_bodyticket_model { get; set; }
        public string error_message { get; set; }
    }
}
