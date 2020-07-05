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

        internal static GiangVienDAO Instance
        {
            get { if (instance == null) instance = new GiangVienDAO();return instance; }
            private set => instance = value;
        }

        public GiangVienDAO() { }

        public List<GiangVien> GiangVienList(string query)
        {
            List<GiangVien> list = new List<GiangVien>();
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
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
                return kq + 1;
            else
                return 1;
        }

        public void themGV(string cbk, string ten, string sdt, string dc, string ngay)
        {
            DataProvider.Instance.ExcuteNonQuery("Insert into GiangVien values " +
                "('" + cbk + getMaxGV() + "'" +
                ", N'" + ten + "', '" + sdt + "'" +
                ", '" + cbk + "', N'" + dc + "', '"+ngay+"')");
        }
        public void suaGV(string id, string ten, string sdt, string dc)
        {
            DataProvider.Instance.ExcuteNonQuery("Update GiangVien set TenGv=N'"+ten+"', SDT='"+sdt+"', DiaChi=N'"+dc+"' where MaGV='"+id+"'");
        }
    }
}
