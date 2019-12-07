using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BAL;

namespace giaodien_Windows
{
    public partial class Frm_hangton : Form
    {
        static string ten;
        BALQuanLy quanly = new BALQuanLy();
        public Frm_hangton()
        {
            InitializeComponent();
        }
        private void loaddulieu(object sender,EventArgs e)
        {
            dataGridView1.DataSource = quanly.loadgiacdo();
        }
        private void cell_click(object sender,DataGridViewCellEventArgs e)
        {
            int num;
            num = e.RowIndex;
            ten = dataGridView1.Rows[num].Cells[0].Value.ToString();
        }
        private void btn_click(object sender,EventArgs e)
        {
            quanly.updatett(ten);
            dataGridView1.DataSource = quanly.loadgiacdo();
        }
    }
}
