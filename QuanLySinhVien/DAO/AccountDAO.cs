using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.DAO
{
    class AccountDAO
    {
        private static AccountDAO instance;

        internal static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            set => instance = value;
        }

        public AccountDAO() { }

        public int checkLogin(string user, string pass)
        {
            DataTable dt = DataProvider.Instance.ExcuteQuery("Select * from Account where TenDN='" + user + "' and MatKhau='" + pass + "'");
            if (dt.Rows.Count > 0)
                return 1;
            return 0;
        }

        public int checkTenDN(string user)
        {
            DataTable dt = DataProvider.Instance.ExcuteQuery("Select * from Account where TenDN='" + user + "'");
            if (dt.Rows.Count > 0)
                return 1;
            return 0;
        }

        public string getQuyenByUser(string user)
        {
            return DataProvider.Instance.ExcuteQuery("Select Quyen from account where TenDN='"+user+"'").Rows[0][0].ToString();
        }
    }
}
