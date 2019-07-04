using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinAppStockManagementSystem.Presentation_Layer;
using WinAppStockManagementSystem.Data_Layer;
using System.Data;

namespace WinAppStockManagementSystem.Business_Layer
{
    public class StockInOutManager
    {
        
        ItemRepository _itemRepository = new ItemRepository();
        StockInOutRepository _StockInOutRepository = new StockInOutRepository();

        public DataTable LoadCategory()
        {
            return _itemRepository.LoadCategory();
        }

        public DataTable LoadCompany()
        {
            return _itemRepository.LoadCompany();
        }

        public DataTable LoadItem(Company company)
        {
            return _StockInOutRepository.LoadItem(company);
        }
    }
}
