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
        public ucDiem()
        {
            InitializeComponent();
            loadDiem();
            loadCBLop("*");
        }

        public void loadDiem()
        {
            dtgvDiem.DataSource = DataProvider.Instance.ExcuteQuery("Select * from DiemLopHoc");
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            loadDiem();
            txtChuyenCan.ResetText();
            txtGiuaKy.ResetText();
            txtTP.ResetText();
            txtThi.ResetText();
            txtKT.ResetText();
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
            lblMaSV.Text = "Mã sinh viên: ";
            lblMaSV.Text = "Mã sinh viên: "+ dtgvDiem.CurrentRow.Cells["MaSV"].Value.ToString();
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
        }
    }
}
