namespace ServiceAccounting.View
{
    partial class CustomersView
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
            panelControl2 = new DevExpress.XtraEditors.PanelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            textEdit2 = new DevExpress.XtraEditors.TextEdit();
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            btnAddCustomer = new DevExpress.XtraEditors.SimpleButton();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)panelControl2).BeginInit();
            panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // panelControl2
            // 
            panelControl2.Controls.Add(labelControl2);
            panelControl2.Controls.Add(labelControl1);
            panelControl2.Controls.Add(textEdit2);
            panelControl2.Controls.Add(textEdit1);
            panelControl2.Controls.Add(btnAddCustomer);
            panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelControl2.Location = new System.Drawing.Point(0, 212);
            panelControl2.Name = "panelControl2";
            panelControl2.Size = new System.Drawing.Size(470, 100);
            panelControl2.TabIndex = 1;
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new System.Drawing.Point(200, 52);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(57, 19);
            labelControl2.TabIndex = 4;
            labelControl2.Text = "Возраст";
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new System.Drawing.Point(216, 9);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(29, 19);
            labelControl1.TabIndex = 3;
            labelControl1.Text = "Имя";
            // 
            // textEdit2
            // 
            textEdit2.Location = new System.Drawing.Point(263, 51);
            textEdit2.Name = "textEdit2";
            textEdit2.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            textEdit2.Properties.MaskSettings.Set("mask", "f");
            textEdit2.Size = new System.Drawing.Size(100, 20);
            textEdit2.TabIndex = 2;
            // 
            // textEdit1
            // 
            textEdit1.Location = new System.Drawing.Point(264, 11);
            textEdit1.Name = "textEdit1";
            textEdit1.Size = new System.Drawing.Size(100, 20);
            textEdit1.TabIndex = 1;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Location = new System.Drawing.Point(23, 24);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new System.Drawing.Size(75, 23);
            btnAddCustomer.TabIndex = 0;
            btnAddCustomer.Text = "Добавить";
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(gridControl1);
            panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            panelControl1.Location = new System.Drawing.Point(0, 0);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new System.Drawing.Size(470, 212);
            panelControl1.TabIndex = 2;
            // 
            // gridControl1
            // 
            gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridControl1.Location = new System.Drawing.Point(2, 2);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new System.Drawing.Size(466, 208);
            gridControl1.TabIndex = 0;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            // 
            // CustomersView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(panelControl1);
            Controls.Add(panelControl2);
            Name = "CustomersView";
            Size = new System.Drawing.Size(470, 312);
            ((System.ComponentModel.ISupportInitialize)panelControl2).EndInit();
            panelControl2.ResumeLayout(false);
            panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnAddCustomer;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}
