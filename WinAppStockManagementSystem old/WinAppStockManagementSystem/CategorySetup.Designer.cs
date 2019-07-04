namespace WinAppStockManagementSystem
{
    partial class CategorySetup
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
            this.components = new System.ComponentModel.Container();
            this.categoryNameTextBox = new System.Windows.Forms.TextBox();
            this.AddCategoryButton = new System.Windows.Forms.Button();
            this.ShowCategoryDataGridView = new System.Windows.Forms.DataGridView();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ShowCategoryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryNameTextBox
            // 
            this.categoryNameTextBox.Location = new System.Drawing.Point(113, 76);
            this.categoryNameTextBox.Name = "categoryNameTextBox";
            this.categoryNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.categoryNameTextBox.TabIndex = 0;
            // 
            // AddCategoryButton
            // 
            this.AddCategoryButton.Location = new System.Drawing.Point(253, 76);
            this.AddCategoryButton.Name = "AddCategoryButton";
            this.AddCategoryButton.Size = new System.Drawing.Size(75, 23);
            this.AddCategoryButton.TabIndex = 1;
            this.AddCategoryButton.Text = "Add";
            this.AddCategoryButton.UseVisualStyleBackColor = true;
            this.AddCategoryButton.Click += new System.EventHandler(this.AddCategoryButton_Click_1);
            // 
            // ShowCategoryDataGridView
            // 
            this.ShowCategoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowCategoryDataGridView.Location = new System.Drawing.Point(97, 152);
            this.ShowCategoryDataGridView.Name = "ShowCategoryDataGridView";
            this.ShowCategoryDataGridView.Size = new System.Drawing.Size(240, 150);
            this.ShowCategoryDataGridView.TabIndex = 2;
            this.ShowCategoryDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ShowCategoryDataGridView_CellMouseDoubleClick);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(WinAppStockManagementSystem.Presentation_Layer.Category);
            // 
            // CategorySetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ShowCategoryDataGridView);
            this.Controls.Add(this.AddCategoryButton);
            this.Controls.Add(this.categoryNameTextBox);
            this.Name = "CategorySetup";
            this.Size = new System.Drawing.Size(505, 450);
            this.DoubleClick += new System.EventHandler(this.CategorySetup_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.ShowCategoryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.TextBox categoryNameTextBox;
        private System.Windows.Forms.Button AddCategoryButton;
        private System.Windows.Forms.DataGridView ShowCategoryDataGridView;
    }
}
