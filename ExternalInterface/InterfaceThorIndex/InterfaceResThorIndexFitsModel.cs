using Newtonsoft.Json;
using System.Collections.Generic;

namespace GM.Model.ExternalInterface.InterfaceThorIndex
{
    public class InterfaceResThorIndexFitsModel
    {
        public int ReturnCode;
        public string Msg;
        public string Serverity;
        public int? HowManyRecord;

        //[JsonIgnore]
        public List<ThorIndexModel> Data;
    }
}
