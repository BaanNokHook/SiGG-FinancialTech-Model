using System;
using System.Collections.Generic;
using System.Text;

namespace GM.Model.ExternalInterface.InterfaceNavPrice
{
    public class InterfaceResNavPriceListModel
    {
        public string market { get; set; }
        public string symbols { get; set; }
        public string last_bid { get; set; }
        public string last_ask { get; set; }
        public string price_close { get; set; }
        public string date { get; set; }
        public string create_date { get; set; }
        public string create_by { get; set; }
        public string update_date { get; set; }
        public string update_by { get; set; }
        public string price_avg { get; set; }
        public string price_floor { get; set; }
        public string price_ceiling { get; set; }
        public string price_highest { get; set; }
        public string price_lowest { get; set; }
        public string volume_unit { get; set; }
        public string volume_amount { get; set; }
        public string volume_buy { get; set; }
        public string volume_sell { get; set; }
        public string price_open { get; set; }
        public string last_update { get; set; }
        public string instrument_id { get; set; }
        public string nav_price { get; set; }
        public string book_price { get; set; }
    }
}
