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
    public partial class ucLop : UserControl
    {
        public Panel pn { get { return panel1; } }
        public Panel pn2 { get { return panel2; } }
        public Panel pn3 { get { return panel3; } }
        public Label lblsv { get { return lblSoSV; } }
        public DataGridView dtgv { get { return dtgvLop; } }
        public string mgv;
        public ucLop(string gv)
        {
            mgv = gv;
            InitializeComponent();

            if (AccountDAO.Instance.getQuyenByUser(mgv).Equals("admin"))
            {
                loadCBNganh("*");
                loadCBGV("*");
            }
            else if (AccountDAO.Instance.getQuyenByUser(mgv).Equals("tk"))
            {
                loadCBNganh(GiangVienDAO.Instance.getKhoabyMGV(mgv));
                loadCBGV(GiangVienDAO.Instance.getKhoabyMGV(mgv));
            }
        }

        private void ucLop_Load(object sender, EventArgs e)
        {
            
        }

        public void loadLop(string nganh)
        {
            try
            {
                if (nganh.Equals("*"))
                    dtgvLop.DataSource = DataProvider.Instance.ExcuteQuery("Select * from Lop");
                else
                    dtgvLop.DataSource = DataProvider.Instance.ExcuteQuery("Select * from Lop where MaNganh='" + nganh + "'");
            }
            catch { }
        }

        public void loadCBNganh(string nganh)
        {
            try
            {
                if (nganh.Equals("*"))
                    cbNganh.DataSource = DataProvider.Instance.ExcuteQuery("Select * from Nganh");
                else
                    cbNganh.DataSource = DataProvider.Instance.ExcuteQuery("Select * from Nganh where MaKhoa='" + nganh + "'");
                cbNganh.DisplayMember = "TenNganh";
                cbNganh.ValueMember = "MaNganh";
            }
            catch { }
        }

        public void loadCBGV(string khoa)
        {
            try
            {
                if (khoa.Equals("*"))
                    cbGV.DataSource = DataProvider.Instance.ExcuteQuery("Select * from GiangVien");
                else
                    cbGV.DataSource = DataProvider.Instance.ExcuteQuery("Select * from GiangVien where MaKhoa='" + khoa + "'");
                cbGV.DisplayMember = "TenGV";
                cbGV.ValueMember = "MaGV";
            }
            catch { }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            if (txtMaLop.Text != "" && txtTenLop.Text != "")
            {
                DataProvider.Instance.ExcuteNonQuery("Insert into Lop values(" +
                    "'" + txtMaLop.Text + "', N'" + txtTenLop.Text + "', '" + dtpNgayLap.Value.ToString("yyyy/MM/dd") + "'," +
                    " '" + cbGV.SelectedValue + "', '" + cbNganh.SelectedValue + "')");

                if (AccountDAO.Instance.getQuyenByUser(mgv).Equals("admin"))
                {
                    loadCBNganh("*"); loadLop(cbNganh.SelectedValue.ToString()); loadCBGV(cbNganh.SelectedValue.ToString());
                }
                else if (AccountDAO.Instance.getQuyenByUser(mgv).Equals("tk"))
                {
                    loadCBNganh(GiangVienDAO.Instance.getKhoabyMGV(mgv));
                    loadLop(cbNganh.SelectedValue.ToString()); loadCBGV(cbNganh.SelectedValue.ToString());
                }
            }
            else { lblLoi.Visible = true; lblLoi.Text = "Vui lòng nhập đầy đủ thông tin lớp"; timer1.Enabled = true; }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTenLop.Text != "")
            {
                DataProvider.Instance.ExcuteNonQuery("Update Lop set" +
                    " TenLop= N'" + txtTenLop.Text + "'," +
                    " GVCN='" + cbGV.SelectedValue + "', MaNganh='" + cbNganh.SelectedValue + "' where MaLop='" + dtgvLop.CurrentRow.Cells["MaLop"].Value.ToString() + "'");
                if (AccountDAO.Instance.getQuyenByUser(mgv).Equals("admin"))
                {
                    loadCBNganh("*"); loadLop(cbNganh.SelectedValue.ToString()); loadCBGV(cbNganh.SelectedValue.ToString());
                }
                else if (AccountDAO.Instance.getQuyenByUser(mgv).Equals("tk"))
                {
                    loadCBNganh(GiangVienDAO.Instance.getKhoabyMGV(mgv));
                    loadLop(cbNganh.SelectedValue.ToString()); loadCBGV(cbNganh.SelectedValue.ToString());
                }
            }
            else { lblLoi.Visible = true; lblLoi.Text = "Vui lòng nhập đầy đủ thông tin lớp"; timer1.Enabled = true; }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DataProvider.Instance.ExcuteNonQuery("Delete from Lop where MaLop='" + dtgvLop.CurrentRow.Cells["MaLop"].Value.ToString() + "'");
                if (AccountDAO.Instance.getQuyenByUser(mgv).Equals("admin"))
                {
                    loadCBNganh("*"); loadLop(cbNganh.SelectedValue.ToString()); loadCBGV(cbNganh.SelectedValue.ToString());
                }
                else if (AccountDAO.Instance.getQuyenByUser(mgv).Equals("tk"))
                {
                    loadCBNganh(GiangVienDAO.Instance.getKhoabyMGV(mgv));
                    loadLop(cbNganh.SelectedValue.ToString()); loadCBGV(cbNganh.SelectedValue.ToString());
                }
            }
            catch { lblLoi.Visible = true; lblLoi.Text = "Không được xoá lớp này"; timer1.Enabled = true; }
        }

        private void dtgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaLop.Text = dtgvLop.CurrentRow.Cells["MaLop"].Value.ToString();
            txtTenLop.Text = dtgvLop.CurrentRow.Cells["TenLop"].Value.ToString();
            cbNganh.SelectedValue = dtgvLop.CurrentRow.Cells["MaNganh"].Value.ToString();
            cbGV.SelectedValue = dtgvLop.CurrentRow.Cells["MaGV"].Value.ToString();

            lblSoSV.Text = "Số sinh viên:  " + DataProvider.Instance.ExcuteQuery("Select count(*) from SinhVien " +
                "where MaLop = '" + dtgvLop.CurrentRow.Cells["MaLop"].Value.ToString() + "'").Rows[0][0].ToString();
        }

        private void cbKhoa_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                loadCBGV(KhoaDAO.Instance.getKhoaByNganh(cbNganh.SelectedValue.ToString()));
                loadLop(cbNganh.SelectedValue.ToString());
            }
            catch { }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            if (AccountDAO.Instance.getQuyenByUser(mgv).Equals("admin"))
            {
                loadCBNganh("*");
                loadCBGV("*");
            }
            else if (AccountDAO.Instance.getQuyenByUser(mgv).Equals("tk"))
            {
                loadCBNganh(GiangVienDAO.Instance.getKhoabyMGV(mgv));
                loadCBGV(GiangVienDAO.Instance.getKhoabyMGV(mgv));
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblLoi.Visible = false;
            timer1.Enabled = false;
        }
    }
}
