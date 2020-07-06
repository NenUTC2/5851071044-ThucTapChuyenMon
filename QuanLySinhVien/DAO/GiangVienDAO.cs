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

        public int getMaxGV()
        {
            int kq = Convert.ToInt32(DataProvider.Instance.ExcuteQuery("Select count(*) from GiangVien").Rows[0][0].ToString());
            if (kq > 0)
                return kq;
            else return 0;
        }
    }
}
