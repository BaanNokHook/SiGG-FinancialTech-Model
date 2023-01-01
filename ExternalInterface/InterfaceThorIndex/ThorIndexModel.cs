using GM.Model.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GM.Model.ExternalInterface.InterfaceThorIndex
{
    #region Real Table
    //public class ThorIndexModel
    //{
    //    public int RowNumber { get; set; }
    //    public string instrument_code { get; set; }
    //    public System.DateTime thor_date { get; set; }

    //    public System.DateTime event_date { get; set; }

    //    public Nullable<System.DateTime> next_business_date { get; set; }

    //    public Nullable<decimal> thor_rate { get; set; }

    //    public Nullable<int> day_count { get; set; }

    //    public Nullable<decimal> accrue_daily_compound { get; set; }

    //    public Nullable<decimal> accrue_daily_compound_accum { get; set; }

    //    public Nullable<int> day_count_accum_obs { get; set; }

    //    public Nullable<decimal> thor_index_compound_obs { get; set; }

    //    public Nullable<decimal> thor_index_spread_compound_obs { get; set; }

    //    public Nullable<int> day_count_accum_period { get; set; }

    //    public Nullable<decimal> ai_index_buy_sell { get; set; }

    //    public Nullable<decimal> ai_index_buy_sell_xi { get; set; }

    //    public Nullable<decimal> ai_index_eod_accum { get; set; }

    //    public Nullable<decimal> ai_index_eod_daily { get; set; }

    //    [StringLength(10)]
    //    public string compound_type { get; set; }

    //    [Required]
    //    public int instrument_id { get; set; }

    //    [StringLength(1)]
    //    public string is_holiday { get; set; }

    //    [Required]
    //    public System.DateTime create_date { get; set; }

    //    [StringLength(255)]
    //    public string create_by { get; set; }

    //    public Nullable<System.DateTime> update_date { get; set; }

    //    [StringLength(255)]
    //    public string update_by { get; set; }
    //}
    #endregion

    public class ThorIndexModel
    {
        public int RowNumber { get; set; }
        public string asof_date { get; set; }
        public string instrument_code { get; set; }
        public string thor_date { get; set; }

        public string event_date { get; set; }

        public string next_business_date { get; set; }

        public string thor_rate { get; set; }

        public string day_count { get; set; }

        public string accrue_daily_compound { get; set; }

        public string accrue_daily_compound_accum { get; set; }

        public string day_count_accum_obs { get; set; }

        public string thor_index_compound_obs { get; set; }

        public string thor_index_spread_compound_obs { get; set; }

        public string day_count_accum_period { get; set; }

        public string ai_index_buy_sell { get; set; }

        public string ai_index_buy_sell_xi { get; set; }

        public string ai_index_eod_accum { get; set; }

        public string ai_index_eod_daily { get; set; }

        [StringLength(10)]
        public string compound_type { get; set; }

        public int instrument_id { get; set; }

        [StringLength(1)]
        public string is_holiday { get; set; }

        public System.DateTime create_date { get; set; }

        [StringLength(255)]
        public string create_by { get; set; }

        public Nullable<System.DateTime> update_date { get; set; }

        [StringLength(255)]
        public string update_by { get; set; }

        #region For Search
        public DateTime? asof_date_from { get; set; }
        public DateTime? asof_date_to { get; set; }
        public virtual PagingModel paging { get; set; }
        public virtual List<OrderByModel> ordersby { get; set; }
        public string mode { get; set; }
        #endregion
    }

}
