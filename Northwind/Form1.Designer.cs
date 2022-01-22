
namespace Northwind
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.BtnCustomerManagement = new System.Windows.Forms.Button();
            this.BtnOrderManagement = new System.Windows.Forms.Button();
            this.BtnEmployeeManagement = new System.Windows.Forms.Button();
            this.panelProductManagementSubMenu = new System.Windows.Forms.Panel();
            this.BtnSuppliers = new System.Windows.Forms.Button();
            this.BtnProducts = new System.Windows.Forms.Button();
            this.BtnCategories = new System.Windows.Forms.Button();
            this.BtnProductManagement = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            this.panelProductManagementSubMenu.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.BtnCustomerManagement);
            this.panelSideMenu.Controls.Add(this.BtnOrderManagement);
            this.panelSideMenu.Controls.Add(this.BtnEmployeeManagement);
            this.panelSideMenu.Controls.Add(this.panelProductManagementSubMenu);
            this.panelSideMenu.Controls.Add(this.BtnProductManagement);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 600);
            this.panelSideMenu.TabIndex = 0;
            // 
            // BtnCustomerManagement
            // 
            this.BtnCustomerManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCustomerManagement.FlatAppearance.BorderSize = 0;
            this.BtnCustomerManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCustomerManagement.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnCustomerManagement.ForeColor = System.Drawing.Color.White;
            this.BtnCustomerManagement.Location = new System.Drawing.Point(0, 409);
            this.BtnCustomerManagement.Name = "BtnCustomerManagement";
            this.BtnCustomerManagement.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnCustomerManagement.Size = new System.Drawing.Size(250, 58);
            this.BtnCustomerManagement.TabIndex = 6;
            this.BtnCustomerManagement.Text = "客戶資料";
            this.BtnCustomerManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCustomerManagement.UseVisualStyleBackColor = true;
            this.BtnCustomerManagement.Click += new System.EventHandler(this.BtnCustomerManagement_Click);
            // 
            // BtnOrderManagement
            // 
            this.BtnOrderManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnOrderManagement.FlatAppearance.BorderSize = 0;
            this.BtnOrderManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOrderManagement.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnOrderManagement.ForeColor = System.Drawing.Color.White;
            this.BtnOrderManagement.Location = new System.Drawing.Point(0, 351);
            this.BtnOrderManagement.Name = "BtnOrderManagement";
            this.BtnOrderManagement.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnOrderManagement.Size = new System.Drawing.Size(250, 58);
            this.BtnOrderManagement.TabIndex = 5;
            this.BtnOrderManagement.Text = "訂單管理";
            this.BtnOrderManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOrderManagement.UseVisualStyleBackColor = true;
            this.BtnOrderManagement.Click += new System.EventHandler(this.BtnOrderManagement_Click);
            // 
            // BtnEmployeeManagement
            // 
            this.BtnEmployeeManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnEmployeeManagement.FlatAppearance.BorderSize = 0;
            this.BtnEmployeeManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEmployeeManagement.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnEmployeeManagement.ForeColor = System.Drawing.Color.White;
            this.BtnEmployeeManagement.Location = new System.Drawing.Point(0, 293);
            this.BtnEmployeeManagement.Name = "BtnEmployeeManagement";
            this.BtnEmployeeManagement.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnEmployeeManagement.Size = new System.Drawing.Size(250, 58);
            this.BtnEmployeeManagement.TabIndex = 3;
            this.BtnEmployeeManagement.Text = "員工管理";
            this.BtnEmployeeManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEmployeeManagement.UseVisualStyleBackColor = true;
            this.BtnEmployeeManagement.Click += new System.EventHandler(this.BtnEmployeeManagement_Click);
            // 
            // panelProductManagementSubMenu
            // 
            this.panelProductManagementSubMenu.AutoSize = true;
            this.panelProductManagementSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelProductManagementSubMenu.Controls.Add(this.BtnSuppliers);
            this.panelProductManagementSubMenu.Controls.Add(this.BtnProducts);
            this.panelProductManagementSubMenu.Controls.Add(this.BtnCategories);
            this.panelProductManagementSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProductManagementSubMenu.Location = new System.Drawing.Point(0, 152);
            this.panelProductManagementSubMenu.Name = "panelProductManagementSubMenu";
            this.panelProductManagementSubMenu.Size = new System.Drawing.Size(250, 141);
            this.panelProductManagementSubMenu.TabIndex = 2;
            // 
            // BtnSuppliers
            // 
            this.BtnSuppliers.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSuppliers.FlatAppearance.BorderSize = 0;
            this.BtnSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSuppliers.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnSuppliers.ForeColor = System.Drawing.Color.White;
            this.BtnSuppliers.Location = new System.Drawing.Point(0, 94);
            this.BtnSuppliers.Name = "BtnSuppliers";
            this.BtnSuppliers.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BtnSuppliers.Size = new System.Drawing.Size(250, 47);
            this.BtnSuppliers.TabIndex = 2;
            this.BtnSuppliers.Text = "製造商";
            this.BtnSuppliers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSuppliers.UseVisualStyleBackColor = true;
            this.BtnSuppliers.Click += new System.EventHandler(this.BtnSuppliers_Click);
            // 
            // BtnProducts
            // 
            this.BtnProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnProducts.FlatAppearance.BorderSize = 0;
            this.BtnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProducts.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnProducts.ForeColor = System.Drawing.Color.White;
            this.BtnProducts.Location = new System.Drawing.Point(0, 47);
            this.BtnProducts.Name = "BtnProducts";
            this.BtnProducts.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BtnProducts.Size = new System.Drawing.Size(250, 47);
            this.BtnProducts.TabIndex = 1;
            this.BtnProducts.Text = "所有產品";
            this.BtnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProducts.UseVisualStyleBackColor = true;
            this.BtnProducts.Click += new System.EventHandler(this.BtnProducts_Click);
            // 
            // BtnCategories
            // 
            this.BtnCategories.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCategories.FlatAppearance.BorderSize = 0;
            this.BtnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCategories.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnCategories.ForeColor = System.Drawing.Color.White;
            this.BtnCategories.Location = new System.Drawing.Point(0, 0);
            this.BtnCategories.Name = "BtnCategories";
            this.BtnCategories.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BtnCategories.Size = new System.Drawing.Size(250, 47);
            this.BtnCategories.TabIndex = 0;
            this.BtnCategories.Text = "產品種類";
            this.BtnCategories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCategories.UseVisualStyleBackColor = true;
            this.BtnCategories.Click += new System.EventHandler(this.BtnCategories_Click);
            // 
            // BtnProductManagement
            // 
            this.BtnProductManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnProductManagement.FlatAppearance.BorderSize = 0;
            this.BtnProductManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProductManagement.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnProductManagement.ForeColor = System.Drawing.Color.White;
            this.BtnProductManagement.Location = new System.Drawing.Point(0, 94);
            this.BtnProductManagement.Name = "BtnProductManagement";
            this.BtnProductManagement.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnProductManagement.Size = new System.Drawing.Size(250, 58);
            this.BtnProductManagement.TabIndex = 1;
            this.BtnProductManagement.Text = "產品管理";
            this.BtnProductManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProductManagement.UseVisualStyleBackColor = true;
            this.BtnProductManagement.Click += new System.EventHandler(this.BtnProductManagement_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 94);
            this.panelLogo.TabIndex = 0;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelChildForm.Controls.Add(this.pictureBox1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 0);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(700, 600);
            this.panelChildForm.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(246, 178);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Northwind Management";
            this.panelSideMenu.ResumeLayout(false);
            this.panelSideMenu.PerformLayout();
            this.panelProductManagementSubMenu.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button BtnCustomerManagement;
        private System.Windows.Forms.Button BtnOrderManagement;
        private System.Windows.Forms.Button BtnEmployeeManagement;
        private System.Windows.Forms.Panel panelProductManagementSubMenu;
        private System.Windows.Forms.Button BtnSuppliers;
        private System.Windows.Forms.Button BtnProducts;
        private System.Windows.Forms.Button BtnCategories;
        private System.Windows.Forms.Button BtnProductManagement;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

