using GM.Model.Common;
using System;
using System.Collections.Generic;

namespace GM.Model.UserAndScreen
{
    public class ActivityLogModel
    {
        public string user_id { get; set; }

        public DateTime? date_from { get; set; }
        public DateTime? date_to { get; set; }

        public virtual PagingModel paging { get; set; }

        public virtual List<OrderByModel> ordersby { get; set; }
    }
}
