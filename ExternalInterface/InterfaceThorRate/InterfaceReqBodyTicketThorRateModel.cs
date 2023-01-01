namespace GM.Model.ExternalInterface.InterfaceThorRate
{
    public class InterfaceReqBodyThorRateModel
    {
        public string data_type { get; set; }
        public string as_of_date { get; set; }
        public string curve_id { get; set; }
        public string ccy { get; set; }
        public string index { get; set; }
    }
}
