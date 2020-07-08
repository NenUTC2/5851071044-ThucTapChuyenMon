using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.DAO
{
    class LopDAO
    {
        private static LopDAO instance;

        internal static LopDAO Instance
        {
            get { if (instance == null) instance = new LopDAO(); return instance; }
            set => instance = value;
        }

        public LopDAO() { }

        public string getMaKhoabyMaLop(string id)
        {
            try
            {
                return DataProvider.Instance.ExcuteQuery("Select MaKhoa from Lop where MaLop='" + id + "'").Rows[0][0].ToString();
            }
            catch { return ""; }
        }

        public string getKhoafromLop(string idlop)
        {
            return DataProvider.Instance.ExcuteQuery("Select MaKhoa from Lop where MaLop='" + idlop + "'").Rows[0][0].ToString();
        }
    }
}
