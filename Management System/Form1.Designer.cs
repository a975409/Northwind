
namespace Management_System
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.BtnCustomerService = new System.Windows.Forms.Button();
            this.panelCompanyService = new System.Windows.Forms.Panel();
            this.BtnShippers = new System.Windows.Forms.Button();
            this.BtnSuppliers = new System.Windows.Forms.Button();
            this.BtnCompanyService = new System.Windows.Forms.Button();
            this.BtnOrderService = new System.Windows.Forms.Button();
            this.panelEmployeeService = new System.Windows.Forms.Panel();
            this.BtnRegionTerritory = new System.Windows.Forms.Button();
            this.BtnEmployees = new System.Windows.Forms.Button();
            this.BtnEmployeeService = new System.Windows.Forms.Button();
            this.panelProductService = new System.Windows.Forms.Panel();
            this.BtnProducts = new System.Windows.Forms.Button();
            this.BtnCategories = new System.Windows.Forms.Button();
            this.BtnProductService = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.BtnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelCompanyService.SuspendLayout();
            this.panelEmployeeService.SuspendLayout();
            this.panelProductService.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.splitContainer1.Panel1.Controls.Add(this.BtnCustomerService);
            this.splitContainer1.Panel1.Controls.Add(this.panelCompanyService);
            this.splitContainer1.Panel1.Controls.Add(this.BtnCompanyService);
            this.splitContainer1.Panel1.Controls.Add(this.BtnOrderService);
            this.splitContainer1.Panel1.Controls.Add(this.panelEmployeeService);
            this.splitContainer1.Panel1.Controls.Add(this.BtnEmployeeService);
            this.splitContainer1.Panel1.Controls.Add(this.panelProductService);
            this.splitContainer1.Panel1.Controls.Add(this.BtnProductService);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.BtnExit);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.GhostWhite;
            this.splitContainer1.Size = new System.Drawing.Size(1272, 796);
            this.splitContainer1.SplitterDistance = 186;
            this.splitContainer1.TabIndex = 0;
            // 
            // BtnCustomerService
            // 
            this.BtnCustomerService.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCustomerService.FlatAppearance.BorderSize = 0;
            this.BtnCustomerService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCustomerService.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnCustomerService.ForeColor = System.Drawing.SystemColors.Window;
            this.BtnCustomerService.Location = new System.Drawing.Point(0, 636);
            this.BtnCustomerService.Name = "BtnCustomerService";
            this.BtnCustomerService.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.BtnCustomerService.Size = new System.Drawing.Size(186, 65);
            this.BtnCustomerService.TabIndex = 14;
            this.BtnCustomerService.Text = "客戶資料";
            this.BtnCustomerService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCustomerService.UseVisualStyleBackColor = true;
            this.BtnCustomerService.Click += new System.EventHandler(this.BtnService_Click);
            // 
            // panelCompanyService
            // 
            this.panelCompanyService.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelCompanyService.Controls.Add(this.BtnShippers);
            this.panelCompanyService.Controls.Add(this.BtnSuppliers);
            this.panelCompanyService.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCompanyService.Location = new System.Drawing.Point(0, 536);
            this.panelCompanyService.Name = "panelCompanyService";
            this.panelCompanyService.Size = new System.Drawing.Size(186, 100);
            this.panelCompanyService.TabIndex = 13;
            // 
            // BtnShippers
            // 
            this.BtnShippers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnShippers.FlatAppearance.BorderSize = 0;
            this.BtnShippers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnShippers.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnShippers.ForeColor = System.Drawing.Color.White;
            this.BtnShippers.Image = ((System.Drawing.Image)(resources.GetObject("BtnShippers.Image")));
            this.BtnShippers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnShippers.Location = new System.Drawing.Point(0, 50);
            this.BtnShippers.Name = "BtnShippers";
            this.BtnShippers.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnShippers.Size = new System.Drawing.Size(186, 50);
            this.BtnShippers.TabIndex = 1;
            this.BtnShippers.Text = "運貨商";
            this.BtnShippers.UseVisualStyleBackColor = true;
            // 
            // BtnSuppliers
            // 
            this.BtnSuppliers.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSuppliers.FlatAppearance.BorderSize = 0;
            this.BtnSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSuppliers.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnSuppliers.ForeColor = System.Drawing.Color.White;
            this.BtnSuppliers.Image = ((System.Drawing.Image)(resources.GetObject("BtnSuppliers.Image")));
            this.BtnSuppliers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSuppliers.Location = new System.Drawing.Point(0, 0);
            this.BtnSuppliers.Name = "BtnSuppliers";
            this.BtnSuppliers.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnSuppliers.Size = new System.Drawing.Size(186, 50);
            this.BtnSuppliers.TabIndex = 1;
            this.BtnSuppliers.Text = "供應商";
            this.BtnSuppliers.UseVisualStyleBackColor = true;
            // 
            // BtnCompanyService
            // 
            this.BtnCompanyService.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCompanyService.FlatAppearance.BorderSize = 0;
            this.BtnCompanyService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCompanyService.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnCompanyService.ForeColor = System.Drawing.SystemColors.Window;
            this.BtnCompanyService.Location = new System.Drawing.Point(0, 471);
            this.BtnCompanyService.Name = "BtnCompanyService";
            this.BtnCompanyService.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.BtnCompanyService.Size = new System.Drawing.Size(186, 65);
            this.BtnCompanyService.TabIndex = 12;
            this.BtnCompanyService.Text = "廠商管理";
            this.BtnCompanyService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCompanyService.UseVisualStyleBackColor = true;
            this.BtnCompanyService.Click += new System.EventHandler(this.BtnService_Click);
            // 
            // BtnOrderService
            // 
            this.BtnOrderService.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnOrderService.FlatAppearance.BorderSize = 0;
            this.BtnOrderService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOrderService.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnOrderService.ForeColor = System.Drawing.SystemColors.Window;
            this.BtnOrderService.Location = new System.Drawing.Point(0, 406);
            this.BtnOrderService.Name = "BtnOrderService";
            this.BtnOrderService.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.BtnOrderService.Size = new System.Drawing.Size(186, 65);
            this.BtnOrderService.TabIndex = 10;
            this.BtnOrderService.Text = "訂單管理";
            this.BtnOrderService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOrderService.UseVisualStyleBackColor = true;
            this.BtnOrderService.Click += new System.EventHandler(this.BtnService_Click);
            // 
            // panelEmployeeService
            // 
            this.panelEmployeeService.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelEmployeeService.Controls.Add(this.BtnRegionTerritory);
            this.panelEmployeeService.Controls.Add(this.BtnEmployees);
            this.panelEmployeeService.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEmployeeService.Location = new System.Drawing.Point(0, 306);
            this.panelEmployeeService.Name = "panelEmployeeService";
            this.panelEmployeeService.Size = new System.Drawing.Size(186, 100);
            this.panelEmployeeService.TabIndex = 9;
            // 
            // BtnRegionTerritory
            // 
            this.BtnRegionTerritory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnRegionTerritory.FlatAppearance.BorderSize = 0;
            this.BtnRegionTerritory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegionTerritory.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnRegionTerritory.ForeColor = System.Drawing.Color.White;
            this.BtnRegionTerritory.Image = ((System.Drawing.Image)(resources.GetObject("BtnRegionTerritory.Image")));
            this.BtnRegionTerritory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegionTerritory.Location = new System.Drawing.Point(0, 52);
            this.BtnRegionTerritory.Name = "BtnRegionTerritory";
            this.BtnRegionTerritory.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnRegionTerritory.Size = new System.Drawing.Size(186, 48);
            this.BtnRegionTerritory.TabIndex = 1;
            this.BtnRegionTerritory.Text = "銷售區域";
            this.BtnRegionTerritory.UseVisualStyleBackColor = true;
            // 
            // BtnEmployees
            // 
            this.BtnEmployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnEmployees.FlatAppearance.BorderSize = 0;
            this.BtnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEmployees.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnEmployees.ForeColor = System.Drawing.Color.White;
            this.BtnEmployees.Image = ((System.Drawing.Image)(resources.GetObject("BtnEmployees.Image")));
            this.BtnEmployees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEmployees.Location = new System.Drawing.Point(0, 0);
            this.BtnEmployees.Name = "BtnEmployees";
            this.BtnEmployees.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnEmployees.Size = new System.Drawing.Size(186, 52);
            this.BtnEmployees.TabIndex = 1;
            this.BtnEmployees.Text = "員工清單";
            this.BtnEmployees.UseVisualStyleBackColor = true;
            this.BtnEmployees.Click += new System.EventHandler(this.BtnEmployees_Click);
            // 
            // BtnEmployeeService
            // 
            this.BtnEmployeeService.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnEmployeeService.FlatAppearance.BorderSize = 0;
            this.BtnEmployeeService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEmployeeService.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnEmployeeService.ForeColor = System.Drawing.SystemColors.Window;
            this.BtnEmployeeService.Location = new System.Drawing.Point(0, 241);
            this.BtnEmployeeService.Name = "BtnEmployeeService";
            this.BtnEmployeeService.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.BtnEmployeeService.Size = new System.Drawing.Size(186, 65);
            this.BtnEmployeeService.TabIndex = 8;
            this.BtnEmployeeService.Text = "員工管理";
            this.BtnEmployeeService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEmployeeService.UseVisualStyleBackColor = true;
            this.BtnEmployeeService.Click += new System.EventHandler(this.BtnService_Click);
            // 
            // panelProductService
            // 
            this.panelProductService.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelProductService.Controls.Add(this.BtnProducts);
            this.panelProductService.Controls.Add(this.BtnCategories);
            this.panelProductService.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProductService.Location = new System.Drawing.Point(0, 147);
            this.panelProductService.Name = "panelProductService";
            this.panelProductService.Size = new System.Drawing.Size(186, 94);
            this.panelProductService.TabIndex = 7;
            // 
            // BtnProducts
            // 
            this.BtnProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnProducts.FlatAppearance.BorderSize = 0;
            this.BtnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProducts.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnProducts.ForeColor = System.Drawing.Color.White;
            this.BtnProducts.Image = ((System.Drawing.Image)(resources.GetObject("BtnProducts.Image")));
            this.BtnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProducts.Location = new System.Drawing.Point(0, 50);
            this.BtnProducts.Name = "BtnProducts";
            this.BtnProducts.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnProducts.Size = new System.Drawing.Size(186, 44);
            this.BtnProducts.TabIndex = 1;
            this.BtnProducts.Text = "產品清單";
            this.BtnProducts.UseVisualStyleBackColor = true;
            this.BtnProducts.Click += new System.EventHandler(this.BtnProducts_Click);
            // 
            // BtnCategories
            // 
            this.BtnCategories.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCategories.FlatAppearance.BorderSize = 0;
            this.BtnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCategories.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnCategories.ForeColor = System.Drawing.Color.White;
            this.BtnCategories.Image = ((System.Drawing.Image)(resources.GetObject("BtnCategories.Image")));
            this.BtnCategories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCategories.Location = new System.Drawing.Point(0, 0);
            this.BtnCategories.Name = "BtnCategories";
            this.BtnCategories.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnCategories.Size = new System.Drawing.Size(186, 50);
            this.BtnCategories.TabIndex = 0;
            this.BtnCategories.Text = "產品種類";
            this.BtnCategories.UseVisualStyleBackColor = true;
            this.BtnCategories.Click += new System.EventHandler(this.BtnCategories_Click);
            // 
            // BtnProductService
            // 
            this.BtnProductService.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnProductService.FlatAppearance.BorderSize = 0;
            this.BtnProductService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProductService.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnProductService.ForeColor = System.Drawing.SystemColors.Window;
            this.BtnProductService.Location = new System.Drawing.Point(0, 82);
            this.BtnProductService.Name = "BtnProductService";
            this.BtnProductService.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.BtnProductService.Size = new System.Drawing.Size(186, 65);
            this.BtnProductService.TabIndex = 6;
            this.BtnProductService.Text = "產品管理";
            this.BtnProductService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProductService.UseVisualStyleBackColor = false;
            this.BtnProductService.Click += new System.EventHandler(this.BtnService_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PicLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 82);
            this.panel1.TabIndex = 0;
            // 
            // PicLogo
            // 
            this.PicLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PicLogo.Image = ((System.Drawing.Image)(resources.GetObject("PicLogo.Image")));
            this.PicLogo.Location = new System.Drawing.Point(0, 0);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(186, 82);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PicLogo.TabIndex = 0;
            this.PicLogo.TabStop = false;
            // 
            // BtnExit
            // 
            this.BtnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnExit.ForeColor = System.Drawing.SystemColors.Window;
            this.BtnExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.Image")));
            this.BtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExit.Location = new System.Drawing.Point(0, 719);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnExit.Size = new System.Drawing.Size(186, 77);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.Text = "結束";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 796);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelCompanyService.ResumeLayout(false);
            this.panelEmployeeService.ResumeLayout(false);
            this.panelProductService.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnProductService;
        private System.Windows.Forms.Button BtnCustomerService;
        private System.Windows.Forms.Panel panelCompanyService;
        private System.Windows.Forms.Button BtnCompanyService;
        private System.Windows.Forms.Button BtnOrderService;
        private System.Windows.Forms.Panel panelEmployeeService;
        private System.Windows.Forms.Button BtnEmployeeService;
        private System.Windows.Forms.Panel panelProductService;
        private System.Windows.Forms.Button BtnProducts;
        private System.Windows.Forms.Button BtnCategories;
        private System.Windows.Forms.Button BtnRegionTerritory;
        private System.Windows.Forms.Button BtnEmployees;
        private System.Windows.Forms.Button BtnShippers;
        private System.Windows.Forms.Button BtnSuppliers;
        private System.Windows.Forms.PictureBox PicLogo;
    }
}

