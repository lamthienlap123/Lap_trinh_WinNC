namespace giaodien_Windows
{
    partial class Frm_manhinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_manhinh));
            System.Windows.Forms.Label maManHinhLabel;
            System.Windows.Forms.Label tenManHinhLabel;
            this.dataSet1 = new giaodien_Windows.DataSet1();
            this.dM_MANHINHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dM_MANHINHTableAdapter = new giaodien_Windows.DataSet1TableAdapters.DM_MANHINHTableAdapter();
            this.tableAdapterManager = new giaodien_Windows.DataSet1TableAdapters.TableAdapterManager();
            this.dM_MANHINHBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.dM_MANHINHBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dM_MANHINHDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maManHinhTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tenManHinhTextEdit = new DevExpress.XtraEditors.TextEdit();
            maManHinhLabel = new System.Windows.Forms.Label();
            tenManHinhLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dM_MANHINHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dM_MANHINHBindingNavigator)).BeginInit();
            this.dM_MANHINHBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dM_MANHINHDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maManHinhTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenManHinhTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dM_MANHINHBindingSource
            // 
            this.dM_MANHINHBindingSource.DataMember = "DM_MANHINH";
            this.dM_MANHINHBindingSource.DataSource = this.dataSet1;
            // 
            // dM_MANHINHTableAdapter
            // 
            this.dM_MANHINHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DM_MANHINHTableAdapter = this.dM_MANHINHTableAdapter;
            this.tableAdapterManager.QL_NGUOIDUNGTableAdapter = null;
            this.tableAdapterManager.QL_NHOMNGUOIDUNGTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = giaodien_Windows.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dM_MANHINHBindingNavigator
            // 
            this.dM_MANHINHBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dM_MANHINHBindingNavigator.BindingSource = this.dM_MANHINHBindingSource;
            this.dM_MANHINHBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dM_MANHINHBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dM_MANHINHBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.dM_MANHINHBindingNavigatorSaveItem});
            this.dM_MANHINHBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dM_MANHINHBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dM_MANHINHBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dM_MANHINHBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dM_MANHINHBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dM_MANHINHBindingNavigator.Name = "dM_MANHINHBindingNavigator";
            this.dM_MANHINHBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dM_MANHINHBindingNavigator.Size = new System.Drawing.Size(334, 25);
            this.dM_MANHINHBindingNavigator.TabIndex = 0;
            this.dM_MANHINHBindingNavigator.Text = "bindingNavigator1";
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
            // dM_MANHINHBindingNavigatorSaveItem
            // 
            this.dM_MANHINHBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dM_MANHINHBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dM_MANHINHBindingNavigatorSaveItem.Image")));
            this.dM_MANHINHBindingNavigatorSaveItem.Name = "dM_MANHINHBindingNavigatorSaveItem";
            this.dM_MANHINHBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.dM_MANHINHBindingNavigatorSaveItem.Text = "Save Data";
            this.dM_MANHINHBindingNavigatorSaveItem.Click += new System.EventHandler(this.dM_MANHINHBindingNavigatorSaveItem_Click);
            // 
            // dM_MANHINHDataGridView
            // 
            this.dM_MANHINHDataGridView.AutoGenerateColumns = false;
            this.dM_MANHINHDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dM_MANHINHDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dM_MANHINHDataGridView.DataSource = this.dM_MANHINHBindingSource;
            this.dM_MANHINHDataGridView.Location = new System.Drawing.Point(15, 123);
            this.dM_MANHINHDataGridView.Name = "dM_MANHINHDataGridView";
            this.dM_MANHINHDataGridView.Size = new System.Drawing.Size(243, 220);
            this.dM_MANHINHDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaManHinh";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaManHinh";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenManHinh";
            this.dataGridViewTextBoxColumn2.HeaderText = "TenManHinh";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // maManHinhLabel
            // 
            maManHinhLabel.AutoSize = true;
            maManHinhLabel.Location = new System.Drawing.Point(12, 48);
            maManHinhLabel.Name = "maManHinhLabel";
            maManHinhLabel.Size = new System.Drawing.Size(74, 13);
            maManHinhLabel.TabIndex = 2;
            maManHinhLabel.Text = "Ma Man Hinh:";
            // 
            // maManHinhTextEdit
            // 
            this.maManHinhTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dM_MANHINHBindingSource, "MaManHinh", true));
            this.maManHinhTextEdit.Location = new System.Drawing.Point(96, 45);
            this.maManHinhTextEdit.Name = "maManHinhTextEdit";
            this.maManHinhTextEdit.Size = new System.Drawing.Size(100, 20);
            this.maManHinhTextEdit.TabIndex = 3;
            // 
            // tenManHinhLabel
            // 
            tenManHinhLabel.AutoSize = true;
            tenManHinhLabel.Location = new System.Drawing.Point(12, 74);
            tenManHinhLabel.Name = "tenManHinhLabel";
            tenManHinhLabel.Size = new System.Drawing.Size(78, 13);
            tenManHinhLabel.TabIndex = 4;
            tenManHinhLabel.Text = "Ten Man Hinh:";
            // 
            // tenManHinhTextEdit
            // 
            this.tenManHinhTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dM_MANHINHBindingSource, "TenManHinh", true));
            this.tenManHinhTextEdit.Location = new System.Drawing.Point(96, 71);
            this.tenManHinhTextEdit.Name = "tenManHinhTextEdit";
            this.tenManHinhTextEdit.Size = new System.Drawing.Size(100, 20);
            this.tenManHinhTextEdit.TabIndex = 5;
            // 
            // Frm_manhinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 425);
            this.Controls.Add(maManHinhLabel);
            this.Controls.Add(this.maManHinhTextEdit);
            this.Controls.Add(tenManHinhLabel);
            this.Controls.Add(this.tenManHinhTextEdit);
            this.Controls.Add(this.dM_MANHINHDataGridView);
            this.Controls.Add(this.dM_MANHINHBindingNavigator);
            this.Name = "Frm_manhinh";
            this.Text = "Frm_manhinh";
            this.Load += new System.EventHandler(this.Frm_manhinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dM_MANHINHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dM_MANHINHBindingNavigator)).EndInit();
            this.dM_MANHINHBindingNavigator.ResumeLayout(false);
            this.dM_MANHINHBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dM_MANHINHDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maManHinhTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenManHinhTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dM_MANHINHBindingSource;
        private DataSet1TableAdapters.DM_MANHINHTableAdapter dM_MANHINHTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator dM_MANHINHBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton dM_MANHINHBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView dM_MANHINHDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DevExpress.XtraEditors.TextEdit maManHinhTextEdit;
        private DevExpress.XtraEditors.TextEdit tenManHinhTextEdit;
    }
}