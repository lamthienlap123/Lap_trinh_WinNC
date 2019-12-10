using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace giaodien_Windows
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static string idlogin;

        public Form1()
        {
            
            InitializeComponent();
            DisEndMenuLogin(true, idlogin);

        }
        public void DisEndMenuLogin(bool e, string _idLogin)
        {
            //btn_DN.Enabled = e;
            //btn_DX.Enabled = !e;
            //Page_TT.Visible = !e;
            //Page_DM.Visible = !e;
            //Page_NV.Visible = !e;
        }
        private Form kiemtraform(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                {
                    return f;
                }
            }
            return null;
        }
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Form frm = kiemtraform(typeof(Frm_LapPhieu));
            if (frm == null)
            {
                Frm_LapPhieu forms = new Frm_LapPhieu();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(Frm_dichvu));
            if (frm == null)
            {
                Frm_dichvu forms = new Frm_dichvu();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(Frm_baocao));
            if (frm == null)
            {
                Frm_baocao forms = new Frm_baocao();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(Frm_nhanvien));
            if (frm == null)
            {
                Frm_nhanvien forms = new Frm_nhanvien();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(Frm_khachhang));
            if (frm == null)
            {
                Frm_khachhang forms = new Frm_khachhang();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Frm_DangNhap dn = new Frm_DangNhap();
            //dn.Show();

        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(Frm_TraHang));
            if (frm == null)
            {
                Frm_TraHang forms = new Frm_TraHang();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(Frm_giat));
            if (frm == null)
            {
                Frm_giat forms = new Frm_giat();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(Frm_nguoidung));
            if (frm == null)
            {
                Frm_nguoidung forms = new Frm_nguoidung();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(Frm_nhomnguoidung));
            if (frm == null)
            {
                Frm_nhomnguoidung forms = new Frm_nhomnguoidung();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(Frm_themnguoidungvaonhom));
            if (frm == null)
            {
                Frm_themnguoidungvaonhom forms = new Frm_themnguoidungvaonhom();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn thoát khỏi ứng dụng?", "Confirmation", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(Frm_TraHang));
            if (frm == null)
            {
                Frm_TraHang forms = new Frm_TraHang();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }
    }
}
