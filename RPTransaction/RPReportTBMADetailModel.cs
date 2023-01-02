using System;

namespace GM.Model.RPTransaction
{
    public class RPReportTBMADetailModel
    {
        public int ORDER_NUM { get; set; }

        public string TRADER_ID { get; set; }

        public string PURPOSE { get; set; }

        public DateTime? TRADE_TIME { get; set; }

        public DateTime? TRADE_DATE { get; set; }

        public DateTime? SETTLEMENT_DATE { get; set; }

        public string TYPE { get; set; }

        public string ISSUE_SYMBOL { get; set; }

        public decimal? YIELD { get; set; }

        public string YIELD_TYPE { get; set; }

        public decimal? PRICE { get; set; }

        public int VOLUME { get; set; }

        public string COUNTER_PARTY { get; set; }

        public int? TERM { get; set; }

        public decimal? RATE { get; set; }

        public string REMARK { get; set; }
    }
}
