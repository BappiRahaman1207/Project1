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
    class CategoryManager
    {
        CategoryRepository _CategoryRepository = new CategoryRepository();


        public DataTable ShowCategory()
        {
            return _CategoryRepository.ShowCategory();
        }

        public int Insert(Category category)
        {
            return _CategoryRepository.Insert(category);
        }
    }
}
