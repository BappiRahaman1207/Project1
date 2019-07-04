using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppStockManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void DashboardButton_Click(object sender, EventArgs e)
        {
            panel2.Height = DashboardButton.Height;
            panel2.Top = DashboardButton.Top;
            //dashboardView1.BringToFront();
            
        }
        private void CategoryButton_Click(object sender, EventArgs e)
        {
            panel2.Height = categoryButton.Height;
            panel2.Top = categoryButton.Top;
            categorySetup1.BringToFront();
        }

        private void CompanyButton_Click(object sender, EventArgs e)
        {
            panel2.Height = companyButton.Height;
            panel2.Top = companyButton.Top;
            companySetup1.BringToFront();
        }

        private void StockButton_Click(object sender, EventArgs e)
        {
            panel2.Height = StockButton.Height;
            panel2.Top = StockButton.Top;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            panel2.Height = SearchButton.Height;
            panel2.Top = SearchButton.Top;
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            panel2.Height = ReportButton.Height;
            panel2.Top = ReportButton.Top;
        }
    }
}
