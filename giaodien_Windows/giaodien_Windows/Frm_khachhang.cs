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
using BAL;
using DAL;

namespace giaodien_Windows
{
    public partial class Frm_khachhang : DevExpress.XtraEditors.XtraForm
    {
        public Frm_khachhang()
        {
            InitializeComponent();
        }
        BALKhachHang kh = new BALKhachHang();
        private void Frm_khachhang_Load(object sender, EventArgs e)
        {
            btn_them.Enabled = true;
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
            btn_luu.Enabled = false;
            txt_makh.Enabled = false;
            txt_sdt.Enabled = false;
            txt_congno.Enabled = false;
            txt_diachi.Enabled = false;
            txt_hoten.Enabled = false;
            txt_makh.ResetText();
            txt_sdt.ResetText();
            txt_congno.ResetText();
            txt_diachi.ResetText();
            txt_hoten.ResetText();
            dataGridView1.DataSource = kh.LoadkhachHang();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txt_makh.ResetText();
            txt_sdt.ResetText();
            txt_congno.ResetText();
            txt_diachi.ResetText();
            txt_hoten.ResetText();
            txt_makh.Enabled = true;
            txt_sdt.Enabled = true;
            txt_congno.Enabled = true;
            txt_diachi.Enabled = true;
            txt_hoten.Enabled = true;
            btn_luu.Enabled = true;
            
        }
        private void btn_xoa_click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                kh.XoaKhachHang(txt_makh.Text);
                dataGridView1.DataSource = kh.LoadkhachHang();
                MessageBox.Show("Xóa thành công");
            }
            catch { MessageBox.Show("Xóa thất bại"); }
            
        }
        private void btn_sua_click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try {
                kh.SuaDichVu(txt_makh.Text, txt_hoten.Text, txt_diachi.Text, int.Parse(txt_sdt.Text), float.Parse(txt_congno.Text));
dataGridView1.DataSource = kh.LoadkhachHang();
                MessageBox.Show("Sửa thành công");
            }
            catch
            {
                MessageBox.Show("Sửa thất bại");
            }
            
        }
        private void grv_cellclick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int number;
                number = e.RowIndex;
                txt_makh.Text = dataGridView1.Rows[number].Cells[0].Value.ToString();
                txt_hoten.Text = dataGridView1.Rows[number].Cells[1].Value.ToString();
                txt_diachi.Text = dataGridView1.Rows[number].Cells[2].Value.ToString();
                txt_sdt.Text = dataGridView1.Rows[number].Cells[3].Value.ToString();
                txt_congno.Text = dataGridView1.Rows[number].Cells[4].Value.ToString();
                btn_luu.Enabled = false;
                btn_them.Enabled = true;
                btn_sua.Enabled = true;
                btn_xoa.Enabled = true;
                txt_makh.Enabled = false;
                txt_sdt.Enabled = true;
                txt_congno.Enabled = true;
                txt_diachi.Enabled = true;
                txt_hoten.Enabled = true;
            }
            catch { }
        }

        private void btn_luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                kh.ThemKhachHang(txt_makh.Text, txt_hoten.Text, txt_diachi.Text, int.Parse(txt_sdt.Text), float.Parse(txt_congno.Text));
                dataGridView1.DataSource = kh.LoadkhachHang();
                MessageBox.Show("Thêm thành công");
            }
            catch
            {
                MessageBox.Show("Thêm thất bại");
            }
            
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_khachhang_Load(sender, e);
        }
    }
}