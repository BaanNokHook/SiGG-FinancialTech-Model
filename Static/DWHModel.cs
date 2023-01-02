using System.Collections.Generic;
using GM.Model.Common;

namespace GM.Model.Static
{
    public class DWHModel
    {
        public string file_type { get; set; }
        public string recorded_by { get; set; }
        public virtual PagingModel paging { get; set; }
        public virtual List<OrderByModel> ordersby { get; set; }
    }
}
