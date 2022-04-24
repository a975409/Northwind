using Management_System.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_System.Presenters
{
    public class EmployeePresenter
    {
        IEmployeeForm employeeForm;
        private int currentPage = 0;
        private readonly int pageSize = 4;
        private int maxPage = 0;

        public EmployeePresenter(IEmployeeForm employeeForm)
        {
            this.employeeForm = employeeForm;
            employeeForm.Page = (currentPage + 1).ToString();
            employeeForm.AddEmployee += EmployeeForm_AddEmployee;
            employeeForm.CancelEmployee += EmployeeForm_CancelEmployee;
            employeeForm.DeleteEmployee += EmployeeForm_DeleteEmployee;
            employeeForm.EditEmployee += EmployeeForm_EditEmployee;
            employeeForm.EmployeeCurrentChanged += EmployeeForm_EmployeeCurrentChanged;
            employeeForm.MoveFirstItem += EmployeeForm_MoveFirstItem;
            employeeForm.MoveLastItem += EmployeeForm_MoveLastItem;
            employeeForm.MoveNextItem += EmployeeForm_MoveNextItem;
            employeeForm.MovePreviousItem += EmployeeForm_MovePreviousItem;
            employeeForm.openFile += EmployeeForm_openFile;
            employeeForm.SaveEmployee += EmployeeForm_SaveEmployee;

            GetCurrentPageData(currentPage, pageSize);
        }

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
                count = (int)employeeForm.employeesAdapter.GetScalarQueryCount();
            }
            catch
            {
                page = 0;
                maxPage = 0;
                employeeForm.Page = (page + 1).ToString();
                return;
            }

            //設定最大頁數
            maxPage = (count / pageSize) - 1;

            if (count % pageSize > 0)
                maxPage += 1;

            //取得某個範圍區間的資料(從資料庫取得的資料寫入至 northwindDataSet.Employees )
            employeeForm.employeesAdapter.FillByPageSize(employeeForm.northwind.Employees, currentPage * pageSize, size);
            employeeForm.Page = (page + 1).ToString();
        }

        private void EmployeeForm_openFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = (OpenFileDialog)sender;
            string filePath = openFileDialog1.FileName;

            //檢查檔案是否為圖檔
            if (!ToolClass.checkImage(filePath))
            {
                employeeForm.FileIsImage = false;
                return;
            }

            employeeForm.FileIsImage = true;

            //以下因為使用Northwind資料庫，圖片的抓法有點特別，圖片byte[]要從index=78開始抓
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                byte[] data = new byte[fs.Length + 78];
                fs.Read(data, 78, (int)fs.Length);

                try
                {
                    ((DataRowView)employeeForm.EmployeeBindingSource.Current)["Photo"] = data;
                    Bitmap bm = new Bitmap(fs, false);
                    employeeForm.Image = bm;
                }
                catch
                {
                    employeeForm.Image = null;
                    return;
                }
            }
        }

        private void EmployeeForm_MovePreviousItem(object sender, EventArgs e)
        {
            if (currentPage > 0)
            {
                currentPage--;
                GetCurrentPageData(currentPage, pageSize);
            }
        }

        private void EmployeeForm_MoveNextItem(object sender, EventArgs e)
        {
            if (employeeForm.EmployeeBindingSource.Count >= pageSize && currentPage < maxPage)
            {
                currentPage++;
                GetCurrentPageData(currentPage, pageSize);
            }
        }

        private void EmployeeForm_MoveLastItem(object sender, EventArgs e)
        {
            currentPage = maxPage;
            GetCurrentPageData(currentPage, pageSize);
        }

        private void EmployeeForm_MoveFirstItem(object sender, EventArgs e)
        {
            currentPage = 0;
            GetCurrentPageData(currentPage, pageSize);
        }

        private void EmployeeForm_EmployeeCurrentChanged(object sender, EventArgs e)
        {
            if (employeeForm.EmployeeBindingSource.Current == null)
            {
                employeeForm.Image = null;
                return;
            }

            //顯示存放在資料庫的圖片
            if (((DataRowView)employeeForm.EmployeeBindingSource.Current)["Photo"] != null)
            {
                byte[] sourceData;
                try
                {
                    sourceData = (byte[])((DataRowView)employeeForm.EmployeeBindingSource.Current)["Photo"];
                }
                catch
                {
                    employeeForm.Image = null;
                    return;
                }

                using (MemoryStream mStream = new MemoryStream())
                {
                    byte[] pData = new byte[sourceData.Length - 78];
                    Array.Copy(sourceData, 78, pData, 0, sourceData.Length - 78);
                    mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
                    Bitmap bm = new Bitmap(mStream, false);
                    employeeForm.Image = bm;
                }
            }
            else
            {
                employeeForm.Image = null;
            }
        }

        private void EmployeeForm_EditEmployee(object sender, EventArgs e)
        {
            
        }

        private void EmployeeForm_CancelEmployee(object sender, EventArgs e)
        {
            //僅能針對目前編輯中的ROW取消編輯，會將變更的欄位資料還原成變更前的資料
            //目前發現如果變更的欄位為陣列的話，則下這個指令會無法變回變更前的資料
            employeeForm.EmployeeBindingSource.CancelEdit();
            employeeForm.EmployeeBindingSource.ResetBindings(false);
        }

        private void EmployeeForm_AddEmployee(object sender, EventArgs e)
        {
            EmployeeForm_MoveLastItem(null, null);
            employeeForm.EmployeeBindingSource.AddNew();
        }

        private void EmployeeForm_DeleteEmployee(object sender, EventArgs e)
        {
            employeeForm.EmployeeBindingSource.RemoveCurrent();
            SaveChange();
        }

        private void EmployeeForm_SaveEmployee(object sender, EventArgs e)
        {
            SaveChange();
        }

        private void SaveChange()
        {
            try
            {
                employeeForm.EmployeeBindingSource.EndEdit();
                employeeForm.AdapterManager.UpdateAll(employeeForm.northwind);
                employeeForm.SaveSuccess = true;
                employeeForm.Message = "儲存成功";
            }
            catch (Exception ex)
            {
                //如果遇到並行衝突，會重新從資料庫取得資料並回寫至datatable
                if (ex is DBConcurrencyException)
                {
                    GetCurrentPageData(currentPage, pageSize);
                }

                employeeForm.EmployeeBindingSource.CancelEdit();
                employeeForm.EmployeeBindingSource.ResetBindings(false);
                employeeForm.SaveSuccess = false;
                employeeForm.Message = $"儲存失敗，失敗原因：{ex.Message}";
            }
        }
    }
}
