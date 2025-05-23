namespace ServiceAccounting.View
{
    partial class NewOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewOrderForm));
            panelControl2 = new DevExpress.XtraEditors.PanelControl();
            btnCancel = new DevExpress.XtraEditors.SimpleButton();
            btnAddOrder = new DevExpress.XtraEditors.SimpleButton();
            dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            panelControl3 = new DevExpress.XtraEditors.PanelControl();
            searchLookUpEdit1 = new DevExpress.XtraEditors.SearchLookUpEdit();
            searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            btnAddOrderItem = new DevExpress.XtraEditors.SimpleButton();
            btnDeleteOrderItem = new DevExpress.XtraEditors.SimpleButton();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            gridControl2 = new DevExpress.XtraGrid.GridControl();
            gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)panelControl2).BeginInit();
            panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl3).BeginInit();
            panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit1View).BeginInit();
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
            panelControl2.Controls.Add(btnCancel);
            panelControl2.Controls.Add(btnAddOrder);
            panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelControl2.Location = new System.Drawing.Point(0, 586);
            panelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelControl2.Name = "panelControl2";
            panelControl2.Size = new System.Drawing.Size(926, 77);
            panelControl2.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(546, 31);
            btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(86, 31);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Отмена";
            btnCancel.Click += BtnCancel_Click;
            // 
            // btnAddOrder
            // 
            btnAddOrder.Location = new System.Drawing.Point(189, 31);
            btnAddOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new System.Drawing.Size(86, 31);
            btnAddOrder.TabIndex = 2;
            btnAddOrder.Text = "Добавить";
            btnAddOrder.Click += BtnAddOrder_Click;
            // 
            // dateEdit1
            // 
            dateEdit1.EditValue = null;
            dateEdit1.Location = new System.Drawing.Point(383, 79);
            dateEdit1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dateEdit1.Name = "dateEdit1";
            dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEdit1.Size = new System.Drawing.Size(114, 22);
            dateEdit1.TabIndex = 1;
            // 
            // panelControl3
            // 
            panelControl3.Controls.Add(searchLookUpEdit1);
            panelControl3.Controls.Add(label2);
            panelControl3.Controls.Add(label1);
            panelControl3.Controls.Add(dateEdit1);
            panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            panelControl3.Location = new System.Drawing.Point(0, 0);
            panelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelControl3.Name = "panelControl3";
            panelControl3.Size = new System.Drawing.Size(926, 133);
            panelControl3.TabIndex = 4;
            // 
            // searchLookUpEdit1
            // 
            searchLookUpEdit1.Location = new System.Drawing.Point(461, 19);
            searchLookUpEdit1.Name = "searchLookUpEdit1";
            searchLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            searchLookUpEdit1.Properties.PopupView = searchLookUpEdit1View;
            searchLookUpEdit1.Size = new System.Drawing.Size(156, 22);
            searchLookUpEdit1.TabIndex = 6;
            // 
            // searchLookUpEdit1View
            // 
            searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(280, 83);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(36, 16);
            label2.TabIndex = 5;
            label2.Text = "Дата";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(280, 36);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(75, 16);
            label1.TabIndex = 4;
            label1.Text = "Покупатель";
            // 
            // btnAddOrderItem
            // 
            btnAddOrderItem.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnAddOrderItem.ImageOptions.Image");
            btnAddOrderItem.Location = new System.Drawing.Point(280, 201);
            btnAddOrderItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnAddOrderItem.Name = "btnAddOrderItem";
            btnAddOrderItem.Size = new System.Drawing.Size(42, 48);
            btnAddOrderItem.TabIndex = 2;
            btnAddOrderItem.Click += BtnAddOrderItem_Click;
            // 
            // btnDeleteOrderItem
            // 
            btnDeleteOrderItem.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnDeleteOrderItem.ImageOptions.Image");
            btnDeleteOrderItem.Location = new System.Drawing.Point(473, 201);
            btnDeleteOrderItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnDeleteOrderItem.Name = "btnDeleteOrderItem";
            btnDeleteOrderItem.Size = new System.Drawing.Size(42, 48);
            btnDeleteOrderItem.TabIndex = 3;
            btnDeleteOrderItem.Click += BtnDeleteOrderItem_Click;
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(gridControl2);
            panelControl1.Controls.Add(gridControl1);
            panelControl1.Controls.Add(btnDeleteOrderItem);
            panelControl1.Controls.Add(btnAddOrderItem);
            panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            panelControl1.Location = new System.Drawing.Point(0, 133);
            panelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new System.Drawing.Size(926, 453);
            panelControl1.TabIndex = 5;
            // 
            // gridControl2
            // 
            gridControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            gridControl2.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            gridControl2.Location = new System.Drawing.Point(2, 274);
            gridControl2.MainView = gridView2;
            gridControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            gridControl2.Name = "gridControl2";
            gridControl2.Size = new System.Drawing.Size(922, 177);
            gridControl2.TabIndex = 5;
            gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView2 });
            // 
            // gridView2
            // 
            gridView2.DetailHeight = 467;
            gridView2.GridControl = gridControl2;
            gridView2.Name = "gridView2";
            gridView2.OptionsBehavior.Editable = false;
            gridView2.OptionsEditForm.PopupEditFormWidth = 914;
            gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridControl1
            // 
            gridControl1.Dock = System.Windows.Forms.DockStyle.Top;
            gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            gridControl1.Location = new System.Drawing.Point(2, 2);
            gridControl1.MainView = gridView1;
            gridControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new System.Drawing.Size(922, 191);
            gridControl1.TabIndex = 4;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.DetailHeight = 467;
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsEditForm.PopupEditFormWidth = 914;
            gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // NewOrderForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(926, 663);
            Controls.Add(panelControl1);
            Controls.Add(panelControl3);
            Controls.Add(panelControl2);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "NewOrderForm";
            Text = "Новый заказ";
            ((System.ComponentModel.ISupportInitialize)panelControl2).EndInit();
            panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl3).EndInit();
            panelControl3.ResumeLayout(false);
            panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit1View).EndInit();
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
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnAddOrder;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnAddOrderItem;
        private DevExpress.XtraEditors.SimpleButton btnDeleteOrderItem;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
    }
}