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
    class CompanyManager
    {
        CompanyRepository _CompanyRepository = new CompanyRepository();
        

        public DataTable ShowCompany()
        {
            return _CompanyRepository.ShowCompany();
        }

        public int Insert(Company company)
        {
            return _CompanyRepository.Insert(company);
        }
    }
}
