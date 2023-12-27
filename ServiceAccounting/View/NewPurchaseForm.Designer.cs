﻿namespace ServiceAccounting.View
{
    partial class NewPurchaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPurchaseForm));
            panelControl2 = new DevExpress.XtraEditors.PanelControl();
            simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            gridLookUpEdit1 = new DevExpress.XtraEditors.GridLookUpEdit();
            gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            panelControl3 = new DevExpress.XtraEditors.PanelControl();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            gridControl2 = new DevExpress.XtraGrid.GridControl();
            gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)panelControl2).BeginInit();
            panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridLookUpEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridLookUpEdit1View).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl3).BeginInit();
            panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // panelControl2
            // 
            panelControl2.Controls.Add(simpleButton2);
            panelControl2.Controls.Add(simpleButton1);
            panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelControl2.Location = new System.Drawing.Point(0, 439);
            panelControl2.Name = "panelControl2";
            panelControl2.Size = new System.Drawing.Size(810, 58);
            panelControl2.TabIndex = 1;
            // 
            // simpleButton2
            // 
            simpleButton2.Location = new System.Drawing.Point(478, 23);
            simpleButton2.Name = "simpleButton2";
            simpleButton2.Size = new System.Drawing.Size(75, 23);
            simpleButton2.TabIndex = 3;
            simpleButton2.Text = "Отмена";
            simpleButton2.Click += simpleButton2_Click;
            // 
            // simpleButton1
            // 
            simpleButton1.Location = new System.Drawing.Point(165, 23);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new System.Drawing.Size(75, 23);
            simpleButton1.TabIndex = 2;
            simpleButton1.Text = "Добавить";
            simpleButton1.Click += simpleButton1_Click;
            // 
            // dateEdit1
            // 
            dateEdit1.EditValue = null;
            dateEdit1.Location = new System.Drawing.Point(335, 59);
            dateEdit1.Name = "dateEdit1";
            dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEdit1.Size = new System.Drawing.Size(100, 20);
            dateEdit1.TabIndex = 1;
            // 
            // gridLookUpEdit1
            // 
            gridLookUpEdit1.Location = new System.Drawing.Point(335, 24);
            gridLookUpEdit1.Name = "gridLookUpEdit1";
            gridLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            gridLookUpEdit1.Properties.DataSource = typeof(Model.Customer);
            gridLookUpEdit1.Properties.DisplayMember = "Name";
            gridLookUpEdit1.Properties.PopupView = gridLookUpEdit1View;
            gridLookUpEdit1.Properties.ValueMember = "Id";
            gridLookUpEdit1.Size = new System.Drawing.Size(100, 20);
            gridLookUpEdit1.TabIndex = 3;
            // 
            // gridLookUpEdit1View
            // 
            gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // panelControl3
            // 
            panelControl3.Controls.Add(label2);
            panelControl3.Controls.Add(label1);
            panelControl3.Controls.Add(gridLookUpEdit1);
            panelControl3.Controls.Add(dateEdit1);
            panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            panelControl3.Location = new System.Drawing.Point(0, 0);
            panelControl3.Name = "panelControl3";
            panelControl3.Size = new System.Drawing.Size(810, 100);
            panelControl3.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(245, 62);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(33, 13);
            label2.TabIndex = 5;
            label2.Text = "Дата";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(245, 27);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(68, 13);
            label1.TabIndex = 4;
            label1.Text = "Покупатель";
            // 
            // simpleButton3
            // 
            simpleButton3.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("simpleButton3.ImageOptions.Image");
            simpleButton3.Location = new System.Drawing.Point(245, 151);
            simpleButton3.Name = "simpleButton3";
            simpleButton3.Size = new System.Drawing.Size(37, 36);
            simpleButton3.TabIndex = 2;
            simpleButton3.Click += simpleButton3_Click;
            // 
            // simpleButton4
            // 
            simpleButton4.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("simpleButton4.ImageOptions.Image");
            simpleButton4.Location = new System.Drawing.Point(414, 151);
            simpleButton4.Name = "simpleButton4";
            simpleButton4.Size = new System.Drawing.Size(37, 36);
            simpleButton4.TabIndex = 3;
            simpleButton4.Click += simpleButton4_Click;
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(gridControl2);
            panelControl1.Controls.Add(gridControl1);
            panelControl1.Controls.Add(simpleButton4);
            panelControl1.Controls.Add(simpleButton3);
            panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            panelControl1.Location = new System.Drawing.Point(0, 100);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new System.Drawing.Size(810, 339);
            panelControl1.TabIndex = 5;
            // 
            // gridControl2
            // 
            gridControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            gridControl2.Location = new System.Drawing.Point(2, 204);
            gridControl2.MainView = gridView2;
            gridControl2.Name = "gridControl2";
            gridControl2.Size = new System.Drawing.Size(806, 133);
            gridControl2.TabIndex = 5;
            gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView2 });
            // 
            // gridView2
            // 
            gridView2.GridControl = gridControl2;
            gridView2.Name = "gridView2";
            gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridControl1
            // 
            gridControl1.DataSource = typeof(Model.Product);
            gridControl1.Dock = System.Windows.Forms.DockStyle.Top;
            gridControl1.Location = new System.Drawing.Point(2, 2);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new System.Drawing.Size(806, 143);
            gridControl1.TabIndex = 4;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // NewPurchaseForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(810, 497);
            Controls.Add(panelControl1);
            Controls.Add(panelControl3);
            Controls.Add(panelControl2);
            Name = "NewPurchaseForm";
            Text = "NewPurchaseForm";
            ((System.ComponentModel.ISupportInitialize)panelControl2).EndInit();
            panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridLookUpEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridLookUpEdit1View).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl3).EndInit();
            panelControl3.ResumeLayout(false);
            panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControl2).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}