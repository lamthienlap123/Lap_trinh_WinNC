namespace giaodien_Windows
{
    partial class Frm_nguoidung
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
            System.Windows.Forms.Label tenDangNhapLabel;
            System.Windows.Forms.Label matKhauLabel;
            System.Windows.Forms.Label hoatDongLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_nguoidung));
            this.qL_NGUOIDUNGBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.qL_NGUOIDUNGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new giaodien_Windows.DataSet1();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.qL_NGUOIDUNGBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.qL_NGUOIDUNGDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tenDangNhapTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.matKhauTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.hoatDongCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.qL_NGUOIDUNGTableAdapter = new giaodien_Windows.DataSet1TableAdapters.QL_NGUOIDUNGTableAdapter();
            this.tableAdapterManager = new giaodien_Windows.DataSet1TableAdapters.TableAdapterManager();
            tenDangNhapLabel = new System.Windows.Forms.Label();
            matKhauLabel = new System.Windows.Forms.Label();
            hoatDongLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NGUOIDUNGBindingNavigator)).BeginInit();
            this.qL_NGUOIDUNGBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NGUOIDUNGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NGUOIDUNGDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenDangNhapTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matKhauTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoatDongCheckEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tenDangNhapLabel
            // 
            tenDangNhapLabel.AutoSize = true;
            tenDangNhapLabel.Location = new System.Drawing.Point(12, 41);
            tenDangNhapLabel.Name = "tenDangNhapLabel";
            tenDangNhapLabel.Size = new System.Drawing.Size(87, 13);
            tenDangNhapLabel.TabIndex = 2;
            tenDangNhapLabel.Text = "Ten Dang Nhap:";
            // 
            // matKhauLabel
            // 
            matKhauLabel.AutoSize = true;
            matKhauLabel.Location = new System.Drawing.Point(12, 67);
            matKhauLabel.Name = "matKhauLabel";
            matKhauLabel.Size = new System.Drawing.Size(56, 13);
            matKhauLabel.TabIndex = 4;
            matKhauLabel.Text = "Mat Khau:";
            // 
            // hoatDongLabel
            // 
            hoatDongLabel.AutoSize = true;
            hoatDongLabel.Location = new System.Drawing.Point(12, 93);
            hoatDongLabel.Name = "hoatDongLabel";
            hoatDongLabel.Size = new System.Drawing.Size(62, 13);
            hoatDongLabel.TabIndex = 6;
            hoatDongLabel.Text = "Hoat Dong:";
            // 
            // qL_NGUOIDUNGBindingNavigator
            // 
            this.qL_NGUOIDUNGBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.qL_NGUOIDUNGBindingNavigator.BindingSource = this.qL_NGUOIDUNGBindingSource;
            this.qL_NGUOIDUNGBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.qL_NGUOIDUNGBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.qL_NGUOIDUNGBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.qL_NGUOIDUNGBindingNavigatorSaveItem});
            this.qL_NGUOIDUNGBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.qL_NGUOIDUNGBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.qL_NGUOIDUNGBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.qL_NGUOIDUNGBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.qL_NGUOIDUNGBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.qL_NGUOIDUNGBindingNavigator.Name = "qL_NGUOIDUNGBindingNavigator";
            this.qL_NGUOIDUNGBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.qL_NGUOIDUNGBindingNavigator.Size = new System.Drawing.Size(432, 25);
            this.qL_NGUOIDUNGBindingNavigator.TabIndex = 0;
            this.qL_NGUOIDUNGBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // qL_NGUOIDUNGBindingSource
            // 
            this.qL_NGUOIDUNGBindingSource.DataMember = "QL_NGUOIDUNG";
            this.qL_NGUOIDUNGBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // qL_NGUOIDUNGBindingNavigatorSaveItem
            // 
            this.qL_NGUOIDUNGBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.qL_NGUOIDUNGBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("qL_NGUOIDUNGBindingNavigatorSaveItem.Image")));
            this.qL_NGUOIDUNGBindingNavigatorSaveItem.Name = "qL_NGUOIDUNGBindingNavigatorSaveItem";
            this.qL_NGUOIDUNGBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.qL_NGUOIDUNGBindingNavigatorSaveItem.Text = "Save Data";
            this.qL_NGUOIDUNGBindingNavigatorSaveItem.Click += new System.EventHandler(this.qL_NGUOIDUNGBindingNavigatorSaveItem_Click);
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
            this.qL_NGUOIDUNGDataGridView.Location = new System.Drawing.Point(0, 134);
            this.qL_NGUOIDUNGDataGridView.Name = "qL_NGUOIDUNGDataGridView";
            this.qL_NGUOIDUNGDataGridView.Size = new System.Drawing.Size(346, 236);
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
            // tenDangNhapTextEdit
            // 
            this.tenDangNhapTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.qL_NGUOIDUNGBindingSource, "TenDangNhap", true));
            this.tenDangNhapTextEdit.Location = new System.Drawing.Point(105, 38);
            this.tenDangNhapTextEdit.Name = "tenDangNhapTextEdit";
            this.tenDangNhapTextEdit.Size = new System.Drawing.Size(100, 20);
            this.tenDangNhapTextEdit.TabIndex = 3;
            // 
            // matKhauTextEdit
            // 
            this.matKhauTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.qL_NGUOIDUNGBindingSource, "MatKhau", true));
            this.matKhauTextEdit.Location = new System.Drawing.Point(105, 64);
            this.matKhauTextEdit.Name = "matKhauTextEdit";
            this.matKhauTextEdit.Size = new System.Drawing.Size(100, 20);
            this.matKhauTextEdit.TabIndex = 5;
            // 
            // hoatDongCheckEdit
            // 
            this.hoatDongCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.qL_NGUOIDUNGBindingSource, "HoatDong", true));
            this.hoatDongCheckEdit.Location = new System.Drawing.Point(105, 90);
            this.hoatDongCheckEdit.Name = "hoatDongCheckEdit";
            this.hoatDongCheckEdit.Properties.Caption = "";
            this.hoatDongCheckEdit.Size = new System.Drawing.Size(100, 19);
            this.hoatDongCheckEdit.TabIndex = 7;
            // 
            // qL_NGUOIDUNGTableAdapter
            // 
            this.qL_NGUOIDUNGTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DM_MANHINHTableAdapter = null;
            this.tableAdapterManager.QL_NGUOIDUNGNHOMNGUOIDUNGDKTableAdapter = null;
            this.tableAdapterManager.QL_NGUOIDUNGNHOMNGUOIDUNGTableAdapter = null;
            this.tableAdapterManager.QL_NGUOIDUNGTableAdapter = this.qL_NGUOIDUNGTableAdapter;
            this.tableAdapterManager.QL_NHOMNGUOIDUNGTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = giaodien_Windows.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Frm_nguoidung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 447);
            this.Controls.Add(tenDangNhapLabel);
            this.Controls.Add(this.tenDangNhapTextEdit);
            this.Controls.Add(matKhauLabel);
            this.Controls.Add(this.matKhauTextEdit);
            this.Controls.Add(hoatDongLabel);
            this.Controls.Add(this.hoatDongCheckEdit);
            this.Controls.Add(this.qL_NGUOIDUNGDataGridView);
            this.Controls.Add(this.qL_NGUOIDUNGBindingNavigator);
            this.Name = "Frm_nguoidung";
            this.Text = "Frm_nguoidung";
            this.Load += new System.EventHandler(this.Frm_nguoidung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qL_NGUOIDUNGBindingNavigator)).EndInit();
            this.qL_NGUOIDUNGBindingNavigator.ResumeLayout(false);
            this.qL_NGUOIDUNGBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NGUOIDUNGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NGUOIDUNGDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenDangNhapTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matKhauTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoatDongCheckEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource qL_NGUOIDUNGBindingSource;
        private DataSet1TableAdapters.QL_NGUOIDUNGTableAdapter qL_NGUOIDUNGTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator qL_NGUOIDUNGBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton qL_NGUOIDUNGBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView qL_NGUOIDUNGDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private DevExpress.XtraEditors.TextEdit tenDangNhapTextEdit;
        private DevExpress.XtraEditors.TextEdit matKhauTextEdit;
        private DevExpress.XtraEditors.CheckEdit hoatDongCheckEdit;
    }
}