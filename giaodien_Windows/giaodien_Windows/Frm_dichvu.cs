using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using DAL;
namespace giaodien_Windows
{
    public partial class Frm_dichvu : Form
    {
        public Frm_dichvu()
        {
            InitializeComponent();
        }
        BALDichVu bal = new BALDichVu();
        
        private void Frm_dichvu_Load(object sender, EventArgs e)
        {

            txt_madv.ResetText();
            txt_tdv.ResetText();
            txt_dongia.ResetText();
            btn_them.Enabled = true;
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
            btn_luu.Enabled = false;
            dataGridView1.DataSource = bal.LoadDichVu();
            txt_dongia.Enabled = false;
            txt_madv.Enabled = false;
            txt_tdv.Enabled = false;
        }

        private void btn_them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txt_dongia.Enabled = true;
            txt_madv.Enabled = true;
            txt_tdv.Enabled = true;
            btn_luu.Enabled = true;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
        }

        private void btn_xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bal.XoaDichVu(txt_madv.Text);
                MessageBox.Show("Xóa thành công");
                dataGridView1.DataSource = bal.LoadDichVu();
            }
            catch
            {
                MessageBox.Show("Xóa thất bại");
            }

        }
        private void btn_sua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bal.SuaDichVu(txt_madv.Text, txt_tdv.Text, float.Parse(txt_dongia.Text));
                MessageBox.Show("Sửa thành công");
                dataGridView1.DataSource = bal.LoadDichVu();
            }
            catch
            {
                MessageBox.Show("Sửa thất bại");
            }
        }
        private void gdv_cellclick(object sender,DataGridViewCellEventArgs e)
        {
            btn_luu.Enabled = false;
            btn_them.Enabled = true;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            txt_dongia.Enabled = true;
            txt_madv.Enabled = false;
            txt_tdv.Enabled = true;
            int numrow;
            numrow = e.RowIndex;
            txt_madv.Text = dataGridView1.Rows[numrow].Cells[0].Value.ToString();
            txt_tdv.Text = dataGridView1.Rows[numrow].Cells[1].Value.ToString();
            txt_dongia.Text = dataGridView1.Rows[numrow].Cells[2].Value.ToString();
        }
        private void btn_luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
                try
                {
                    bal.ThemDichVu(txt_madv.Text, txt_tdv.Text, float.Parse(txt_dongia.Text));
                    MessageBox.Show("Thêm thành công");
                    dataGridView1.DataSource = bal.LoadDichVu();
                }
                catch
                {
                    txt_dongia.Enabled = false;
                    txt_madv.Enabled = false;
                    txt_tdv.Enabled = false;
                    MessageBox.Show("Thêm thất bại");
                }
            
        }

        private void btn_lammoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_dichvu_Load(sender, e);
        }

    }
}
