namespace ServiceAccounting
{
    partial class MainForm
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
            btnCustomers = new DevExpress.XtraEditors.SimpleButton();
            btnProducts = new DevExpress.XtraEditors.SimpleButton();
            btnOrders = new DevExpress.XtraEditors.SimpleButton();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            panelControl2 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl2).BeginInit();
            SuspendLayout();
            // 
            // btnCustomers
            // 
            btnCustomers.Location = new System.Drawing.Point(12, 12);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new System.Drawing.Size(75, 23);
            btnCustomers.TabIndex = 0;
            btnCustomers.Text = "Покупатели";
            btnCustomers.Click += btnCustomers_Click;
            // 
            // btnProducts
            // 
            btnProducts.Location = new System.Drawing.Point(93, 12);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new System.Drawing.Size(75, 23);
            btnProducts.TabIndex = 1;
            btnProducts.Text = "Товары";
            btnProducts.Click += btnProducts_Click;
            // 
            // btnOrders
            // 
            btnOrders.Location = new System.Drawing.Point(174, 12);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new System.Drawing.Size(75, 23);
            btnOrders.TabIndex = 2;
            btnOrders.Text = "Покупки";
            btnOrders.Click += btnOrders_Click;
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(btnOrders);
            panelControl1.Controls.Add(btnCustomers);
            panelControl1.Controls.Add(btnProducts);
            panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            panelControl1.Location = new System.Drawing.Point(0, 0);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new System.Drawing.Size(632, 46);
            panelControl1.TabIndex = 3;
            // 
            // panelControl2
            // 
            panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            panelControl2.Location = new System.Drawing.Point(0, 46);
            panelControl2.Name = "panelControl2";
            panelControl2.Size = new System.Drawing.Size(632, 232);
            panelControl2.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(632, 278);
            Controls.Add(panelControl2);
            Controls.Add(panelControl1);
            Name = "MainForm";
            Text = "Главное окно";
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelControl2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCustomers;
        private DevExpress.XtraEditors.SimpleButton btnProducts;
        private DevExpress.XtraEditors.SimpleButton btnOrders;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
    }
}

