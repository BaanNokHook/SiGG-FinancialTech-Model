using System.Collections.Generic;

namespace GM.Model.Common
{
      
    public class DataTableAjaxPostModel
    {
        //public DataTableAjaxPostModel()
        //{
        //    this.start = 1;
        //    this.length = 10;
        //}

        // properties are not capital due to json mapping
        public int draw { get; set; }
        int _pageno = 0;

        public int pageno
        {
            get {
                return _pageno = (start / length) + 1;

            }

            set {
                _pageno = value;
            }
        }
        public int start { get; set; }
        public int length { get; set; }
        public List<Column> columns { get; set; }
        public Search search { get; set; }
        public List<Order> order { get; set; }
    }

    public class Column
    {
        public string data { get; set; }
        public string name { get; set; }
        public bool searchable { get; set; }
        public bool orderable { get; set; }
        public Search search { get; set; }
    }

    public class Search
    {
        public string value { get; set; }
        public string regex { get; set; }
    }

    public class Order
    {
        public int column { get; set; }
        public string dir { get; set; }
    }
}
