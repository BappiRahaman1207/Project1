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
        //int id;
        Category category = new Category();
        public CategorySetup()
        {
            InitializeComponent();
        }

        private void UpdateCategory(Category category)
        {
            CategoryManager _categoryManager = new CategoryManager();
            category.CategoryName = categoryNameTextBox.Text;

            _categoryManager.Update(category);

        }
        

        private void addButton_Click(object sender, EventArgs e)
        {
            CategoryManager _categoryManager = new CategoryManager();
            if (addButton.Text == "Update")
            {

                UpdateCategory(category);
                MessageBox.Show("update");
                ShowCategoryDataGridView.DataSource = _categoryManager.ShowCategory();
                addButton.Text = "Add";
                categoryNameTextBox.Text = "";


            }

            else
            {
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
            

            
        }

        private void ShowCategoryDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            category.CategoryID = Convert.ToInt32(ShowCategoryDataGridView.Rows[e.RowIndex].Cells["CategoryID"].Value.ToString());
            //categoryIdTextBox.Text=Convert.ToInt32(ShowCategoryDataGridView.RowCount[e.RowIndex].C)
            categoryNameTextBox.Text = ShowCategoryDataGridView.Rows[e.RowIndex].Cells["CategoryName"].Value.ToString();
            addButton.Text = "Update";
        }
    }
}

