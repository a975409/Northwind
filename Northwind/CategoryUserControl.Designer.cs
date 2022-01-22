
namespace Northwind
{
    partial class CategoryUserControl
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

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.PicImage = new System.Windows.Forms.PictureBox();
            this.LblName = new System.Windows.Forms.Label();
            this.panelCategory = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PicImage)).BeginInit();
            this.panelCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // PicImage
            // 
            this.PicImage.Location = new System.Drawing.Point(0, 0);
            this.PicImage.Margin = new System.Windows.Forms.Padding(0);
            this.PicImage.Name = "PicImage";
            this.PicImage.Size = new System.Drawing.Size(172, 120);
            this.PicImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicImage.TabIndex = 0;
            this.PicImage.TabStop = false;
            this.PicImage.Click += new System.EventHandler(this.getProducts);
            this.PicImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PicImage_MouseMove);
            // 
            // LblName
            // 
            this.LblName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.LblName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LblName.Location = new System.Drawing.Point(30, 47);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(112, 27);
            this.LblName.TabIndex = 1;
            this.LblName.Text = "label1";
            this.LblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblName.Click += new System.EventHandler(this.getProducts);
            this.LblName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LblName_MouseMove);
            // 
            // panelCategory
            // 
            this.panelCategory.Controls.Add(this.LblName);
            this.panelCategory.Controls.Add(this.PicImage);
            this.panelCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCategory.Location = new System.Drawing.Point(0, 0);
            this.panelCategory.Name = "panelCategory";
            this.panelCategory.Size = new System.Drawing.Size(172, 120);
            this.panelCategory.TabIndex = 2;
            // 
            // CategoryUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelCategory);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "CategoryUserControl";
            this.Size = new System.Drawing.Size(172, 120);
            this.Load += new System.EventHandler(this.CategoryUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicImage)).EndInit();
            this.panelCategory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicImage;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Panel panelCategory;
    }
}
