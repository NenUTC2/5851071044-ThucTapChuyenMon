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
using ExcelDataReader;
using System.IO;

namespace QuanLySinhVien
{
    public partial class ucSV : UserControl
    {
        public Panel pn { get { return panel1; } }
        public Panel pn2 { get { return panel2; } }
        public Panel pn3 { get { return panel3; } }
        public DataGridView dtgv { get { return dtgvSV; } }

        public DataSet dsSV;
        public string mgv;
        public ucSV(string gv)
        {
            mgv = gv;
            InitializeComponent();
            
            if (AccountDAO.Instance.getQuyenByUser(mgv).Equals("admin"))
            {
                loadSV();
                loadCBNganh();
                loadCBLop(cbNganh.SelectedValue.ToString());
            }

            else if (AccountDAO.Instance.getQuyenByUser(mgv).Equals("tk"))
            {
                cbNganh.DataSource = DataProvider.Instance.ExcuteQuery("Select * from Nganh " +
                    "where makhoa='" + GiangVienDAO.Instance.getKhoabyMGV(mgv) + "'");
                cbNganh.DisplayMember = "TenNganh";
                cbNganh.ValueMember = "MaNganh";

                loadCBLop(cbNganh.SelectedValue.ToString());
            }
            else if (AccountDAO.Instance.getQuyenByUser(mgv).Equals("gv"))
            {
                cbNganh.DataSource = DataProvider.Instance.ExcuteQuery("Select * from Nganh " +
                    "where makhoa='" + GiangVienDAO.Instance.getKhoabyMGV(mgv) + "'");
                cbNganh.DisplayMember = "TenNganh";
                cbNganh.ValueMember = "MaNganh";
                cbLop.DataSource = DataProvider.Instance.ExcuteQuery("Select * from Lop where GVCN='" + mgv + "'");
                cbLop.DisplayMember = "TenLop";
                cbLop.ValueMember = "MaLop";
            }
        }
        public void loadSV()
        {
            dtgvSV.DataSource = DataProvider.Instance.ExcuteQuery("Select * from SinhVien");
        }

        public void loadCBLop(string nganh)
        {
            if (nganh.Equals("*"))
                cbLop.DataSource = DataProvider.Instance.ExcuteQuery("Select * from Lop");
            else
                cbLop.DataSource = DataProvider.Instance.ExcuteQuery("Select * from Lop where MaNganh='"+nganh+"'");
            cbLop.DisplayMember = "TenLop";
            cbLop.ValueMember = "MaLop";
        }

        public void loadCBNganh()
        {
            cbNganh.DataSource = DataProvider.Instance.ExcuteQuery("Select * from Nganh");
            cbNganh.DisplayMember = "TenNganh";
            cbNganh.ValueMember = "MaNganh";
        }

        public void loadCBMonHoc(string khoa, string soky, string msv)
        {
            int ky = Convert.ToInt32(soky)+1;
            if (khoa.Equals("*"))
                cbMonHoc.DataSource = DataProvider.Instance.ExcuteQuery("Select * from MonHoc where SoKy=" + ky);
            else
                cbMonHoc.DataSource = DataProvider.Instance.ExcuteQuery("Select MonHoc.MaMon,TenMon from MonHoc where MaNganh='"+khoa+"' and SoKy="+ky+" " +
                    "UNION ALL " +
                    "Select MonHoc.MaMon, TenMon from MonHoc, NoMon where MonHoc.MaMon=NoMon.MaMon AND MaSV = '"+msv+"'");
            cbMonHoc.DisplayMember = "TenMon";
            cbMonHoc.ValueMember = "MaMon";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenSV.Text != "" && txtSDT.Text != "" && txtDiaChi.Text != "" && txtEmail.Text != "")
            {
                DataProvider.Instance.ExcuteQuery("Insert into SinhVien values(" +
                    " '" + cbLop.SelectedValue + "-" + SinhVienDAO.Instance.getMaxGV() + "'," +
                    " N'" + txtTenSV.Text + "', '" + txtSDT.Text + "', '" + txtEmail.Text + "', '" + cbLop.SelectedValue + "', N'" + txtDiaChi.Text + "', 0,0)");
                loadSV();
            }
            else { lblLoi.Visible = true; lblLoi.Text = "Vui lòng nhập đầy đủ thông tin điểm"; timer1.Enabled = true; }
        }

        private void cbKhoa_SelectedValueChanged(object sender, EventArgs e)
        {
            loadCBLop(cbNganh.SelectedValue.ToString());
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTenSV.Text != "" && txtSDT.Text != "" && txtDiaChi.Text != "" && txtEmail.Text != "")
            {
                DataProvider.Instance.ExcuteQuery("Update SinhVien set " +
                    " TenSV=N'" + txtTenSV.Text + "', SDT='" + txtSDT.Text + "', Email='" + txtEmail.Text + "', DiaCHi=N'" + txtDiaChi.Text + "' " +
                    "where MaSV='" + dtgvSV.CurrentRow.Cells["MaSV"].Value.ToString() + "'");
                loadSV();
            }
            else { lblLoi.Visible = true; lblLoi.Text = "Vui lòng nhập đầy đủ thông tin điểm"; timer1.Enabled = true; }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataProvider.Instance.ExcuteNonQuery("Delete from SinhVien where MaSV='" + dtgvSV.CurrentRow.Cells["MaSV"].Value.ToString() + "'");
            loadSV();
        }

        private void dtgvSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenSV.Text = dtgvSV.CurrentRow.Cells["TenSV"].Value.ToString();
            txtSDT.Text = dtgvSV.CurrentRow.Cells["SDT"].Value.ToString();
            txtEmail.Text = dtgvSV.CurrentRow.Cells["Email"].Value.ToString();
            txtDiaChi.Text = dtgvSV.CurrentRow.Cells["DiaChi"].Value.ToString();
            cbNganh.SelectedValue = LopDAO.Instance.getNganhfromLop(dtgvSV.CurrentRow.Cells["MaLop"].Value.ToString());
            cbLop.SelectedValue = dtgvSV.CurrentRow.Cells["MaLop"].Value.ToString();

            loadCBMonHoc(LopDAO.Instance.getNganhfromLop(dtgvSV.CurrentRow.Cells["MaLop"].Value.ToString()), dtgvSV.CurrentRow.Cells["SoKy"].Value.ToString(), dtgvSV.CurrentRow.Cells["MaSV"].Value.ToString());
        }

        private void cbMonHoc_SelectedValueChanged(object sender, EventArgs e)
        {
            string mhk = DataProvider.Instance.ExcuteQuery("Select MaHK from HocKy where TrangThai=0").Rows[0][0].ToString();
            cbLopHoc.DataSource = DataProvider.Instance.ExcuteQuery("Select * from LopHocPhan where HocKy='"+mhk+"' and MaMon='" + cbMonHoc.SelectedValue + "'");
            cbLopHoc.DisplayMember = "MaHP";
            cbLopHoc.ValueMember = "MaHP";
        }

        private void cbSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtgvExcel.DataSource = dsSV.Tables[cbSheet.SelectedIndex];
        }

        private void btnNhapExel_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx|Excel Workbook 97-2003|*.xls", ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    using (var stream = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read))
                    {
                        IExcelDataReader reader;
                        if (ofd.FilterIndex == 2)
                        {
                            reader = ExcelReaderFactory.CreateBinaryReader(stream);
                        }
                        else
                        {
                            reader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                        }

                        dsSV = reader.AsDataSet(new ExcelDataSetConfiguration()
                        {
                            ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                            {
                                UseHeaderRow = true
                            }
                        });

                        cbSheet.Items.Clear();
                        foreach (DataTable dt in dsSV.Tables)
                        {
                            cbSheet.Items.Add(dt.TableName);
                        }
                        reader.Close();

                    }
                }
            }

            dtgvExcel.Visible = true; cbSheet.Visible = true; btnThoatExcel.Visible = true;
        }

        private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenSV.Text = dtgvExcel.CurrentRow.Cells[0].Value.ToString();
            txtSDT.Text = dtgvExcel.CurrentRow.Cells[1].Value.ToString();
            cbNganh.SelectedValue = LopDAO.Instance.getNganhfromLop(dtgvExcel.CurrentRow.Cells[2].Value.ToString());
            cbLop.SelectedValue = dtgvExcel.CurrentRow.Cells[2].Value.ToString();
            txtDiaChi.Text = dtgvExcel.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnThoatExcel_Click(object sender, EventArgs e)
        {
            dtgvExcel.Visible = false; cbSheet.Visible = false; btnThoatExcel.Visible = false;
        }

        private void btnDangKyMon_Click(object sender, EventArgs e)
        {
            if (DataProvider.Instance.ExcuteQuery("Select * from DiemHocPhan where MaHP='" + cbLopHoc.SelectedValue.ToString() + "'").Rows.Count <= 0)
            {
                string msv = dtgvSV.CurrentRow.Cells["MaSV"].Value.ToString();
                if (SinhVienDAO.Instance.checkSV(msv) == 1)
                {
                    DataProvider.Instance.ExcuteNonQuery("Insert into DiemHocPhan values('" + cbLopHoc.SelectedValue + "', '" + msv + "', 0, 0,0,0,0,0,0,0)");
                    DiemDAO.Instance.themCTHocKy(cbLopHoc.SelectedValue.ToString(), msv);
                }
            }
            else { lblLoi.Visible = true; lblLoi.Text = "Sinh viên đã đăng ký môn này"; timer1.Enabled = true; }

        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            if (AccountDAO.Instance.getQuyenByUser(mgv).Equals("admin"))
            {
                loadSV();
                loadCBNganh();
                loadCBLop(cbNganh.SelectedValue.ToString());
            }

            else if (AccountDAO.Instance.getQuyenByUser(mgv).Equals("tk"))
            {
                cbNganh.DataSource = DataProvider.Instance.ExcuteQuery("Select * from Nganh " +
                    "where makhoa='" + GiangVienDAO.Instance.getKhoabyMGV(mgv) + "'");
                cbNganh.DisplayMember = "TenNganh";
                cbNganh.ValueMember = "MaNganh";

                loadCBLop(cbNganh.SelectedValue.ToString());
            }
            else if (AccountDAO.Instance.getQuyenByUser(mgv).Equals("gv"))
            {
                cbNganh.DataSource = DataProvider.Instance.ExcuteQuery("Select * from Nganh " +
                    "where makhoa='" + GiangVienDAO.Instance.getKhoabyMGV(mgv) + "'");
                cbNganh.DisplayMember = "TenNganh";
                cbNganh.ValueMember = "MaNganh";
                cbLop.DataSource = DataProvider.Instance.ExcuteQuery("Select * from Lop where GVCN='" + mgv + "'");
                cbLop.DisplayMember = "TenLop";
                cbLop.ValueMember = "MaLop";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblLoi.Visible = false;
            timer1.Enabled = false;
        }

        private void cbLop_SelectedValueChanged(object sender, EventArgs e)
        {
            dtgvSV.DataSource = DataProvider.Instance.ExcuteQuery("select * from SinhVien where MaLop='" + cbLop.SelectedValue + "'");
        }
    }
}
