namespace BackOffice.Forms.Tables
{
    partial class FrmTableAdd
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label3 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.label4 = new System.Windows.Forms.Label();
            this.ComTableGroupList = new System.Windows.Forms.ComboBox();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.BtnClose = new DevExpress.XtraEditors.SimpleButton();
            this.BtnAddNew = new DevExpress.XtraEditors.SimpleButton();
            this.BtnAddClose = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCapasite = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCapasite.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(70, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad : ";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(116, 36);
            this.TxtName.Name = "TxtName";
            this.TxtName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtName.Properties.Appearance.Options.UseFont = true;
            this.TxtName.Size = new System.Drawing.Size(307, 24);
            this.TxtName.TabIndex = 1;
            // 
            // ComStatus
            // 
            this.ComStatus.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ComStatus.FormattingEnabled = true;
            this.ComStatus.Items.AddRange(new object[] {
            "Onayla",
            "Onaylama"});
            this.ComStatus.Location = new System.Drawing.Point(116, 119);
            this.ComStatus.Name = "ComStatus";
            this.ComStatus.Size = new System.Drawing.Size(307, 26);
            this.ComStatus.TabIndex = 2;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.TxtCapasite);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.ComStatus);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.TxtName);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(439, 166);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Masa Ön Bilgileri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(43, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Durum : ";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.label4);
            this.groupControl2.Controls.Add(this.ComTableGroupList);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 166);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(439, 78);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "Masa Grup Bilgisi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(30, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Grup Seç : ";
            // 
            // ComTableGroupList
            // 
            this.ComTableGroupList.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ComTableGroupList.FormattingEnabled = true;
            this.ComTableGroupList.Location = new System.Drawing.Point(116, 36);
            this.ComTableGroupList.Name = "ComTableGroupList";
            this.ComTableGroupList.Size = new System.Drawing.Size(307, 26);
            this.ComTableGroupList.TabIndex = 5;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.BtnClose);
            this.groupControl3.Controls.Add(this.BtnAddNew);
            this.groupControl3.Controls.Add(this.BtnAddClose);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl3.Location = new System.Drawing.Point(0, 244);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(439, 69);
            this.groupControl3.TabIndex = 5;
            this.groupControl3.Text = "İşlemler";
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnClose.Appearance.Options.UseFont = true;
            this.BtnClose.Location = new System.Drawing.Point(337, 24);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(86, 36);
            this.BtnClose.TabIndex = 9;
            this.BtnClose.Text = "Kapat";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnAddNew
            // 
            this.BtnAddNew.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAddNew.Appearance.Options.UseFont = true;
            this.BtnAddNew.Location = new System.Drawing.Point(176, 24);
            this.BtnAddNew.Name = "BtnAddNew";
            this.BtnAddNew.Size = new System.Drawing.Size(86, 36);
            this.BtnAddNew.TabIndex = 8;
            this.BtnAddNew.Text = "Ekle Yeni";
            this.BtnAddNew.Click += new System.EventHandler(this.BtnAddNew_Click);
            // 
            // BtnAddClose
            // 
            this.BtnAddClose.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAddClose.Appearance.Options.UseFont = true;
            this.BtnAddClose.Location = new System.Drawing.Point(12, 24);
            this.BtnAddClose.Name = "BtnAddClose";
            this.BtnAddClose.Size = new System.Drawing.Size(86, 36);
            this.BtnAddClose.TabIndex = 7;
            this.BtnAddClose.Text = "Ekle Kapat";
            this.BtnAddClose.Click += new System.EventHandler(this.BtnAddClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(32, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kapasite : ";
            // 
            // TxtCapasite
            // 
            this.TxtCapasite.Location = new System.Drawing.Point(116, 79);
            this.TxtCapasite.Name = "TxtCapasite";
            this.TxtCapasite.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtCapasite.Properties.Appearance.Options.UseFont = true;
            this.TxtCapasite.Size = new System.Drawing.Size(307, 24);
            this.TxtCapasite.TabIndex = 6;
            // 
            // FrmTableAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 313);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmTableAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Masa Ekleme İşleemi";
            this.Load += new System.EventHandler(this.FrmTableAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TxtCapasite.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit TxtName;
        private System.Windows.Forms.ComboBox ComStatus;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ComTableGroupList;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton BtnClose;
        private DevExpress.XtraEditors.SimpleButton BtnAddNew;
        private DevExpress.XtraEditors.SimpleButton BtnAddClose;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit TxtCapasite;
    }
}