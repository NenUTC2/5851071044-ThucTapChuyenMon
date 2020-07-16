using QuanLySinhVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.DAO
{
    class GiangVienDAO
    {
        private static GiangVienDAO instance;

        internal static GiangVienDAO Instance {
            get { if (instance == null) instance = new GiangVienDAO(); return instance; }
            set => instance = value;
        }

        public GiangVienDAO() { }

        public List<GiangVien> AccountList()
        {
            List<GiangVien> list = new List<GiangVien>();
            DataTable data = DataProvider.Instance.ExcuteQuery("Select * from GiangVien");
            foreach (DataRow item in data.Rows)
            {
                GiangVien gv = new GiangVien(item);
                list.Add(gv);
            }
            return list;
        }

        public int getMaxGV(string khoa)
        {
            int kq = Convert.ToInt32(DataProvider.Instance.ExcuteQuery("Select count(*) from GiangVien where MaKhoa='"+khoa+"'").Rows[0][0].ToString());
            if (kq > 0)
                return kq;
            else return 0;
        }

        public int checkMGV(string mgv)
        {
            if (DataProvider.Instance.ExcuteQuery("Select * from GiangVien where MaGV='" + mgv + "'").Rows.Count > 0)
            {
                return 1;
            }
            return 0;
        }

        public int checkTruongKhoa(string tk)
        {
            if (DataProvider.Instance.ExcuteQuery("Select * from GiangVien where TruongKhoa='" + tk + "'").Rows.Count > 0)
            {
                return 1;
            } return 0;
        }

        public string getTKbyMaKHoa(string khoa)
        {
            return DataProvider.Instance.ExcuteQuery("Select MaGV from GiangVien where TruongKhoa='" + khoa + "'").Rows[0][0].ToString();
        }

        public string getTenGV(string mgv)
        {
            return DataProvider.Instance.ExcuteQuery("Select TenGV from GiangVien where MaGV='" + mgv + "'").Rows[0][0].ToString();
        }

        public string getTKbyMGV(string mgv)
        {
            return DataProvider.Instance.ExcuteQuery("Select TruongKhoa from GiangVien where MaGV='" + mgv + "'").Rows[0][0].ToString();
        }

        public string getKhoabyMGV(string mgv)
        {
            return DataProvider.Instance.ExcuteQuery("Select MaKhoa from GiangVien where MaGV='" + mgv + "'").Rows[0][0].ToString();
        }
    }
}
