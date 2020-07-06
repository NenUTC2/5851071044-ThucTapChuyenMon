using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.DTO
{
    class Lop
    {
        private string maLop;
        private string tenLop;
        private string ngayLap;
        private string maKhoa;
        private string maGV;

        public string MaLop { get => maLop; set => maLop = value; }
        public string TenLop { get => tenLop; set => tenLop = value; }
        public string NgayLap { get => ngayLap; set => ngayLap = value; }
        public string MaKhoa { get => maKhoa; set => maKhoa = value; }
        public string MaGV { get => maGV; set => maGV = value; }

        public Lop() { }

        public Lop(DataRow row)
        {
            this.MaLop = row["MaLop"].ToString();
            this.TenLop = row["TenLop"].ToString();
            this.NgayLap = row["NgayLap"].ToString();
            this.MaKhoa = row["MaKhoa"].ToString();
            this.MaGV = row["MaGV"].ToString();
        }
    }
}
