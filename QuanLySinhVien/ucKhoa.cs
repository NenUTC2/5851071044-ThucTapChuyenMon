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
        public Panel pn { get { return panel1; }  }
        public ucKhoa()
        {
            InitializeComponent();
            loadKhoa();
        }
        public void loadKhoa()
        {
            dtgvKhoa.DataSource = DataProvider.Instance.ExcuteQuery("Select * from Khoa");
        }

        private void dtgvKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKhoa.Text = dtgvKhoa.CurrentRow.Cells["MaKhoa"].Value.ToString();
            txtTenKhoa.Text = dtgvKhoa.CurrentRow.Cells["TenKhoa"].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DataProvider.Instance.ExcuteNonQuery("insert into Khoa " +
                "values('" + txtMaKhoa.Text + "', N'" + txtTenKhoa.Text + "', '" + dtpNgayLap.Value.ToString("yyyy/MM/dd") + "')");
            loadKhoa();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DataProvider.Instance.ExcuteNonQuery("Update Khoa set TenKhoa=N'"+txtTenKhoa.Text+"' where MaKhoa='"+ dtgvKhoa.CurrentRow.Cells["MaKhoa"].Value.ToString() + "'");
            loadKhoa();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataProvider.Instance.ExcuteNonQuery("Delete from Khoa where MaKhoa='"+dtgvKhoa.CurrentRow.Cells["MaKhoa"].Value.ToString()+"'");
            loadKhoa();
        }
    }
}
