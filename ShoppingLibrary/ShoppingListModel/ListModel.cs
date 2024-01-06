using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ShoppingLibrary.ShoppingListModel
{
    public class ListModel
    {
        public string? CategoryName { get; set; }
        public string? Date { get; set; }
        public double Budget { get; set; }
        public string? StoreName { get; set; }
        public string? Productname { get; set; }
        public double Price { get; set; }
        public double TotalSpent { get; set; }
        public double ExcessMoney { get; set; }
        public double SavedMoney { get; set; }
        public string? AddNote { get; set; }
        public int ListNumber { get; set; }
        public int SavedListNumber { get; set; }
        public bool SaveList { get; set; }

    }
}
