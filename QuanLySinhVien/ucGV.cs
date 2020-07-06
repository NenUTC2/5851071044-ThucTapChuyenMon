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
    public partial class ucGV : UserControl
    {
        public Panel pn { get { return panel1; } }
        public Panel pn2 { get { return panel2; } }
        public Panel pn3 { get { return panel3; } }
        public ucGV()
        {
            InitializeComponent();
            loadGV();
            loadCBKhoa();
        }
        
        public void loadGV()
        {
            dtgvGV.DataSource = DataProvider.Instance.ExcuteQuery("Select * from GiangVien");
        }

        public void loadCBKhoa()
        {
            cbKhoa.DataSource = DataProvider.Instance.ExcuteQuery("Select * from Khoa");
            cbKhoa.DisplayMember = "TenKhoa";
            cbKhoa.ValueMember = "MaKhoa";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DataProvider.Instance.ExcuteNonQuery("Insert into GiangVien values" +
               "('" + cbKhoa.SelectedValue.ToString() + (GiangVienDAO.Instance.getMaxGV()+1).ToString() + "', N'" + txtTenGV.Text + "'," +
               "'"+txtSDT.Text+"', '"+cbKhoa.SelectedValue.ToString()+"', N'"+txtDiaChi.Text+"' , '" + dtpNgayDay.Value.ToString("yyyy/MM/dd") + "')");

            //lblError.Text = "Thêm thành công khoa " + txtTenKhoa.Text;
            //thongbao();
            loadGV();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DataProvider.Instance.ExcuteNonQuery("Update GiangVien set TenGV=N'"+txtTenGV.Text+"', SDT='"+txtSDT.Text+"', DiaChi=N'"+txtDiaChi.Text+"' " +
                "where MaGV='"+ dtgvGV.CurrentRow.Cells["MaGV"].Value.ToString() + "'");

            //lblError.Text = "Thêm thành công khoa " + txtTenKhoa.Text;
            //thongbao();
            loadGV();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataProvider.Instance.ExcuteNonQuery("Delete from GiangVien where MaGV='"+ dtgvGV.CurrentRow.Cells["MaGV"].Value.ToString() +"'");

            //lblError.Text = "Thêm thành công khoa " + txtTenKhoa.Text;
            //thongbao();
            loadGV();
        }

        private void dtgvGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenGV.Text = dtgvGV.CurrentRow.Cells["TenGV"].Value.ToString();
            txtSDT.Text = dtgvGV.CurrentRow.Cells["SDT"].Value.ToString();
            txtDiaChi.Text = dtgvGV.CurrentRow.Cells["DiaChi"].Value.ToString();
            cbKhoa.SelectedValue = dtgvGV.CurrentRow.Cells["MaKhoa"].Value.ToString();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            loadCBKhoa();
            loadGV();
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            loadGV();
            loadCBKhoa();
        }
    }
}
