using System.Collections.Generic;
using GM.Model.Static;

namespace GM.Model.ExternalInterface
{
    public class InterfaceCheckingEodModel
    {
        public string task_name { get; set; }

        public virtual List<RpConfigModel> RpConfigModel { get; set; }
    }
}
