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
    public partial class Frm_giat : DevExpress.XtraEditors.XtraForm
    {
        public Frm_giat()
        {
            InitializeComponent();
        }
        QuanLyTiemGiacLaDataContext ql = new QuanLyTiemGiacLaDataContext();
        BALGiat giat = new BALGiat();
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            
        }
        public void LoadMayGiat()
        {
            foreach (MayGiat mg in ql.MayGiats)
            {
                SimpleButton btn = new SimpleButton();
                btn.Text = mg.TenMay;
                btn.Name = mg.MaMG;
                btn.ImageOptions.ImageList = imageList1;
                btn.Size = new Size(70, 95);
                if (mg.TrangThai == true)
                {
                    btn.ImageOptions.ImageIndex = 1;
                    btn.ForeColor = Color.White;
                }
                else
                {
                    btn.ImageOptions.ImageIndex = 0;
                    btn.ForeColor = Color.Black;
                }
                btn.Click += btn_Click;
                flowLayoutPanel1.Controls.Add(btn);
                this.Refresh();
            }
            
        }
        string MaMay = "";
        private void Frm_giat_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            LoadMayGiat();
            dataGridView1.DataSource = giat.LoadDonHangChuaGiat();
            
        }
        private void btn_Click(object sender, EventArgs e)
        {
            SimpleButton bt = sender as SimpleButton;
            txtTenMay.Text = bt.Text;
            MaMay = bt.Name;
            txtMaMay.Text = MaMay;
            if (giat.LayTrinhTrang(MaMay) == "True")
                txtTrinhTrang.Text = "Đang sử dụng";
            else
                txtTrinhTrang.Text = "Đang trống";
            dataGridView1.Enabled = true;
            dataGridView2.DataSource = giat.LoadDonHangDangGiat(txtMaMay.Text);
        }

        private void btnTienHanhGiat_Click(object sender, EventArgs e)
        {
            
            if (giat.LayTrinhTrang(txtMaMay.Text)=="True")
            {
                XtraMessageBox.Show("Máy đang được sử dụng");
            }
            else
            {
                giat.CapNhatPhieuGiat(int.Parse(txtMaPhieu.Text), txtMaMay.Text);
                giat.CapNhatTinhTrangGiatDangSD(txtMaMay.Text,true);
                dataGridView1.DataSource = giat.LoadDonHangChuaGiat();
                flowLayoutPanel1.Controls.Clear();
                LoadMayGiat();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            btnTienHanhGiat.Enabled = true;
            int numrow;
            numrow = e.RowIndex;
            txtMaPhieu.Text = dataGridView1.Rows[numrow].Cells[0].Value.ToString();
        }

        private void btn_DaGiat_Click(object sender, EventArgs e)
        {
            string maphieu = dataGridView2.Rows[0].Cells[0].Value.ToString();
            giat.CapNhatPhieuGiatDaGiat(int.Parse(maphieu));
            dataGridView2.DataSource = giat.LoadDonHangDangGiat(txtMaMay.Text);
            giat.CapNhatTinhTrangGiatDangSD(txtMaMay.Text, false);
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Refresh();
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Refresh();
            LoadMayGiat();
            dataGridView1.DataSource = giat.LoadDonHangChuaGiat();
        }
    }
}