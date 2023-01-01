namespace GM.Model.ExternalInterface.InterfaceEquitySymbol
{
    public class ReqEquitySymbol
    {
        public bool success;
        public string message;
        public string serverity;
        public ReqEquitySymbolHeader datas { get; set; }
        public int rdfcode;
        public int total;
    }
}
