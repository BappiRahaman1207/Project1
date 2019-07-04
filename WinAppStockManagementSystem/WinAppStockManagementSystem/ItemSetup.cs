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
    public partial class ItemSetup : UserControl
    {
        
        Item item = new Item();
        public ItemSetup()
        {
            InitializeComponent();
        }

        private void ItemSetup_Load(object sender, EventArgs e)
        {
            ItemManager _itemManager = new ItemManager();

            DataTable count = _itemManager.LoadCategory();
            categoryComboBox.DataSource = count;
            //if (count.Rows.Count > 0)
            //    categoryComboBox.DataSource = _itemManager.LoadCategory();

            DataTable count2 = _itemManager.LoadCompany();
            
            companyComboBox.DataSource = count2;

        }

        private void SaveItemButton_Click(object sender, EventArgs e)
        {
            ItemManager _itemManager = new ItemManager();

            item.ItemName = itemNameTextBox.Text;
            item.ReorderLevel = Convert.ToInt32(recordLevelTextBox.Text);
            item.CategoryName = Convert.ToString(categoryComboBox.SelectedValue);
            item.CompanyName = Convert.ToString(companyComboBox.SelectedValue);

            int isExecuted;
            isExecuted = _itemManager.Insert(item);

            if (isExecuted > 0)
            {
                MessageBox.Show("saved!!");
            }
            else
            {
                MessageBox.Show("Not saved!!");
            }

            //showCompanyDataGridView.DataSource = _companyManager.ShowCompany();
        }
    }
}
