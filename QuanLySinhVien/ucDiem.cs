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
    public partial class ucDiem : UserControl
    {
        public Panel pn { get { return panel1; } }
        public Panel pn2 { get { return panel2; } }
        public Panel pn3 { get { return panel3; } }
        public Label lbl1 { get { return lblTenSV; } }
        public Label lbl2 { get { return lblLop ; } }
        public Label lbl3 { get { return lblDiemTL; } }
        public string mgv;
        public ucDiem(string gv)
        {
            mgv = gv;

            InitializeComponent();
            

            if (AccountDAO.Instance.getQuyenByUser(mgv).Equals("admin"))
            {
                loadCBKhoa("*");
                try
                {
                    loadCBGV(cbKhoa.SelectedValue.ToString());
                    loadCBLop(cbGV.SelectedValue.ToString());
                }
                catch { }
            }
            else
            {
                loadCBLop(mgv);
                loadCBGV(mgv);
                loadCBKhoa(GiangVienDAO.Instance.getKhoabyMGV(mgv));
            }
        }

        public void loadDiem(string mon)
        {
            dtgvDiem.DataSource = DataProvider.Instance.ExcuteQuery("Select * from DiemLopHoc");
            if (mon.Equals("*"))
                dtgvDiem.DataSource = DataProvider.Instance.ExcuteQuery("Select * from DiemLopHoc");
            else
                dtgvDiem.DataSource = DataProvider.Instance.ExcuteQuery("Select * from DiemLopHoc where MaCTMon='"+mon+"'");
        }

        public void loadCBLop(string gv)
        {
            if (gv.Equals("*"))
                cbLop.DataSource = DataProvider.Instance.ExcuteQuery("Select * from LopHoc");
            else
                cbLop.DataSource = DataProvider.Instance.ExcuteQuery("Select * from LopHoc where MaGV='"+gv+"'");
            cbLop.DisplayMember = "MaCTMon";
            cbLop.ValueMember = "MaCTMon";
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

        public void loadCBGV(string khoa)
        {
            if (khoa.Equals("*"))
                cbGV.DataSource = DataProvider.Instance.ExcuteQuery("Select * from GiangVien");
            else
                cbGV.DataSource = DataProvider.Instance.ExcuteQuery("Select * from GiangVien where MaGV='" + khoa + "'");
            cbGV.DisplayMember = "TenGV";
            cbGV.ValueMember = "MaGV";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            loadCBLop("*");
            loadDiem(cbLop.SelectedValue.ToString());
            txtChuyenCan.ResetText();
            txtGiuaKy.ResetText();
            txtTP.ResetText();
            txtThi.ResetText();
            txtKT.ResetText();

            if (AccountDAO.Instance.getQuyenByUser(mgv).Equals("admin"))
            {
                loadCBLop("*");
                loadDiem(cbLop.SelectedValue.ToString());
            }
            else
            {
                loadCBLop(mgv);
                loadDiem(cbLop.SelectedValue.ToString());
            }
        }

        private void cbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dtgvDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtChuyenCan.Text = dtgvDiem.CurrentRow.Cells["ChuyenCan"].Value.ToString();
            txtGiuaKy.Text = dtgvDiem.CurrentRow.Cells["DiemGiuaKy"].Value.ToString();
            txtThi.Text = dtgvDiem.CurrentRow.Cells["DiemThi"].Value.ToString();
            txtTP.Text = dtgvDiem.CurrentRow.Cells["DiemTP"].Value.ToString();
            txtKT.Text = dtgvDiem.CurrentRow.Cells["DiemKT"].Value.ToString();
            lblDiemTL.Text = "Điểm tích luỹ: ";
            lblDiemTL.Text = "Điểm tích luỹ: " + SinhVienDAO.Instance.getdiemTL(dtgvDiem.CurrentRow.Cells["MaSV"].Value.ToString());
            lblTenSV.Text = "Tên sinh viên: ";
            lblTenSV.Text = "Tên sinh viên: " + SinhVienDAO.Instance.getTenformMa(dtgvDiem.CurrentRow.Cells["MaSV"].Value.ToString());
            lblLop.Text = "Lớp: ";
            lblLop.Text = "Lớp: " + LopDAO.Instance.getTenfromID(SinhVienDAO.Instance.getLopformMa(dtgvDiem.CurrentRow.Cells["MaSV"].Value.ToString()));
        }

        private void txtChuyenCan_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double cc = Convert.ToDouble(txtChuyenCan.Text) * (Convert.ToDouble(txtPTCC.Text) / 100);
                double gk = Convert.ToDouble(txtGiuaKy.Text) * (Convert.ToDouble(txtPTGK.Text) / 100);
                txtTP.Text = (cc + gk).ToString();
            }
            catch { }
        }

        private void txtGiuaKy_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double cc = Convert.ToDouble(txtChuyenCan.Text) * (Convert.ToDouble(txtPTCC.Text) / 100);
                double gk = Convert.ToDouble(txtGiuaKy.Text) * (Convert.ToDouble(txtPTGK.Text) / 100);
                txtTP.Text = (cc + gk).ToString();
            }
            catch { }
        }

        private void txtTP_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double tp = Convert.ToDouble(txtTP.Text) * (Convert.ToDouble(txtPTTP.Text) / 100);
                double thi = Convert.ToDouble(txtThi.Text) * (Convert.ToDouble(txtPTDT.Text) / 100);
                txtKT.Text = (tp + thi).ToString();
            }
            catch { }
        }

        private void txtThi_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double tp = Convert.ToDouble(txtTP.Text) * (Convert.ToDouble(txtPTTP.Text) / 100);
                double thi = Convert.ToDouble(txtThi.Text) * (Convert.ToDouble(txtPTDT.Text) / 100);
                txtKT.Text = (tp + thi).ToString();
            }
            catch { }
        }

        private void btnLuuDIem_Click(object sender, EventArgs e)
        {
            DiemDAO.Instance.suaDiem(Convert.ToDecimal(txtChuyenCan.Text), Convert.ToDecimal(txtGiuaKy.Text), Convert.ToDecimal(txtTP.Text),
                Convert.ToDecimal(txtThi.Text), Convert.ToDecimal(txtKT.Text), 
                dtgvDiem.CurrentRow.Cells["MaCTMon"].Value.ToString(), dtgvDiem.CurrentRow.Cells["MaSV"].Value.ToString());
            loadDiem("*");
        }

        private void txtPTCC_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtPTGK.Text = (100 - Convert.ToInt32(txtPTCC.Text)).ToString();
            }
            catch { }
        }

        private void txtPTGK_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtPTCC.Text = (100 - Convert.ToInt32(txtPTGK.Text)).ToString();
            }
            catch { }
        }

        private void txtPTTP_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtPTDT.Text = (100 - Convert.ToInt32(txtPTTP.Text)).ToString();
            }
            catch { }
        }

        private void txtPTDT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtPTTP.Text = (100 - Convert.ToInt32(txtPTDT.Text)).ToString();
            }
            catch { }
        }

        private void txtPTCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void cbLop_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                loadDiem(cbLop.SelectedValue.ToString());
            }
            catch { }
        }

        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbKhoa_SelectedValueChanged(object sender, EventArgs e)
        {
            if (AccountDAO.Instance.getQuyenByUser(mgv).Equals("admin"))
            {
                try
                {
                    cbGV.DataSource = DataProvider.Instance.ExcuteQuery("Select * from GiangVien where MaKhoa='" + cbKhoa.SelectedValue.ToString() + "'");
                    cbGV.DisplayMember = "TenGV";
                    cbGV.ValueMember = "MaGV";
                }
                catch { }
            }
        }

        private void cbGV_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                loadCBLop(cbGV.SelectedValue.ToString());
            }
            catch { }
        }
    }
}
