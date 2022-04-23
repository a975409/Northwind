using Northwind;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Management_System
{
    public partial class ProductsForm : Form
    {
        private int currentPage = 0;
        private readonly int pageSize = 4;
        private int maxPage = 0;

        //紀錄現在執行的狀態
        private currentState currentState = currentState.none;
   
        #region 針對此Form的控制項所寫的方法
        /// <summary>
        /// 指定頁數和單一頁數取得某個範圍區間的員工資料
        /// </summary>
        /// <param name="page">顯示第幾頁的資料</param>
        /// <param name="size">單頁最多資料筆數</param>
        private void GetCurrentPageData(int page, int size)
        {
            int count;
            try
            {
                //取得總資料筆數
                count = (int)this.productsTableAdapter.GetScalarQueryCount();
            }
            catch
            {
                page = 0;
                maxPage = 0;
                LblPage.Text = (page + 1).ToString();
                return;
            }

            //設定最大頁數
            maxPage = (count / pageSize) - 1;

            if (count % pageSize > 0)
                maxPage += 1;
            
            //取得某個範圍區間的資料(從資料庫取得的資料寫入至 northwindDataSet.Employees )
            this.productsTableAdapter.FillByPageSize(northwindDataSet.Products, currentPage * pageSize, size);
            LblPage.Text = (page + 1).ToString();
        }

        /// <summary>
        /// 針對部分控制項做初始化設定
        /// </summary>
        private void initControlSetting()
        {
            BtnMoveFirstItem.Cursor = Cursors.Hand;
            BtnMovePreviousItem.Cursor = Cursors.Hand;
            BtnMoveNextItem.Cursor = Cursors.Hand;
            BtnMovePreviousItem.Cursor = Cursors.Hand;
            BtnMoveLastItem.Cursor = Cursors.Hand;
        }

        /// <summary>
        /// 當使用者正在新增/編輯模式時，會針對部分的控制項做狀態切換
        /// </summary>
        /// <param name="ReadOnly">true:無法操作控制項，false:可操作控制項</param>
        private void EditControl(bool ReadOnly)
        {
            //懶人寫法，因為輸入欄位太多不想一個個設定，所以就以DataBinding做判斷
            //DataBindings["控制項的屬性名稱"]
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox && ctrl.DataBindings["Text"].DataSource == productsBindingSource)
                {
                    (ctrl as TextBox).ReadOnly = ReadOnly;
                }
                else if (ctrl is ComboBox && ctrl.DataBindings["SelectedValue"].DataSource == productsBindingSource)
                {
                    (ctrl as ComboBox).Enabled = !ReadOnly;
                }
                else if (ctrl is DateTimePicker && ctrl.DataBindings["Value"].DataSource == productsBindingSource)
                {
                    (ctrl as DateTimePicker).Enabled = !ReadOnly;
                }
                else if (ctrl is CheckBox && ctrl.DataBindings["CheckState"].DataSource == productsBindingSource)
                {
                    (ctrl as CheckBox).Enabled = !ReadOnly;
                }
                else { }
            }

            if(ReadOnly)
                currentState = currentState.none;

            productsDataGridView.Enabled = ReadOnly;
            BtnCancel.Enabled = !ReadOnly;
            BtnSave.Enabled = !ReadOnly;
            BtnInsertEmployee.Enabled = ReadOnly;
            BtnEditEmployee.Enabled = ReadOnly;
            BtnDeleteEmployee.Enabled = ReadOnly;
            BtnMoveFirstItem.Enabled = ReadOnly;
            BtnMoveLastItem.Enabled = ReadOnly;
            BtnMoveNextItem.Enabled = ReadOnly;
            BtnMovePreviousItem.Enabled = ReadOnly;  
        }

        private void SaveChange()
        {
            EditControl(true);
            this.Validate();
            
            try
            {
                this.productsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.northwindDataSet);
            }
            catch (Exception ex)
            {
                //如果遇到並行衝突，會重新從資料庫取得資料並回寫至datatable
                if (ex is DBConcurrencyException)
                {
                    GetCurrentPageData(currentPage, pageSize);
                }

                this.productsBindingSource.CancelEdit();
                this.productsBindingSource.ResetBindings(false);

                MessageBox.Show($"儲存失敗，失敗原因：{ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("儲存成功", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region Form控制項的事件
        public ProductsForm()
        {
            InitializeComponent();
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'northwindDataSet.Suppliers' 資料表。您可以視需要進行移動或移除。
            this.suppliersTableAdapter.Fill(this.northwindDataSet.Suppliers);
            // TODO: 這行程式碼會將資料載入 'northwindDataSet.Categories' 資料表。您可以視需要進行移動或移除。
            this.categoriesTableAdapter.Fill(this.northwindDataSet.Categories);

            initControlSetting();
            EditControl(true);

            GetCurrentPageData(currentPage, pageSize);
        }

        /// <summary>
        /// 下一頁
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMoveNextItem_Click(object sender, EventArgs e)
        {
            if (productsBindingSource.Count >= pageSize && currentPage < maxPage)
            {
                currentPage++;
                GetCurrentPageData(currentPage, pageSize);
            }
        }

        /// <summary>
        /// 上一頁
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMovePreviousItem_Click(object sender, EventArgs e)
        {
            if (currentPage > 0)
            {
                currentPage--;
                GetCurrentPageData(currentPage, pageSize);
            }
        }

        /// <summary>
        /// 最後一頁
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMoveLastItem_Click(object sender, EventArgs e)
        {
            currentPage = maxPage;
            GetCurrentPageData(currentPage, pageSize);
        }

        /// <summary>
        /// 第一頁
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMoveFirstItem_Click(object sender, EventArgs e)
        {
            currentPage = 0;
            GetCurrentPageData(currentPage, pageSize);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            if (currentState != currentState.none)
            {
                DialogResult msg = MessageBox.Show("您變更的項目尚未儲存，確定要關閉此視窗?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (msg != DialogResult.Yes)
                    return;
            }

            this.Close();
        }

        private void BtnInsertEmployee_Click(object sender, EventArgs e)
        {
            currentState = currentState.insert;

            //回到最後一頁
            BtnMoveLastItem_Click(sender, e);

            //新增ROW
            productsBindingSource.AddNew();
            EditControl(false);
        }

        private void BtnEditEmployee_Click(object sender, EventArgs e)
        {
            currentState = currentState.edit;
            EditControl(false);
        }

        private void BtnDeleteEmployee_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("是否要刪除這位員工?刪除後就無法再復原了", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (msg != DialogResult.Yes)
                return;

            currentState = currentState.delete;

            //刪除目前指定的ROW
            productsBindingSource.RemoveCurrent();
            SaveChange();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            EditControl(true);

            //僅能針對目前編輯中的ROW取消編輯，會將變更的欄位資料還原成變更前的資料
            //目前發現如果變更的欄位為陣列的話，則下這個指令會無法變回變更前的資料
            productsBindingSource.CancelEdit();
            productsBindingSource.ResetBindings(false);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("是否儲存目前的變更?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (msg != DialogResult.Yes)
                return;

            SaveChange();
        }
       
        #endregion

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwindDataSet);
        }
    }
}
