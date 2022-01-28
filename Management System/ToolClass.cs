using Northwind;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_System
{
    public static class ToolClass
    {
        /// <summary>
        /// 驗證檔案是否為圖檔
        /// </summary>
        /// <param name="filePath">完整檔案路徑</param>
        /// <returns></returns>
        public static bool checkImage(string filePath)
        {
            Dictionary<string, string> ImageTypes = new Dictionary<string, string>() { { "FFD8", ".jpg" }, { "424D", ".bmp" }, { "474946", ".gif" }, { "89504E470D0A1A0A", ".png" } };
            string builtHex = string.Empty;
            string extension = "";

            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                for (int i = 0; i < 8; i++)
                {
                    builtHex += fs.ReadByte().ToString("X2");
                    if (ImageTypes.ContainsKey(builtHex))
                    {
                        extension = ImageTypes[builtHex];
                        break;
                    }
                }
            }

            return !string.IsNullOrEmpty(extension);
        }

        /// <summary>
        /// 透過SQL查詢語法指定欄位查詢的結果顯示在ComboBox的選項上
        /// </summary>
        /// <param name="comboBox"></param>
        /// <param name="sql">SQL語法</param>
        /// <param name="ValueMember">指定欄位名稱為value值</param>
        /// <param name="DisplayMember">指定欄位名稱為顯示欄位</param>
        public static void ComboBoxItem(string sql, ComboBox comboBox, string ValueMember, string DisplayMember)
        {
            DataTable dt = DatabaseManagement.SqlQueryDataTable(sql);

            comboBox.DataSource = dt;
            comboBox.ValueMember = ValueMember;
            comboBox.DisplayMember = DisplayMember;
        }
    }
}
