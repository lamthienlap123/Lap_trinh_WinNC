using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;

namespace giaodien_Windows
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static Form1 mainForm = null;
        public static Frm_DangNhap DangNhap = null;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            DevExpress.Skins.SkinManager.EnableMdiFormSkins();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Office 2007 Green";
            //Application.Run(new Frm_giat());
            //Application.Run(new Frm_taophieu());
            //Application.Run(new Frm_nhanvien());
            //Application.Run(new Frm_TraHang());
            Application.Run(new Form1());
            //Application.Run(new Frm_LapPhieu());
        }
    }
}
