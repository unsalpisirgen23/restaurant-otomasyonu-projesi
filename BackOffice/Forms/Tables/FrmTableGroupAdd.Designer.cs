namespace BackOffice.Forms.Tables
{
    partial class FrmTableGroupAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtName = new DevExpress.XtraEditors.TextEdit();
            this.ComStatus = new System.Windows.Forms.ComboBox();
            this.BtnAddClose = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAddNew = new DevExpress.XtraEditors.SimpleButton();
            this.BtnClose = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.TxtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.label1.Location = new System.Drawing.Point(46, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad : ";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(89, 40);
            this.TxtName.Name = "TxtName";
            this.TxtName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtName.Properties.Appearance.Options.UseFont = true;
            this.TxtName.Size = new System.Drawing.Size(287, 24);
            this.TxtName.TabIndex = 1;
            // 
            // ComStatus
            // 
            this.ComStatus.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ComStatus.FormattingEnabled = true;
            this.ComStatus.Items.AddRange(new object[] {
            "Onayla",
            "Onaylama"});
            this.ComStatus.Location = new System.Drawing.Point(89, 96);
            this.ComStatus.Name = "ComStatus";
            this.ComStatus.Size = new System.Drawing.Size(287, 26);
            this.ComStatus.TabIndex = 2;
            // 
            // BtnAddClose
            // 
            this.BtnAddClose.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAddClose.Appearance.Options.UseFont = true;
            this.BtnAddClose.Location = new System.Drawing.Point(12, 178);
            this.BtnAddClose.Name = "BtnAddClose";
            this.BtnAddClose.Size = new System.Drawing.Size(86, 30);
            this.BtnAddClose.TabIndex = 3;
            this.BtnAddClose.Text = "Ekle Kapat";
            this.BtnAddClose.Click += new System.EventHandler(this.BtnAddClose_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.ComStatus);
            this.groupControl1.Controls.Add(this.TxtName);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(393, 159);
            this.groupControl1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.label2.Location = new System.Drawing.Point(17, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Durum : ";
            // 
            // BtnAddNew
            // 
            this.BtnAddNew.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAddNew.Appearance.Options.UseFont = true;
            this.BtnAddNew.Location = new System.Drawing.Point(153, 178);
            this.BtnAddNew.Name = "BtnAddNew";
            this.BtnAddNew.Size = new System.Drawing.Size(86, 30);
            this.BtnAddNew.TabIndex = 5;
            this.BtnAddNew.Text = "Ekle Yeni";
            this.BtnAddNew.Click += new System.EventHandler(this.BtnAddNew_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnClose.Appearance.Options.UseFont = true;
            this.BtnClose.Location = new System.Drawing.Point(290, 178);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(86, 30);
            this.BtnClose.TabIndex = 6;
            this.BtnClose.Text = "Kapat";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // FrmTableGroupAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 220);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnAddNew);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.BtnAddClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmTableGroupAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Masa Grup Ekleme İşlemi";
            this.Load += new System.EventHandler(this.FrmTableGroupAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit TxtName;
        private System.Windows.Forms.ComboBox ComStatus;
        private DevExpress.XtraEditors.SimpleButton BtnAddClose;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton BtnAddNew;
        private DevExpress.XtraEditors.SimpleButton BtnClose;
    }
}