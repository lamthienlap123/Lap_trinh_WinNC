using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace giaodien_Windows
{
    public partial class Frm_nhomnguoidung : Form
    {
        public Frm_nhomnguoidung()
        {
            InitializeComponent();
        }

        private void qL_NHOMNGUOIDUNGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.qL_NHOMNGUOIDUNGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Frm_nhomnguoidung_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.QL_NHOMNGUOIDUNG' table. You can move, or remove it, as needed.
            this.qL_NHOMNGUOIDUNGTableAdapter.Fill(this.dataSet1.QL_NHOMNGUOIDUNG);

        }
    }
}
