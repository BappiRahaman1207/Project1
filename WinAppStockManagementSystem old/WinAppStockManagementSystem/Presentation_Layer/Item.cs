using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppStockManagementSystem.Presentation_Layer
{
    class Item
    {
        public string CategoryName { get; set; }
        public string CompanyName { get; set; }
        public string ItemName { get; set; }
        public int ReorderLevel { get; set; }
    }
}
