using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //int idanh = 1;
        private void LoadNextImage()
        {
            //if (idanh == 6)
            //{
            //    idanh = 1;
            //}
            //pictureBox1.ImageLocation = string.Format(@"Images\{0}.jpg", idanh);
            //idanh++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
