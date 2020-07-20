using QuanLySinhVien.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class Main : Form
    {
        public string mgv;
        public string timkiem="ucd";
        public Main(string gv)
        {
            mgv = gv;
            InitializeComponent();
            panel1.Width = 60;
            lblTime.Text = DateTime.Now.ToString("hh:mm");
            lblDay.Text = DateTime.Now.ToString("dd/MM");

            ucsv = new ucSV(mgv);
            ucd = new ucDiem(mgv);
            ucgv = new ucGV(mgv);
            ucm = new ucMon(mgv);
            ucl = new ucLop(mgv);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
            //Theme
            if(DataProvider.Instance.ExcuteQuery("Select theme from Account where TenDN='" + mgv + "'").Rows[0][0].ToString().Equals("black"))
            {
                txtTimKiem.FillColor = Color.FromArgb(11, 14, 21);
                txtTimKiem.ForeColor = Color.White;
                txtTimKiem.PlaceholderForeColor = Color.Silver;
                picTK.Image = Properties.Resources.searchw_48px;
                picTK.BackColor = Color.FromArgb(11, 14, 21);

                guna2CircleButton1.Text = "ON";
                guna2CircleButton1.FillColor = Color.FromArgb(4, 197, 150);
                guna2CircleButton1.ForeColor = Color.White;

                uck.pn.BackColor = Color.FromArgb(21, 24, 31);
                uck.pn2.BackColor = Color.FromArgb(31, 34, 41);
                uck.pn3.BackColor = Color.FromArgb(31, 34, 41);
                uck.pn5.BackColor = Color.FromArgb(31, 34, 41);
                uck.lbltenkhoa.ForeColor = Color.White;
                uck.lbllop.ForeColor = Color.White;
                uck.lblgv.ForeColor = Color.White;
                uck.lblsv.ForeColor = Color.White;

                ucl.pn.BackColor = Color.FromArgb(21, 24, 31);
                ucl.pn2.BackColor = Color.FromArgb(31, 34, 41);
                ucl.pn3.BackColor = Color.FromArgb(31, 34, 41);
                ucl.lblsv.ForeColor = Color.White;

                ucgv.pn.BackColor = Color.FromArgb(21, 24, 31);
                ucgv.pn2.BackColor = Color.FromArgb(31, 34, 41);
                ucgv.pn3.BackColor = Color.FromArgb(31, 34, 41);
                ucgv.chktk.ForeColor = Color.White;

                ucsv.pn.BackColor = Color.FromArgb(21, 24, 31);
                ucsv.pn2.BackColor = Color.FromArgb(31, 34, 41);
                ucsv.pn3.BackColor = Color.FromArgb(31, 34, 41);
                //ucsv.lbl1.ForeColor = Color.White;

                ucm.pn.BackColor = Color.FromArgb(21, 24, 31);
                ucm.pn2.BackColor = Color.FromArgb(31, 34, 41);
                ucm.pn3.BackColor = Color.FromArgb(31, 34, 41);
                ucm.lbl1.ForeColor = Color.White;
                ucm.lbl2.ForeColor = Color.White;
                //ucm.lbl3.ForeColor = Color.White;

                ucd.pn.BackColor = Color.FromArgb(21, 24, 31);
                ucd.pn2.BackColor = Color.FromArgb(31, 34, 41);
                ucd.pn3.BackColor = Color.FromArgb(31, 34, 41);
                ucd.pn4.BackColor = Color.FromArgb(31, 34, 41);
                ucd.lbl1.ForeColor = Color.White;
                ucd.lbl2.ForeColor = Color.White;
                ucd.lbl3.ForeColor = Color.White;
                ucd.lblvang.ForeColor = Color.White;
                ucd.chk1.ForeColor = Color.White;
                ucd.chk2.ForeColor = Color.White;

                uctk.pn.BackColor = Color.FromArgb(21, 24, 31);
                pnDoiPass.BackColor = Color.White;
            }
            else
            {
                txtTimKiem.FillColor = Color.White;
                txtTimKiem.ForeColor = Color.Black;
                txtTimKiem.PlaceholderForeColor = Color.Gray;
                picTK.Image = Properties.Resources.search_48px;
                picTK.BackColor = Color.White;

                guna2CircleButton1.Text = "OFF";
                guna2CircleButton1.FillColor = Color.Black;
                guna2CircleButton1.ForeColor = Color.Gray;

                uck.pn.BackColor = Color.FromArgb(230, 230, 230);
                uck.pn2.BackColor = Color.White;
                uck.pn3.BackColor = Color.White;
                uck.pn5.BackColor = Color.White;
                uck.lbltenkhoa.ForeColor = Color.Black;
                uck.lbllop.ForeColor = Color.Black;
                uck.lblgv.ForeColor = Color.Black;
                uck.lblsv.ForeColor = Color.Black;

                ucl.pn.BackColor = Color.FromArgb(230, 230, 230);
                ucl.pn2.BackColor = Color.White;
                ucl.pn3.BackColor = Color.White;
                ucl.lblsv.ForeColor = Color.Black;

                ucgv.pn.BackColor = Color.FromArgb(230, 230, 230);
                ucgv.pn2.BackColor = Color.White;
                ucgv.pn3.BackColor = Color.White;
                ucgv.chktk.ForeColor = Color.Black;

                ucsv.pn.BackColor = Color.FromArgb(230, 230, 230);
                ucsv.pn2.BackColor = Color.White;
                ucsv.pn3.BackColor = Color.White;
                //ucsv.lbl1.ForeColor = Color.Black;

                ucm.pn.BackColor = Color.FromArgb(230, 230, 230);
                ucm.pn2.BackColor = Color.White;
                ucm.pn3.BackColor = Color.White;
                ucm.lbl1.ForeColor = Color.Black;
                ucm.lbl2.ForeColor = Color.Black;
                //ucm.lbl3.ForeColor = Color.Black;

                ucd.pn.BackColor = Color.FromArgb(230, 230, 230);
                ucd.pn2.BackColor = Color.White;
                ucd.pn3.BackColor = Color.White;
                ucd.pn4.BackColor = Color.White;
                ucd.lbl1.ForeColor = Color.Black;
                ucd.lbl2.ForeColor = Color.Black;
                ucd.lbl3.ForeColor = Color.Black;
                ucd.lblvang.ForeColor = Color.Black;
                ucd.chk1.ForeColor = Color.Black;
                ucd.chk2.ForeColor = Color.Black;

                uctk.pn.BackColor = Color.FromArgb(230,230,230);
                pnDoiPass.BackColor = Color.FromArgb(31, 34, 41);
            }

            showControl(ucd);
            line.Top = btnDiem.Top + 4;

            if (AccountDAO.Instance.getQuyenByUser(mgv).Equals("admin")) { lblUser.Text = mgv; }

            else if (AccountDAO.Instance.getQuyenByUser(mgv).Equals("tk"))
            {
                lblUser.Text = GiangVienDAO.Instance.getTenGV(mgv);
                btnKhoa.Visible = false;
            }
            else if (AccountDAO.Instance.getQuyenByUser(mgv).Equals("gv"))
            {
                lblUser.Text = GiangVienDAO.Instance.getTenGV(mgv);
                btnKhoa.Visible = false;
                btnGV.Visible = false;
                btnLop.Visible = false;
                btnMon.Visible = false;
                if (DataProvider.Instance.ExcuteQuery("Select * from Lop where GVCN='" + mgv + "'").Rows.Count <= 0)
                    btnSV.Visible = false;
            }
        }

        public void showControl(System.Windows.Forms.Control obj)
        {
            uc.Controls.Clear();
            obj.Dock = DockStyle.Fill;
            uc.Controls.Add(obj);
        }

        public ucKhoa uck = new ucKhoa();
        private void guna2Button5_Click(object sender, EventArgs e)
        {
            line.Top = btnKhoa.Top+4;
            showControl(uck);
            panel1.Width = 60;
            lblUC.Text = "Quản lý khoa";
            txtTimKiem.ResetText();
        }

        public ucLop ucl;
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            line.Top = btnLop.Top + 4;
            showControl(ucl);
            panel1.Width = 60;
            lblUC.Text = "Quản Lý Lớp";
            txtTimKiem.ResetText();
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (panel1.Width >= 230)
                timer1.Enabled = false;
            else
                panel1.Width += 20;
            
        }
        
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (panel1.Width <= 60)
                timer2.Enabled = false;
            else
                panel1.Width -= 20;
        }

        private void uc_Click(object sender, EventArgs e)
        {
            
        }

        public ucDiem ucd;
        private void btnDiem_Click(object sender, EventArgs e)
        {
            line.Top = btnDiem.Top + 4;
            panel1.Width = 60;
            showControl(ucd);
            lblUC.Text = "Nhập sửa điểm";
            txtTimKiem.ResetText();
        }

        public ucSV ucsv;
        private void btnSV_Click(object sender, EventArgs e)
        {
            
            line.Top = btnSV.Top + 4;
            panel1.Width = 60;
            showControl(ucsv);
            lblUC.Text = "Quản lý sinh viên";
            txtTimKiem.ResetText();
        }

        public ucGV ucgv;
        private void btnGV_Click(object sender, EventArgs e)
        {
            line.Top = btnGV.Top + 4;
            panel1.Width = 60;
            showControl(ucgv);
            lblUC.Text = "Quản lý giảng viên";
            txtTimKiem.ResetText();
        }

        public ucMon ucm;
        private void btnMon_Click(object sender, EventArgs e)
        {
            line.Top = btnMon.Top + 4;
            panel1.Width = 60;
            showControl(ucm);
            lblUC.Text = "Quản lý môn học";
            txtTimKiem.ResetText();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            if (panel1.Width <= 60)
                timer1.Enabled = true;
            else
                timer2.Enabled = true;
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2ImageButton1_MouseHover(object sender, EventArgs e)
        {
            guna2ImageButton1.BackColor = Color.OrangeRed;
        }

        private void guna2ImageButton1_MouseLeave(object sender, EventArgs e)
        {
            guna2ImageButton1.BackColor = Color.Transparent;
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void guna2ImageButton2_MouseHover(object sender, EventArgs e)
        {
            guna2ImageButton2.BackColor = Color.FromArgb(224, 180, 0);
        }

        private void guna2ImageButton2_MouseLeave(object sender, EventArgs e)
        {
            guna2ImageButton2.BackColor = Color.Transparent;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm");
            lblDay.Text = DateTime.Now.ToString("dd/MM");
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            if (guna2CircleButton1.Text.Equals("OFF"))
            {
                txtTimKiem.FillColor = Color.FromArgb(11, 14, 21);
                txtTimKiem.ForeColor = Color.White;
                txtTimKiem.PlaceholderForeColor = Color.Silver;
                picTK.Image = Properties.Resources.searchw_48px;
                picTK.BackColor = Color.FromArgb(11, 14, 21);

                guna2CircleButton1.Text = "ON";
                guna2CircleButton1.FillColor = Color.FromArgb(4, 197, 150);
                guna2CircleButton1.ForeColor = Color.White;

                uck.pn.BackColor = Color.FromArgb(21, 24, 31);
                uck.pn2.BackColor = Color.FromArgb(31, 34, 41);
                uck.pn3.BackColor = Color.FromArgb(31, 34, 41);
                uck.pn5.BackColor = Color.FromArgb(31, 34, 41);
                uck.lbltenkhoa.ForeColor = Color.White;
                uck.lbllop.ForeColor = Color.White;
                uck.lblgv.ForeColor = Color.White;
                uck.lblsv.ForeColor = Color.White;

                ucl.pn.BackColor = Color.FromArgb(21, 24, 31);
                ucl.pn2.BackColor = Color.FromArgb(31, 34, 41);
                ucl.pn3.BackColor = Color.FromArgb(31, 34, 41);
                ucl.lblsv.ForeColor = Color.White;

                ucgv.pn.BackColor = Color.FromArgb(21, 24, 31);
                ucgv.pn2.BackColor = Color.FromArgb(31, 34, 41);
                ucgv.pn3.BackColor = Color.FromArgb(31, 34, 41);
                ucgv.chktk.ForeColor = Color.White;

                ucsv.pn.BackColor = Color.FromArgb(21, 24, 31);
                ucsv.pn2.BackColor = Color.FromArgb(31, 34, 41);
                ucsv.pn3.BackColor = Color.FromArgb(31, 34, 41);
                //ucsv.lbl1.ForeColor = Color.White;

                ucm.pn.BackColor = Color.FromArgb(21, 24, 31);
                ucm.pn2.BackColor = Color.FromArgb(31, 34, 41);
                ucm.pn3.BackColor = Color.FromArgb(31, 34, 41);
                ucm.lbl1.ForeColor = Color.White;
                ucm.lbl2.ForeColor = Color.White;
                //ucm.lbl3.ForeColor = Color.White;

                ucd.pn.BackColor = Color.FromArgb(21, 24, 31);
                ucd.pn2.BackColor = Color.FromArgb(31, 34, 41);
                ucd.pn3.BackColor = Color.FromArgb(31, 34, 41);
                ucd.pn4.BackColor = Color.FromArgb(31, 34, 41);
                ucd.lbl1.ForeColor = Color.White;
                ucd.lbl2.ForeColor = Color.White;
                ucd.lbl3.ForeColor = Color.White;
                ucd.lblvang.ForeColor = Color.White;
                ucd.chk1.ForeColor = Color.White;
                ucd.chk2.ForeColor = Color.White;

                uctk.pn.BackColor = Color.FromArgb(21, 24, 31);

                pnDoiPass.BackColor = Color.White;

                DataProvider.Instance.ExcuteNonQuery("Update Account set theme = 'black' where TenDN='" + mgv + "'");
            }
            else
            {
                txtTimKiem.FillColor = Color.White;
                txtTimKiem.ForeColor = Color.Black;
                txtTimKiem.PlaceholderForeColor = Color.Gray;
                picTK.Image = Properties.Resources.search_48px;
                picTK.BackColor = Color.White;

                guna2CircleButton1.Text = "OFF";
                guna2CircleButton1.FillColor = Color.Black;
                guna2CircleButton1.ForeColor = Color.Gray;

                uck.pn.BackColor = Color.FromArgb(230, 230, 230);
                uck.pn2.BackColor = Color.White;
                uck.pn3.BackColor = Color.White;
                uck.pn5.BackColor = Color.White;
                uck.lbltenkhoa.ForeColor = Color.Black;
                uck.lbllop.ForeColor = Color.Black;
                uck.lblgv.ForeColor = Color.Black;
                uck.lblsv.ForeColor = Color.Black;

                ucl.pn.BackColor = Color.FromArgb(230,230,230);
                ucl.pn2.BackColor = Color.White;
                ucl.pn3.BackColor = Color.White;
                ucl.lblsv.ForeColor = Color.Black;

                ucgv.pn.BackColor = Color.FromArgb(230, 230, 230);
                ucgv.pn2.BackColor = Color.White;
                ucgv.pn3.BackColor = Color.White;
                ucgv.chktk.ForeColor = Color.Black;

                ucsv.pn.BackColor = Color.FromArgb(230, 230, 230);
                ucsv.pn2.BackColor = Color.White;
                ucsv.pn3.BackColor = Color.White;
                //ucsv.lbl1.ForeColor = Color.Black;

                ucm.pn.BackColor = Color.FromArgb(230, 230, 230);
                ucm.pn2.BackColor = Color.White;
                ucm.pn3.BackColor = Color.White;
                ucm.lbl1.ForeColor = Color.Black;
                ucm.lbl2.ForeColor = Color.Black;
                //ucm.lbl3.ForeColor = Color.Black;

                ucd.pn.BackColor = Color.FromArgb(230, 230, 230);
                ucd.pn2.BackColor = Color.White;
                ucd.pn3.BackColor = Color.White;
                ucd.pn4.BackColor = Color.White;
                ucd.lbl1.ForeColor = Color.Black;
                ucd.lbl2.ForeColor = Color.Black;
                ucd.lbl3.ForeColor = Color.Black;
                ucd.lblvang.ForeColor = Color.Black;
                ucd.chk1.ForeColor = Color.Black;
                ucd.chk2.ForeColor = Color.Black;

                uctk.pn.BackColor = Color.FromArgb(230, 230, 230);

                pnDoiPass.BackColor = Color.FromArgb(31, 34, 41);

                DataProvider.Instance.ExcuteNonQuery("Update Account set theme = 'white' where TenDN='" + mgv + "'");
            }
        }

        private void lblPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (pnDoiPass.Visible == true)
                pnDoiPass.Visible = false;
            else pnDoiPass.Visible = true;
        }

        private void lblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formTraCuu tc = new formTraCuu();
            this.Close();
            tc.Show();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            ucl.dtgv.DataSource = DataProvider.Instance.ExcuteQuery("select * from Lop where concat(MaLop,MaNganh,TenLop) like '%" + txtTimKiem.Text + "%'");
            ucd.dtgv.DataSource = DataProvider.Instance.ExcuteQuery("select * from DiemHocPhan where concat(MaHP,MaSV) like '%" + txtTimKiem.Text + "%'");
            ucsv.dtgv.DataSource = DataProvider.Instance.ExcuteQuery("select * from SinhVien where concat(MaSV,TenSV,SDT,DiaChi,MaLop) like '%" + txtTimKiem.Text + "%'");
            ucgv.dtgv.DataSource = DataProvider.Instance.ExcuteQuery("select * from GiangVien where concat(MaGV,TenGV,SDT,MaKhoa,DiaChi) like '%" + txtTimKiem.Text + "%'");
            ucm.dtgvMon.DataSource = DataProvider.Instance.ExcuteQuery("select * from MonHoc where concat(MaMon,MaNganh,TenMon,TinChi) like '%" + txtTimKiem.Text + "%'");
            ucm.dtgvHP.DataSource = DataProvider.Instance.ExcuteQuery("select * from LopHocPhan where concat(MaMon,MaGV,MaLop,Phong,HocKy,MaHP) like '%" + txtTimKiem.Text + "%'");
            uck.dtgv.DataSource = DataProvider.Instance.ExcuteQuery("select * from Khoa where concat(MaKhoa,TenKhoa) like '%" + txtTimKiem.Text + "%'");
            uck.dtgvN.DataSource = DataProvider.Instance.ExcuteQuery("select * from Nganh where concat(MaNganh,TenNganh,MaKhoa) like '%" + txtTimKiem.Text + "%'");
        }
        public ucThongKe uctk = new ucThongKe();
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            line.Top = btnThongKe.Top + 4;
            showControl(uctk);
            panel1.Width = 60;
            lblUC.Text = "Thống kê điểm";
            txtTimKiem.ResetText();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            pnDoiPass.Visible = false;
        }

        private void btnDoiPass_Click(object sender, EventArgs e)
        {
            if(AccountDAO.Instance.checkLogin(mgv, txtPass.Text) == 1)
            {
                DataProvider.Instance.ExcuteNonQuery("Update account set MatKhau='" + txtRePass.Text + "' where TenDN='" + mgv + "'");
                lblErrorLogin.Visible = false;
                pnDoiPass.Visible = false;
            }
            else { lblErrorLogin.Visible = true; }
        }
    }
}
