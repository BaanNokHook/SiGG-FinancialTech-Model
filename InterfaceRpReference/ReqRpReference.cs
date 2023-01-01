namespace GM.Model.InterfaceRpReference
{
    public class ReqRpReference
    {
        public bool success;
        public string message;
        public string serverity;
        public ReqRpReferenceHeader datas { get; set; }
        public int rdfcode;
        public int total;
    }
}
