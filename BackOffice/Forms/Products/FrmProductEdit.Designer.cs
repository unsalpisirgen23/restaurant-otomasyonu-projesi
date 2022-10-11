namespace BackOffice.Forms.Products
{
    partial class FrmProductEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductEdit));
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.ComGroup = new System.Windows.Forms.ComboBox();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ComStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtName = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPrice = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.BtnClose = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.ComGroup);
            this.groupControl4.Controls.Add(this.groupControl2);
            this.groupControl4.Controls.Add(this.label4);
            this.groupControl4.Controls.Add(this.ComStatus);
            this.groupControl4.Controls.Add(this.label2);
            this.groupControl4.Controls.Add(this.TxtName);
            this.groupControl4.Controls.Add(this.label1);
            this.groupControl4.Controls.Add(this.TxtPrice);
            this.groupControl4.Controls.Add(this.label3);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl4.Location = new System.Drawing.Point(0, 0);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(381, 419);
            this.groupControl4.TabIndex = 20;
            this.groupControl4.Text = "Bilgiler";
            // 
            // ComGroup
            // 
            this.ComGroup.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ComGroup.FormattingEnabled = true;
            this.ComGroup.Location = new System.Drawing.Point(79, 309);
            this.ComGroup.Name = "ComGroup";
            this.ComGroup.Size = new System.Drawing.Size(291, 27);
            this.ComGroup.TabIndex = 20;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.pictureBox1);
            this.groupControl2.Location = new System.Drawing.Point(122, 54);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(173, 137);
            this.groupControl2.TabIndex = 18;
            this.groupControl2.Text = "Resim Seç";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(2, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 115);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(19, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "Grup : ";
            // 
            // ComStatus
            // 
            this.ComStatus.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ComStatus.FormattingEnabled = true;
            this.ComStatus.Location = new System.Drawing.Point(79, 352);
            this.ComStatus.Name = "ComStatus";
            this.ComStatus.Size = new System.Drawing.Size(291, 27);
            this.ComStatus.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(7, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Durum : ";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(79, 229);
            this.TxtName.Margin = new System.Windows.Forms.Padding(7);
            this.TxtName.Name = "TxtName";
            this.TxtName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtName.Properties.Appearance.Options.UseFont = true;
            this.TxtName.Size = new System.Drawing.Size(291, 26);
            this.TxtName.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(27, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Adı : ";
            // 
            // TxtPrice
            // 
            this.TxtPrice.Location = new System.Drawing.Point(79, 268);
            this.TxtPrice.Margin = new System.Windows.Forms.Padding(7);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPrice.Properties.Appearance.Options.UseFont = true;
            this.TxtPrice.Properties.Mask.EditMask = "d";
            this.TxtPrice.Size = new System.Drawing.Size(291, 26);
            this.TxtPrice.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(18, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Fiyatı :";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.BtnClose);
            this.groupControl1.Controls.Add(this.BtnSave);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 419);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(381, 78);
            this.groupControl1.TabIndex = 21;
            this.groupControl1.Text = "İşlemler";
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnClose.Appearance.Options.UseFont = true;
            this.BtnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.ImageOptions.Image")));
            this.BtnClose.Location = new System.Drawing.Point(263, 29);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(98, 37);
            this.BtnClose.TabIndex = 20;
            this.BtnClose.Text = "Kapat";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSave.Appearance.Options.UseFont = true;
            this.BtnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdd.ImageOptions.Image")));
            this.BtnSave.Location = new System.Drawing.Point(31, 29);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(98, 37);
            this.BtnSave.TabIndex = 18;
            this.BtnSave.Text = "Kaydet";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmProductEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 497);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProductEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Düzenleme İşlemi";
            this.Load += new System.EventHandler(this.FrmProductEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl4;
        private System.Windows.Forms.ComboBox ComGroup;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ComStatus;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit TxtName;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit TxtPrice;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton BtnClose;
        private DevExpress.XtraEditors.SimpleButton BtnSave;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}