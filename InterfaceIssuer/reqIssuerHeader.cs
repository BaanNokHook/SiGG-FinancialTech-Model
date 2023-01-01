namespace GM.Model.InterfaceIssuer
{
    public class reqIssuerHeader
    {
        public string channel = string.Empty;
        public string ref_code = string.Empty;
        public string request_date = string.Empty;
        public string mode = string.Empty;

        public string JsonValues { get ; set; }
        public int CountData { get ; set; }
    }
}
