namespace giaodien_Windows
{
    partial class Frm_themnguoidungvaonhom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataSet1 = new giaodien_Windows.DataSet1();
            this.qL_NGUOIDUNGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_NGUOIDUNGTableAdapter = new giaodien_Windows.DataSet1TableAdapters.QL_NGUOIDUNGTableAdapter();
            this.tableAdapterManager = new giaodien_Windows.DataSet1TableAdapters.TableAdapterManager();
            this.qL_NGUOIDUNGDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.qL_NGUOIDUNGNHOMNGUOIDUNGDKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_NGUOIDUNGNHOMNGUOIDUNGDKTableAdapter = new giaodien_Windows.DataSet1TableAdapters.QL_NGUOIDUNGNHOMNGUOIDUNGDKTableAdapter();
            this.qL_NGUOIDUNGNHOMNGUOIDUNGDKDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qL_NHOMNGUOIDUNGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_NHOMNGUOIDUNGTableAdapter = new giaodien_Windows.DataSet1TableAdapters.QL_NHOMNGUOIDUNGTableAdapter();
            this.qL_NHOMNGUOIDUNGComboBox = new System.Windows.Forms.ComboBox();
            this.btnVaoNhom = new System.Windows.Forms.Button();
            this.btnRaNhom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NGUOIDUNGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NGUOIDUNGDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NGUOIDUNGNHOMNGUOIDUNGDKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NGUOIDUNGNHOMNGUOIDUNGDKDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NHOMNGUOIDUNGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qL_NGUOIDUNGBindingSource
            // 
            this.qL_NGUOIDUNGBindingSource.DataMember = "QL_NGUOIDUNG";
            this.qL_NGUOIDUNGBindingSource.DataSource = this.dataSet1;
            // 
            // qL_NGUOIDUNGTableAdapter
            // 
            this.qL_NGUOIDUNGTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DM_MANHINHTableAdapter = null;
            this.tableAdapterManager.QL_NGUOIDUNGNHOMNGUOIDUNGDKTableAdapter = this.qL_NGUOIDUNGNHOMNGUOIDUNGDKTableAdapter;
            this.tableAdapterManager.QL_NGUOIDUNGNHOMNGUOIDUNGTableAdapter = null;
            this.tableAdapterManager.QL_NGUOIDUNGTableAdapter = this.qL_NGUOIDUNGTableAdapter;
            this.tableAdapterManager.QL_NHOMNGUOIDUNGTableAdapter = this.qL_NHOMNGUOIDUNGTableAdapter;
            this.tableAdapterManager.UpdateOrder = giaodien_Windows.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // qL_NGUOIDUNGDataGridView
            // 
            this.qL_NGUOIDUNGDataGridView.AutoGenerateColumns = false;
            this.qL_NGUOIDUNGDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.qL_NGUOIDUNGDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn1});
            this.qL_NGUOIDUNGDataGridView.DataSource = this.qL_NGUOIDUNGBindingSource;
            this.qL_NGUOIDUNGDataGridView.Location = new System.Drawing.Point(12, 59);
            this.qL_NGUOIDUNGDataGridView.Name = "qL_NGUOIDUNGDataGridView";
            this.qL_NGUOIDUNGDataGridView.Size = new System.Drawing.Size(342, 220);
            this.qL_NGUOIDUNGDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TenDangNhap";
            this.dataGridViewTextBoxColumn1.HeaderText = "TenDangNhap";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MatKhau";
            this.dataGridViewTextBoxColumn2.HeaderText = "MatKhau";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "HoatDong";
            this.dataGridViewCheckBoxColumn1.HeaderText = "HoatDong";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // qL_NGUOIDUNGNHOMNGUOIDUNGDKBindingSource
            // 
            this.qL_NGUOIDUNGNHOMNGUOIDUNGDKBindingSource.DataMember = "QL_NGUOIDUNGNHOMNGUOIDUNGDK";
            this.qL_NGUOIDUNGNHOMNGUOIDUNGDKBindingSource.DataSource = this.dataSet1;
            // 
            // qL_NGUOIDUNGNHOMNGUOIDUNGDKTableAdapter
            // 
            this.qL_NGUOIDUNGNHOMNGUOIDUNGDKTableAdapter.ClearBeforeFill = true;
            // 
            // qL_NGUOIDUNGNHOMNGUOIDUNGDKDataGridView
            // 
            this.qL_NGUOIDUNGNHOMNGUOIDUNGDKDataGridView.AutoGenerateColumns = false;
            this.qL_NGUOIDUNGNHOMNGUOIDUNGDKDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.qL_NGUOIDUNGNHOMNGUOIDUNGDKDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.qL_NGUOIDUNGNHOMNGUOIDUNGDKDataGridView.DataSource = this.qL_NGUOIDUNGNHOMNGUOIDUNGDKBindingSource;
            this.qL_NGUOIDUNGNHOMNGUOIDUNGDKDataGridView.Location = new System.Drawing.Point(486, 59);
            this.qL_NGUOIDUNGNHOMNGUOIDUNGDKDataGridView.Name = "qL_NGUOIDUNGNHOMNGUOIDUNGDKDataGridView";
            this.qL_NGUOIDUNGNHOMNGUOIDUNGDKDataGridView.Size = new System.Drawing.Size(246, 220);
            this.qL_NGUOIDUNGNHOMNGUOIDUNGDKDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TenDangNhap";
            this.dataGridViewTextBoxColumn3.HeaderText = "TenDangNhap";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MaNhom";
            this.dataGridViewTextBoxColumn4.HeaderText = "MaNhom";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // qL_NHOMNGUOIDUNGBindingSource
            // 
            this.qL_NHOMNGUOIDUNGBindingSource.DataMember = "QL_NHOMNGUOIDUNG";
            this.qL_NHOMNGUOIDUNGBindingSource.DataSource = this.dataSet1;
            // 
            // qL_NHOMNGUOIDUNGTableAdapter
            // 
            this.qL_NHOMNGUOIDUNGTableAdapter.ClearBeforeFill = true;
            // 
            // qL_NHOMNGUOIDUNGComboBox
            // 
            this.qL_NHOMNGUOIDUNGComboBox.DataSource = this.qL_NHOMNGUOIDUNGBindingSource;
            this.qL_NHOMNGUOIDUNGComboBox.DisplayMember = "TenNhom";
            this.qL_NHOMNGUOIDUNGComboBox.FormattingEnabled = true;
            this.qL_NHOMNGUOIDUNGComboBox.Location = new System.Drawing.Point(486, 12);
            this.qL_NHOMNGUOIDUNGComboBox.Name = "qL_NHOMNGUOIDUNGComboBox";
            this.qL_NHOMNGUOIDUNGComboBox.Size = new System.Drawing.Size(167, 21);
            this.qL_NHOMNGUOIDUNGComboBox.TabIndex = 3;
            this.qL_NHOMNGUOIDUNGComboBox.ValueMember = "MaNhom";
            this.qL_NHOMNGUOIDUNGComboBox.SelectedIndexChanged += new System.EventHandler(this.qL_NHOMNGUOIDUNGComboBox_SelectedIndexChanged);
            // 
            // btnVaoNhom
            // 
            this.btnVaoNhom.Location = new System.Drawing.Point(386, 129);
            this.btnVaoNhom.Name = "btnVaoNhom";
            this.btnVaoNhom.Size = new System.Drawing.Size(75, 23);
            this.btnVaoNhom.TabIndex = 4;
            this.btnVaoNhom.Text = ">>";
            this.btnVaoNhom.UseVisualStyleBackColor = true;
            this.btnVaoNhom.Click += new System.EventHandler(this.btnVaoNhom_Click);
            // 
            // btnRaNhom
            // 
            this.btnRaNhom.Location = new System.Drawing.Point(386, 185);
            this.btnRaNhom.Name = "btnRaNhom";
            this.btnRaNhom.Size = new System.Drawing.Size(75, 23);
            this.btnRaNhom.TabIndex = 5;
            this.btnRaNhom.Text = "<<";
            this.btnRaNhom.UseVisualStyleBackColor = true;
            this.btnRaNhom.Click += new System.EventHandler(this.btnRaNhom_Click);
            // 
            // Frm_themnguoidungvaonhom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 441);
            this.Controls.Add(this.btnRaNhom);
            this.Controls.Add(this.btnVaoNhom);
            this.Controls.Add(this.qL_NHOMNGUOIDUNGComboBox);
            this.Controls.Add(this.qL_NGUOIDUNGNHOMNGUOIDUNGDKDataGridView);
            this.Controls.Add(this.qL_NGUOIDUNGDataGridView);
            this.Name = "Frm_themnguoidungvaonhom";
            this.Text = "Frm_themnguoidungvaonhom";
            this.Load += new System.EventHandler(this.Frm_themnguoidungvaonhom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NGUOIDUNGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NGUOIDUNGDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NGUOIDUNGNHOMNGUOIDUNGDKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NGUOIDUNGNHOMNGUOIDUNGDKDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NHOMNGUOIDUNGBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource qL_NGUOIDUNGBindingSource;
        private DataSet1TableAdapters.QL_NGUOIDUNGTableAdapter qL_NGUOIDUNGTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView qL_NGUOIDUNGDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private DataSet1TableAdapters.QL_NGUOIDUNGNHOMNGUOIDUNGDKTableAdapter qL_NGUOIDUNGNHOMNGUOIDUNGDKTableAdapter;
        private System.Windows.Forms.BindingSource qL_NGUOIDUNGNHOMNGUOIDUNGDKBindingSource;
        private DataSet1TableAdapters.QL_NHOMNGUOIDUNGTableAdapter qL_NHOMNGUOIDUNGTableAdapter;
        private System.Windows.Forms.DataGridView qL_NGUOIDUNGNHOMNGUOIDUNGDKDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource qL_NHOMNGUOIDUNGBindingSource;
        private System.Windows.Forms.ComboBox qL_NHOMNGUOIDUNGComboBox;
        private System.Windows.Forms.Button btnVaoNhom;
        private System.Windows.Forms.Button btnRaNhom;
    }
}