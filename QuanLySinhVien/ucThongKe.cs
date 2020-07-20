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
    public partial class ucThongKe : UserControl
    {
        public Panel pn { get { return panel1; } }
        public ucThongKe()
        {
            InitializeComponent();
            loadCBNganh(); loadCBLop(cbKhoa.SelectedValue.ToString());
            loadSV();
        }

        public void loadSV()
        {
            dtgvSV.DataSource = DataProvider.Instance.ExcuteQuery("Select * from SinhVien");
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

        public void loadCBNganh()
        {
            cbKhoa.DataSource = DataProvider.Instance.ExcuteQuery("Select * from Nganh");
            cbKhoa.DisplayMember = "TenNganh";
            cbKhoa.ValueMember = "MaNganh";
        }

        private void cbKhoa_SelectedValueChanged(object sender, EventArgs e)
        {
            loadCBLop(cbKhoa.SelectedValue.ToString());
        }

        private void cbLop_SelectedValueChanged(object sender, EventArgs e)
        {
            dtgvSV.DataSource = DataProvider.Instance.ExcuteQuery("Select * from SinhVien where MaLop='"+cbLop.SelectedValue+"'");
            dtgvSV.Visible = true;
            dtgvNo.Visible = false;
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            loadCBNganh(); loadCBLop(cbKhoa.SelectedValue.ToString());
            loadSV();
        }

        private void dtgvSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            chrDiemHK.ChartAreas[0].AxisY.Maximum = 10;
            chrDiemHK.DataSource = DataProvider.Instance.ExcuteQuery("Select MaHK, DiemTichLuy from CTHocKy where MaSV='" + dtgvSV.CurrentRow.Cells["MaSV"].Value.ToString() + "'");
            chrDiemHK.Series[0].XValueMember = "MaHK";
            chrDiemHK.Series[0].YValueMembers = "DiemTichLuy";
            chrDiemHK.DataBind();
        }

        private void btnSVGioi_Click(object sender, EventArgs e)
        {
            try
            {
                dtgvSV.Visible = true;
                dtgvNo.Visible = false;
                dtgvSV.DataSource = DataProvider.Instance.ExcuteQuery("Select * from SinhVien where TichLuy>=8 and MaLop='" + cbLop.SelectedValue.ToString() + "'");
            }
            catch { }
        }

        private void btnSVKem_Click(object sender, EventArgs e)
        {
            try
            {
                dtgvSV.Visible = true;
                dtgvNo.Visible = false;
                dtgvSV.DataSource = DataProvider.Instance.ExcuteQuery("Select * from SinhVien where TichLuy<=4 and MaLop='" + cbLop.SelectedValue.ToString() + "'");
            }
            catch { }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                dtgvSV.Visible = false;
                dtgvNo.Visible = true;
                dtgvNo.DataSource = DataProvider.Instance.ExcuteQuery("Select NoMon.MaSV,TenSV,NoMon.MaMon,MaHK,Tra from NoMon, SinhVien where NoMon.MaSV=SinhVien.MaSV and  MaLop='" + cbLop.SelectedValue.ToString() + "'");
                
            }
            catch { }
            chrDiemHK.ChartAreas[0].AxisY.Maximum = 10;
            chrDiemHK.DataSource = DataProvider.Instance.ExcuteQuery("Select MaHK,Count(*) as 'SoSVNo' from NoMon group by MaHK");
            chrDiemHK.Series[0].XValueMember = "MaHK";
            chrDiemHK.Series[0].YValueMembers = "SoSVNo";
            chrDiemHK.DataBind();
        }

        private void dtgvNo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
