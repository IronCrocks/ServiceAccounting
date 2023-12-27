namespace ServiceAccounting
{
    partial class Form1
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
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            panelControl2 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl2).BeginInit();
            SuspendLayout();
            // 
            // simpleButton1
            // 
            simpleButton1.Location = new System.Drawing.Point(12, 12);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new System.Drawing.Size(75, 23);
            simpleButton1.TabIndex = 0;
            simpleButton1.Text = "Покупатели";
            simpleButton1.Click += simpleButton1_Click;
            // 
            // simpleButton2
            // 
            simpleButton2.Location = new System.Drawing.Point(93, 12);
            simpleButton2.Name = "simpleButton2";
            simpleButton2.Size = new System.Drawing.Size(75, 23);
            simpleButton2.TabIndex = 1;
            simpleButton2.Text = "Товары";
            simpleButton2.Click += simpleButton2_Click;
            // 
            // simpleButton3
            // 
            simpleButton3.Location = new System.Drawing.Point(174, 12);
            simpleButton3.Name = "simpleButton3";
            simpleButton3.Size = new System.Drawing.Size(75, 23);
            simpleButton3.TabIndex = 2;
            simpleButton3.Text = "Покупки";
            simpleButton3.Click += simpleButton3_Click;
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(simpleButton3);
            panelControl1.Controls.Add(simpleButton1);
            panelControl1.Controls.Add(simpleButton2);
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
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(632, 278);
            Controls.Add(panelControl2);
            Controls.Add(panelControl1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelControl2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
    }
}

