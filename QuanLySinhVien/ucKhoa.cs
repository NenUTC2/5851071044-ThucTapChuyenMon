using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySinhVien.DAO;

namespace QuanLySinhVien
{
    public partial class ucKhoa : UserControl
    {
        //private static ucKhoa _instance;
        //public static ucKhoa Instance
        //{
        //    get
        //    {
        //        if (_instance == null)
        //            _instance = new ucKhoa();
        //        return _instance;
        //    }
        //}
        //public  string id;
        //public  string Id
        //{
        //    get { return id; }
        //    set
        //    {
        //        id = value;
        //    }
        //}
        public Panel pn { get { return panel1; }  }
        public Panel pn2 { get { return panel2; }  }
        public Panel pn3 { get { return panel3; }  }
        public ucKhoa()
        {
            InitializeComponent();
            loadKhoa();
        }
        public void loadKhoa()
        {
            dtgvKhoa.DataSource = DataProvider.Instance.ExcuteQuery("Select * from Khoa");
        }
        private void thongbao()
        {
            guna2Transition1.ShowSync(lblError);
            timer1.Enabled = true;
        }

        private void dtgvKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKhoa.Text = dtgvKhoa.CurrentRow.Cells["MaKhoa"].Value.ToString();
            txtTenKhoa.Text = dtgvKhoa.CurrentRow.Cells["TenKhoa"].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DataProvider.Instance.ExcuteNonQuery("Insert into Khoa values" +
                "('" + txtMaKhoa.Text + "', N'" + txtTenKhoa.Text + "', '" + dtp.Value.ToString("yyyy/MM/dd") + "')");
            
            lblError.Text = "Thêm thành công khoa " + txtTenKhoa.Text;
            thongbao();
            loadKhoa();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DataProvider.Instance.ExcuteNonQuery("Update Khoa " +
                "set TenKhoa=N'"+txtTenKhoa.Text+"' where MaKhoa='"+ dtgvKhoa.CurrentRow.Cells["MaKhoa"].Value.ToString() + "'");
            lblError.Text = "Sửa thành công khoa " + txtTenKhoa.Text;
            thongbao();
            loadKhoa();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataProvider.Instance.ExcuteNonQuery("Delete from Khoa " +
                "where MaKhoa='"+ dtgvKhoa.CurrentRow.Cells["MaKhoa"].Value.ToString() + "'");
            lblError.Text = "Xoá thành công khoa " + txtTenKhoa.Text;
            thongbao();
            loadKhoa();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            guna2Transition1.HideSync(lblError);
        }
    }
}
