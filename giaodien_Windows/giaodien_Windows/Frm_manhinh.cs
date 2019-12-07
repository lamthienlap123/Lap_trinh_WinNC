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
    public partial class Frm_manhinh : Form
    {
        public Frm_manhinh()
        {
            InitializeComponent();
        }

        private void dM_MANHINHBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dM_MANHINHBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Frm_manhinh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.DM_MANHINH' table. You can move, or remove it, as needed.
            this.dM_MANHINHTableAdapter.Fill(this.dataSet1.DM_MANHINH);

        }
    }
}
