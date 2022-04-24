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
using Management_System.View;
using Management_System.NorthwindDataSetTableAdapters;

namespace Management_System
{
    public partial class EmployeeForm : Form, IEmployeeForm
    {
        private currentState currentState = currentState.none;

        public event EventHandler SaveEmployee;
        public event EventHandler CancelEmployee;
        public event EventHandler AddEmployee;
        public event EventHandler EditEmployee;
        public event EventHandler DeleteEmployee;
        public event EventHandler MoveNextItem;
        public event EventHandler MovePreviousItem;
        public event EventHandler MoveLastItem;
        public event EventHandler MoveFirstItem;
        public event EventHandler openFile;
        public event EventHandler EmployeeCurrentChanged;

        public BindingSource EmployeeBindingSource { get { return employeesBindingSource; } }
        public TableAdapterManager AdapterManager { get { return tableAdapterManager; } }
        public EmployeesTableAdapter employeesAdapter { get { return employeesTableAdapter; } }
        public NorthwindDataSet northwind { get { return northwindDataSet; } }
        public string Page
        {
            get
            {
                return LblPage.Text;
            }
            set
            {
                LblPage.Text = value;
            } 
        }

        public Image Image 
        {
            get
            {
                return pictureBox1.Image;
            }
            set
            {
                pictureBox1.Image = value;
            }
        }

        private bool fileIsImage;
        public bool FileIsImage
        {
            get
            {
                return fileIsImage;
            }
            set
            {
                fileIsImage = value;
            }
        }

        private bool saveSuccess;
        public bool SaveSuccess 
        {
            get
            {
                return saveSuccess;
            }
            set
            {
                saveSuccess = value;
            } 
        }

        private string message;
        public string Message
        {
            get
            {
                return message;
            }
            set
            {
                message = value;
            }
        }

        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            initControlSetting();
            EditControl(true);
        }

        /// <summary>
        /// 下一頁
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMoveNextItem_Click(object sender, EventArgs e)
        {
            MoveNextItem?.Invoke(sender, e);
        }

        /// <summary>
        /// 上一頁
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMovePreviousItem_Click(object sender, EventArgs e)
        {
            MovePreviousItem?.Invoke(sender, e);
        }

        /// <summary>
        /// 最後一頁
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMoveLastItem_Click(object sender, EventArgs e)
        {
            MoveLastItem?.Invoke(sender, e);
        }

        /// <summary>
        /// 第一頁
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMoveFirstItem_Click(object sender, EventArgs e)
        {
            MoveFirstItem?.Invoke(sender, e);
        }

        private void employeesBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            EmployeeCurrentChanged?.Invoke(sender, e);
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
            AddEmployee?.Invoke(sender, e);
            EditControl(false);
        }

        private void BtnEditEmployee_Click(object sender, EventArgs e)
        {
            currentState = currentState.edit;
            EditEmployee?.Invoke(sender, e);
            EditControl(false);
        }

        private void BtnDeleteEmployee_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("是否要刪除這位員工?刪除後就無法再復原了", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (msg != DialogResult.Yes)
                return;

            currentState = currentState.delete;
            DeleteEmployee?.Invoke(sender, e);

            if(saveSuccess)
                MessageBox.Show(message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            EditControl(true);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            CancelEmployee?.Invoke(sender, e);
            EditControl(true);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("是否儲存目前的變更?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (msg != DialogResult.Yes)
                return;

            this.Validate();
            SaveEmployee?.Invoke(sender, e);
            EditControl(true);
        }

        private void BtnPic_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
       
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            openFile?.Invoke(sender, e);

            if (!fileIsImage)
                MessageBox.Show("請選擇正確的圖檔", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    if((ctrl as TextBox).Name!= "employeeIDTextBox")
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

            if (ReadOnly)
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
    }
}
