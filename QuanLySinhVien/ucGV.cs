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
using ZXing;
using ZXing.Common;
using ZXing.QrCode.Internal;
using ZXing.Rendering;

namespace QuanLySinhVien
{
    public partial class ucGV : UserControl
    {
        public Panel pn { get { return panel1; } }
        public Panel pntxt { get { return pn1; } }
        public Panel pnbtn { get { return pn2; } }
        public ucGV()
        {
            InitializeComponent();
            loadGV();
            loadCBKhoa();
        }
        public void loadGV()
        {
            dtgvGV.DataSource =DataProvider.Instance.ExcuteQuery("Select * from GiangVien");
        }
        
        public void loadCBKhoa()
        {
            DataTable dt = DataProvider.Instance.ExcuteQuery("Select * from Khoa");
            cbKhoa.DataSource = dt;
            cbKhoa.DisplayMember = "TenKhoa";
            cbKhoa.ValueMember = "MaKhoa";
        }
        public void taoQR(string txt)
        {
            BarcodeWriter barcodeWriter = new BarcodeWriter();
            EncodingOptions encodingOptions = new EncodingOptions() { Width = 300, Height = 300, Margin = 0, PureBarcode = false };
            encodingOptions.Hints.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H);
            barcodeWriter.Renderer = new BitmapRenderer();
            barcodeWriter.Options = encodingOptions;
            barcodeWriter.Format = BarcodeFormat.QR_CODE;
            Bitmap bitmap = barcodeWriter.Write(txt);
            Bitmap logo = new Bitmap(Properties.Resources.logoqr);
            Graphics g = Graphics.FromImage(bitmap);
            g.DrawImage(logo, new Point((bitmap.Width - logo.Width) / 2, (bitmap.Height - logo.Height) / 2));
            picQR.Image = bitmap;
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            GiangVienDAO.Instance.themGV(cbKhoa.SelectedValue.ToString(), txtTenGV.Text, txtSDT.Text, txtDiaChi.Text, dtpNgayDay.Value.ToString("yyyy/MM/dd"));
            loadGV();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataProvider.Instance.ExcuteNonQuery("Delete from GiangVien where MaGV='" + dtgvGV.CurrentRow.Cells["MaGV"].Value.ToString() + "'");
            loadGV();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            GiangVienDAO.Instance.suaGV(dtgvGV.CurrentRow.Cells["MaGV"].Value.ToString(), txtTenGV.Text, txtSDT.Text, txtDiaChi.Text);
            loadGV();
        }

        private void dtgvGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenGV.Text = dtgvGV.CurrentRow.Cells["TenGV"].Value.ToString();
            txtSDT.Text = dtgvGV.CurrentRow.Cells["SDT"].Value.ToString();
            txtDiaChi.Text = dtgvGV.CurrentRow.Cells["DiaChi"].Value.ToString();
            cbKhoa.DisplayMember = "abc";
            try
            {
                taoQR(dtgvGV.CurrentRow.Cells["MaGV"].Value.ToString());
            }
            catch { }
        }

        private void btnLuuQR_Click(object sender, EventArgs e)
        {
            if (picQR.Image != null)
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "JPG(*,JPG) |*.jpg";
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    picQR.Image.Save(saveFile.FileName);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng tạo mã QR !", "Thông Báo Lưu QR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
