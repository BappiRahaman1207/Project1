using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinAppStockManagementSystem.Business_Layer;
using WinAppStockManagementSystem.Presentation_Layer;


namespace WinAppStockManagementSystem
{
    public partial class StockIn : UserControl
    {
        
        Item item = new Item();
        public StockIn()
        {
            InitializeComponent();
        }

        private void StockIn_Load(object sender, EventArgs e)
        {

            //CategoryManager _categoryManager = new CategoryManager();
            StockInOutManager _stockInOutManager = new StockInOutManager();
            ItemManager _itemManager = new ItemManager();

            DataTable count = _itemManager.LoadCategory();
            categoryNameComboBox.DataSource = count;
            //if (count.Rows.Count > 0)
            //    categoryComboBox.DataSource = _itemManager.LoadCategory();

            DataTable count2 = _itemManager.LoadCompany();
            companyNameComboBox.DataSource = count2;



           


        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

        }

        private void companyNameComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            StockInOutManager _stockInOutManager = new StockInOutManager();
            //if (count.Rows.Count > 0)
            //    categoryComboBox.DataSource = _itemManager.LoadCategory();
            Company company = new Company();
            company.CompanyID = Convert.ToInt32(companyNameComboBox.SelectedValue);

            DataTable count3 = _stockInOutManager.LoadItem(company);
            itemNameComboBox.DataSource = count3;
        }
    }
}
