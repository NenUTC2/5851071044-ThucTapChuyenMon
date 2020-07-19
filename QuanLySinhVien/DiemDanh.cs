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
    public partial class DiemDanh : Form
    {
        public string mahp;
        public DiemDanh(string hp)
        {
            mahp = hp;
            InitializeComponent();

            lblMaHP.Text = "Mã học phần:  " + mahp;
            lblTenMon.Text = "Môn:  " + DataProvider.Instance.ExcuteQuery("Select TenMon from LopHocPhan l, MonHoc m " +
                "where l.MaMon=m.MaMon and MaHP='" + mahp + "'").Rows[0][0].ToString();
            string mgv = DataProvider.Instance.ExcuteQuery("Select MaGV from LopHocPhan where MaHP='" + mahp + "'").Rows[0][0].ToString();
            lblGV.Text = "Giảng viên:  " + GiangVienDAO.Instance.getTenGV(mgv);

            loadcbNgay();
        }

        public void loadcbNgay()
        {
            cbNgayDD.DataSource = DataProvider.Instance.ExcuteQuery("Select * from DiemDanh where MaHP='" + mahp + "'");
            cbNgayDD.DisplayMember = "Ngay";
            cbNgayDD.ValueMember = "id";
        }

        public void loadDD(string id)
        {
            dtgvDiemDanh.DataSource = DataProvider.Instance.ExcuteQuery("Select id,d.MaSV,TenSV,DiemDanh from CTDiemDanh d, SinhVien s " +
                "where d.MaSV=s.MaSV and id="+id);
        }

        public string getidDiemDanh(string mhp, string ngay)
        {
            return DataProvider.Instance.ExcuteQuery("Select id from DiemDanh where MaHP='" + mhp + "' and Ngay='" + ngay + "'").Rows[0][0].ToString();
        }
        private void btnTaoDD_Click(object sender, EventArgs e)
        {
            if (DataProvider.Instance.ExcuteQuery("Select id from DiemDanh where MaHP='" + mahp + "' and Ngay='" + DateTime.Now.ToString("dd/MM/yyyy") + "'").Rows.Count <= 0)
            {
                DataProvider.Instance.ExcuteNonQuery("Insert into DiemDanh values('" + mahp + "', '" + DateTime.Now.ToString("dd/MM/yyyy") + "')");
                DataTable dt = DataProvider.Instance.ExcuteQuery("Select * from DiemHocPhan where MaHP='" + mahp + "'");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string msv = dt.Rows[i][1].ToString();
                    string id = getidDiemDanh(mahp, DateTime.Now.ToString("dd/MM/yyyy"));
                    DataProvider.Instance.ExcuteNonQuery("Insert into CTDiemDanh values('" + id + "', '" + msv + "', N'Có')");
                    loadcbNgay();
                    cbNgayDD.SelectedValue = id;
                }
            }
            else { lblSVCo.ForeColor = Color.Red; lblSVCo.Text = "Hôm nay đã có điểm danh"; }
        }
        private void dtgvDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvDiemDanh.Columns[e.ColumnIndex].Name == "Co")
            {
                if (dtgvDiemDanh.CurrentRow.Cells["Co"].Value.ToString().Equals("Có"))
                {
                    DataProvider.Instance.ExcuteNonQuery("Update CTDiemDanh set DiemDanh=N'Vắng' " +
                        "where id=" + Convert.ToInt32(dtgvDiemDanh.CurrentRow.Cells["id"].Value.ToString()) + " and " +
                        "MaSV='" + dtgvDiemDanh.CurrentRow.Cells["MaSV"].Value.ToString() + "'");
                    dtgvDiemDanh.CurrentRow.Cells["Co"].Value = "Vắng";
                    lblSVCo.ForeColor = Color.Red;
                    lblSVCo.Text = dtgvDiemDanh.CurrentRow.Cells["TenSV"].Value.ToString() + " vắng mặt";
                }
                else
                {
                    DataProvider.Instance.ExcuteNonQuery("Update CTDiemDanh set DiemDanh=N'Có' " +
                        "where id=" + Convert.ToInt32(dtgvDiemDanh.CurrentRow.Cells["id"].Value.ToString()) + " and " +
                        "MaSV='" + dtgvDiemDanh.CurrentRow.Cells["MaSV"].Value.ToString() + "'");
                    dtgvDiemDanh.CurrentRow.Cells["Co"].Value = "Có";
                    lblSVCo.ForeColor = Color.Green;
                    lblSVCo.Text = dtgvDiemDanh.CurrentRow.Cells["TenSV"].Value.ToString() + " có mặt";
                }
            }
            else {
                lblSVCo.ForeColor = Color.Black;
                lblSVCo.Text = dtgvDiemDanh.CurrentRow.Cells["TenSV"].Value.ToString();
            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbNgayDD_SelectedValueChanged(object sender, EventArgs e)
        {
            try { loadDD(cbNgayDD.SelectedValue.ToString()); } catch { }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DataProvider.Instance.ExcuteNonQuery("Delete from CTDiemDanh where id='" + cbNgayDD.SelectedValue.ToString() + "'");
            DataProvider.Instance.ExcuteNonQuery("Delete from DiemDanh where id='" + cbNgayDD.SelectedValue.ToString() + "'");
        }

        private void btnDiemDanh_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
