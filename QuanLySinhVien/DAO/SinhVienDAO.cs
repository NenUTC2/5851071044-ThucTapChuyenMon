using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.DAO
{
    class SinhVienDAO
    {
        private static SinhVienDAO instance;

        internal static SinhVienDAO Instance
        {
            get { if (instance == null) instance = new SinhVienDAO(); return instance; }
            set => instance = value;
        }

        public SinhVienDAO() { }

        public int getMaxGV()
        {
            int kq = Convert.ToInt32(DataProvider.Instance.ExcuteQuery("Select count(*) from SinhVien").Rows[0][0].ToString());
            if (kq > 0)
                return kq;
            else return 0;
        }
    }
}
