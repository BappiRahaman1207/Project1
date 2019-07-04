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
    public partial class CategorySetup : UserControl
    {
        int id;
        public CategorySetup()
        {
            InitializeComponent();
        }
     

        private void AddCategoryButton_Click_1(object sender, EventArgs e)
        {
            CategoryManager _categoryManager = new CategoryManager();

            Category category = new Category();

            category.CategoryName = categoryNameTextBox.Text;

            int isExecuted;
            isExecuted = _categoryManager.Insert(category);

            if (isExecuted > 0)
            {
                MessageBox.Show("saved!!");
            }
            else
            {
                MessageBox.Show("Not saved!!");
            }

            ShowCategoryDataGridView.DataSource = _categoryManager.ShowCategory();
        }

        private void CategorySetup_DoubleClick(object sender, EventArgs e)
        {

        }

        private void ShowCategoryDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = Convert.ToInt32(ShowCategoryDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            categoryNameTextBox.Text = ShowCategoryDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }

}

