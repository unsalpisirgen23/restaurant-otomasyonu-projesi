namespace BackOffice.Forms.Customers
{
    partial class FrmCustomerList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomerList));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.ComStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtSurname = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtName = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.RgGender = new DevExpress.XtraEditors.RadioGroup();
            this.BtnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.BtnClear = new DevExpress.XtraEditors.SimpleButton();
            this.BtnExit = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GcID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GcName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GcSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GcFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GcStatus2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GcStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GcGender2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GcGender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GcAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GcCommunication = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BtnAddressDetails = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.BtnCommunicationDetails = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RgGender.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAddressDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCommunicationDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.BtnExit);
            this.groupControl1.Controls.Add(this.BtnClear);
            this.groupControl1.Controls.Add(this.BtnSearch);
            this.groupControl1.Controls.Add(this.ComStatus);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.TxtSurname);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.TxtName);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.RgGender);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1294, 59);
            this.groupControl1.TabIndex = 0;
            // 
            // ComStatus
            // 
            this.ComStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComStatus.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ComStatus.FormattingEnabled = true;
            this.ComStatus.Location = new System.Drawing.Point(825, 27);
            this.ComStatus.Margin = new System.Windows.Forms.Padding(7);
            this.ComStatus.Name = "ComStatus";
            this.ComStatus.Size = new System.Drawing.Size(136, 24);
            this.ComStatus.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(761, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 45;
            this.label2.Text = "Durum : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(523, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 44;
            this.label6.Text = "Cinsiyet : ";
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(308, 27);
            this.TxtSurname.Margin = new System.Windows.Forms.Padding(7);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSurname.Properties.Appearance.Options.UseFont = true;
            this.TxtSurname.Size = new System.Drawing.Size(205, 22);
            this.TxtSurname.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(246, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 42;
            this.label5.Text = "Soyad : ";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(46, 27);
            this.TxtName.Margin = new System.Windows.Forms.Padding(7);
            this.TxtName.Name = "TxtName";
            this.TxtName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtName.Properties.Appearance.Options.UseFont = true;
            this.TxtName.Size = new System.Drawing.Size(193, 22);
            this.TxtName.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(5, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Adı : ";
            // 
            // RgGender
            // 
            this.RgGender.Location = new System.Drawing.Point(588, 27);
            this.RgGender.Margin = new System.Windows.Forms.Padding(7);
            this.RgGender.Name = "RgGender";
            this.RgGender.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RgGender.Properties.Appearance.Options.UseFont = true;
            this.RgGender.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(1)), "Erkek"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(2)), "Kadın")});
            this.RgGender.Size = new System.Drawing.Size(166, 22);
            this.RgGender.TabIndex = 39;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSearch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.BtnSearch.Location = new System.Drawing.Point(1010, 24);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 26);
            this.BtnSearch.TabIndex = 47;
            this.BtnSearch.Text = "Ara";
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.BtnClear.Location = new System.Drawing.Point(1100, 24);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(85, 26);
            this.BtnClear.TabIndex = 48;
            this.BtnClear.Text = "Temizle";
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.BtnExit.Location = new System.Drawing.Point(1197, 24);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(85, 26);
            this.BtnExit.TabIndex = 49;
            this.BtnExit.Text = "Kapat";
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 59);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.BtnAddressDetails,
            this.BtnCommunicationDetails});
            this.gridControl1.Size = new System.Drawing.Size(1294, 537);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GcID,
            this.GcName,
            this.GcSurname,
            this.GcFullName,
            this.GcGender,
            this.GcGender2,
            this.GcStatus2,
            this.GcStatus,
            this.GcAddress,
            this.GcCommunication});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // GcID
            // 
            this.GcID.Caption = "ID";
            this.GcID.FieldName = "ID";
            this.GcID.Name = "GcID";
            // 
            // GcName
            // 
            this.GcName.Caption = "AD";
            this.GcName.FieldName = "Name";
            this.GcName.Name = "GcName";
            this.GcName.Visible = true;
            this.GcName.VisibleIndex = 0;
            // 
            // GcSurname
            // 
            this.GcSurname.Caption = "SOYAD";
            this.GcSurname.FieldName = "Surname";
            this.GcSurname.Name = "GcSurname";
            this.GcSurname.Visible = true;
            this.GcSurname.VisibleIndex = 1;
            // 
            // GcFullName
            // 
            this.GcFullName.Caption = "TAM ADI";
            this.GcFullName.FieldName = "FullName";
            this.GcFullName.Name = "GcFullName";
            this.GcFullName.Visible = true;
            this.GcFullName.VisibleIndex = 2;
            // 
            // GcStatus2
            // 
            this.GcStatus2.Caption = "DURUM";
            this.GcStatus2.FieldName = "Status2";
            this.GcStatus2.Name = "GcStatus2";
            this.GcStatus2.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.GcStatus2.Visible = true;
            this.GcStatus2.VisibleIndex = 5;
            // 
            // GcStatus
            // 
            this.GcStatus.Caption = "durum";
            this.GcStatus.FieldName = "Status";
            this.GcStatus.Name = "GcStatus";
            this.GcStatus.Visible = true;
            this.GcStatus.VisibleIndex = 6;
            // 
            // GcGender2
            // 
            this.GcGender2.Caption = "CİNSİYET";
            this.GcGender2.FieldName = "Gender2";
            this.GcGender2.Name = "GcGender2";
            this.GcGender2.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.GcGender2.Visible = true;
            this.GcGender2.VisibleIndex = 3;
            // 
            // GcGender
            // 
            this.GcGender.Caption = "cinsiyet";
            this.GcGender.FieldName = "Gender";
            this.GcGender.Name = "GcGender";
            this.GcGender.Visible = true;
            this.GcGender.VisibleIndex = 4;
            // 
            // GcAddress
            // 
            this.GcAddress.Caption = "ADRES DETAY";
            this.GcAddress.ColumnEdit = this.BtnAddressDetails;
            this.GcAddress.FieldName = "Address";
            this.GcAddress.Name = "GcAddress";
            this.GcAddress.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            this.GcAddress.Visible = true;
            this.GcAddress.VisibleIndex = 7;
            // 
            // GcCommunication
            // 
            this.GcCommunication.Caption = "İLETİŞİM DETAY";
            this.GcCommunication.ColumnEdit = this.BtnCommunicationDetails;
            this.GcCommunication.FieldName = "Communication";
            this.GcCommunication.Name = "GcCommunication";
            this.GcCommunication.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            this.GcCommunication.Visible = true;
            this.GcCommunication.VisibleIndex = 8;
            // 
            // BtnAddressDetails
            // 
            this.BtnAddressDetails.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.BtnAddressDetails.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions1, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.BtnAddressDetails.Name = "BtnAddressDetails";
            this.BtnAddressDetails.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // BtnCommunicationDetails
            // 
            this.BtnCommunicationDetails.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.BtnCommunicationDetails.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions2, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.BtnCommunicationDetails.Name = "BtnCommunicationDetails";
            this.BtnCommunicationDetails.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // FrmCustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 596);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmCustomerList";
            this.Text = "Müşteri Listesi";
            this.Load += new System.EventHandler(this.FrmCustomerList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RgGender.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAddressDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCommunicationDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ComboBox ComStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit TxtSurname;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit TxtName;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.RadioGroup RgGender;
        private DevExpress.XtraEditors.SimpleButton BtnSearch;
        private DevExpress.XtraEditors.SimpleButton BtnExit;
        private DevExpress.XtraEditors.SimpleButton BtnClear;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn GcID;
        private DevExpress.XtraGrid.Columns.GridColumn GcName;
        private DevExpress.XtraGrid.Columns.GridColumn GcSurname;
        private DevExpress.XtraGrid.Columns.GridColumn GcFullName;
        private DevExpress.XtraGrid.Columns.GridColumn GcGender;
        private DevExpress.XtraGrid.Columns.GridColumn GcGender2;
        private DevExpress.XtraGrid.Columns.GridColumn GcStatus2;
        private DevExpress.XtraGrid.Columns.GridColumn GcStatus;
        private DevExpress.XtraGrid.Columns.GridColumn GcAddress;
        private DevExpress.XtraGrid.Columns.GridColumn GcCommunication;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit BtnAddressDetails;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit BtnCommunicationDetails;
    }
}