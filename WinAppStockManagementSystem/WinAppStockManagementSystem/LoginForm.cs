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
    public partial class LoginForm : Form
    {
        MainForm mainForm;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (userNameTextBox.Text=="admin" && passwordTextBox.Text=="admin")
            {
                mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
        }
    }
}
