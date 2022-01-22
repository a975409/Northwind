using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Northwind
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void customizeDesing()
        {
            panelProductManagementSubMenu.Visible = false;
        }

        private void showSubPanel(Panel panel)
        {
            hideSubPanel();
            panel.Visible = true;
        }

        private void hideSubPanel()
        {
            if (panelProductManagementSubMenu.Visible)
                panelProductManagementSubMenu.Visible = false;
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
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        #region ProductManagementMenu

        private void BtnCategories_Click(object sender, EventArgs e)
        {
            hideSubPanel();
            openChildForm(new CategoriesForm());
        }
        private void BtnProducts_Click(object sender, EventArgs e)
        {
            hideSubPanel();
            openChildForm(new ProductsForm());
        }

        private void BtnSuppliers_Click(object sender, EventArgs e)
        {
            hideSubPanel();
        }
        #endregion

        private void BtnOrderManagement_Click(object sender, EventArgs e)
        {
            hideSubPanel();
        }

        private void BtnEmployeeManagement_Click(object sender, EventArgs e)
        {
            hideSubPanel();
        }

        private void BtnProductManagement_Click(object sender, EventArgs e)
        {
            showSubPanel(panelProductManagementSubMenu);
        }

        private void BtnCustomerManagement_Click(object sender, EventArgs e)
        {
            hideSubPanel();
        }
    }
}
