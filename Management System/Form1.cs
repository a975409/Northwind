using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 依據點擊左側大按鈕顯示對應的子選單
        /// </summary>
        /// <param name="button"></param>
        private void TriggerShowLeftPanel(Button button)
        {
            if (button.Name == "BtnProductService")
            {
                panelProductService.Visible = true;
            }
            else 
            {
                if (panelProductService.Visible)
                    panelProductService.Visible = false;
            }

            if (button.Name == "BtnEmployeeService")
            {
                panelEmployeeService.Visible = true;
            }
            else
            {
                if (panelEmployeeService.Visible)
                    panelEmployeeService.Visible = false;
            }

            if (button.Name == "BtnCompanyService")
            {
                panelCompanyService.Visible = true;
            }
            else
            {
                if (panelCompanyService.Visible)
                    panelCompanyService.Visible = false;
            }
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1200, 750);
            panelCompanyService.Visible = false;
            panelEmployeeService.Visible = false;
            panelProductService.Visible = false;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnService_Click(object sender, EventArgs e)
        {
            TriggerShowLeftPanel((Button)sender);
        }

        private void BtnEmployees_Click(object sender, EventArgs e)
        {
            openChildForm(new EmployeeForm());
        }

        private void BtnCategories_Click(object sender, EventArgs e)
        {
            openChildForm(new CategoriesForm());
        }

        private void BtnProducts_Click(object sender, EventArgs e)
        {
            openChildForm(new ProductsForm());
        }
    }
}
