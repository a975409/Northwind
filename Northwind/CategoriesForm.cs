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
    public partial class CategoriesForm : Form
    {
        public CategoriesForm()
        {
            InitializeComponent();
        }

        private void GetCategories(params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseManagement.conStr))
            {
                conn.Open();
                string sql = "select CategoryName,Picture,CategoryID from Categories";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (parameters.Length > 0)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string name = reader["CategoryName"].ToString();
                        byte[] image = (byte[])reader["Picture"];
                        int id = (int)reader["CategoryID"];

                        flowLayoutPanel1.Controls.Add(new CategoryUserControl(name, image, id));
                    }
                }
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CategoriesForm_Load(object sender, EventArgs e)
        {
            GetCategories();
        }

        private void BtnClose_MouseMove(object sender, MouseEventArgs e)
        {
            BtnClose.Cursor = Cursors.Hand;
        }
    }
}
