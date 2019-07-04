namespace WinAppStockManagementSystem
{
    partial class CompanySetup
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.companyNameTextBox = new System.Windows.Forms.TextBox();
            this.AddCompanyButton = new System.Windows.Forms.Button();
            this.showCompanyDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.showCompanyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // companyNameTextBox
            // 
            this.companyNameTextBox.Location = new System.Drawing.Point(55, 33);
            this.companyNameTextBox.Name = "companyNameTextBox";
            this.companyNameTextBox.Size = new System.Drawing.Size(159, 20);
            this.companyNameTextBox.TabIndex = 0;
            // 
            // AddCompanyButton
            // 
            this.AddCompanyButton.Location = new System.Drawing.Point(220, 30);
            this.AddCompanyButton.Name = "AddCompanyButton";
            this.AddCompanyButton.Size = new System.Drawing.Size(75, 23);
            this.AddCompanyButton.TabIndex = 1;
            this.AddCompanyButton.Text = "Add";
            this.AddCompanyButton.UseVisualStyleBackColor = true;
            this.AddCompanyButton.Click += new System.EventHandler(this.AddCompanyButton_Click);
            // 
            // showCompanyDataGridView
            // 
            this.showCompanyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showCompanyDataGridView.Location = new System.Drawing.Point(55, 89);
            this.showCompanyDataGridView.Name = "showCompanyDataGridView";
            this.showCompanyDataGridView.Size = new System.Drawing.Size(397, 150);
            this.showCompanyDataGridView.TabIndex = 2;
            this.showCompanyDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.showCompanyDataGridView_CellMouseDoubleClick);
            // 
            // CompanySetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.showCompanyDataGridView);
            this.Controls.Add(this.AddCompanyButton);
            this.Controls.Add(this.companyNameTextBox);
            this.Name = "CompanySetup";
            this.Size = new System.Drawing.Size(505, 450);
            ((System.ComponentModel.ISupportInitialize)(this.showCompanyDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox companyNameTextBox;
        private System.Windows.Forms.Button AddCompanyButton;
        private System.Windows.Forms.DataGridView showCompanyDataGridView;
    }
}
