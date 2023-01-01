namespace GM.Model.InterfaceNavPrice
{
    public class ReqNavPrice
    {
        public bool success;
        public string message;
        public string serverity;
        public ReqNavPriceHeader datas { get; set; }
        public int rdfcode;
        public int total;
    }
}
