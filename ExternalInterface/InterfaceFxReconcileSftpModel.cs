using GM.Model.Common;
using GM.Model.Static;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GM.Model.ExternalInterface
{
    public class InterfaceFxReconcileSftpModel
    {
        public DateTime AsofDate { get; set; }

        public string FileTransaction { get; set; }

        public string FilePosition { get; set; }

        public string FilePostingEvent { get; set; }

        public string FilePath { get; set; }

        public List<string> FileSuccess { get; set; }

        public List<string> FileFail { get; set; }

        public virtual List<RpConfigModel> RpConfigModel { get; set; }

        //=======================================================

        public DateTime? create_date { get; set; }

        [StringLength(50)]
        public string create_by { get; set; }

        public DateTime? update_date { get; set; }

        [StringLength(50)]
        public string update_by { get; set; }

        public virtual PagingModel paging { get; set; }

        public virtual List<OrderByModel> ordersby { get; set; }
    }
}
