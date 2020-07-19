using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml;
using System.Configuration;
using QuanLySinhVien.DAO;

namespace QuanLySinhVien
{
    public partial class formKetNoi : Form
    {
        public formKetNoi()
        {
            InitializeComponent();
            txtServer.Text = SystemInformation.ComputerName.ToString();
            txtDatabase.Text = "dataSV";
            try
            {
                DataProvider.Constr = ConfigurationManager.AppSettings["constr"];
                cmbTestValue.DataSource = DataProvider.Instance.ExcuteQuery("Select * from SinhVien");
                cmbTestValue.DisplayMember = "TenSV";
            }
            catch { }
        }

        private void btnTaoMon_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder Con = new StringBuilder("Data Source=");
            Con.Append(txtServer.Text);
            Con.Append(";Initial Catalog=");
            Con.Append(txtDatabase.Text);
            Con.Append(";Integrated Security=true;");
            string strCon = Con.ToString();
            updateConfigFile(strCon);
            //SqlConnection Db = new SqlConnection();
            //ConfigurationManager.RefreshSection("connectionStrings");
            //Db.ConnectionString = ConfigurationManager.ConnectionStrings["con"].ToString();
            //SqlDataAdapter da = new SqlDataAdapter("Select * from SinhVien", Db);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //cmbTestValue.DataSource = dt;
            //cmbTestValue.DisplayMember = "TenSV";
            //MessageBox.Show("Kết nối không khả dụng", "Lỗi");
            Application.Restart();
            Environment.Exit(0);
            }
            catch (Exception E)
            {
                MessageBox.Show("Kết nối không khả dụng", "Lỗi");
            }
        }
        public void updateConfigFile(string con)
        {
            //XmlDocument XmlDoc = new XmlDocument();
            //XmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            //foreach (XmlElement xElement in XmlDoc.DocumentElement)
            //{
            //    if (xElement.Name == "connectionStrings")
            //    {
            //        xElement.FirstChild.Attributes[2].Value = con;
            //    }
            //}
            //XmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);

            config.AppSettings.Settings.Remove("constr");
            config.AppSettings.Settings.Add("constr", con);

            config.Save(ConfigurationSaveMode.Modified);
        }

        private void guna2ImageButton1_MouseHover(object sender, EventArgs e)
        {
            guna2ImageButton1.BackColor = Color.OrangeRed;
        }

        private void guna2ImageButton1_MouseLeave(object sender, EventArgs e)
        {
            guna2ImageButton1.BackColor = Color.Transparent;
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
