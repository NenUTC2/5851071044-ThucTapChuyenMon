using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.DAO
{
    class DiemDAO
    {
        private static DiemDAO instance;

        internal static DiemDAO Instance
        {
            get { if (instance == null) instance = new DiemDAO(); return instance; }
            set => instance = value;
        }

        public DiemDAO() { }

        public void suaDiem(decimal cc, decimal gk, decimal tp, decimal thi, decimal kt, string mactmon, string msv)
        {
            int tc = Convert.ToInt32(DataProvider.Instance.ExcuteQuery("SELECT TinChi FROM dbo.MonHoc, dbo.LopHoc, dbo.DiemLopHoc " +
                "WHERE LopHoc.MaCTMon=DiemLopHoc.MaCTMon AND LopHoc.MaMon=MonHoc.MaMon AND " +
                "DiemLopHoc.MaCTMon='"+mactmon+"' AND MaSV='"+msv+"'").Rows[0][0].ToString());
            DataProvider.Instance.ExcuteNonQuery("Update DiemLopHoc set ChuyenCan=" +cc + "," +
                " DiemGiuaKy=" + gk + ", DiemTP=" + tp + "," +
                " DiemThi=" + thi + ", DiemKT=" + kt + ", KTxTC="+kt*tc+ " where DiemLopHoc.MaCTMon='" + mactmon + "' AND MaSV='" + msv + "'");
        }
    }
}
