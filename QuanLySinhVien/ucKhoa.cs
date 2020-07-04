using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class ucKhoa : UserControl
    {
        //private static ucKhoa _instance;
        //public static ucKhoa Instance
        //{
        //    get
        //    {
        //        if (_instance == null)
        //            _instance = new ucKhoa();
        //        return _instance;
        //    }
        //}
        //public  string id;
        //public  string Id
        //{
        //    get { return id; }
        //    set
        //    {
        //        id = value;
        //    }
        //}
        public Panel pn { get { return panel1; }  }
        public ucKhoa()
        {
            InitializeComponent();
        }
    }
}
