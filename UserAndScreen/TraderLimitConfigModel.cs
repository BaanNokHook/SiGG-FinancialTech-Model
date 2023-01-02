using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GM.Model.Common;

namespace GM.Model.UserAndScreen
{
    public class TraderLimitConfigModel
    {
        public int? RowNumber { get; set; }

        public int? limit_id { get; set; }

        [Required]
        [StringLength(255)]
        public string user_id { get; set; }

        public string user_eng_name { get; set; }

        public int? title_master_id { get; set; }

        public string title_master_name { get; set; }
        public string title_master_name_eng { get; set; }

        public int? desk_group_id { get; set; }

        public string desk_group_name { get; set; }

        public decimal? govt_short_limit { get; set; }

        public decimal? govt_long_limit { get; set; }

        public decimal? corp_limit { get; set; }

        [StringLength(3)]
        public string cur { get; set; }

        [Required]
        public DateTime? effective_date { get; set; }

        [Required]
        public bool active_flag { get; set; }

        public DateTime? create_date { get; set; }

        [StringLength(255)]
        public string create_by { get; set; }

        public DateTime? update_date { get; set; }

        [StringLength(255)]
        public string update_by { get; set; }

        public virtual PagingModel paging { get; set; }

        public virtual List<OrderByModel> ordersby { get; set; }
    }

}
