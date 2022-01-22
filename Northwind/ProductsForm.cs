using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind
{
    public partial class ProductsForm : Form
    {
        private CurrentState currentState = CurrentState.none;
        private int currentPage = 0;
        private readonly int pageSize = 10;
        private BindingSource bindingSource = new BindingSource();

        #region FormControlMethod 變更Form表單內控制項屬性的方法
        private enum CurrentState
        {
            none, insert, edit
        }

        private void getCurrentProduct(int page, int size)
        {
            // TODO: 這行程式碼會將資料載入 'northwindDataSet.Products' 資料表。您可以視需要進行移動或移除。
            this.productsTableAdapter.Fill(this.northwindDataSet.Products, currentPage * pageSize, pageSize);
            LblPage.Text = (page + 1).ToString();
        }

        private void initControlSetting()
        {
            BtnMoveFirstItem.Cursor = Cursors.Hand;
            BtnMovePreviousItem.Cursor = Cursors.Hand;
            BtnMoveNextItem.Cursor = Cursors.Hand;
            BtnMovePreviousItem.Cursor = Cursors.Hand;
            BtnMoveLastItem.Cursor = Cursors.Hand;
        }

        #endregion

        public ProductsForm()
        {
            InitializeComponent();
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            initControlSetting();

            // TODO: 這行程式碼會將資料載入 'northwindDataSet.Categories' 資料表。您可以視需要進行移動或移除。
            this.categoriesTableAdapter.Fill(this.northwindDataSet.Categories);
            // TODO: 這行程式碼會將資料載入 'northwindDataSet.Suppliers' 資料表。您可以視需要進行移動或移除。
            this.suppliersTableAdapter.Fill(this.northwindDataSet.Suppliers);
            
            getCurrentProduct(currentPage, pageSize);
        }


        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMoveFirstItem_Click(object sender, EventArgs e)
        {
            currentPage = 0;
            getCurrentProduct(currentPage, pageSize);
        }

        private void BtnMovePreviousItem_Click(object sender, EventArgs e)
        {
            if (currentPage > 0)
            {
                currentPage--;
                getCurrentProduct(currentPage, pageSize);
            }
        }

        private void BtnMoveNextItem_Click(object sender, EventArgs e)
        {
            if (productsDataGridView.Rows.Count >= pageSize) 
            {
                currentPage++;
                getCurrentProduct(currentPage, pageSize);
            }
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwindDataSet);
        }

        private void BtnMoveLastItem_Click(object sender, EventArgs e)
        {
            if (this.productsTableAdapter.GetScalarQueryCount() != null)
            {
                int count = (int)this.productsTableAdapter.GetScalarQueryCount();

                if (count % pageSize > 0)
                    currentPage = count / pageSize;
                else
                    currentPage = count / pageSize - 1;

                getCurrentProduct(currentPage, pageSize);
            }
        }

        private void bindingNavigatorCancelItem_Click(object sender, EventArgs e)
        {
            this.productsBindingSource.CancelEdit();
            productsDataGridView.ReadOnly = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            productsDataGridView.ReadOnly = false;
        }

        private void productsDataGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            this.productsBindingSource.CancelEdit();
            productsDataGridView.ReadOnly = true;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            productsDataGridView.ReadOnly = false;
        }

        private void productsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            

        }
    }
}
