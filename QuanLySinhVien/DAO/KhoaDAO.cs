using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.DAO
{
    class KhoaDAO
    {
        private static KhoaDAO instance;

        internal static KhoaDAO Instance
        {
            get { if (instance == null) instance = new KhoaDAO(); return instance; }
            set => instance = value;
        }

        public KhoaDAO() { }

        public string getTenbyID(string id)
        {
            return DataProvider.Instance.ExcuteQuery("Select TenKhoa from Khoa where MaKhoa='" + id + "'").Rows[0][0].ToString();
        }
    }
}
