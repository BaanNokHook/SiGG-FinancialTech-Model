namespace GM.Model.ExternalInterface
{
    public class RequestObligateModel
    {
        public ObligateHeader Header { get; set; }
        public ObligateBody Body { get; set; }

        public class ResultObligate
        {
            public string channel_id { get; set; }
            public string ref_id { get; set; }
            public string response_date { get; set; }
            public string response_time { get; set; }
            public string mode { get; set; }
            public string response_code { get; set; }
            public string response_message { get; set; }
            public string total_number { get; set; }
            public string content_type { get; set; }
        }

        public class ObligateHeader
        {
            public string channel_id { get; set; }
            public string ref_id { get; set; }
            public string request_date { get; set; }
            public string request_time { get; set; }
            public string mode { get; set; }
            public string content_type { get; set; }
        }

        public class ObligateBody
        {
            public string obligate_id { get; set; }
            public string system_name { get; set; }
            public string instrument_id { get; set; }
            public string port { get; set; }
            public string start_obligate_date { get; set; }
            public string expire_obligate_date { get; set; }
            public string obligate_unit { get; set; }
            public string approve_state { get; set; }
            public string create_date { get; set; }
            public string create_by { get; set; }
        }
    }
}
