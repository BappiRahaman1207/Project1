using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppStockManagementSystem.Presentation_Layer
{
    public class StockInOut
    {
        public int StockInId { get; set; }
        public int ItemId { get; set; }
        public int SrockInQuantity { get; set; }
        public DateTime StockInDate { get; set; }
    }
}
