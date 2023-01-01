namespace GM.Model.InterfaceSecurity
{
    public class ReqSecurityRatingList
    {
        public string instrument_id { get; set; }
        public string agency_code { get; set; }
        public string short_long_term { get; set; }
        public string local_rating { get; set; }
        public string foreign_rating { get; set; }
        public string create_date { get; set; }
        public string create_by { get; set; }
        public string update_date { get; set; }
        public string update_by { get; set; }
        public string assess_date { get; set; }
        public string ref_code { get; set; }
    }
}
