using System;
using System.Collections.Generic;
using System.Text;

namespace GM.Model.InterfaceEodReconcile
{
    public class ReqEodReconcileBahtnetHeader
    {
        public DateTime asOfDate { get; set; }
        public string filename { get; set; }
        public string recordedBy { get; set; }

        public List<ReqEodReconcileBahtnet> listData { get; set; }
    }
}
