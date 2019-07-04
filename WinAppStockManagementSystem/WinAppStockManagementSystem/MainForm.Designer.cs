namespace WinAppStockManagementSystem
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DashboardButton = new System.Windows.Forms.Button();
            this.ReportButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.StockButton = new System.Windows.Forms.Button();
            this.companyButton = new System.Windows.Forms.Button();
            this.categoryButton = new System.Windows.Forms.Button();
            this.companySetup1 = new WinAppStockManagementSystem.CompanySetup();
            this.categorySetup1 = new WinAppStockManagementSystem.CategorySetup();
            this.itemSetup1 = new WinAppStockManagementSystem.ItemSetup();
            this.stockIn1 = new WinAppStockManagementSystem.StockIn();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.DashboardButton);
            this.panel1.Controls.Add(this.ReportButton);
            this.panel1.Controls.Add(this.SearchButton);
            this.panel1.Controls.Add(this.StockButton);
            this.panel1.Controls.Add(this.companyButton);
            this.panel1.Controls.Add(this.categoryButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 461);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 43);
            this.panel2.TabIndex = 1;
            // 
            // DashboardButton
            // 
            this.DashboardButton.FlatAppearance.BorderSize = 0;
            this.DashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashboardButton.ForeColor = System.Drawing.SystemColors.Control;
            this.DashboardButton.Location = new System.Drawing.Point(3, 60);
            this.DashboardButton.Name = "DashboardButton";
            this.DashboardButton.Size = new System.Drawing.Size(156, 43);
            this.DashboardButton.TabIndex = 0;
            this.DashboardButton.Text = "Dashbord";
            this.DashboardButton.UseVisualStyleBackColor = true;
            this.DashboardButton.Click += new System.EventHandler(this.DashboardButton_Click);
            // 
            // ReportButton
            // 
            this.ReportButton.FlatAppearance.BorderSize = 0;
            this.ReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ReportButton.Location = new System.Drawing.Point(3, 305);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(156, 43);
            this.ReportButton.TabIndex = 0;
            this.ReportButton.Text = "Report";
            this.ReportButton.UseVisualStyleBackColor = true;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.ForeColor = System.Drawing.SystemColors.Control;
            this.SearchButton.Location = new System.Drawing.Point(3, 256);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(156, 43);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // StockButton
            // 
            this.StockButton.FlatAppearance.BorderSize = 0;
            this.StockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StockButton.ForeColor = System.Drawing.SystemColors.Control;
            this.StockButton.Location = new System.Drawing.Point(3, 207);
            this.StockButton.Name = "StockButton";
            this.StockButton.Size = new System.Drawing.Size(156, 43);
            this.StockButton.TabIndex = 0;
            this.StockButton.Text = "Stock";
            this.StockButton.UseVisualStyleBackColor = true;
            this.StockButton.Click += new System.EventHandler(this.StockButton_Click);
            // 
            // companyButton
            // 
            this.companyButton.FlatAppearance.BorderSize = 0;
            this.companyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.companyButton.ForeColor = System.Drawing.SystemColors.Control;
            this.companyButton.Location = new System.Drawing.Point(3, 158);
            this.companyButton.Name = "companyButton";
            this.companyButton.Size = new System.Drawing.Size(156, 43);
            this.companyButton.TabIndex = 0;
            this.companyButton.Text = "Company";
            this.companyButton.UseVisualStyleBackColor = true;
            this.companyButton.Click += new System.EventHandler(this.CompanyButton_Click);
            // 
            // categoryButton
            // 
            this.categoryButton.FlatAppearance.BorderSize = 0;
            this.categoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryButton.ForeColor = System.Drawing.SystemColors.Control;
            this.categoryButton.Location = new System.Drawing.Point(3, 109);
            this.categoryButton.Name = "categoryButton";
            this.categoryButton.Size = new System.Drawing.Size(156, 43);
            this.categoryButton.TabIndex = 0;
            this.categoryButton.Text = "Category";
            this.categoryButton.UseVisualStyleBackColor = true;
            this.categoryButton.Click += new System.EventHandler(this.CategoryButton_Click);
            // 
            // companySetup1
            // 
            this.companySetup1.Location = new System.Drawing.Point(188, 21);
            this.companySetup1.Name = "companySetup1";
            this.companySetup1.Size = new System.Drawing.Size(584, 450);
            this.companySetup1.TabIndex = 2;
            // 
            // categorySetup1
            // 
            this.categorySetup1.Location = new System.Drawing.Point(209, 21);
            this.categorySetup1.Name = "categorySetup1";
            this.categorySetup1.Size = new System.Drawing.Size(505, 450);
            this.categorySetup1.TabIndex = 1;
            // 
            // itemSetup1
            // 
            this.itemSetup1.Location = new System.Drawing.Point(188, 21);
            this.itemSetup1.Name = "itemSetup1";
            this.itemSetup1.Size = new System.Drawing.Size(505, 450);
            this.itemSetup1.TabIndex = 3;
            // 
            // stockIn1
            // 
            this.stockIn1.Location = new System.Drawing.Point(178, 21);
            this.stockIn1.Name = "stockIn1";
            this.stockIn1.Size = new System.Drawing.Size(505, 450);
            this.stockIn1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.stockIn1);
            this.Controls.Add(this.itemSetup1);
            this.Controls.Add(this.companySetup1);
            this.Controls.Add(this.categorySetup1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Opacity = 0.98D;
            this.Text = "Stock Management System";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button categoryButton;
        private System.Windows.Forms.Button ReportButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button StockButton;
        private System.Windows.Forms.Button companyButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button DashboardButton;
        private CategorySetup categorySetup1;
        private CompanySetup companySetup1;
        private ItemSetup itemSetup1;
        private StockIn stockIn1;
    }
}

