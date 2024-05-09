namespace ServiceAccounting.View
{
    partial class ProductsView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsView));
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            colId = new DevExpress.XtraGrid.Columns.GridColumn();
            colName = new DevExpress.XtraGrid.Columns.GridColumn();
            colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            btnRemove = new DevExpress.XtraEditors.SimpleButton();
            btnAdd = new DevExpress.XtraEditors.SimpleButton();
            panelControl2 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl2).BeginInit();
            panelControl2.SuspendLayout();
            SuspendLayout();
            // 
            // gridControl1
            // 
            gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridControl1.Location = new System.Drawing.Point(2, 2);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new System.Drawing.Size(442, 240);
            gridControl1.TabIndex = 0;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colId, colName, colDescription, colPrice });
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.RowUpdated += gridView1_RowUpdated;
            // 
            // colId
            // 
            colId.FieldName = "Id";
            colId.Name = "colId";
            colId.Visible = true;
            colId.VisibleIndex = 0;
            // 
            // colName
            // 
            colName.FieldName = "Name";
            colName.Name = "colName";
            colName.Visible = true;
            colName.VisibleIndex = 1;
            // 
            // colDescription
            // 
            colDescription.FieldName = "Description";
            colDescription.Name = "colDescription";
            colDescription.Visible = true;
            colDescription.VisibleIndex = 2;
            // 
            // colPrice
            // 
            colPrice.FieldName = "Price";
            colPrice.Name = "colPrice";
            colPrice.Visible = true;
            colPrice.VisibleIndex = 3;
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(btnRemove);
            panelControl1.Controls.Add(btnAdd);
            panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            panelControl1.Location = new System.Drawing.Point(0, 0);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new System.Drawing.Size(446, 19);
            panelControl1.TabIndex = 1;
            // 
            // btnRemove
            // 
            btnRemove.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnRemove.ImageOptions.Image");
            btnRemove.Location = new System.Drawing.Point(20, 0);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new System.Drawing.Size(21, 20);
            btnRemove.TabIndex = 1;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnAdd
            // 
            btnAdd.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnAdd.ImageOptions.Image");
            btnAdd.Location = new System.Drawing.Point(0, 0);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(21, 20);
            btnAdd.TabIndex = 0;
            btnAdd.Click += btnAdd_Click;
            // 
            // panelControl2
            // 
            panelControl2.Controls.Add(gridControl1);
            panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            panelControl2.Location = new System.Drawing.Point(0, 19);
            panelControl2.Name = "panelControl2";
            panelControl2.Size = new System.Drawing.Size(446, 244);
            panelControl2.TabIndex = 2;
            // 
            // ProductsView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(panelControl2);
            Controls.Add(panelControl1);
            Name = "ProductsView";
            Size = new System.Drawing.Size(446, 263);
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelControl2).EndInit();
            panelControl2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnRemove;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
    }
}
