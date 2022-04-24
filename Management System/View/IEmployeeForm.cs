using Management_System.NorthwindDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_System.View
{
    public interface IEmployeeForm
    {
        string Message { get; set; }
        bool SaveSuccess { get; set; }
        bool FileIsImage { get; set; }
        string Page { get; set; }
        BindingSource EmployeeBindingSource { get; }
        TableAdapterManager AdapterManager { get; }
        EmployeesTableAdapter employeesAdapter { get; }

        NorthwindDataSet northwind { get; }

        Image Image { get; set; }

        event EventHandler SaveEmployee;
        event EventHandler CancelEmployee;
        event EventHandler AddEmployee;
        event EventHandler EditEmployee;
        event EventHandler DeleteEmployee;
        event EventHandler MoveNextItem;
        event EventHandler MovePreviousItem;
        event EventHandler MoveLastItem;
        event EventHandler MoveFirstItem;
        event EventHandler openFile;
        event EventHandler EmployeeCurrentChanged;
    }
}
