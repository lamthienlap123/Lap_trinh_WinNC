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
    public partial class Frm_nguoidung : Form
    {
        public Frm_nguoidung()
        {
            InitializeComponent();
        }

        private void qL_NGUOIDUNGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.qL_NGUOIDUNGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Frm_nguoidung_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.QL_NGUOIDUNG' table. You can move, or remove it, as needed.
            this.qL_NGUOIDUNGTableAdapter.Fill(this.dataSet1.QL_NGUOIDUNG);

        }
    }
}
