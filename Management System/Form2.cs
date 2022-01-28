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
using System.Transactions;

namespace Management_System
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'northwindDataSet.Customers' 資料表。您可以視需要進行移動或移除。
            this.customersTableAdapter.Fill(this.northwindDataSet.Customers);


        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwindDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.customersBindingSource.CancelEdit();


            
        }

        private void testFuc()
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    using (SqlConnection conn = new SqlConnection())
                    {
                        conn.Open();

                        using (SqlCommand cmd = new SqlCommand("sql指令",conn))
                        {
                            cmd.ExecuteNonQuery();
                            //...後續省略
                        }
                    }

                    //以上指令執行後如果沒有出現例外狀況，就會執行下列指令標記此交易已完成
                    scope.Complete();
                }
            }
            catch(TransactionException ex)
            {
                //Transaction例外狀況...
            }

        }
    }
}
