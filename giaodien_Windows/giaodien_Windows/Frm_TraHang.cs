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
    public partial class Frm_TraHang : Form
    {
        static string ma;
        BALTraHang trahang = new BALTraHang();
        public Frm_TraHang()
        {
            InitializeComponent();
        }
        private void loaddulieu(object sender, EventArgs e)
        {
            dataGridView1.DataSource = trahang.loaddulieu();
        }
        private void cell_click(object sender, DataGridViewCellEventArgs e)
        {
            //int num;
            //num = e.RowIndex;
            //ten = dataGridView1.Rows[num].Cells[5].Value.ToString();
        }
        private void btn_click(object sender, EventArgs e)
        {
            trahang.updatett(ma);
            dataGridView1.DataSource = trahang.loaddulieu();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnTraDo.Enabled = true;
                int numrow;
                numrow = e.RowIndex;
                ma = dataGridView1.Rows[numrow].Cells[0].Value.ToString();
                dataGridView2.DataSource = trahang.loadCTDHtheoDH(int.Parse(ma));
            }
            catch
            {

            }
            
        }

        private void textEdit1_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            dataGridView1.DataSource = trahang.TimKiemMaDH(int.Parse(txtTimKiem.Text));
            dataGridView1.Refresh();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            loaddulieu(sender, e);
        }
    }
}
