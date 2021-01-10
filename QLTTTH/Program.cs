using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;

namespace QLTTTH
{
    static class Program
    {
        public static frmMain mainfrm= null;
        public static frmDangNhap loginfrm=null;
        public static frmCauHinh cauhinhfrm =null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Application.Run(new frmDangNhap());
        }
    }
}
