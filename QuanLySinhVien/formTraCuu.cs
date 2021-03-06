﻿using QuanLySinhVien.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class formTraCuu : Form
    {
        public formTraCuu()
        {
            InitializeComponent();
        }

        //bool IsTheSameCellValue(int column, int row)
        //{
        //    DataGridViewCell cell1 = dtgvDiem[column, row];
        //    DataGridViewCell cell2 = dtgvDiem[column, row - 1];
        //    if (cell1.Value == null || cell2.Value == null)
        //    {
        //        return false;
        //    }
        //    return cell1.Value.ToString() == cell2.Value.ToString();
        //}

        private void formTraCuu_Load(object sender, EventArgs e)
        {
            guna2ShadowPanel1.Width = 320;
            try
            {
                DataProvider.Constr = ConfigurationManager.AppSettings["constr"];
            }
            catch { }
        }

        private void dtgvDiem_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            //if (e.RowIndex < 1 || e.ColumnIndex < 0)
            //    return;
            //if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
            //{
            //    e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            //}
            //else
            //{
            //    e.AdvancedBorderStyle.Top = dtgvDiem.AdvancedCellBorderStyle.Top;
            //}
        }

        private void dtgvDiem_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //if (e.RowIndex == 0)
            //    return;
            //if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
            //{
            //    e.Value = "";
            //    e.FormattingApplied = true;
            //}
        }

        public void loadDiem(string msv)
        {
            dtgvDiem.DataSource = DataProvider.Instance.ExcuteQuery("SELECT HocKy, TenMon, DiemKT FROM dbo.DiemHocPhan, dbo.LopHocPhan, dbo.MonHoc " +
                "WHERE DiemHocPhan.MaHP=LopHocPhan.MaHP AND LopHocPhan.MaMon=MonHoc.MaMon AND MaSV='" + msv + "'");
        }

        public void loadMon(string msv)
        {
            dtgvMon.DataSource = DataProvider.Instance.ExcuteQuery("SELECT TenMon, TinChi,TenGV, Phong FROM dbo.DiemHocPhan, dbo.LopHocPhan, dbo.MonHoc, dbo.GiangVien " +
                "WHERE DiemHocPhan.MaHP = LopHocPhan.MaHP AND LopHocPhan.MaMon = MonHoc.MaMon AND LopHocPhan.MaGV = GiangVien.MaGV and TrangThai=0 AND MaSV = '" + msv + "'");
        }

        public void loadCBMon()
        {
            try
            {
                string msv = txtMSV.Text.Trim();
                int ky = SinhVienDAO.Instance.getSoKy(msv)+1;
                string nganh = LopDAO.Instance.getNganhfromLop(SinhVienDAO.Instance.getLopformMa(msv));
                cbMonHoc.DataSource = DataProvider.Instance.ExcuteQuery("Select MonHoc.MaMon,TenMon from MonHoc where MaNganh='" + nganh + "' and SoKy=" + ky + " " +
                        "UNION ALL " +
                        "Select MonHoc.MaMon, TenMon from MonHoc, NoMon where MonHoc.MaMon=NoMon.MaMon AND MaSV = '" + msv + "'");
                cbMonHoc.DisplayMember = "TenMon";
                cbMonHoc.ValueMember = "MaMon";
            }
            catch { }
        }
        private void txtMSV_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string msv = txtMSV.Text;
                if (SinhVienDAO.Instance.checkSV(msv) == 1)
                {
                    picCheckSV.Image = Properties.Resources.checked_checkbox_60px;
                    lblTen.Text = SinhVienDAO.Instance.getTenformMa(msv);
                    lblLop.Text = SinhVienDAO.Instance.getLopformMa(msv);
                    lblTL.Text = Convert.ToDouble(SinhVienDAO.Instance.getdiemTL(msv)).ToString("#.##");
                    chrDiemHK.DataSource = DataProvider.Instance.ExcuteQuery("Select MaHK, DiemTichLuy from CTHocKy where MaSV='" + txtMSV.Text + "'");
                    chrDiemHK.Series[0].XValueMember = "MaHK";
                    chrDiemHK.Series[0].YValueMembers = "DiemTichLuy";
                    chrDiemHK.DataBind();
                    try
                    {
                        loadDiem(msv);
                        loadMon(msv);
                        loadCBMon();
                    }
                    catch { }
                }
            }
            catch { MessageBox.Show("Hãy kết nối trước khi đăng nhập"); }
        }

        private void guna2ImageButton1_MouseHover(object sender, EventArgs e)
        {
            guna2ImageButton1.BackColor = Color.OrangeRed;
        }

        private void guna2ImageButton1_MouseLeave(object sender, EventArgs e)
        {
            guna2ImageButton1.BackColor = Color.Transparent;
        }

        private void guna2ImageButton2_MouseHover(object sender, EventArgs e)
        {
            guna2ImageButton2.BackColor = Color.FromArgb(224, 180, 0);
        }

        private void guna2ImageButton2_MouseLeave(object sender, EventArgs e)
        {
            guna2ImageButton2.BackColor = Color.Transparent;
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (AccountDAO.Instance.checkLogin(txtUser.Text, txtPass.Text) == 1)
                {
                    Main m = new Main(txtUser.Text);
                    this.Hide();
                    m.Show();
                }
                else
                {
                    lblErrorLogin.Text = "Sai tên đăng nhập hoặc mật khẩu";
                    lblErrorLogin.Visible = true;
                }
            //}
            //catch { MessageBox.Show("Hãy kết nối trước khi đăng nhập"); }
        }

        private void btnShowLogin_Click(object sender, EventArgs e)
        {
            if (pnLogin.Visible == true)
            {
                pnLogin.Visible = false;
                btnShowLogin.Text = "Đăng nhập";
            }
            else
            {
                btnShowLogin.Text = "Quay lại";
                pnLogin.Visible = true;
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (txtResUser.Text == "") { lblResError.Text = "Bạn phải nhập tên đăng nhập!"; lblResError.Visible = true; }
                else if (txtResPass.Text == "") { lblResError.Text = "Bạn phải nhập mật khẩu!"; lblResError.Visible = true; }
                else if (txtResPass2.Text == "") { lblResError.Text = "Vui lòng nhập lại mật khẩu!"; lblResError.Visible = true; }
                else if (txtResPass.Text.Equals(txtResPass2.Text))
                {
                    if (DataProvider.Instance.ExcuteQuery("Select * from Account").Rows.Count <= 0)
                    {
                        DataProvider.Instance.ExcuteNonQuery("Insert into Account values('" + txtResUser.Text + "', '" + txtResPass.Text + "','admin', 'white')");
                        lblResError.Visible = false;
                        guna2ShadowPanel1.Width = 320;
                        guna2ShadowPanel1.Left += 140;

                        lblRes.Enabled = true;
                    }
                    else
                    {
                        if (GiangVienDAO.Instance.checkMGV(txtResUser.Text) == 1)
                        {
                            if (AccountDAO.Instance.checkTenDN(txtResUser.Text) == 0)
                            {
                                if (GiangVienDAO.Instance.getTKbyMGV(txtResUser.Text).Equals("None"))
                                    DataProvider.Instance.ExcuteNonQuery("Insert into Account values('" + txtResUser.Text + "', '" + txtResPass.Text + "','gv', 'white')");
                                else
                                    DataProvider.Instance.ExcuteNonQuery("Insert into Account values('" + txtResUser.Text + "', '" + txtResPass.Text + "','tk', 'white')");
                                lblResError.Visible = false;
                                guna2ShadowPanel1.Width = 320;
                                guna2ShadowPanel1.Left += 140;

                                lblRes.Enabled = true;
                            }
                            else { lblResError.Text = "Mã giáo viên đã được đăng ký tài khoản!"; lblResError.Visible = true; }
                        }
                        else { lblResError.Text = "Mã giảng viên không tồn tại!"; lblResError.Visible = true; }
                    }
                }
                else { lblResError.Text = "Nhập lại mật khẩu không đúng!"; lblResError.Visible = true; }
            //}
            //catch { MessageBox.Show("Hãy kết nối trước khi đăng ký"); }
        }

        private void lblRes_Click(object sender, EventArgs e)
        {
            guna2ShadowPanel1.Width = 598;
            guna2ShadowPanel1.Left -= 140;
            lblRes.Enabled = false;
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            guna2ShadowPanel1.Width = 320;
            guna2ShadowPanel1.Left += 140;

            lblRes.Enabled = true;
        }

        private void txtResPass_Enter(object sender, EventArgs e)
        {
            txtResPass.UseSystemPasswordChar = true;
            txtResPass2.UseSystemPasswordChar = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                txtPass.UseSystemPasswordChar = false;
            else
                txtPass.UseSystemPasswordChar = true;
        }

        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            formKetNoi kn = new formKetNoi();
            kn.ShowDialog();
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnDangKyMon_Click(object sender, EventArgs e)
        {
            string msv = txtMSV.Text;
            if (DataProvider.Instance.ExcuteQuery("Select * from DiemHocPhan where MaSV='" + msv + "' and MaHP='" + cbLopHoc.SelectedValue.ToString() + "'").Rows.Count <= 0)
            {
                if (SinhVienDAO.Instance.checkSV(msv) == 1)
                {
                    DataProvider.Instance.ExcuteNonQuery("Insert into DiemHocPhan values('" + cbLopHoc.SelectedValue + "', '" + msv + "', 0, 0,0,0,0,0,0,0)");
                    DiemDAO.Instance.themCTHocKy(cbLopHoc.SelectedValue.ToString(), msv);
                    loadMon(txtMSV.Text.Trim());
                }
            }
            else { /*lblLoi.Visible = true; lblLoi.Text = "Sinh viên đã đăng ký môn này"; timer1.Enabled = true;*/
                MessageBox.Show("Sinh viên đã đăng ký môn này");
            }
        }

        private void cbMonHoc_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                string mhk = DataProvider.Instance.ExcuteQuery("Select MaHK from HocKy where TrangThai=0").Rows[0][0].ToString();
                cbLopHoc.DataSource = DataProvider.Instance.ExcuteQuery("Select * from LopHocPhan where HocKy='" + mhk + "' and MaMon='" + cbMonHoc.SelectedValue + "'");
                cbLopHoc.DisplayMember = "MaHP";
                cbLopHoc.ValueMember = "MaHP";
            }
            catch { }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            panel6.Visible = false;
        }

        private void guna2Button2_Click_2(object sender, EventArgs e)
        {
            panel6.Visible = true;
        }
    }
}
