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
            components = new System.ComponentModel.Container();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding6 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding7 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding8 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding9 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding10 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            orderDTOBindingSource = new System.Windows.Forms.BindingSource(components);
            pivotGridField3 = new DevExpress.XtraPivotGrid.PivotGridField();
            pivotGridField1 = new DevExpress.XtraPivotGrid.PivotGridField();
            pivotGridField2 = new DevExpress.XtraPivotGrid.PivotGridField();
            pivotGridField4 = new DevExpress.XtraPivotGrid.PivotGridField();
            pivotGridField5 = new DevExpress.XtraPivotGrid.PivotGridField();
            panelControl2 = new DevExpress.XtraEditors.PanelControl();
            btnReport = new DevExpress.XtraEditors.SimpleButton();
            btnAddOrder = new DevExpress.XtraEditors.SimpleButton();
            DetailsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pivotGridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderDTOBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl2).BeginInit();
            panelControl2.SuspendLayout();
            SuspendLayout();
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(pivotGridControl1);
            panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            panelControl1.Location = new System.Drawing.Point(0, 0);
            panelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new System.Drawing.Size(1185, 738);
            panelControl1.TabIndex = 0;
            // 
            // pivotGridControl1
            // 
            pivotGridControl1.DataSource = orderDTOBindingSource;
            pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] { pivotGridField3, pivotGridField1, pivotGridField2, pivotGridField4, pivotGridField5 });
            pivotGridControl1.Location = new System.Drawing.Point(2, 2);
            pivotGridControl1.Name = "pivotGridControl1";
            pivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized;
            pivotGridControl1.Size = new System.Drawing.Size(1181, 734);
            pivotGridControl1.TabIndex = 0;
            // 
            // orderDTOBindingSource
            // 
            orderDTOBindingSource.DataSource = typeof(DTO.OrderDTO);
            // 
            // pivotGridField3
            // 
            pivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            pivotGridField3.AreaIndex = 0;
            dataSourceColumnBinding6.ColumnName = "CustomerName";
            pivotGridField3.DataBinding = dataSourceColumnBinding6;
            pivotGridField3.Name = "pivotGridField3";
            // 
            // pivotGridField1
            // 
            pivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            pivotGridField1.AreaIndex = 0;
            dataSourceColumnBinding7.ColumnName = "Count";
            pivotGridField1.DataBinding = dataSourceColumnBinding7;
            pivotGridField1.EmptyCellText = "0";
            pivotGridField1.Name = "pivotGridField1";
            // 
            // pivotGridField2
            // 
            pivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            pivotGridField2.AreaIndex = 0;
            dataSourceColumnBinding8.ColumnName = "ProductName";
            pivotGridField2.DataBinding = dataSourceColumnBinding8;
            pivotGridField2.Name = "pivotGridField2";
            // 
            // pivotGridField4
            // 
            pivotGridField4.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            pivotGridField4.AreaIndex = 1;
            dataSourceColumnBinding9.ColumnName = "Price";
            pivotGridField4.DataBinding = dataSourceColumnBinding9;
            pivotGridField4.EmptyCellText = "0";
            pivotGridField4.Name = "pivotGridField4";
            pivotGridField4.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Min;
            // 
            // pivotGridField5
            // 
            pivotGridField5.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            pivotGridField5.AreaIndex = 2;
            dataSourceColumnBinding10.ColumnName = "TotalPrice";
            pivotGridField5.DataBinding = dataSourceColumnBinding10;
            pivotGridField5.EmptyCellText = "0";
            pivotGridField5.Name = "pivotGridField5";
            // 
            // panelControl2
            // 
            panelControl2.Controls.Add(DetailsLabel);
            panelControl2.Controls.Add(btnReport);
            panelControl2.Controls.Add(btnAddOrder);
            panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelControl2.Location = new System.Drawing.Point(0, 738);
            panelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelControl2.Name = "panelControl2";
            panelControl2.Size = new System.Drawing.Size(1185, 83);
            panelControl2.TabIndex = 1;
            // 
            // btnReport
            // 
            btnReport.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnReport.Location = new System.Drawing.Point(109, 43);
            btnReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnReport.Name = "btnReport";
            btnReport.Size = new System.Drawing.Size(86, 31);
            btnReport.TabIndex = 1;
            btnReport.Text = "Отчет";
            btnReport.Click += BtnReport_Click;
            // 
            // btnAddOrder
            // 
            btnAddOrder.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnAddOrder.Location = new System.Drawing.Point(16, 43);
            btnAddOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new System.Drawing.Size(86, 31);
            btnAddOrder.TabIndex = 0;
            btnAddOrder.Text = "Добавить";
            btnAddOrder.Click += BtnAddOrder_Click;
            // 
            // DetailsLabel
            // 
            DetailsLabel.AutoSize = true;
            DetailsLabel.Location = new System.Drawing.Point(16, 11);
            DetailsLabel.Name = "DetailsLabel";
            DetailsLabel.Size = new System.Drawing.Size(607, 16);
            DetailsLabel.TabIndex = 2;
            DetailsLabel.Text = "Показаны данные за последний месяц. Для просмотра данных за другой период сформируйте отчёт.";
            // 
            // OrdersView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(panelControl1);
            Controls.Add(panelControl2);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "OrdersView";
            Size = new System.Drawing.Size(1185, 821);
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pivotGridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderDTOBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl2).EndInit();
            panelControl2.ResumeLayout(false);
            panelControl2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnAddOrder;
        private DevExpress.XtraEditors.SimpleButton btnReport;
        private System.Windows.Forms.BindingSource orderDTOBindingSource;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField3;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField1;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField2;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField4;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField5;
        private System.Windows.Forms.Label DetailsLabel;
    }
}
