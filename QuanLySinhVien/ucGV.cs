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
    public partial class ucGV : UserControl
    {
        public Panel pn { get { return panel1; } }
        public Panel pn2 { get { return panel2; } }
        public Panel pn3 { get { return panel3; } }

        public string mgv;
        public ucGV(string gv)
        {
            mgv = gv;
            InitializeComponent();

            if (AccountDAO.Instance.getQuyenByUser(mgv).Equals("admin"))
            {
                loadCBKhoa("*");
                loadGV(cbKhoa.SelectedValue.ToString());
            }

            else if (AccountDAO.Instance.getQuyenByUser(mgv).Equals("tk"))
            {
                loadCBKhoa(GiangVienDAO.Instance.getKhoabyMGV(mgv));
                loadGV(cbKhoa.SelectedValue.ToString());
            }
        }
        
        public void loadGV(string khoa)
        {
            if (khoa.Equals("*"))
                dtgvGV.DataSource = DataProvider.Instance.ExcuteQuery("Select * from GiangVien");
            else
                dtgvGV.DataSource = DataProvider.Instance.ExcuteQuery("Select * from GiangVien where MaKhoa='" + khoa + "'");
        }

        public void loadCBKhoa(string khoa)
        {
            if (khoa.Equals("*"))
                cbKhoa.DataSource = DataProvider.Instance.ExcuteQuery("Select * from Khoa");
            else
                cbKhoa.DataSource = DataProvider.Instance.ExcuteQuery("Select * from Khoa where MaKhoa='" + khoa + "'");
            cbKhoa.DisplayMember = "TenKhoa";
            cbKhoa.ValueMember = "MaKhoa";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string truongkhoa = "None";
            if (chkTruongKhoa.Checked == true)
            {
                if (GiangVienDAO.Instance.checkTruongKhoa(cbKhoa.SelectedValue.ToString()) == 1)
                {
                    DialogResult dialogResult = MessageBox.Show("Khoa này đã có trưởng khoa. Bạn có muốn đổi trưởng khoa?", "Thông báo", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string gv = GiangVienDAO.Instance.getTKbyMaKHoa(cbKhoa.SelectedValue.ToString());
                        DataProvider.Instance.ExcuteNonQuery("Update GiangVien set TruongKhoa='None' where MaGV='"+gv+"'");
                        truongkhoa = cbKhoa.SelectedValue.ToString();
                    }
                }
                
            }
            DataProvider.Instance.ExcuteNonQuery("Insert into GiangVien values" +
               "('" + cbKhoa.SelectedValue.ToString() + (GiangVienDAO.Instance.getMaxGV(cbKhoa.SelectedValue.ToString())+1).ToString() + "', N'" + txtTenGV.Text + "'," +
               "'"+txtSDT.Text+"', '"+cbKhoa.SelectedValue.ToString()+"', '"+truongkhoa+"', N'"+txtDiaChi.Text+"' , '" + dtpNgayDay.Value.ToString("yyyy/MM/dd") + "')");

            //lblError.Text = "Thêm thành công khoa " + txtTenKhoa.Text;
            //thongbao();
            loadGV(cbKhoa.SelectedValue.ToString());
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string truongkhoa = "None";
            if (dtgvGV.CurrentRow.Cells["TK"].Value.ToString().Equals("None"))
            {
                if (chkTruongKhoa.Checked == true)
                {
                    if (GiangVienDAO.Instance.checkTruongKhoa(cbKhoa.SelectedValue.ToString()) == 1)
                    {
                        DialogResult dialogResult = MessageBox.Show("Khoa này đã có trưởng khoa. Bạn có muốn đổi trưởng khoa?", "Thông báo", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            string gv = GiangVienDAO.Instance.getTKbyMaKHoa(cbKhoa.SelectedValue.ToString());
                            DataProvider.Instance.ExcuteNonQuery("Update GiangVien set TruongKhoa='None' where MaGV='" + gv + "'");
                            truongkhoa = cbKhoa.SelectedValue.ToString();
                        }
                    }else truongkhoa = cbKhoa.SelectedValue.ToString();
                }
            }
            else if (chkTruongKhoa.Checked == true)
                truongkhoa = cbKhoa.SelectedValue.ToString();
            DataProvider.Instance.ExcuteNonQuery("Update GiangVien set TenGV=N'"+txtTenGV.Text+"', SDT='"+txtSDT.Text+"', TruongKhoa='"+truongkhoa+"', DiaChi=N'"+txtDiaChi.Text+"' " +
                "where MaGV='"+ dtgvGV.CurrentRow.Cells["MaGV"].Value.ToString() + "'");

            //lblError.Text = "Thêm thành công khoa " + txtTenKhoa.Text;
            //thongbao();
            loadGV(cbKhoa.SelectedValue.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataProvider.Instance.ExcuteNonQuery("Delete from GiangVien where MaGV='"+ dtgvGV.CurrentRow.Cells["MaGV"].Value.ToString() +"'");

            //lblError.Text = "Thêm thành công khoa " + txtTenKhoa.Text;
            //thongbao();
            loadGV(cbKhoa.SelectedValue.ToString());
        }

        private void dtgvGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenGV.Text = dtgvGV.CurrentRow.Cells["TenGV"].Value.ToString();
            txtSDT.Text = dtgvGV.CurrentRow.Cells["SDT"].Value.ToString();
            txtDiaChi.Text = dtgvGV.CurrentRow.Cells["DiaChi"].Value.ToString();
            cbKhoa.SelectedValue = dtgvGV.CurrentRow.Cells["MaKhoa"].Value.ToString();
            if (dtgvGV.CurrentRow.Cells["TK"].Value.ToString().Equals("None"))
                chkTruongKhoa.Checked = false;
            else
                chkTruongKhoa.Checked = true;
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            if (AccountDAO.Instance.getQuyenByUser(mgv).Equals("admin"))
            {
                loadCBKhoa("*");
                loadGV(cbKhoa.SelectedValue.ToString());
            }

            else if (AccountDAO.Instance.getQuyenByUser(mgv).Equals("tk"))
            {
                loadCBKhoa(GiangVienDAO.Instance.getKhoabyMGV(mgv));
                loadGV(cbKhoa.SelectedValue.ToString());
            }
        }

        private void cbKhoa_SelectedValueChanged(object sender, EventArgs e)
        {
            loadGV(cbKhoa.SelectedValue.ToString());
        }
    }
}
