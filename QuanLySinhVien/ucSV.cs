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
    public partial class ucSV : UserControl
    {
        public Panel pn { get { return panel1; } }
        public Panel pn2 { get { return panel2; } }
        public Panel pn3 { get { return panel3; } }
        public ucSV()
        {
            InitializeComponent();
            loadSV();
            loadCBKhoa();
            loadCBLop(cbKhoa.SelectedValue.ToString());
            loadCBMonHoc("*");
        }

        public void loadSV()
        {
            dtgvSV.DataSource = DataProvider.Instance.ExcuteQuery("Select * from SinhVien");
        }

        public void loadCBLop(string khoa)
        {
            if (khoa.Equals("*"))
                cbLop.DataSource = DataProvider.Instance.ExcuteQuery("Select * from Lop");
            else
                cbLop.DataSource = DataProvider.Instance.ExcuteQuery("Select * from Lop where MaKhoa='"+khoa+"'");
            cbLop.DisplayMember = "TenLop";
            cbLop.ValueMember = "MaLop";
        }

        public void loadCBKhoa()
        {
            cbKhoa.DataSource = DataProvider.Instance.ExcuteQuery("Select * from Khoa");
            cbKhoa.DisplayMember = "TenKhoa";
            cbKhoa.ValueMember = "MaKhoa";
        }

        public void loadCBMonHoc(string khoa)
        {
            if (khoa.Equals("*"))
                cbMonHoc.DataSource = DataProvider.Instance.ExcuteQuery("Select * from MonHoc");
            else
                cbMonHoc.DataSource = DataProvider.Instance.ExcuteQuery("Select * from MonHoc where MaKhoa='" + khoa + "'");
            cbMonHoc.DisplayMember = "TenMon";
            cbMonHoc.ValueMember = "MaMon";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DataProvider.Instance.ExcuteQuery("Insert into SinhVien values(" +
                " '" + cbLop.SelectedValue + "-" + SinhVienDAO.Instance.getMaxGV() + "'," +
                " N'" + txtTenSV.Text + "', '"+txtSDT.Text+"', '"+cbLop.SelectedValue+"', N'"+txtDiaChi.Text+"', 0)");
            loadSV();
        }

        private void cbKhoa_SelectedValueChanged(object sender, EventArgs e)
        {
            loadCBLop(cbKhoa.SelectedValue.ToString());
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataProvider.Instance.ExcuteNonQuery("Delete from SinhVien where MaSV='" + dtgvSV.CurrentRow.Cells["MaSV"].Value.ToString() + "'");
            loadSV();
        }

        private void dtgvSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenSV.Text = dtgvSV.CurrentRow.Cells["TenSV"].Value.ToString();
            txtSDT.Text = dtgvSV.CurrentRow.Cells["SDT"].Value.ToString();
            txtDiaChi.Text = dtgvSV.CurrentRow.Cells["DiaChi"].Value.ToString();
            cbKhoa.SelectedValue = LopDAO.Instance.getMaKhoabyMaLop(dtgvSV.CurrentRow.Cells["MaLop"].Value.ToString());
            cbLop.SelectedValue = dtgvSV.CurrentRow.Cells["MaLop"].Value.ToString();
            loadCBMonHoc(LopDAO.Instance.getKhoafromLop(dtgvSV.CurrentRow.Cells["MaLop"].Value.ToString()));
        }

        private void cbMonHoc_SelectedValueChanged(object sender, EventArgs e)
        {
            cbLopHoc.DataSource = DataProvider.Instance.ExcuteQuery("Select * from LopHoc where MaMon='" + cbMonHoc.SelectedValue + "'");
            cbLopHoc.DisplayMember = "MaCTMon";
            cbLopHoc.ValueMember = "MaCTMon";
        }
    }
}
