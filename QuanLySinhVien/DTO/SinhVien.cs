using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.DTO
{
    class SinhVien
    {
        private string maSV;
        private string tenSV;
        private string sDT;
        private string maLop;
        private string diaChi;
        private int tichLuy;

        public string MaSV { get => maSV; set => maSV = value; }
        public string TenSV { get => tenSV; set => tenSV = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string MaLop { get => maLop; set => maLop = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public int TichLuy { get => tichLuy; set => tichLuy = value; }

        public SinhVien() { }

        public SinhVien(DataRow row)
        {
            this.MaSV = row["MaSV"].ToString();
            this.TenSV = row["TenSV"].ToString();
            this.SDT = row["SDT"].ToString();
            this.MaLop = row["MaLop"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
            this.TichLuy = (int)row["TichLuy"];
        }
    }
}
