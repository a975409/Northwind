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
            BtnPic.Enabled = !ReadOnly;
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
                this.employeesBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.northwindDataSet);
            }
            catch (Exception ex)
            {
                this.employeesBindingSource.CancelEdit();
                GetCurrentPageData(currentPage, pageSize);
                MessageBox.Show($"儲存失敗，失敗原因：{ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("儲存成功", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region Form控制項的事件
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            initControlSetting();
            EditControl(true);

            //從資料庫取得上司名字填到reportsToComboBox控制項
            string sql = "select EmployeeID,(LastName+' '+FirstName) as BossName from Employees";
            ComboUtil.BindTableToDDL(reportsToComboBox, sql, "EmployeeID", "BossName", false);

            GetCurrentPageData(currentPage, pageSize);
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

            //回到最後一頁
            BtnMoveLastItem_Click(sender, e);

            //新增ROW
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

            //刪除目前指定的ROW
            employeesBindingSource.RemoveCurrent();
            SaveChange();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            EditControl(true);

            //僅能針對目前編輯中的ROW取消編輯，會將變更的欄位資料還原成變更前的資料
            //目前發現如果變更的欄位為陣列的話，則下這個指令會無法變回變更前的資料
            employeesBindingSource.CancelEdit();

            //重新載入資料
            GetCurrentPageData(currentPage, pageSize);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("是否儲存目前的變更?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (msg != DialogResult.Yes)
                return;

            SaveChange();
        }

        private void BtnPic_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
       
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string filePath = openFileDialog1.FileName;

            //檢查檔案是否為圖檔
            if (!ToolClass.checkImage(filePath))
            {
                MessageBox.Show("請選擇正確的圖檔", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //以下因為使用Northwind資料庫，圖片的抓法有點特別，圖片byte[]要從index=78開始抓
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                byte[] data = new byte[fs.Length + 78];
                fs.Read(data, 78, (int)fs.Length);

                try
                {
                    if (currentState == currentState.edit)
                    {
                        //employeesBindingSource.Current僅能讀取，不能設定
                        int employeeID = (int)((DataRowView)employeesBindingSource.Current)["EmployeeID"];

                        //如果要設定employeesBindingSource.Current裡面的內容，則要透過對應的DataTable做設定
                        DataRow row = northwindDataSet.Employees.SingleOrDefault(m => m.EmployeeID == employeeID);
                        row["Photo"] = data;
                    }
                    else if (currentState == currentState.insert)
                    {
                        ((DataRowView)employeesBindingSource.Current)["Photo"] = data;
                    }

                    Bitmap bm = new Bitmap(fs, false);
                    pictureBox1.Image = bm;
                }
                catch
                {
                    Console.WriteLine("error");
                    pictureBox1.Image = null;
                    return;
                }
            }
        }

        #endregion
    }
}
