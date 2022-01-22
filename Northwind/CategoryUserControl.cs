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

namespace Northwind
{
    public partial class CategoryUserControl : UserControl
    {
        private string cName = "";
        private byte[] cImage;
        private int categoryID = -1;

        public CategoryUserControl(string name, byte[] image,int id)
        {
            InitializeComponent();
            cName = name;
            cImage = image;
            categoryID = id;
        }

        private void CategoryUserControl_Load(object sender, EventArgs e)
        {
            LblName.Text = cName;
            MemoryStream mStream = new MemoryStream();
            byte[] pData = new byte[cImage.Length - 78];
            Array.Copy(cImage, 78, pData, 0, cImage.Length - 78);
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            PicImage.Image = bm;
        }

        private void PicImage_MouseMove(object sender, MouseEventArgs e)
        {
            PicImage.Cursor = Cursors.Hand;
        }

        private void LblName_MouseMove(object sender, MouseEventArgs e)
        {
            LblName.Cursor = Cursors.Hand;
        }

        private void getProducts(object sender, EventArgs e)
        { 
            
        }
    }
}
