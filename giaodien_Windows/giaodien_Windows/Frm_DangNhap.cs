using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace giaodien_Windows
{
    public partial class Frm_DangNhap : DevExpress.XtraEditors.XtraForm
    {
        public Frm_DangNhap()
        {
            InitializeComponent();
        }
        QL_nguoidung CauHinh = new QL_nguoidung();
        public void ProcessLogin()
        {
            int result;
            result = CauHinh.check_user(txt_taikhoan.Text, txt_matkhau.Text);
            // Wrong username or pass
            if (result == 0)
            {
                MessageBox.Show("Sai " + lbl_taikhoan.Text + " Hoặc " + lbl_matkhau.Text);
                return;
            }
            // Account had been disabled
            Form1 frm1 = new Form1();
            frm1.Show();
            //this.Hide();
        }
        private void btn_dangnhap_click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_taikhoan.Text.Trim()))

            {
                MessageBox.Show("Không được bỏ trống" + lbl_taikhoan.Text.ToLower());
                this.txt_taikhoan.Focus();
                return;
            }

            if (string.IsNullOrEmpty(this.txt_matkhau.Text))

            {
                MessageBox.Show("Không được bỏ trống" + txt_matkhau.Text.ToLower());
                this.txt_matkhau.Focus();
                return;
            }

            if (CauHinh.check_congif() == 0)

            {
                ProcessLogin();// Cấu hình phù hợp xử lý đăng nhập
            }

            if (CauHinh.check_congif() == 1)
            {
                MessageBox.Show("Chuỗi cấu hình không tồn tại");// Xử lý cấu hình
                Frm_cauhinh cauhinh = new Frm_cauhinh();
                cauhinh.Show();
            }
            if (CauHinh.check_congif() == 2)
            {
                MessageBox.Show("Chuỗi cấu hình không phù hợp");// Xử lý cấu hình
                Frm_cauhinh cauhinh = new Frm_cauhinh();
                cauhinh.Show();
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}