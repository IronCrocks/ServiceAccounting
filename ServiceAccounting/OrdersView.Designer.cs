namespace ServiceAccounting.View
{
    partial class OrdersView
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
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding2 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            pivotGridField2 = new DevExpress.XtraPivotGrid.PivotGridField();
            pivotGridField1 = new DevExpress.XtraPivotGrid.PivotGridField();
            pivotGridField3 = new DevExpress.XtraPivotGrid.PivotGridField();
            panelControl2 = new DevExpress.XtraEditors.PanelControl();
            btnReport = new DevExpress.XtraEditors.SimpleButton();
            btnAddOrder = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pivotGridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl2).BeginInit();
            panelControl2.SuspendLayout();
            SuspendLayout();
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(pivotGridControl1);
            panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            panelControl1.Location = new System.Drawing.Point(0, 0);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new System.Drawing.Size(1037, 580);
            panelControl1.TabIndex = 0;
            // 
            // pivotGridControl1
            // 
            pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] { pivotGridField2, pivotGridField1, pivotGridField3 });
            pivotGridControl1.Location = new System.Drawing.Point(2, 2);
            pivotGridControl1.Name = "pivotGridControl1";
            pivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized;
            pivotGridControl1.Size = new System.Drawing.Size(1033, 576);
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
            pivotGridField1.DataBinding = dataSourceColumnBinding2;
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
            panelControl2.Controls.Add(btnReport);
            panelControl2.Controls.Add(btnAddOrder);
            panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelControl2.Location = new System.Drawing.Point(0, 580);
            panelControl2.Name = "panelControl2";
            panelControl2.Size = new System.Drawing.Size(1037, 36);
            panelControl2.TabIndex = 1;
            // 
            // btnReport
            // 
            btnReport.Location = new System.Drawing.Point(95, 6);
            btnReport.Name = "btnReport";
            btnReport.Size = new System.Drawing.Size(75, 23);
            btnReport.TabIndex = 1;
            btnReport.Text = "Отчет";
            btnReport.Click += BtnReport_Click;
            // 
            // btnAddOrder
            // 
            btnAddOrder.Location = new System.Drawing.Point(14, 6);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new System.Drawing.Size(75, 23);
            btnAddOrder.TabIndex = 0;
            btnAddOrder.Text = "Добавить";
            btnAddOrder.Click += BtnAddOrder_Click;
            // 
            // OrdersView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(panelControl1);
            Controls.Add(panelControl2);
            Name = "OrdersView";
            Size = new System.Drawing.Size(1037, 616);
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pivotGridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl2).EndInit();
            panelControl2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnAddOrder;
        private DevExpress.XtraEditors.SimpleButton btnReport;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField2;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField1;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField3;
    }
}
