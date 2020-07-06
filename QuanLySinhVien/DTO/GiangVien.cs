using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.DTO
{
    class GiangVien
    {
        private string maGV;
        private string tenGV;
        private string sDT;
        private string maKhoa;
        private string diaChi;
        private string ngayDay;

        public string MaGV { get => maGV; set => maGV = value; }
        public string TenGV { get => tenGV; set => tenGV = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string MaKhoa { get => maKhoa; set => maKhoa = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string NgayDay { get => ngayDay; set => ngayDay = value; }

        public GiangVien() { }

        public GiangVien(DataRow row)
        {
            this.MaGV = row["MaGV"].ToString();
            this.TenGV = row["TenGV"].ToString();
            this.SDT = row["SDT"].ToString();
            this.MaKhoa = row["MaKhoa"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
            this.NgayDay = row["DiaChi"].ToString();
        }
    }
}
