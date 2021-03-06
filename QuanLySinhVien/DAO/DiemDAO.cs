﻿using System;
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
            int tc = Convert.ToInt32(DataProvider.Instance.ExcuteQuery("SELECT TinChi FROM dbo.MonHoc, dbo.LopHocPhan, dbo.DiemHocPhan " +
                "WHERE LopHocPhan.MaHP=DiemHocPhan.MaHP AND LopHocPhan.MaMon=MonHoc.MaMon AND " +
                "DiemHocPhan.MaHP='"+mactmon+"' AND MaSV='"+msv+"'").Rows[0][0].ToString());
            int tra = 0;
            if (kt > 4)
                tra = 1;
            DataProvider.Instance.ExcuteNonQuery("Update DiemHocPhan set ChuyenCan=" +cc + "," +
                " DiemGiuaKy=" + gk + ", DiemTP=" + tp + "," +
                " DiemThi=" + thi + ", DiemKT=" + kt + ", KTxTC="+kt*tc+ ",Tra="+tra+" where DiemHocPhan.MaHP='" + mactmon + "' AND MaSV='" + msv + "'");
            if (kt > 0)
            {
                decimal KTxTC = Convert.ToDecimal(DataProvider.Instance.ExcuteQuery("SELECT SUM(KTxTC) FROM dbo.DiemHocPhan WHERE MaSV='" + msv + "'").Rows[0][0].ToString());
                decimal ttc = Convert.ToDecimal(DataProvider.Instance.ExcuteQuery("SELECT SUM(TinChi) FROM dbo.MonHoc, dbo.LopHocPhan, dbo.DiemHocPhan " +
                    "WHERE LopHocPhan.MaHP=DiemHocPhan.MaHP AND LopHocPhan.MaMon=MonHoc.MaMon AND MaSV='" + msv + "'").Rows[0][0].ToString());
                string hk = getHKfromCTMon(mactmon);
                decimal tlhk = KTxTC / ttc;
                DataProvider.Instance.ExcuteNonQuery("Update CTHocKy set DiemTichLuy= "+tlhk+" where MaHK='"+hk+"' and MaSV='"+msv+"'");
                decimal tongtichluy = Convert.ToDecimal(DataProvider.Instance.ExcuteQuery("SELECT SUM(DiemTichLuy) FROM dbo.CTHocKy WHERE MaSV='"+msv+"'").Rows[0][0].ToString());
                decimal sohk = Convert.ToDecimal(DataProvider.Instance.ExcuteQuery("SELECT COUNT(*) FROM dbo.CTHocKy WHERE MaSV='"+msv+"'").Rows[0][0].ToString());
                decimal tl = tongtichluy / sohk;
                DataProvider.Instance.ExcuteNonQuery("Update SinhVien set TichLuy= "+tl+" where MaSV='"+msv+"'");
            }
        }

        public string getHKfromCTMon(string mact)
        {
            return DataProvider.Instance.ExcuteQuery("Select HocKy from LopHocPhan where MaHP='" + mact + "'").Rows[0][0].ToString();
        }

        public string getMaMonbyCTMon(string mact)
        {
            return DataProvider.Instance.ExcuteQuery("Select MaMon from LopHocPhan where MaHP='" + mact + "'").Rows[0][0].ToString();
        }

        public void themCTHocKy(string mact, string msv)
        {
            string hk = DataProvider.Instance.ExcuteQuery("Select HocKy from LopHocPhan where MaHP='" + mact + "'").Rows[0][0].ToString();

            DataTable dthk = DataProvider.Instance.ExcuteQuery("Select * from CTHocKy where MaHK='" + hk + "' and MaSV='" + msv + "'");
            if (dthk.Rows.Count <= 0)
            {
                DataProvider.Instance.ExcuteNonQuery("Insert into CTHocKy values('" + hk + "', '" + msv + "', 0)");
            }
        }
    }
}
