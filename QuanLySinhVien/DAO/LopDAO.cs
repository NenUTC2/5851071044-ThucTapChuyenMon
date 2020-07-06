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

        
    }
}
