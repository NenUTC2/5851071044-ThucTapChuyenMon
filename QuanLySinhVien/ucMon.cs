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
        //public Label lbl3 { get { return label3; } }
        public Label lbl1 { get { return label1; } }
        public Label lbl2 { get { return label2; } }

        public string mgv;
        public ucMon(string gv)
        {
            mgv = gv;
            InitializeComponent();
            loadHK();
            loadLopHoc("*");

            if (AccountDAO.Instance.getQuyenByUser(mgv).Equals("admin"))
            {
                loadCBNganh("*");
            }
            else if (AccountDAO.Instance.getQuyenByUser(mgv).Equals("tk"))
            {
                loadCBNganh(GiangVienDAO.Instance.getKhoabyMGV(mgv));
            }
        }

        public void loadMon(string khoa)
        {
            if (khoa.Equals("*"))
                dtgvMonHoc.DataSource = DataProvider.Instance.ExcuteQuery("Select * from MonHoc");
            else
                dtgvMonHoc.DataSource = DataProvider.Instance.ExcuteQuery("Select * from MonHoc where MaNganh='"+khoa+"'");
        }

        public void loadLopHoc(string khoa)
        {
            if (khoa.Equals("*"))
                dtgvLopHoc.DataSource = DataProvider.Instance.ExcuteQuery("Select * from LopHocPhan");
            else
                dtgvLopHoc.DataSource = DataProvider.Instance.ExcuteQuery("SELECT MaHP,LopHocPhan.MaMon,MaGV,MaLop,phong,HocKy,TrangThai FROM dbo.LopHocPhan, dbo.MonHoc " +
                    "WHERE LopHocPhan.MaMon=MonHoc.MaMon AND MaKhoa='" + khoa + "'");
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
                cbLop.DataSource = DataProvider.Instance.ExcuteQuery("Select * from Lop where MaNganh='" + khoa + "'");
            cbLop.DisplayMember = "TenLop";
            cbLop.ValueMember = "MaLop";
        }

        public void loadCBNganh(string khoa)
        {
            if (khoa.Equals("*"))
            {
                cbNganh.DataSource = DataProvider.Instance.ExcuteQuery("Select * from Nganh");
                cbNganh2.DataSource = DataProvider.Instance.ExcuteQuery("Select * from Nganh");
            }
            else
            {
                cbNganh.DataSource = DataProvider.Instance.ExcuteQuery("Select * from Nganh where MaKhoa='" + khoa + "'");
                cbNganh2.DataSource = DataProvider.Instance.ExcuteQuery("Select * from Nganh where MaKhoa='" + khoa + "'");
            }
            cbNganh.DisplayMember = "TenNganh";
            cbNganh2.DisplayMember = "TenNganh";
            cbNganh.ValueMember = "MaNganh";
            cbNganh2.ValueMember = "MaNganh";
        }

        //public void loadCBNganh2(string khoa)
        //{
        //    if (khoa.Equals("*"))
        //        cbNganh2.DataSource = DataProvider.Instance.ExcuteQuery("Select * from Nganh");
        //    else
        //        cbNganh2.DataSource = DataProvider.Instance.ExcuteQuery("Select * from Nganh where MaKhoa='" + khoa + "'");
        //    cbNganh2.DisplayMember = "TenNganh";
        //    cbNganh2.ValueMember = "MaNganh";
        //}

        public void loadHK()
        {
            if(DataProvider.Instance.ExcuteQuery("Select * from HocKy where TrangThai=0").Rows.Count > 0)
            {
                txtHocKy.ReadOnly = true;
                txtHocKy.Text = DataProvider.Instance.ExcuteQuery("Select MaHK from HocKy where TrangThai=0").Rows[0][0].ToString();
                btnKTHK.Visible = true;
                btnTaoHK.Visible = false;
            }else
            {
                txtHocKy.ReadOnly = false;
                btnKTHK.Visible = false;
                btnTaoHK.Visible = true;
            }
        }
        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            loadLopHoc("*");

            if (AccountDAO.Instance.getQuyenByUser(mgv).Equals("admin"))
            {
                loadCBNganh("*");
            }
            else if (AccountDAO.Instance.getQuyenByUser(mgv).Equals("tk"))
            {
                loadCBNganh(GiangVienDAO.Instance.getKhoabyMGV(mgv));
            }
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
            if (DataProvider.Instance.ExcuteQuery("Select * from MonHoc where Mamon='" + txtMaMonTao.Text + "'").Rows.Count > 0)
            {
                lblLoi.Visible = true; lblLoi.Text = "Mã môn đã tồn tại"; timer1.Enabled = true;
            }
            else
            {
                if (txtMaMonTao.Text != "" && txtTenMon.Text != "" && nbrTinChi.Value > 0)
                {
                    DataProvider.Instance.ExcuteNonQuery("Insert into MonHoc values(" +
                        " '" + txtMaMonTao.Text + "', N'" + txtTenMon.Text + "', '" + cbNganh.SelectedValue + "', " + nbrTinChi.Value + ", " + nbrKy.Value + ")");
                    loadMon("*");
                }
                else { lblLoi.Visible = true; lblLoi.Text = "Vui lòng nhập đầy đủ thông tin môn"; timer1.Enabled = true; }
            }
        }

        private void btnSuaMon_Click(object sender, EventArgs e)
        {
            if (txtTenMon.Text != "" && txtMaMonTao.Text != "" && nbrTinChi.Value > 0)
            {
                DataProvider.Instance.ExcuteNonQuery("Update MonHoc set " +
                    "TenMon = N'" + txtTenMon.Text + "', MaNganh = '" + cbNganh.SelectedValue + "', TinChi = " + nbrTinChi.Value + ", SoKy="+nbrKy.Value+" where MaMon = '" + txtMaMonTao.Text + "'");
                loadMon("*");
            }
            else { lblLoi.Visible = true; lblLoi.Text = "Vui lòng nhập đầy đủ thông tin môn"; timer1.Enabled = true; }
        }

        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            DataProvider.Instance.ExcuteNonQuery("Delete from MonHoc where MaMon='"+ dtgvMonHoc.CurrentRow.Cells["MaMon"].Value.ToString() + "'");
            loadMon("*");
        }

        private void dtgvMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //cbNganh.SelectedValue = dtgvMonHoc.CurrentRow.Cells["MaNganh"].Value.ToString();
            txtMaMonTao.Text = dtgvMonHoc.CurrentRow.Cells["MaMon"].Value.ToString();
            txtMaMon.Text = dtgvMonHoc.CurrentRow.Cells["MaMon"].Value.ToString();
            txtTenMon.Text = dtgvMonHoc.CurrentRow.Cells["TenMon"].Value.ToString();
            nbrTinChi.Value = Convert.ToInt32(dtgvMonHoc.CurrentRow.Cells["TinChi"].Value);
            nbrKy.Value = Convert.ToInt32(dtgvMonHoc.CurrentRow.Cells["SoKy"].Value);

            loadCBLop(dtgvMonHoc.CurrentRow.Cells["MaNganh"].Value.ToString());
            loadCBGV(KhoaDAO.Instance.getKhoaByNganh(dtgvMonHoc.CurrentRow.Cells["MaNganh"].Value.ToString()));
            dtgvLopHoc.DataSource = DataProvider.Instance.ExcuteQuery("Select * from LopHocPhan " +
                "where MaMon='" + dtgvMonHoc.CurrentRow.Cells["MaMon"].Value.ToString() + "'");
        }

        private void cbKhoa_SelectedValueChanged(object sender, EventArgs e)
        {
            txtMaMonTao.Text = cbNganh.SelectedValue.ToString()+"-";
            loadMon(cbNganh.SelectedValue.ToString());
        }

        private void btnMoLop_Click(object sender, EventArgs e)
        {
            if (txtMaMon.Text != "" && txtPhong.Text != "")
            {
                int count = Convert.ToInt32(DataProvider.Instance.ExcuteQuery("Select Count(*) from LopHocPhan where MaHP like '%" + txtMaMon.Text + "%' ").Rows[0][0].ToString());
                count += 1;
                DataProvider.Instance.ExcuteNonQuery("insert into LopHocPhan values('" + txtMaMon.Text + "-" + count + "', " +
                    "'" + txtMaMon.Text + "', '" + cbGV.SelectedValue + "', '" + cbLop.SelectedValue + "', '" + txtPhong.Text + "', '" + txtHocKy.Text + "', 0)");
                loadLopHoc("*");
            }
            else { lblLoi.Visible = true; lblLoi.Text = "Vui lòng nhập đầy đủ thông tin lớp học phần"; timer1.Enabled = true; }
        }

        private void btnShowtxt_Click(object sender, EventArgs e)
        {
            DataProvider.Instance.ExcuteNonQuery("insert into HocKy values('" + txtHocKy.Text + "','',0)");
            txtHocKy.ReadOnly = true;
            txtHocKy.Text = DataProvider.Instance.ExcuteQuery("Select MaHK from HocKy where TrangThai=0").Rows[0][0].ToString();
            btnKTHK.Visible = true;
            btnTaoHK.Visible = false;
        }

        private void btnThemHK_Click(object sender, EventArgs e)
        {
            if (DataProvider.Instance.ExcuteQuery("Select * from LopHocPhan where trangthai=0").Rows.Count > 0)
            {
                lblLoi.Text = "Kết thúc tất cả các môn trong kỳ và thử lại";
                lblLoi.Visible = true;
                timer1.Enabled = true;
            }
            else
            {
                DataProvider.Instance.ExcuteNonQuery("Update SinhVien set SoKy+=1");
                DataProvider.Instance.ExcuteNonQuery("Update HocKY set TrangThai=1 where MaHK='"+txtHocKy.Text+"'");
                txtHocKy.ReadOnly = false;
                btnKTHK.Visible = false;
                btnTaoHK.Visible = true;
            }
        }

        private void btnXoaLop_Click(object sender, EventArgs e)
        {
            DataProvider.Instance.ExcuteNonQuery("Delete from LopHocPhan where MaHP='"+dtgvLopHoc.CurrentRow.Cells["MaHP"].Value.ToString()+"'");
            loadLopHoc("*");
        }

        private void btnSuaLop_Click(object sender, EventArgs e)
        {
            if (txtPhong.Text != "")
            {
                DataProvider.Instance.ExcuteNonQuery("Update LopHocPhan set" +
                    " MaGV= '" + cbGV.SelectedValue + "', Phong= '" + txtPhong.Text + "' " +
                    "where MaHP='" + dtgvLopHoc.CurrentRow.Cells["MaHP"].Value.ToString() + "'");
                loadLopHoc("*");
            }
            else { lblLoi.Visible = true; lblLoi.Text = "Vui lòng nhập đầy đủ thông tin phòng học"; timer1.Enabled = true; }
        }

        private void dtgvLopHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbGV.SelectedValue = dtgvLopHoc.CurrentRow.Cells["MaGV"].Value.ToString();
            cbLop.SelectedValue = dtgvLopHoc.CurrentRow.Cells["MaLop"].Value.ToString();
           // txtHocKy.Text = dtgvLopHoc.CurrentRow.Cells["HocKy"].Value.ToString();
            txtMaMon.Text = dtgvLopHoc.CurrentRow.Cells["MaMonHoc"].Value.ToString();
            txtPhong.Text = dtgvLopHoc.CurrentRow.Cells["Phong"].Value.ToString();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            if (AccountDAO.Instance.getQuyenByUser(mgv).Equals("admin"))
            {
                loadCBGV("*");
                loadCBLop("*");
                loadCBNganh("*");
                //loadCBNganh2("*");
                loadHK();

                loadMon(cbNganh.SelectedValue.ToString());
                loadLopHoc("*");
            }
            else if (AccountDAO.Instance.getQuyenByUser(mgv).Equals("tk"))
            {
                loadCBNganh(GiangVienDAO.Instance.getKhoabyMGV(mgv));
                //loadCBNganh2(GiangVienDAO.Instance.getKhoabyMGV(mgv));
                loadCBLop(GiangVienDAO.Instance.getKhoabyMGV(mgv));
                loadCBGV(GiangVienDAO.Instance.getKhoabyMGV(mgv));

                loadMon(cbNganh.SelectedValue.ToString());
                loadLopHoc("*");
                loadHK();
            }
        }

        private void cbLop_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void cbKhoa2_SelectedValueChanged(object sender, EventArgs e)
        {
            loadMon(cbNganh2.SelectedValue.ToString());
            loadCBLop(cbNganh2.SelectedValue.ToString());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblLoi.Visible = false;
            timer1.Enabled = false;
        }

        private void nbrKyHP_ValueChanged(object sender, EventArgs e)
        {
            dtgvMon.DataSource = DataProvider.Instance.ExcuteQuery("Select * from MonHoc where MaNganh='"+cbNganh2.SelectedValue+"' and SoKy=" + nbrKyHP.Value);
        }
    }
}
