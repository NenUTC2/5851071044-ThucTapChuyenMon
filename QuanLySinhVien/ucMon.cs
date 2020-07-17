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
    public partial class ucMon : UserControl
    {
        public Panel pn { get { return panel1; } }
        public Panel pn2 { get { return pnLopHoc; } }
        public Panel pn3 { get { return pnMon; } }
        public DataGridView dtgv1 { get { return dtgvMonHoc; } }
        public DataGridView dtgvMon { get { return dtgvMonHoc; } }
        public DataGridView dtgvHP { get { return dtgvLopHoc; } }

        public string mgv;
        public ucMon(string gv)
        {
            mgv = gv;
            InitializeComponent();

            if (AccountDAO.Instance.getQuyenByUser(mgv).Equals("admin"))
            {
                loadCBGV("*");
                loadCBLop("*");
                loadCBKhoa("*");
                loadCBKhoa2("*");
                loadCBHK();

                loadMon(cbKhoa.SelectedValue.ToString());
                loadLopHoc("*");
            }
            else if (AccountDAO.Instance.getQuyenByUser(mgv).Equals("tk"))
            {
                loadCBKhoa(GiangVienDAO.Instance.getKhoabyMGV(mgv));
                loadCBKhoa2(GiangVienDAO.Instance.getKhoabyMGV(mgv));
                loadCBLop(GiangVienDAO.Instance.getKhoabyMGV(mgv));
                loadCBGV(GiangVienDAO.Instance.getKhoabyMGV(mgv));

                loadMon(cbKhoa.SelectedValue.ToString());
                loadLopHoc("*");
                loadCBHK();
            }
        }

        public void loadMon(string khoa)
        {
            if (khoa.Equals("*"))
                dtgvMonHoc.DataSource = DataProvider.Instance.ExcuteQuery("Select * from MonHoc");
            else
                dtgvMonHoc.DataSource = DataProvider.Instance.ExcuteQuery("Select * from MonHoc where MaKhoa='"+khoa+"'");
        }

        public void loadLopHoc(string khoa)
        {
            if (khoa.Equals("*"))
                dtgvLopHoc.DataSource = DataProvider.Instance.ExcuteQuery("Select * from LopHoc");
            else
                dtgvLopHoc.DataSource = DataProvider.Instance.ExcuteQuery("SELECT MaCTMon,LopHoc.MaMon,MaGV,MaLop,phong,HocKy,TrangThai FROM dbo.LopHoc, dbo.MonHoc " +
                    "WHERE LopHoc.MaMon=MonHoc.MaMon AND MaKhoa='" + khoa + "'");
        }

        public void loadCBGV(string khoa)
        {
            if (khoa.Equals("*"))
                cbGV.DataSource = DataProvider.Instance.ExcuteQuery("Select * from GiangVien");
            else
                cbGV.DataSource = DataProvider.Instance.ExcuteQuery("Select * from GiangVien where MaKhoa='" + khoa + "'");
            cbGV.DisplayMember = "TenGV";
            cbGV.ValueMember = "MaGV";
        }

        public void loadCBLop(string khoa)
        {
            if (khoa.Equals("*"))
                cbLop.DataSource = DataProvider.Instance.ExcuteQuery("Select * from Lop");
            else
                cbLop.DataSource = DataProvider.Instance.ExcuteQuery("Select * from Lop where MaKhoa='" + khoa + "'");
            cbLop.DisplayMember = "TenLop";
            cbLop.ValueMember = "MaLop";
        }

        public void loadCBKhoa(string khoa)
        {
            if (khoa.Equals("*"))
                cbKhoa.DataSource = DataProvider.Instance.ExcuteQuery("Select * from Khoa");
            else
                cbKhoa.DataSource = DataProvider.Instance.ExcuteQuery("Select * from Khoa where MaKhoa='" + khoa + "'");
            cbKhoa.DisplayMember = "TenKhoa";
            cbKhoa.ValueMember = "MaKhoa";
        }

        public void loadCBKhoa2(string khoa)
        {
            if (khoa.Equals("*"))
                cbKhoa2.DataSource = DataProvider.Instance.ExcuteQuery("Select * from Khoa");
            else
                cbKhoa2.DataSource = DataProvider.Instance.ExcuteQuery("Select * from Khoa where MaKhoa='" + khoa + "'");
            cbKhoa2.DisplayMember = "TenKhoa";
            cbKhoa2.ValueMember = "MaKhoa";
        }

        public void loadCBHK()
        {
            cbHocKy.DataSource = DataProvider.Instance.ExcuteQuery("Select * from HocKy");
            cbHocKy.DisplayMember = "MaHK";
            cbHocKy.ValueMember = "MaHK";
        }
        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            loadMon("*");
            loadLopHoc("*");
            loadCBGV("*");
            loadCBLop("*");
            loadCBKhoa("*");
        }
        
        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            if (pnLopHoc.Visible == true)
            {
                pnLopHoc.Visible = false;
                pnMon.Visible = true;
            }
            else
            {
                pnLopHoc.Visible = true;
                pnMon.Visible = false;
            }
        }

        private void btnTaoMon_Click(object sender, EventArgs e)
        {
            DataProvider.Instance.ExcuteNonQuery("Insert into MonHoc values(" +
                " '" + txtMaMonTao.Text + "', N'" + txtTenMon.Text + "', '" + cbKhoa.SelectedValue + "', " + nbrTinChi.Value + ")");
            loadMon("*");
        }

        private void btnSuaMon_Click(object sender, EventArgs e)
        {
            DataProvider.Instance.ExcuteNonQuery("Update MonHoc set " +
                "TenMon = N'" + txtTenMon.Text + "', MaKhoa = '" + cbKhoa.SelectedValue + "', TinChi = " + nbrTinChi.Value + " where MaMon = '" + txtMaMonTao.Text + "'");
            loadMon("*");
        }

        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            DataProvider.Instance.ExcuteNonQuery("Delete from MonHoc where MaMon='"+ dtgvMonHoc.CurrentRow.Cells["MaMon"].Value.ToString() + "'");
            loadMon("*");
        }

        private void dtgvMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbKhoa.SelectedValue = dtgvMonHoc.CurrentRow.Cells["MaKhoa"].Value.ToString();
            txtMaMonTao.Text = dtgvMonHoc.CurrentRow.Cells["MaMon"].Value.ToString();
            txtMaMon.Text = dtgvMonHoc.CurrentRow.Cells["MaMon"].Value.ToString();
            txtTenMon.Text = dtgvMonHoc.CurrentRow.Cells["TenMon"].Value.ToString();
            nbrTinChi.Value = Convert.ToInt32(dtgvMonHoc.CurrentRow.Cells["TinChi"].Value);

            loadCBLop(dtgvMonHoc.CurrentRow.Cells["MaKhoa"].Value.ToString());
            loadCBGV(dtgvMonHoc.CurrentRow.Cells["MaKhoa"].Value.ToString());
        }

        private void cbKhoa_SelectedValueChanged(object sender, EventArgs e)
        {
            txtMaMonTao.Text = cbKhoa.SelectedValue.ToString()+"-";
            loadMon(cbKhoa.SelectedValue.ToString());
        }

        private void btnMoLop_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(DataProvider.Instance.ExcuteQuery("Select Count(*) from LopHoc where MaCTMon like '%" + txtMaMon.Text + "%' ").Rows[0][0].ToString());
            count += 1;
            DataProvider.Instance.ExcuteNonQuery("insert into LopHoc values('" + txtMaMon.Text +"-"+ count + "', " +
                "'" + txtMaMon.Text + "', '" + cbGV.SelectedValue + "', '" + cbLop.SelectedValue + "', '" + txtPhong.Text + "', '"+cbHocKy.SelectedValue+"', 0)");
            loadLopHoc("*");
        }

        private void btnShowtxt_Click(object sender, EventArgs e)
        {
            txtHocKy.Visible = true;
            btnThemHK.Visible = true;
            btnHuyHK.Visible = true;
        }

        private void btnHuyHK_Click(object sender, EventArgs e)
        {
            txtHocKy.Visible = false;
            btnThemHK.Visible = false;
            btnHuyHK.Visible = false;
        }

        private void btnThemHK_Click(object sender, EventArgs e)
        {
            DataProvider.Instance.ExcuteNonQuery("Insert into HocKy values(" +
                " '"+txtHocKy.Text+"', '')");
            loadCBHK(); txtHocKy.Visible = false;
            btnThemHK.Visible = false;
            btnHuyHK.Visible = false;
        }

        private void btnXoaLop_Click(object sender, EventArgs e)
        {
            DataProvider.Instance.ExcuteNonQuery("Delete from LopHoc where MaCTMon='"+dtgvLopHoc.CurrentRow.Cells["MaCTMon"].Value.ToString()+"'");
            loadLopHoc("*");
        }

        private void btnSuaLop_Click(object sender, EventArgs e)
        {
            DataProvider.Instance.ExcuteNonQuery("Update LopHoc set" +
                " MaGV= '" + cbGV.SelectedValue + "', Phong= '" + txtPhong.Text + "' " +
                "where MaCTMon='" + dtgvLopHoc.CurrentRow.Cells["MaCTMon"].Value.ToString() + "'");
            loadLopHoc("*");
        }

        private void dtgvLopHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbGV.SelectedValue = dtgvLopHoc.CurrentRow.Cells["MaGV"].Value.ToString();
            cbLop.SelectedValue = dtgvLopHoc.CurrentRow.Cells["MaLop"].Value.ToString();
            cbHocKy.SelectedValue = dtgvLopHoc.CurrentRow.Cells["HocKy"].Value.ToString();
            txtMaMon.Text = dtgvLopHoc.CurrentRow.Cells["MaMonHoc"].Value.ToString();
            txtPhong.Text = dtgvLopHoc.CurrentRow.Cells["Phong"].Value.ToString();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            if (AccountDAO.Instance.getQuyenByUser(mgv).Equals("admin"))
            {
                loadCBGV("*");
                loadCBLop("*");
                loadCBKhoa("*");
                loadCBKhoa2("*");
                loadCBHK();

                loadMon(cbKhoa.SelectedValue.ToString());
                loadLopHoc("*");
            }
            else if (AccountDAO.Instance.getQuyenByUser(mgv).Equals("tk"))
            {
                loadCBKhoa(GiangVienDAO.Instance.getKhoabyMGV(mgv));
                loadCBKhoa2(GiangVienDAO.Instance.getKhoabyMGV(mgv));
                loadCBLop(GiangVienDAO.Instance.getKhoabyMGV(mgv));
                loadCBGV(GiangVienDAO.Instance.getKhoabyMGV(mgv));

                loadMon(cbKhoa.SelectedValue.ToString());
                loadLopHoc("*");
                loadCBHK();
            }
        }

        private void cbLop_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void cbKhoa2_SelectedValueChanged(object sender, EventArgs e)
        {
            loadMon(cbKhoa2.SelectedValue.ToString());
            loadCBLop(cbKhoa2.SelectedValue.ToString());
        }
    }
}
