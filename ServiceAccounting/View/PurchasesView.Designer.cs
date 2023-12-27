namespace ServiceAccounting.View
{
    partial class PurchasesView
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
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding1 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            pivotGridField2 = new DevExpress.XtraPivotGrid.PivotGridField();
            pivotGridField1 = new DevExpress.XtraPivotGrid.PivotGridField();
            pivotGridField3 = new DevExpress.XtraPivotGrid.PivotGridField();
            panelControl2 = new DevExpress.XtraEditors.PanelControl();
            gridLookUpEdit1 = new DevExpress.XtraEditors.GridLookUpEdit();
            gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pivotGridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl2).BeginInit();
            panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridLookUpEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridLookUpEdit1View).BeginInit();
            SuspendLayout();
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(pivotGridControl1);
            panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            panelControl1.Location = new System.Drawing.Point(0, 0);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new System.Drawing.Size(1037, 463);
            panelControl1.TabIndex = 0;
            // 
            // pivotGridControl1
            // 
            pivotGridControl1.DesignTimeDataObjectType = typeof(ApplicationContext.CompanyProductsGroup);
            pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] { pivotGridField2, pivotGridField1, pivotGridField3 });
            pivotGridControl1.Location = new System.Drawing.Point(2, 2);
            pivotGridControl1.Name = "pivotGridControl1";
            pivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized;
            pivotGridControl1.Size = new System.Drawing.Size(1033, 459);
            pivotGridControl1.TabIndex = 0;
            // 
            // pivotGridField2
            // 
            pivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            pivotGridField2.AreaIndex = 1;
            pivotGridField2.Name = "pivotGridField2";
            // 
            // pivotGridField1
            // 
            pivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            pivotGridField1.AreaIndex = 0;
            pivotGridField1.DataBinding = dataSourceColumnBinding1;
            pivotGridField1.Name = "pivotGridField1";
            // 
            // pivotGridField3
            // 
            pivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            pivotGridField3.AreaIndex = 2;
            pivotGridField3.Name = "pivotGridField3";
            // 
            // panelControl2
            // 
            panelControl2.Controls.Add(gridLookUpEdit1);
            panelControl2.Controls.Add(simpleButton2);
            panelControl2.Controls.Add(simpleButton1);
            panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelControl2.Location = new System.Drawing.Point(0, 463);
            panelControl2.Name = "panelControl2";
            panelControl2.Size = new System.Drawing.Size(1037, 153);
            panelControl2.TabIndex = 1;
            // 
            // gridLookUpEdit1
            // 
            gridLookUpEdit1.Location = new System.Drawing.Point(241, 44);
            gridLookUpEdit1.Name = "gridLookUpEdit1";
            gridLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            gridLookUpEdit1.Properties.DataSource = typeof(Model.Customer);
            gridLookUpEdit1.Properties.DisplayMember = "Name";
            gridLookUpEdit1.Properties.PopupView = gridLookUpEdit1View;
            gridLookUpEdit1.Properties.ValueMember = "Id";
            gridLookUpEdit1.Size = new System.Drawing.Size(100, 20);
            gridLookUpEdit1.TabIndex = 2;
            // 
            // gridLookUpEdit1View
            // 
            gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // simpleButton2
            // 
            simpleButton2.Location = new System.Drawing.Point(86, 41);
            simpleButton2.Name = "simpleButton2";
            simpleButton2.Size = new System.Drawing.Size(75, 23);
            simpleButton2.TabIndex = 1;
            simpleButton2.Text = "Отчет";
            simpleButton2.Click += simpleButton2_Click;
            // 
            // simpleButton1
            // 
            simpleButton1.Location = new System.Drawing.Point(5, 41);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new System.Drawing.Size(75, 23);
            simpleButton1.TabIndex = 0;
            simpleButton1.Text = "Добавить";
            simpleButton1.Click += simpleButton1_Click;
            // 
            // PurchasesView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(panelControl1);
            Controls.Add(panelControl2);
            Name = "PurchasesView";
            Size = new System.Drawing.Size(1037, 616);
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pivotGridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl2).EndInit();
            panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridLookUpEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridLookUpEdit1View).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField2;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField1;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField3;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
    }
}
