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
    enum currentState
    {
        none, insert, edit, delete
    }
    public partial class EmployeeForm : Form
    {
        private int currentPage = 0;
        private readonly int pageSize = 4;
        private int maxPage = 0;

        //紀錄現在執行的狀態
        private currentState currentState = currentState.none;

        public EmployeeForm()
        {
            InitializeComponent();
        }
        #region 針對此Form的控制項所寫的方法
        /// <summary>
        /// 指定頁數和單一頁數取得某個範圍區間的員工資料
        /// </summary>
        /// <param name="page">顯示第幾頁的資料</param>
        /// <param name="size">單頁最多資料筆數</param>
        private void getCurrentEmployee(int page, int size)
        {
            int count;
            try
            {
                //取得總資料筆數
                count = (int)this.employeesTableAdapter.GetScalarQueryCount();
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

            //取得某個範圍區間的資料
            this.employeesTableAdapter.FillByPageSize(northwindDataSet.Employees, currentPage * pageSize, size);
            LblPage.Text = (page + 1).ToString();
        }

        /// <summary>
        /// 從資料庫取得上司名字填到reportsToComboBox控制項
        /// </summary>
        private void getBossName()
        {
            string sql = "select EmployeeID,(LastName+' '+FirstName) as BossName from Employees";
            DataTable dt = DatabaseManagement.SqlQueryDataTable(sql);

            reportsToComboBox.DataSource = dt;
            reportsToComboBox.ValueMember = "EmployeeID";
            reportsToComboBox.DisplayMember = "BossName";
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
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox && ctrl.DataBindings["Text"].DataSource == employeesBindingSource)
                {
                    (ctrl as TextBox).ReadOnly = ReadOnly;
                }
                else if (ctrl is ComboBox && ctrl.DataBindings["SelectedValue"].DataSource == employeesBindingSource)
                {
                    (ctrl as ComboBox).Enabled = !ReadOnly;
                }
                else if (ctrl is DateTimePicker && ctrl.DataBindings["Value"].DataSource == employeesBindingSource)
                {
                    (ctrl as DateTimePicker).Enabled = !ReadOnly;
                }
                else { }
            }

            if(ReadOnly)
                currentState = currentState.none;

            employeesDataGridView.Enabled = ReadOnly;
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
            this.employeesBindingSource.EndEdit();

            try
            {
                this.tableAdapterManager.UpdateAll(this.northwindDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"儲存失敗，失敗原因：{ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MessageBox.Show("儲存成功", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Form控制項的事件
        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            initControlSetting();
            EditControl(true);
            getBossName();
            getCurrentEmployee(currentPage, pageSize);
        }

        /// <summary>
        /// 下一頁
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMoveNextItem_Click(object sender, EventArgs e)
        {
            if (employeesDataGridView.Rows.Count >= pageSize && currentPage < maxPage)
            {
                currentPage++;
                getCurrentEmployee(currentPage, pageSize);
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
                getCurrentEmployee(currentPage, pageSize);
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
            getCurrentEmployee(currentPage, pageSize);
        }

        /// <summary>
        /// 第一頁
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMoveFirstItem_Click(object sender, EventArgs e)
        {
            currentPage = 0;
            getCurrentEmployee(currentPage, pageSize);
        }

        private void employeesBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (employeesBindingSource.Current == null)
            {
                pictureBox1.Image = null;
                return;
            }

            //顯示存放在資料庫的圖片
            if (((DataRowView)(employeesBindingSource.Current))["Photo"] != null)
            {
                byte[] sourceData;
                try
                {
                    sourceData = (byte[])(((DataRowView)(employeesBindingSource.Current))["Photo"]);
                }
                catch
                {
                    pictureBox1.Image = null;
                    return;
                }

                using (MemoryStream mStream = new MemoryStream())
                {
                    byte[] pData = new byte[sourceData.Length - 78];
                    Array.Copy(sourceData, 78, pData, 0, sourceData.Length - 78);
                    mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
                    Bitmap bm = new Bitmap(mStream, false);
                    mStream.Dispose();
                    pictureBox1.Image = bm;
                }
            }
            else
            {
                pictureBox1.Image = null;
            }
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
            BtnMoveLastItem_Click(sender, e);
            employeesBindingSource.AddNew();
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
            employeesBindingSource.RemoveCurrent();
            SaveChange();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            EditControl(true);
            employeesBindingSource.CancelEdit();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("是否儲存目前的變更?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (msg != DialogResult.Yes)
                return;

            SaveChange();
        }

        #endregion
    }
}
