using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitarios.DataTableSSP
{
    public class DataTableSsp
    {
        public int draw { set; get; }
        public Column[] columns { set; get; }
        public OrderColumn[] order { set; get; }
        public int start { set; get; }
        public int length { set; get; }
        public Search search { set; get; }


        public class Column
        {
            public string data { set; get; }
            public string name { set; get; }
            public bool orderable { set; get; }
            Search search { set; get; }
            public bool searchable { set; get; }
            
        }

        public class OrderColumn
        {
            public int column { set; get; }
            public string dir { set; get; }
        }

        public class Search
        {
            public bool regex { set; get; }
            public string value { set; get; }
        }
    }
}
