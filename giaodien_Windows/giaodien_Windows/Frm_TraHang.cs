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
        static string ten;
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
            int num;
            num = e.RowIndex;
            ten = dataGridView1.Rows[num].Cells[5].Value.ToString();
        }
        private void btn_click(object sender, EventArgs e)
        {
           trahang.updatett(ten);
            dataGridView1.DataSource = trahang.loaddulieu();
        }
    }
}
