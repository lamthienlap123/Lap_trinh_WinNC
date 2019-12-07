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
    public partial class Frm_kho : DevExpress.XtraEditors.XtraForm
    {
        public Frm_kho()
        {
            InitializeComponent();
        }
        BALKho kho = new BALKho();
        private void Frm_kho_Load(object sender, EventArgs e)
        {
           dataGridView1.DataSource = kho.LoadKho();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            kho.ThemKho(txt_makho.Text,txt_tenkho.Text);
            dataGridView1.DataSource = kho.LoadKho();
        }
        private void btn_xoa_click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            kho.XoaKho(txt_makho.Text);
            dataGridView1.DataSource = kho.LoadKho();
        }
        private void btn_click_sua(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            kho.SuaKho(txt_makho.Text, txt_tenkho.Text);
            dataGridView1.DataSource = kho.LoadKho();
        }
        private void gdv_cellclick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txt_makho.Text = dataGridView1.Rows[numrow].Cells[0].Value.ToString();
            txt_tenkho.Text = dataGridView1.Rows[numrow].Cells[1].Value.ToString();
        }
    }
}