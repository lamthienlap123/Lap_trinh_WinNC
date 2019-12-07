namespace giaodien_Windows
{
    partial class Frm_nhomnguoidung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_nhomnguoidung));
            System.Windows.Forms.Label maNhomLabel;
            System.Windows.Forms.Label tenNhomLabel;
            System.Windows.Forms.Label ghiChuLabel;
            this.dataSet1 = new giaodien_Windows.DataSet1();
            this.qL_NHOMNGUOIDUNGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_NHOMNGUOIDUNGTableAdapter = new giaodien_Windows.DataSet1TableAdapters.QL_NHOMNGUOIDUNGTableAdapter();
            this.tableAdapterManager = new giaodien_Windows.DataSet1TableAdapters.TableAdapterManager();
            this.qL_NHOMNGUOIDUNGBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.qL_NHOMNGUOIDUNGBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.qL_NHOMNGUOIDUNGDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNhomTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tenNhomTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ghiChuTextEdit = new DevExpress.XtraEditors.TextEdit();
            maNhomLabel = new System.Windows.Forms.Label();
            tenNhomLabel = new System.Windows.Forms.Label();
            ghiChuLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NHOMNGUOIDUNGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NHOMNGUOIDUNGBindingNavigator)).BeginInit();
            this.qL_NHOMNGUOIDUNGBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NHOMNGUOIDUNGDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maNhomTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenNhomTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghiChuTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.QL_NGUOIDUNGTableAdapter = null;
            this.tableAdapterManager.QL_NHOMNGUOIDUNGTableAdapter = this.qL_NHOMNGUOIDUNGTableAdapter;
            this.tableAdapterManager.UpdateOrder = giaodien_Windows.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // qL_NHOMNGUOIDUNGBindingNavigator
            // 
            this.qL_NHOMNGUOIDUNGBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.qL_NHOMNGUOIDUNGBindingNavigator.BindingSource = this.qL_NHOMNGUOIDUNGBindingSource;
            this.qL_NHOMNGUOIDUNGBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.qL_NHOMNGUOIDUNGBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.qL_NHOMNGUOIDUNGBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.qL_NHOMNGUOIDUNGBindingNavigatorSaveItem});
            this.qL_NHOMNGUOIDUNGBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.qL_NHOMNGUOIDUNGBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.qL_NHOMNGUOIDUNGBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.qL_NHOMNGUOIDUNGBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.qL_NHOMNGUOIDUNGBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.qL_NHOMNGUOIDUNGBindingNavigator.Name = "qL_NHOMNGUOIDUNGBindingNavigator";
            this.qL_NHOMNGUOIDUNGBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.qL_NHOMNGUOIDUNGBindingNavigator.Size = new System.Drawing.Size(494, 25);
            this.qL_NHOMNGUOIDUNGBindingNavigator.TabIndex = 0;
            this.qL_NHOMNGUOIDUNGBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // qL_NHOMNGUOIDUNGBindingNavigatorSaveItem
            // 
            this.qL_NHOMNGUOIDUNGBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.qL_NHOMNGUOIDUNGBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("qL_NHOMNGUOIDUNGBindingNavigatorSaveItem.Image")));
            this.qL_NHOMNGUOIDUNGBindingNavigatorSaveItem.Name = "qL_NHOMNGUOIDUNGBindingNavigatorSaveItem";
            this.qL_NHOMNGUOIDUNGBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.qL_NHOMNGUOIDUNGBindingNavigatorSaveItem.Text = "Save Data";
            this.qL_NHOMNGUOIDUNGBindingNavigatorSaveItem.Click += new System.EventHandler(this.qL_NHOMNGUOIDUNGBindingNavigatorSaveItem_Click);
            // 
            // qL_NHOMNGUOIDUNGDataGridView
            // 
            this.qL_NHOMNGUOIDUNGDataGridView.AutoGenerateColumns = false;
            this.qL_NHOMNGUOIDUNGDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.qL_NHOMNGUOIDUNGDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.qL_NHOMNGUOIDUNGDataGridView.DataSource = this.qL_NHOMNGUOIDUNGBindingSource;
            this.qL_NHOMNGUOIDUNGDataGridView.Location = new System.Drawing.Point(12, 144);
            this.qL_NHOMNGUOIDUNGDataGridView.Name = "qL_NHOMNGUOIDUNGDataGridView";
            this.qL_NHOMNGUOIDUNGDataGridView.Size = new System.Drawing.Size(344, 233);
            this.qL_NHOMNGUOIDUNGDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaNhom";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaNhom";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenNhom";
            this.dataGridViewTextBoxColumn2.HeaderText = "TenNhom";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "GhiChu";
            this.dataGridViewTextBoxColumn3.HeaderText = "GhiChu";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // maNhomLabel
            // 
            maNhomLabel.AutoSize = true;
            maNhomLabel.Location = new System.Drawing.Point(33, 51);
            maNhomLabel.Name = "maNhomLabel";
            maNhomLabel.Size = new System.Drawing.Size(56, 13);
            maNhomLabel.TabIndex = 2;
            maNhomLabel.Text = "Ma Nhom:";
            // 
            // maNhomTextEdit
            // 
            this.maNhomTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.qL_NHOMNGUOIDUNGBindingSource, "MaNhom", true));
            this.maNhomTextEdit.Location = new System.Drawing.Point(99, 48);
            this.maNhomTextEdit.Name = "maNhomTextEdit";
            this.maNhomTextEdit.Size = new System.Drawing.Size(100, 20);
            this.maNhomTextEdit.TabIndex = 3;
            // 
            // tenNhomLabel
            // 
            tenNhomLabel.AutoSize = true;
            tenNhomLabel.Location = new System.Drawing.Point(33, 77);
            tenNhomLabel.Name = "tenNhomLabel";
            tenNhomLabel.Size = new System.Drawing.Size(60, 13);
            tenNhomLabel.TabIndex = 4;
            tenNhomLabel.Text = "Ten Nhom:";
            // 
            // tenNhomTextEdit
            // 
            this.tenNhomTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.qL_NHOMNGUOIDUNGBindingSource, "TenNhom", true));
            this.tenNhomTextEdit.Location = new System.Drawing.Point(99, 74);
            this.tenNhomTextEdit.Name = "tenNhomTextEdit";
            this.tenNhomTextEdit.Size = new System.Drawing.Size(100, 20);
            this.tenNhomTextEdit.TabIndex = 5;
            // 
            // ghiChuLabel
            // 
            ghiChuLabel.AutoSize = true;
            ghiChuLabel.Location = new System.Drawing.Point(33, 103);
            ghiChuLabel.Name = "ghiChuLabel";
            ghiChuLabel.Size = new System.Drawing.Size(48, 13);
            ghiChuLabel.TabIndex = 6;
            ghiChuLabel.Text = "Ghi Chu:";
            // 
            // ghiChuTextEdit
            // 
            this.ghiChuTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.qL_NHOMNGUOIDUNGBindingSource, "GhiChu", true));
            this.ghiChuTextEdit.Location = new System.Drawing.Point(99, 100);
            this.ghiChuTextEdit.Name = "ghiChuTextEdit";
            this.ghiChuTextEdit.Size = new System.Drawing.Size(100, 20);
            this.ghiChuTextEdit.TabIndex = 7;
            // 
            // Frm_nhomnguoidung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 452);
            this.Controls.Add(maNhomLabel);
            this.Controls.Add(this.maNhomTextEdit);
            this.Controls.Add(tenNhomLabel);
            this.Controls.Add(this.tenNhomTextEdit);
            this.Controls.Add(ghiChuLabel);
            this.Controls.Add(this.ghiChuTextEdit);
            this.Controls.Add(this.qL_NHOMNGUOIDUNGDataGridView);
            this.Controls.Add(this.qL_NHOMNGUOIDUNGBindingNavigator);
            this.Name = "Frm_nhomnguoidung";
            this.Text = "Frm_nhomnguoidung";
            this.Load += new System.EventHandler(this.Frm_nhomnguoidung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NHOMNGUOIDUNGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NHOMNGUOIDUNGBindingNavigator)).EndInit();
            this.qL_NHOMNGUOIDUNGBindingNavigator.ResumeLayout(false);
            this.qL_NHOMNGUOIDUNGBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NHOMNGUOIDUNGDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maNhomTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenNhomTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghiChuTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource qL_NHOMNGUOIDUNGBindingSource;
        private DataSet1TableAdapters.QL_NHOMNGUOIDUNGTableAdapter qL_NHOMNGUOIDUNGTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator qL_NHOMNGUOIDUNGBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton qL_NHOMNGUOIDUNGBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView qL_NHOMNGUOIDUNGDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DevExpress.XtraEditors.TextEdit maNhomTextEdit;
        private DevExpress.XtraEditors.TextEdit tenNhomTextEdit;
        private DevExpress.XtraEditors.TextEdit ghiChuTextEdit;
    }
}