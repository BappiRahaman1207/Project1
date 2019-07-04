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
    public partial class CompanySetup : UserControl
    {
        Company company = new Company();
        public CompanySetup()
        {
            InitializeComponent();
        }

        private void UpdateCompany(Company company)
        {
            CompanyManager _companyManager = new CompanyManager();
            company.CompanyName = companyNameTextBox.Text;

            _companyManager.Update(company);

        }

        private void AddCompanyButton_Click(object sender, EventArgs e)
        {
            CompanyManager _companyManager = new CompanyManager();
            if (AddCompanyButton.Text == "Update")
            {

                UpdateCompany(company);
                MessageBox.Show("update");
                showCompanyDataGridView.DataSource = _companyManager.ShowCompany();
                AddCompanyButton.Text = "Add";
                companyNameTextBox.Text = "";


            }

            else
            {
                company.CompanyName = companyNameTextBox.Text;

                int isExecuted;
                isExecuted = _companyManager.Insert(company);

                if (isExecuted > 0)
                {
                    MessageBox.Show("saved!!");
                }
                else
                {
                    MessageBox.Show("Not saved!!");
                }

                showCompanyDataGridView.DataSource = _companyManager.ShowCompany();
            }
        }

        private void showCompanyDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            company.CompanyID = Convert.ToInt32(showCompanyDataGridView.Rows[e.RowIndex].Cells["CompanyID"].Value.ToString());
            //categoryIdTextBox.Text=Convert.ToInt32(ShowCategoryDataGridView.RowCount[e.RowIndex].C)
            companyNameTextBox.Text = showCompanyDataGridView.Rows[e.RowIndex].Cells["CompanyName"].Value.ToString();
            AddCompanyButton.Text = "Update";
        }
    }
}
