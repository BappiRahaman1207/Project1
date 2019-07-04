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
    public class CompanyManager
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

        public int Update(Company company)
        {
            return _CompanyRepository.Update(company);
        }
    }
}
