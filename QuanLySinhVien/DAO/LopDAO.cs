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

        public string getMaNganhbyMaLop(string id)
        {
            try
            {
                return DataProvider.Instance.ExcuteQuery("Select MaNganh from Lop where MaLop='" + id + "'").Rows[0][0].ToString();
            }
            catch { return ""; }
        }

        public string getNganhfromLop(string idlop)
        {
            return DataProvider.Instance.ExcuteQuery("Select MaNganh from Lop where MaLop='" + idlop + "'").Rows[0][0].ToString();
        }

        public string getTenfromID(string idlop)
        {
            return DataProvider.Instance.ExcuteQuery("Select TenLop from Lop where MaLop='" + idlop + "'").Rows[0][0].ToString();
        }
    }
}
