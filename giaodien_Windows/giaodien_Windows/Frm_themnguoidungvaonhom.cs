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
    public partial class Frm_themnguoidungvaonhom : Form
    {
        public Frm_themnguoidungvaonhom()
        {
            InitializeComponent();
        }

        private void qL_NGUOIDUNGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.qL_NGUOIDUNGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Frm_themnguoidungvaonhom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.QL_NHOMNGUOIDUNG' table. You can move, or remove it, as needed.
            this.qL_NHOMNGUOIDUNGTableAdapter.Fill(this.dataSet1.QL_NHOMNGUOIDUNG);
            // TODO: This line of code loads data into the 'dataSet1.QL_NGUOIDUNG' table. You can move, or remove it, as needed.
            this.qL_NGUOIDUNGTableAdapter.Fill(this.dataSet1.QL_NGUOIDUNG);

        }

        
        public void LoadComboByCondition()
        {
            if (qL_NHOMNGUOIDUNGComboBox.SelectedValue != null)
                this.qL_NGUOIDUNGNHOMNGUOIDUNGDKTableAdapter.Fill_DK(this.dataSet1.QL_NGUOIDUNGNHOMNGUOIDUNGDK, qL_NHOMNGUOIDUNGComboBox.SelectedValue.ToString());

        }
        private void qL_NHOMNGUOIDUNGComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadComboByCondition();
        }

        private void btnVaoNhom_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in qL_NGUOIDUNGDataGridView.SelectedRows)
            {
                // Nhớ kiểm tra trước khi thêm trùng khóa chính
                if (this.qL_NGUOIDUNGNHOMNGUOIDUNGDKTableAdapter.KiemTraKhoa(item.Cells[0].Value.ToString(), qL_NHOMNGUOIDUNGComboBox.SelectedValue.ToString()) > 0)
                {
                    MessageBox.Show("Đã tồn tại");
                }
                else
                {
                    this.qL_NGUOIDUNGNHOMNGUOIDUNGDKTableAdapter.InsertQuery(item.Cells[0].Value.ToString(), qL_NHOMNGUOIDUNGComboBox.SelectedValue.ToString());
                }
            }
            LoadComboByCondition();
        }

        private void btnRaNhom_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in qL_NGUOIDUNGNHOMNGUOIDUNGDKDataGridView.SelectedRows)
            {
                if
                (this.qL_NGUOIDUNGNHOMNGUOIDUNGDKTableAdapter.DeleteQuery(item.Cells[0].Value.ToString(), qL_NHOMNGUOIDUNGComboBox.SelectedValue.ToString()) == 1)
                {
                    MessageBox.Show("Thành công");
                }
                else
                {
                    MessageBox.Show("Thất bại");
                }
                LoadComboByCondition();
            }
        }
    }
}
