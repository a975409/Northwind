
namespace Management_System
{
    partial class CategoriesForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoriesForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label categoryNameLabel;
            System.Windows.Forms.Label descriptionLabel;
            this.BtnInsertEmployee = new System.Windows.Forms.Button();
            this.BtnEditEmployee = new System.Windows.Forms.Button();
            this.BtnDeleteEmployee = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnPic = new System.Windows.Forms.Button();
            this.BtnMoveLastItem = new System.Windows.Forms.Button();
            this.LblPage = new System.Windows.Forms.Label();
            this.BtnMoveFirstItem = new System.Windows.Forms.Button();
            this.BtnMovePreviousItem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnMoveNextItem = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.categoriesDataGridView = new System.Windows.Forms.DataGridView();
            this.categoryNameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.northwindDataSet = new Management_System.NorthwindDataSet();
            this.categoriesTableAdapter = new Management_System.NorthwindDataSetTableAdapters.CategoriesTableAdapter();
            this.tableAdapterManager = new Management_System.NorthwindDataSetTableAdapters.TableAdapterManager();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            categoryNameLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnInsertEmployee
            // 
            this.BtnInsertEmployee.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnInsertEmployee.Location = new System.Drawing.Point(286, 249);
            this.BtnInsertEmployee.Name = "BtnInsertEmployee";
            this.BtnInsertEmployee.Size = new System.Drawing.Size(103, 31);
            this.BtnInsertEmployee.TabIndex = 36;
            this.BtnInsertEmployee.Text = "新增";
            this.BtnInsertEmployee.UseVisualStyleBackColor = true;
            this.BtnInsertEmployee.Click += new System.EventHandler(this.BtnInsertEmployee_Click);
            // 
            // BtnEditEmployee
            // 
            this.BtnEditEmployee.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnEditEmployee.Location = new System.Drawing.Point(390, 249);
            this.BtnEditEmployee.Name = "BtnEditEmployee";
            this.BtnEditEmployee.Size = new System.Drawing.Size(103, 31);
            this.BtnEditEmployee.TabIndex = 36;
            this.BtnEditEmployee.Text = "編輯";
            this.BtnEditEmployee.UseVisualStyleBackColor = true;
            this.BtnEditEmployee.Click += new System.EventHandler(this.BtnEditEmployee_Click);
            // 
            // BtnDeleteEmployee
            // 
            this.BtnDeleteEmployee.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnDeleteEmployee.Location = new System.Drawing.Point(494, 249);
            this.BtnDeleteEmployee.Name = "BtnDeleteEmployee";
            this.BtnDeleteEmployee.Size = new System.Drawing.Size(103, 31);
            this.BtnDeleteEmployee.TabIndex = 36;
            this.BtnDeleteEmployee.Text = "刪除";
            this.BtnDeleteEmployee.UseVisualStyleBackColor = true;
            this.BtnDeleteEmployee.Click += new System.EventHandler(this.BtnDeleteEmployee_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox1.Location = new System.Drawing.Point(287, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // BtnPic
            // 
            this.BtnPic.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnPic.Location = new System.Drawing.Point(286, 281);
            this.BtnPic.Name = "BtnPic";
            this.BtnPic.Size = new System.Drawing.Size(311, 31);
            this.BtnPic.TabIndex = 36;
            this.BtnPic.Text = "上傳圖片";
            this.BtnPic.UseVisualStyleBackColor = true;
            this.BtnPic.Click += new System.EventHandler(this.BtnPic_Click);
            // 
            // BtnMoveLastItem
            // 
            this.BtnMoveLastItem.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnMoveLastItem.FlatAppearance.BorderSize = 0;
            this.BtnMoveLastItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("BtnMoveLastItem.Image")));
            this.BtnMoveLastItem.Location = new System.Drawing.Point(223, 0);
            this.BtnMoveLastItem.Name = "BtnMoveLastItem";
            this.BtnMoveLastItem.Size = new System.Drawing.Size(44, 65);
            this.BtnMoveLastItem.TabIndex = 47;
            this.BtnMoveLastItem.UseVisualStyleBackColor = true;
            this.BtnMoveLastItem.Click += new System.EventHandler(this.BtnMoveLastItem_Click);
            // 
            // LblPage
            // 
            this.LblPage.BackColor = System.Drawing.Color.White;
            this.LblPage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPage.Location = new System.Drawing.Point(92, 14);
            this.LblPage.Name = "LblPage";
            this.LblPage.Size = new System.Drawing.Size(85, 36);
            this.LblPage.TabIndex = 43;
            this.LblPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnMoveFirstItem
            // 
            this.BtnMoveFirstItem.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnMoveFirstItem.FlatAppearance.BorderSize = 0;
            this.BtnMoveFirstItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("BtnMoveFirstItem.Image")));
            this.BtnMoveFirstItem.Location = new System.Drawing.Point(0, 0);
            this.BtnMoveFirstItem.Name = "BtnMoveFirstItem";
            this.BtnMoveFirstItem.Size = new System.Drawing.Size(44, 65);
            this.BtnMoveFirstItem.TabIndex = 44;
            this.BtnMoveFirstItem.UseVisualStyleBackColor = true;
            this.BtnMoveFirstItem.Click += new System.EventHandler(this.BtnMoveFirstItem_Click);
            // 
            // BtnMovePreviousItem
            // 
            this.BtnMovePreviousItem.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnMovePreviousItem.FlatAppearance.BorderSize = 0;
            this.BtnMovePreviousItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("BtnMovePreviousItem.Image")));
            this.BtnMovePreviousItem.Location = new System.Drawing.Point(44, 0);
            this.BtnMovePreviousItem.Name = "BtnMovePreviousItem";
            this.BtnMovePreviousItem.Size = new System.Drawing.Size(44, 65);
            this.BtnMovePreviousItem.TabIndex = 45;
            this.BtnMovePreviousItem.UseVisualStyleBackColor = true;
            this.BtnMovePreviousItem.Click += new System.EventHandler(this.BtnMovePreviousItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel1.Controls.Add(this.BtnMoveNextItem);
            this.panel1.Controls.Add(this.BtnMoveLastItem);
            this.panel1.Controls.Add(this.BtnMovePreviousItem);
            this.panel1.Controls.Add(this.BtnMoveFirstItem);
            this.panel1.Controls.Add(this.LblPage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 702);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 65);
            this.panel1.TabIndex = 48;
            // 
            // BtnMoveNextItem
            // 
            this.BtnMoveNextItem.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnMoveNextItem.FlatAppearance.BorderSize = 0;
            this.BtnMoveNextItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("BtnMoveNextItem.Image")));
            this.BtnMoveNextItem.Location = new System.Drawing.Point(179, 0);
            this.BtnMoveNextItem.Name = "BtnMoveNextItem";
            this.BtnMoveNextItem.Size = new System.Drawing.Size(44, 65);
            this.BtnMoveNextItem.TabIndex = 50;
            this.BtnMoveNextItem.UseVisualStyleBackColor = true;
            this.BtnMoveNextItem.Click += new System.EventHandler(this.BtnMoveNextItem_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.Location = new System.Drawing.Point(985, 3);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(35, 31);
            this.BtnClose.TabIndex = 49;
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnSave.Location = new System.Drawing.Point(286, 313);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(311, 31);
            this.BtnSave.TabIndex = 36;
            this.BtnSave.Text = "儲存";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnCancel.Location = new System.Drawing.Point(286, 345);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(311, 31);
            this.BtnCancel.TabIndex = 36;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // categoriesDataGridView
            // 
            this.categoriesDataGridView.AllowUserToAddRows = false;
            this.categoriesDataGridView.AllowUserToDeleteRows = false;
            this.categoriesDataGridView.AutoGenerateColumns = false;
            this.categoriesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoriesDataGridView.ColumnHeadersVisible = false;
            this.categoriesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.categoriesDataGridView.DataSource = this.categoriesBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.categoriesDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.categoriesDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.categoriesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.categoriesDataGridView.Name = "categoriesDataGridView";
            this.categoriesDataGridView.ReadOnly = true;
            this.categoriesDataGridView.RowTemplate.Height = 40;
            this.categoriesDataGridView.Size = new System.Drawing.Size(267, 713);
            this.categoriesDataGridView.TabIndex = 50;
            // 
            // categoryNameLabel
            // 
            categoryNameLabel.AutoSize = true;
            categoryNameLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            categoryNameLabel.Location = new System.Drawing.Point(618, 25);
            categoryNameLabel.Name = "categoryNameLabel";
            categoryNameLabel.Size = new System.Drawing.Size(73, 20);
            categoryNameLabel.TabIndex = 52;
            categoryNameLabel.Text = "產品種類";
            // 
            // categoryNameTextBox
            // 
            this.categoryNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriesBindingSource, "CategoryName", true));
            this.categoryNameTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.categoryNameTextBox.Location = new System.Drawing.Point(622, 48);
            this.categoryNameTextBox.Name = "categoryNameTextBox";
            this.categoryNameTextBox.Size = new System.Drawing.Size(224, 29);
            this.categoryNameTextBox.TabIndex = 53;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            descriptionLabel.Location = new System.Drawing.Point(618, 94);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(77, 20);
            descriptionLabel.TabIndex = 54;
            descriptionLabel.Text = "產品敘述:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriesBindingSource, "Description", true));
            this.descriptionTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.descriptionTextBox.Location = new System.Drawing.Point(622, 117);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(364, 29);
            this.descriptionTextBox.TabIndex = 55;
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.northwindDataSet;
            this.categoriesBindingSource.CurrentChanged += new System.EventHandler(this.categoriesBindingSource_CurrentChanged);
            // 
            // northwindDataSet
            // 
            this.northwindDataSet.DataSetName = "NorthwindDataSet";
            this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = this.categoriesTableAdapter;
            this.tableAdapterManager.CustomerCustomerDemoTableAdapter = null;
            this.tableAdapterManager.CustomerDemographicsTableAdapter = null;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.EmployeeTerritoriesTableAdapter = null;
            this.tableAdapterManager.Order_DetailsTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.RegionTableAdapter = null;
            this.tableAdapterManager.ShippersTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.TerritoriesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Management_System.NorthwindDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.categoriesDataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 767);
            this.panel2.TabIndex = 56;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CategoryName";
            this.dataGridViewTextBoxColumn2.HeaderText = "產品種類";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 230;
            // 
            // CategoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 767);
            this.Controls.Add(this.panel2);
            this.Controls.Add(categoryNameLabel);
            this.Controls.Add(this.categoryNameTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnDeleteEmployee);
            this.Controls.Add(this.BtnEditEmployee);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnPic);
            this.Controls.Add(this.BtnInsertEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoriesForm";
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.CategoriesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categoriesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnInsertEmployee;
        private System.Windows.Forms.Button BtnEditEmployee;
        private System.Windows.Forms.Button BtnDeleteEmployee;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnPic;
        private System.Windows.Forms.Button BtnMoveLastItem;
        private System.Windows.Forms.Label LblPage;
        private System.Windows.Forms.Button BtnMoveFirstItem;
        private System.Windows.Forms.Button BtnMovePreviousItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnMoveNextItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private NorthwindDataSet northwindDataSet;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private NorthwindDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private NorthwindDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView categoriesDataGridView;
        private System.Windows.Forms.TextBox categoryNameTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}