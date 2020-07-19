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
using System.Net.Mail;
using System.Net;

namespace QuanLySinhVien
{
    public partial class ucDiem : UserControl
    {
        public Panel pn { get { return panel1; } }
        public Panel pn2 { get { return panel2; } }
        public Panel pn3 { get { return panel3; } }
        public Label lbl1 { get { return lblTenSV; } }
        public Label lbl2 { get { return lblLop; } }
        public Label lbl3 { get { return lblDiemTL; } }
        public Panel pn4 { get { return panel4; } }
        public DataGridView dtgv { get { return dtgvDiem; } }
        public CheckBox chk1 { get { return chkKT; } }
        public CheckBox chk2 { get { return chkMess; } }
        public string mgv;
        public ucDiem(string gv)
        {
            mgv = gv;

            InitializeComponent();


            if (AccountDAO.Instance.getQuyenByUser(mgv).Equals("admin"))
            {
                //loadCBNganh("*");
                loadCBGV("*");
            }
            else
            {
                loadCBGV(mgv);
                //loadCBNganh(GiangVienDAO.Instance.getKhoabyMGV(mgv));
            }
        }
        public void loadLop(string a)
        {
            if (chkKT.Checked == true)
            {
                loadCBLopKT(a);
            }
            else loadCBLop(a);
        }
        public void loadDiem(string mon)
        {
            dtgvDiem.DataSource = DataProvider.Instance.ExcuteQuery("Select * from DiemHocPhan");
            if (mon.Equals("*"))
                dtgvDiem.DataSource = DataProvider.Instance.ExcuteQuery("Select * from DiemHocPhan");
            else
                dtgvDiem.DataSource = DataProvider.Instance.ExcuteQuery("Select * from DiemHocPhan where MaHP='" + mon + "'");
        }

        public void loadCBLop(string gv)
        {
            if (gv.Equals("*"))
                cbLopHP.DataSource = DataProvider.Instance.ExcuteQuery("Select * from LopHocPhan where TrangThai=0");
            else
                cbLopHP.DataSource = DataProvider.Instance.ExcuteQuery("Select * from LopHocPhan where TrangThai=0 and MaGV='" + gv + "'");
            cbLopHP.DisplayMember = "MaHP";
            cbLopHP.ValueMember = "MaHP";
        }

        public void loadCBLopKT(string gv)
        {
            if (gv.Equals("*"))
                cbLopHP.DataSource = DataProvider.Instance.ExcuteQuery("Select * from LopHocPhan TrangThai=1");
            else
                cbLopHP.DataSource = DataProvider.Instance.ExcuteQuery("Select * from LopHocPhan where TrangThai=1 and MaGV='" + gv + "'");
            cbLopHP.DisplayMember = "MaHP";
            cbLopHP.ValueMember = "MaHP";
        }

        //public void loadCBNganh(string khoa)
        //{
        //    if (khoa.Equals("*"))
        //        cbKhoa.DataSource = DataProvider.Instance.ExcuteQuery("Select * from Khoa");
        //    else
        //        cbKhoa.DataSource = DataProvider.Instance.ExcuteQuery("Select * from Khoa where MaKhoa='" + khoa + "'");
        //    cbKhoa.DisplayMember = "TenKhoa";
        //    cbKhoa.ValueMember = "MaKhoa";
        //}

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
            try { loadCBGV("*"); loadDiem(cbLopHP.SelectedValue.ToString()); } catch { }
            txtChuyenCan.ResetText();
            txtGiuaKy.ResetText();
            txtTP.ResetText();
            txtThi.ResetText();
            txtKT.ResetText();

            if (AccountDAO.Instance.getQuyenByUser(mgv).Equals("admin"))
            {
                loadLop("*");
                loadDiem(cbLopHP.SelectedValue.ToString());
            }
            else
            {
                loadLop(mgv);
                loadDiem(cbLopHP.SelectedValue.ToString());
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
            lblDiemTL.Text = "Điểm tích luỹ: " + Convert.ToDouble( SinhVienDAO.Instance.getdiemTL(dtgvDiem.CurrentRow.Cells["MaSV"].Value.ToString())).ToString("#.##"); 
            lblTenSV.Text = "Tên sinh viên: ";
            lblTenSV.Text = "Tên sinh viên: " + SinhVienDAO.Instance.getTenformMa(dtgvDiem.CurrentRow.Cells["MaSV"].Value.ToString());
            lblLop.Text = "Lớp: ";
            lblLop.Text = "Lớp: " + LopDAO.Instance.getTenfromID(SinhVienDAO.Instance.getLopformMa(dtgvDiem.CurrentRow.Cells["MaSV"].Value.ToString()));
            lblVang.Text = "Số buổi học: " + DataProvider.Instance.ExcuteQuery("SELECT COUNT(*) FROM dbo.CTDiemDanh,dbo.DiemDanh " +
                "WHERE CTDiemDanh.id=DiemDanh.id AND MaHP='"+cbLopHP.SelectedValue.ToString()+"' AND MaSV='"+ dtgvDiem.CurrentRow.Cells["MaSV"].Value.ToString() + "' AND DiemDanh=N'Có'").Rows[0][0].ToString()+"/"
                + DataProvider.Instance.ExcuteQuery("SELECT COUNT(*) FROM dbo.DiemDanh WHERE MaHP='"+cbLopHP.SelectedValue.ToString()+"'").Rows[0][0].ToString();
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
            if (txtChuyenCan.Text != "" && txtGiuaKy.Text != "" && txtTP.Text != "" && txtThi.Text != "")
            {
                DiemDAO.Instance.suaDiem(Convert.ToDecimal(txtChuyenCan.Text), Convert.ToDecimal(txtGiuaKy.Text), Convert.ToDecimal(txtTP.Text),
                    Convert.ToDecimal(txtThi.Text), Convert.ToDecimal(txtKT.Text),
                    dtgvDiem.CurrentRow.Cells["MaHP"].Value.ToString(), dtgvDiem.CurrentRow.Cells["MaSV"].Value.ToString());
                loadDiem(cbLopHP.SelectedValue.ToString());
                
            }
            else { lblLoi.Visible = true; lblLoi.Text = "Vui lòng nhập đầy đủ thông tin điểm"; timer1.Enabled = true; }
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
                loadDiem(cbLopHP.SelectedValue.ToString());
            }
            catch { }
        }

        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //private void cbKhoa_SelectedValueChanged(object sender, EventArgs e)
        //{
        //    if (AccountDAO.Instance.getQuyenByUser(mgv).Equals("admin"))
        //    {
        //        try
        //        {
        //            cbGV.DataSource = DataProvider.Instance.ExcuteQuery("Select * from GiangVien where MaKhoa='" + cbKhoa.SelectedValue.ToString() + "'");
        //            cbGV.DisplayMember = "TenGV";
        //            cbGV.ValueMember = "MaGV";
        //        }
        //        catch { }
        //    }
        //}

        private void cbGV_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                loadLop(cbGV.SelectedValue.ToString());
            }
            catch { }
        }

        public void sendMail(string address, string hoten, string tp, string kt, string mon)
        {
            try
            {
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                string to, from, pass, content;
                to = address;
                from = "thanhnen1360@gmail.com";
                pass = "01208853712sz";
                content = "UTC2 Xin Chào!\n" +
                    "Thông báo điểm của sinh viên " + hoten + "\n Môn học: " + mon + "\n" +
                    "Điểm thành phần: " + tp + ", Điểm kết thúc môn: " + kt + "\n" +
                    "Chúc em học tốt và đạt kết quả cao.";
                MailMessage message = new MailMessage();
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = content;
                message.Subject = "UTC2 thông báo điểm";
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(from, pass);
                smtp.EnableSsl = true;
                smtp.Send(message);
            }
            catch { MessageBox.Show("Vui lòng kiểm tra kết nối mạng và thử lại"); }
        }

        private void btnGuiDiem_Click(object sender, EventArgs e)
        {
            if (chkGuiEmail.Checked == true)
            {
                DataTable dt = DataProvider.Instance.ExcuteQuery("Select TenSV, Email, DiemTP, DiemKT, TenMon " +
                    "from DiemLopHoc, SinhVien, dbo.MonHoc,dbo.LopHocPhan " +
                    "WHERE DiemLopHoc.MaHP=LopHocPhan.MaHP AND LopHocPhan.MaMon=MonHoc.MaMon and DiemLopHoc.MaSV=SinhVien.MaSV " +
                    "and DiemLopHoc.MaHP='" + cbLopHP.SelectedValue.ToString() + "'");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    sendMail(dt.Rows[i][1].ToString(), dt.Rows[i][0].ToString(), dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), dt.Rows[i][4].ToString());
                }
                MessageBox.Show("Đã gửi điểm đến tất cả sinh viên trong lớp học phần "+ cbLopHP.SelectedValue.ToString());
            }
            else
            {
                string email = DataProvider.Instance.ExcuteQuery("select Email from sinhvien where masv='" + dtgvDiem.CurrentRow.Cells["MaSV"].Value.ToString() + "'").Rows[0][0].ToString();
                string hoten = DataProvider.Instance.ExcuteQuery("select TenSV from sinhvien where masv='" + dtgvDiem.CurrentRow.Cells["MaSV"].Value.ToString() + "'").Rows[0][0].ToString();
                string tp = dtgvDiem.CurrentRow.Cells["DiemTP"].Value.ToString();
                string kt = dtgvDiem.CurrentRow.Cells["DiemKT"].Value.ToString();
                string mon = DataProvider.Instance.ExcuteQuery("Select TenMon FROM dbo.MonHoc,dbo.LopHocPhan " +
                    "WHERE LopHocPhan.MaMon=MonHoc.MaMon AND LopHocPhan.MaHP='" + dtgvDiem.CurrentRow.Cells["MaHP"].Value.ToString() + "'").Rows[0][0].ToString();
                sendMail(email, hoten, tp, kt, mon);
                MessageBox.Show("Đã gửi điểm đến mail sinh viên " + hoten);
                int x = email.Length;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblLoi.Visible = false;
            timer1.Enabled = false;
        }

        private void btnKTHP_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dtgvDiem.Rows.Count; i++)
                {
                    string msv = dtgvDiem.Rows[i].Cells["MaSV"].Value.ToString();
                    string mamon = DiemDAO.Instance.getMaMonbyCTMon(cbLopHP.SelectedValue.ToString());
                    string hk = DiemDAO.Instance.getHKfromCTMon(cbLopHP.SelectedValue.ToString());
                    if (dtgv.Rows[i].Cells["Tra"].Value.ToString().Equals("0"))
                    {
                        try
                        {
                            DataProvider.Instance.ExcuteNonQuery("Insert into NoMon " +
                                "values('" + msv + "'," +
                                "'" + mamon + "','" + hk + "',N'Chưa trả')");
                        }
                        catch { }
                    }
                    else if (dtgv.Rows[i].Cells["Tra"].Value.ToString().Equals("1"))
                    {
                        try
                        {
                            DataProvider.Instance.ExcuteNonQuery("Update NoMon set Tra=N'Đã trả' where MaSV='" + msv + "' and MaMon='" + mamon + "'");
                        }
                        catch { }
                    }

                }
                DataProvider.Instance.ExcuteNonQuery("update LopHocPhan set TrangThai=1 where MaHP='" + cbLopHP.SelectedValue.ToString() + "'");
                loadDiem(cbLopHP.SelectedValue.ToString());
                txtChuyenCan.ResetText();
                txtGiuaKy.ResetText();
                txtTP.ResetText();
                txtThi.ResetText();
                txtKT.ResetText();

                if (AccountDAO.Instance.getQuyenByUser(mgv).Equals("admin"))
                {
                    loadLop("*");
                    loadDiem(cbLopHP.SelectedValue.ToString());
                }
                else
                {
                    loadLop(mgv);
                    loadDiem(cbLopHP.SelectedValue.ToString());
                }
            }
            catch { }
        }

            private void chkKT_Click(object sender, EventArgs e)
        {
            loadLop(cbGV.SelectedValue.ToString());
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview";
            // storing header part in Excel  
            for (int i = 1; i < dtgvDiem.Columns.Count; i++)
            {
                worksheet.Cells[1, i] = dtgvDiem.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dtgvDiem.Rows.Count; i++)
            {
                for (int j = 0; j < dtgvDiem.Columns.Count-1; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dtgvDiem.Rows[i].Cells[j].Value.ToString();
                }
            }
        }

        private void btnPNFunc_Click(object sender, EventArgs e)
        {
            if (pnFunc.Visible == false)
                pnFunc.Visible = true;
            else pnFunc.Visible = false;
        }

        private void btnDiemDanh_Click(object sender, EventArgs e)
        {
            DiemDanh d = new DiemDanh(cbLopHP.SelectedValue.ToString());
            d.ShowDialog();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            DataTable dt = DataProvider.Instance.ExcuteQuery("Select TenSV, Email, DiemTP, DiemKT, TenMon " +
                    "from DiemLopHoc, SinhVien, dbo.MonHoc,dbo.LopHocPhan " +
                    "WHERE DiemLopHoc.MaHP=LopHocPhan.MaHP AND LopHocPhan.MaMon=MonHoc.MaMon and DiemLopHoc.MaSV=SinhVien.MaSV " +
                    "and DiemLopHoc.MaHP='" + cbLopHP.SelectedValue.ToString() + "'");
            if (chkGuiEmail.Checked == true)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    try
                    {
                        SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                        smtp.EnableSsl = true;
                        string to, from, pass, content;
                        to = dt.Rows[i][1].ToString();
                        from = "thanhnen1360@gmail.com";
                        pass = "01208853712sz";
                        content = txtMess.Text;
                        MailMessage message = new MailMessage();
                        message.To.Add(to);
                        message.From = new MailAddress(from);
                        message.Body = content;
                        message.Subject = "UTC2 thông báo";
                        smtp.Port = 587;
                        smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                        smtp.UseDefaultCredentials = false;
                        smtp.Credentials = new NetworkCredential(from, pass);
                        smtp.EnableSsl = true;
                        smtp.Send(message);
                    }
                    catch { MessageBox.Show("Vui lòng kiểm tra kết nối mạng và thử lại"); }
                }
                MessageBox.Show("Đã gửi điểm đến tất cả sinh viên trong lớp học phần " + cbLopHP.SelectedValue.ToString());
            }
            else
            {
                string email = DataProvider.Instance.ExcuteQuery("select Email from sinhvien where masv='" + dtgvDiem.CurrentRow.Cells["MaSV"].Value.ToString() + "'").Rows[0][0].ToString();
                string hoten = DataProvider.Instance.ExcuteQuery("select TenSV from sinhvien where masv='" + dtgvDiem.CurrentRow.Cells["MaSV"].Value.ToString() + "'").Rows[0][0].ToString();
                try
                {
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    smtp.EnableSsl = true;
                    string to, from, pass, content;
                    to = email;
                    from = "thanhnen1360@gmail.com";
                    pass = "01208853712sz";
                    content = txtMess.Text;
                    MailMessage message = new MailMessage();
                    message.To.Add(to);
                    message.From = new MailAddress(from);
                    message.Body = content;
                    message.Subject = "UTC2 thông báo";
                    smtp.Port = 587;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential(from, pass);
                    smtp.EnableSsl = true;
                    smtp.Send(message);
                }
                catch { MessageBox.Show("Vui lòng kiểm tra kết nối mạng và thử lại"); }
                MessageBox.Show("Đã gửi điểm đến mail sinh viên " + hoten);
            }
        }
    }
}
