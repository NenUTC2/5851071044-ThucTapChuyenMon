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
    public partial class ucLop : UserControl
    {
        public Panel pn { get { return panel1; } }
        public Panel pn2 { get { return panel2; } }
        public Panel pn3 { get { return panel3; } }
        public string mgv;
        public ucLop(string gv)
        {
            mgv = gv;
            InitializeComponent();

            if (AccountDAO.Instance.getQuyenByUser(mgv).Equals("admin"))
            {
                loadCBKHoa("*");
            }
            else if (AccountDAO.Instance.getQuyenByUser(mgv).Equals("tk"))
            {
                loadCBKHoa(GiangVienDAO.Instance.getKhoabyMGV(mgv));
            }
        }

        private void ucLop_Load(object sender, EventArgs e)
        {
            
        }

        public void loadLop(string khoa)
        {
            if (khoa.Equals("*"))
                dtgvLop.DataSource = DataProvider.Instance.ExcuteQuery("Select * from Lop");
            else
                dtgvLop.DataSource = DataProvider.Instance.ExcuteQuery("Select * from Lop where MaKhoa='" + khoa + "'");
        }

        public void loadCBKHoa(string khoa)
        {
            
            if (khoa.Equals("*"))
                cbKhoa.DataSource = DataProvider.Instance.ExcuteQuery("Select * from Khoa");
            else
                cbKhoa.DataSource = DataProvider.Instance.ExcuteQuery("Select * from Khoa where MaKhoa='" + khoa + "'");
            cbKhoa.DisplayMember = "TenKhoa";
            cbKhoa.ValueMember = "MaKhoa";
        }

        public void loadCBGV(string MaKhoa)
        {
            if(MaKhoa.Equals("*"))
                cbGV.DataSource = DataProvider.Instance.ExcuteQuery("Select * from GiangVien");
            else
                cbGV.DataSource = DataProvider.Instance.ExcuteQuery("Select * from GiangVien where MaKhoa='"+MaKhoa+"'");
            cbGV.DisplayMember = "TenGV";
            cbGV.ValueMember = "MaGV";
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            DataProvider.Instance.ExcuteNonQuery("Insert into Lop values(" +
                "'" + txtMaLop.Text + "', N'" + txtTenLop.Text + "', '" + dtpNgayLap.Value.ToString("yyyy/MM/dd") + "'," +
                " '" + cbGV.SelectedValue + "', '" + cbKhoa.SelectedValue + "')");
            if (AccountDAO.Instance.getQuyenByUser(mgv).Equals("admin"))
            {
                loadCBKHoa("*"); loadLop(cbKhoa.SelectedValue.ToString()); loadCBGV(cbKhoa.SelectedValue.ToString());
            }
            else if (AccountDAO.Instance.getQuyenByUser(mgv).Equals("tk"))
            {
                loadCBKHoa(GiangVienDAO.Instance.getKhoabyMGV(mgv));
                loadLop(cbKhoa.SelectedValue.ToString()); loadCBGV(cbKhoa.SelectedValue.ToString());
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DataProvider.Instance.ExcuteNonQuery("Update Lop set" +
                " TenLop= N'" + txtTenLop.Text + "'," +
                " GVCN='" + cbGV.SelectedValue + "', MaKhoa='" + cbKhoa.SelectedValue + "' where MaLop='" + dtgvLop.CurrentRow.Cells["MaLop"].Value.ToString() + "'");
            if (AccountDAO.Instance.getQuyenByUser(mgv).Equals("admin"))
            {
                loadCBKHoa("*"); loadLop(cbKhoa.SelectedValue.ToString()); loadCBGV(cbKhoa.SelectedValue.ToString());
            }
            else if (AccountDAO.Instance.getQuyenByUser(mgv).Equals("tk"))
            {
                loadCBKHoa(GiangVienDAO.Instance.getKhoabyMGV(mgv));
                loadLop(cbKhoa.SelectedValue.ToString()); loadCBGV(cbKhoa.SelectedValue.ToString());
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataProvider.Instance.ExcuteNonQuery("Delete from Lop where MaLop='"+dtgvLop.CurrentRow.Cells["MaLop"].Value.ToString()+"'");
            if (AccountDAO.Instance.getQuyenByUser(mgv).Equals("admin"))
            {
                loadCBKHoa("*"); loadLop(cbKhoa.SelectedValue.ToString()); loadCBGV(cbKhoa.SelectedValue.ToString());
            }
            else if (AccountDAO.Instance.getQuyenByUser(mgv).Equals("tk"))
            {
                loadCBKHoa(GiangVienDAO.Instance.getKhoabyMGV(mgv));
                loadLop(cbKhoa.SelectedValue.ToString()); loadCBGV(cbKhoa.SelectedValue.ToString());
            }
        }

        private void dtgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaLop.Text = dtgvLop.CurrentRow.Cells["MaLop"].Value.ToString();
            txtTenLop.Text = dtgvLop.CurrentRow.Cells["TenLop"].Value.ToString();
            cbKhoa.SelectedValue = dtgvLop.CurrentRow.Cells["MaKhoa"].Value.ToString();
            cbGV.SelectedValue = dtgvLop.CurrentRow.Cells["MaGV"].Value.ToString();
        }

        private void cbKhoa_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                loadCBGV(cbKhoa.SelectedValue.ToString());
                loadLop(cbKhoa.SelectedValue.ToString());
            }
            catch { }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            if (AccountDAO.Instance.getQuyenByUser(mgv).Equals("admin"))
            {
                loadCBKHoa("*"); loadLop(cbKhoa.SelectedValue.ToString()); loadCBGV(cbKhoa.SelectedValue.ToString());
            }
            else if (AccountDAO.Instance.getQuyenByUser(mgv).Equals("tk"))
            {
                loadCBKHoa(GiangVienDAO.Instance.getKhoabyMGV(mgv));
                loadLop(cbKhoa.SelectedValue.ToString()); loadCBGV(cbKhoa.SelectedValue.ToString());
            }
        }
    }
}
