﻿using System;
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
        public Main()
        {
            InitializeComponent();
            panel1.Width = 60;
            lblTime.Text = DateTime.Now.ToString("hh:mm");
            lblDay.Text = DateTime.Now.ToString("dd/MM");
        }

        private void Main_Load(object sender, EventArgs e)
        {
            showControl(uck);
            line.Top = btnKhoa.Top + 4;
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
        }

        public ucLop ucl = new ucLop();
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            line.Top = btnLop.Top + 4;
            showControl(ucl);
            panel1.Width = 60;
            lblUC.Text = "Quản Lý Lớp";
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

        public ucDiem ucd = new ucDiem();
        private void btnDiem_Click(object sender, EventArgs e)
        {
            line.Top = btnDiem.Top + 4;
            panel1.Width = 60;
            showControl(ucd);
            lblUC.Text = "Nhập sửa điểm";
        }

        public ucSV ucsv = new ucSV();
        private void btnSV_Click(object sender, EventArgs e)
        {
            line.Top = btnSV.Top + 4;
            panel1.Width = 60;
            showControl(ucsv);
            lblUC.Text = "Quản lý sinh viên";
        }

        public ucGV ucgv = new ucGV();
        private void btnGV_Click(object sender, EventArgs e)
        {
            line.Top = btnGV.Top + 4;
            panel1.Width = 60;
            showControl(ucgv);
            lblUC.Text = "Quản lý giảng viên";
        }

        public ucMon ucm = new ucMon();
        private void btnMon_Click(object sender, EventArgs e)
        {
            line.Top = btnMon.Top + 4;
            panel1.Width = 60;
            showControl(ucm);
            lblUC.Text = "Quản lý môn học";
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
            this.Close();
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

                ucl.pn.BackColor = Color.FromArgb(21, 24, 31);
                ucl.pn2.BackColor = Color.FromArgb(31, 34, 41);
                ucl.pn3.BackColor = Color.FromArgb(31, 34, 41);

                ucgv.pn.BackColor = Color.FromArgb(21, 24, 31);
                ucgv.pn2.BackColor = Color.FromArgb(31, 34, 41);
                ucgv.pn3.BackColor = Color.FromArgb(31, 34, 41);

                ucsv.pn.BackColor = Color.FromArgb(21, 24, 31);
                ucsv.pn2.BackColor = Color.FromArgb(31, 34, 41);
                ucsv.pn3.BackColor = Color.FromArgb(31, 34, 41);
                ucsv.lbl1.ForeColor = Color.White;

                ucm.pn.BackColor = Color.FromArgb(21, 24, 31);
                ucm.pn2.BackColor = Color.FromArgb(31, 34, 41);
                ucm.pn3.BackColor = Color.FromArgb(31, 34, 41);

                ucd.pn.BackColor = Color.FromArgb(21, 24, 31);
                ucd.pn2.BackColor = Color.FromArgb(31, 34, 41);
                ucd.pn3.BackColor = Color.FromArgb(31, 34, 41);
                ucd.lbl1.ForeColor = Color.White;
                ucd.lbl2.ForeColor = Color.White;
                ucd.lbl3.ForeColor = Color.White;
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

                ucl.pn.BackColor = Color.FromArgb(230,230,230);
                ucl.pn2.BackColor = Color.White;
                ucl.pn3.BackColor = Color.White;

                ucgv.pn.BackColor = Color.FromArgb(230, 230, 230);
                ucgv.pn2.BackColor = Color.White;
                ucgv.pn3.BackColor = Color.White;

                ucsv.pn.BackColor = Color.FromArgb(230, 230, 230);
                ucsv.pn2.BackColor = Color.White;
                ucsv.pn3.BackColor = Color.White;
                ucsv.lbl1.ForeColor = Color.Black;

                ucm.pn.BackColor = Color.FromArgb(230, 230, 230);
                ucm.pn2.BackColor = Color.White;
                ucm.pn3.BackColor = Color.White;

                ucd.pn.BackColor = Color.FromArgb(230, 230, 230);
                ucd.pn2.BackColor = Color.White;
                ucd.pn3.BackColor = Color.White;
                ucd.lbl1.ForeColor = Color.Black;
                ucd.lbl2.ForeColor = Color.Black;
                ucd.lbl3.ForeColor = Color.Black;
            }
        }
    }
}
