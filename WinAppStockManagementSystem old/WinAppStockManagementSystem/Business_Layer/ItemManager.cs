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
    class ItemManager
    {
        ItemRepository _itemRepository = new ItemRepository();

        public DataTable LoadCategory()
        {
            return _itemRepository.LoadCategory();
        }

        public DataTable LoadCompany()
        {
            return _itemRepository.LoadCompany();
        }

        public int Insert(Item item)
        {
            return _itemRepository.Insert(item);
        }
    }
}
