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
    public partial class ucKhoa : UserControl
    {
        //private static ucKhoa _instance;
        //public static ucKhoa Instance
        //{
        //    get
        //    {
        //        if (_instance == null)
        //            _instance = new ucKhoa();
        //        return _instance;
        //    }
        //}
        //public  string id;
        //public  string Id
        //{
        //    get { return id; }
        //    set
        //    {
        //        id = value;
        //    }
        //}
        public Panel pn { get { return panel1; } }
        public Panel pn2 { get { return panel2; } }
        public Panel pn3 { get { return panel3; } }
        public Panel pn5 { get { return panel5; } }
        public Label lbltenkhoa { get { return lblTenKhoa; } }
        public Label lblsv { get { return lblSoSV; } }
        public Label lblgv { get { return lblSoGV; } }
        public Label lbllop { get { return lblSoLop; } }
        public DataGridView dtgv { get { return dtgvKhoa; } }
        public DataGridView dtgvN { get { return dtgvNganh; } }
        public ucKhoa()
        {
            InitializeComponent();
            loadKhoa();
            loadNganh();
        }
        public void loadKhoa()
        {
            dtgvKhoa.DataSource = DataProvider.Instance.ExcuteQuery("Select * from Khoa");
        }

        public void loadNganh()
        {
            dtgvNganh.DataSource = DataProvider.Instance.ExcuteQuery("Select * from Nganh");
        }
        //private void thongbao()
        //{
        //    guna2Transition1.ShowSync(lblError);
        //    timer1.Enabled = true;
        //}

        private void dtgvKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKhoa.Text = dtgvKhoa.CurrentRow.Cells["MaKhoa"].Value.ToString();
            txtTenKhoa.Text = dtgvKhoa.CurrentRow.Cells["TenKhoa"].Value.ToString();
            lblTenKhoa.Text = "Tên khoa:  " + dtgvKhoa.CurrentRow.Cells["TenKhoa"].Value.ToString();
            lblSoLop.Text = "Số ngành:  " + DataProvider.Instance.ExcuteQuery
                ("Select count(*) from Nganh " +
                "where MaKhoa='" + dtgvKhoa.CurrentRow.Cells["MaKhoa"].Value.ToString() + "'").Rows[0][0].ToString();
            lblSoGV.Text = "Số giảng viên:  " + DataProvider.Instance.ExcuteQuery
                ("Select count(*) from GiangVien " +
                "where MaKhoa='" + dtgvKhoa.CurrentRow.Cells["MaKhoa"].Value.ToString() + "'").Rows[0][0].ToString();
            lblSoSV.Text = "Số sinh viên:  " + DataProvider.Instance.ExcuteQuery
                ("Select count(*) from Lop, SinhVien, Nganh " +
                "where SinhVien.MaLop=Lop.MaLop and lop.MaNganh=Nganh.MaNganh and MaKhoa='" + dtgvKhoa.CurrentRow.Cells["MaKhoa"].Value.ToString() + "'").Rows[0][0].ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaKhoa.Text != "" && txtTenKhoa.Text != "")
            {
                DataProvider.Instance.ExcuteNonQuery("Insert into Khoa values" +
                    "('" + txtMaKhoa.Text + "', N'" + txtTenKhoa.Text + "')");

                loadKhoa();
            }
            else { lblLoi.Visible = true; lblLoi.Text = "Vui lòng nhập đầy đủ thông tin khoa"; timer1.Enabled = true; }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTenKhoa.Text != "")
            {
                DataProvider.Instance.ExcuteNonQuery("Update Khoa " +
                    "set TenKhoa=N'" + txtTenKhoa.Text + "' where MaKhoa='" + dtgvKhoa.CurrentRow.Cells["MaKhoa"].Value.ToString() + "'");
                loadKhoa();
                pnEDKhoa.Visible = false;
            }
            else { lblLoi.Visible = true; lblLoi.Text = "Vui lòng nhập đầy đủ thông tin khoa"; timer1.Enabled = true; }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DataProvider.Instance.ExcuteNonQuery("Delete from Khoa " +
                "where MaKhoa='" + dtgvKhoa.CurrentRow.Cells["MaKhoa"].Value.ToString() + "'");
                loadKhoa();
                pnEDKhoa.Visible = false;
            }
            catch { lblLoi.Visible = true; lblLoi.Text = "Không được xoá khoa này"; timer1.Enabled = true; }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lblLoi.Visible = false;
            timer1.Enabled = false;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (pnEDKhoa.Visible == true)
                pnEDKhoa.Visible = false;
            else
                pnEDKhoa.Visible = true;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            if (pnEDNganh.Visible == true)
                pnEDNganh.Visible = false;
            else
                pnEDNganh.Visible = true;
        }

        private void btnThemN_Click(object sender, EventArgs e)
        {
            if (txtMaNganh.Text != "" && txtTenNganh.Text != "")
            {
                DataProvider.Instance.ExcuteNonQuery("Insert into Nganh values" +
                    "('" + txtMaNganh.Text + "', N'" + txtTenNganh.Text + "','" + dtgvKhoa.CurrentRow.Cells["MaKhoa"].Value.ToString() + "')");

                loadNganh();
            }
            else { lblLoi.Visible = true; lblLoi.Text = "Vui lòng nhập đầy đủ thông tin ngành"; timer1.Enabled = true; }
        }

        private void dtgvNganh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNganh.Text = dtgvNganh.CurrentRow.Cells["MaNganh"].Value.ToString();
            txtTenNganh.Text = dtgvNganh.CurrentRow.Cells["TenNganh"].Value.ToString();
        }

        private void btnSuaN_Click(object sender, EventArgs e)
        {
            if (txtMaNganh.Text != "" && txtTenNganh.Text != "")
            {
                DataProvider.Instance.ExcuteNonQuery("Update Nganh set " +
                    " TenNganh= N'" + txtTenNganh.Text + "',MaKhoa='" + dtgvKhoa.CurrentRow.Cells["MaKhoa"].Value.ToString() + "' " +
                    "where MaNganh='" + txtMaNganh.Text + "'");

                loadNganh();
                pnEDNganh.Visible = false;
            }
            else { lblLoi.Visible = true; lblLoi.Text = "Không được xoá khoa"; timer1.Enabled = true; }
        }

        private void btnXoaN_Click(object sender, EventArgs e)
        {
            try
            {
                DataProvider.Instance.ExcuteNonQuery("Delete from Nganh " +
                "where MaNganh='" + dtgvNganh.CurrentRow.Cells["MaNganh"].Value.ToString() + "'");
                loadNganh();
                pnEDNganh.Visible = false;
            }
            catch { lblLoi.Visible = true; lblLoi.Text = "Không được xoá sinh viên này"; timer1.Enabled = true; }
        }
    }
}
