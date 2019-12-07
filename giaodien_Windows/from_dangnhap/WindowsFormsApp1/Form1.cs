using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
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
            Form2 frm2 = new Form2();
            frm2.Show();
        }
        private void btn_dangnhap_click(object sender,EventArgs e)
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
    }
}
