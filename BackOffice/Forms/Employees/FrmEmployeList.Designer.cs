namespace BackOffice.Forms.Employees
{
    partial class FrmEmployeList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmployeList));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.BtnClose = new DevExpress.XtraEditors.SimpleButton();
            this.BtnClear = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.TxtTc = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSurname = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtName = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GcID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GcName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GcSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GcCitizenshipNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GcGender2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GcGender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GcAvatar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GcDateOfBirth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GcMaritalStatus2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GcMaritalStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GcUsername = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GcStatus2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GcStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GcFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GcAddDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GcUpdateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GcDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BtnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.GcEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BtnEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.GcSessionMovementLoginID2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GcSessionMovementLoginID = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.BtnClose);
            this.groupControl1.Controls.Add(this.BtnClear);
            this.groupControl1.Controls.Add(this.BtnSearch);
            this.groupControl1.Controls.Add(this.TxtTc);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.TxtSurname);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.TxtName);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1264, 62);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "İşlemler";
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnClose.Appearance.Options.UseFont = true;
            this.BtnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.ImageOptions.Image")));
            this.BtnClose.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.BtnClose.Location = new System.Drawing.Point(1136, 23);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(106, 35);
            this.BtnClose.TabIndex = 67;
            this.BtnClose.Text = "Kapat";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClear.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnClear.Appearance.Options.UseFont = true;
            this.BtnClear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnClear.ImageOptions.Image")));
            this.BtnClear.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.BtnClear.Location = new System.Drawing.Point(1024, 23);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(106, 35);
            this.BtnClear.TabIndex = 66;
            this.BtnClear.Text = "Temizle";
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSearch.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSearch.Appearance.Options.UseFont = true;
            this.BtnSearch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSearch.ImageOptions.Image")));
            this.BtnSearch.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.BtnSearch.Location = new System.Drawing.Point(912, 23);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(106, 35);
            this.BtnSearch.TabIndex = 65;
            this.BtnSearch.Text = "Ara";
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click_1);
            // 
            // TxtTc
            // 
            this.TxtTc.Location = new System.Drawing.Point(668, 26);
            this.TxtTc.Margin = new System.Windows.Forms.Padding(7);
            this.TxtTc.Name = "TxtTc";
            this.TxtTc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtTc.Properties.Appearance.Options.UseFont = true;
            this.TxtTc.Size = new System.Drawing.Size(202, 30);
            this.TxtTc.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(547, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 18);
            this.label2.TabIndex = 63;
            this.label2.Text = "T.C. Kimlik No : ";
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(352, 27);
            this.TxtSurname.Margin = new System.Windows.Forms.Padding(7);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSurname.Properties.Appearance.Options.UseFont = true;
            this.TxtSurname.Size = new System.Drawing.Size(187, 26);
            this.TxtSurname.TabIndex = 62;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(284, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 18);
            this.label5.TabIndex = 61;
            this.label5.Text = "Soyad : ";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(69, 26);
            this.TxtName.Margin = new System.Windows.Forms.Padding(7);
            this.TxtName.Name = "TxtName";
            this.TxtName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtName.Properties.Appearance.Options.UseFont = true;
            this.TxtName.Size = new System.Drawing.Size(202, 26);
            this.TxtName.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 18);
            this.label1.TabIndex = 59;
            this.label1.Text = "Adı : ";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 62);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.BtnDelete,
            this.BtnEdit});
            this.gridControl1.Size = new System.Drawing.Size(1264, 621);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GcID,
            this.GcAvatar,
            this.GcName,
            this.GcSurname,
            this.GcFullName,
            this.GcCitizenshipNumber,
            this.GcGender2,
            this.GcGender,
            this.GcDateOfBirth,
            this.GcMaritalStatus2,
            this.GcMaritalStatus,
            this.GcUsername,
            this.GcStatus2,
            this.GcSessionMovementLoginID2,
            this.GcAddDate,
            this.GcUpdateDate,
            this.GcStatus,
            this.GcDelete,
            this.GcEdit,
            this.GcSessionMovementLoginID});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowHeight = 55;
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
            this.GcName.VisibleIndex = 1;
            this.GcName.Width = 73;
            // 
            // GcSurname
            // 
            this.GcSurname.Caption = "SOYAD";
            this.GcSurname.FieldName = "Surname";
            this.GcSurname.Name = "GcSurname";
            this.GcSurname.Visible = true;
            this.GcSurname.VisibleIndex = 2;
            this.GcSurname.Width = 73;
            // 
            // GcCitizenshipNumber
            // 
            this.GcCitizenshipNumber.Caption = "T.C. NO";
            this.GcCitizenshipNumber.FieldName = "CitizenshipNumber";
            this.GcCitizenshipNumber.Name = "GcCitizenshipNumber";
            this.GcCitizenshipNumber.Visible = true;
            this.GcCitizenshipNumber.VisibleIndex = 4;
            this.GcCitizenshipNumber.Width = 73;
            // 
            // GcGender2
            // 
            this.GcGender2.Caption = "CİNSİYET";
            this.GcGender2.FieldName = "Gender2";
            this.GcGender2.Name = "GcGender2";
            this.GcGender2.Visible = true;
            this.GcGender2.VisibleIndex = 5;
            this.GcGender2.Width = 73;
            // 
            // GcGender
            // 
            this.GcGender.Caption = "cinsiyet";
            this.GcGender.FieldName = "Gender";
            this.GcGender.Name = "GcGender";
            this.GcGender.Visible = true;
            this.GcGender.VisibleIndex = 6;
            this.GcGender.Width = 73;
            // 
            // GcAvatar
            // 
            this.GcAvatar.Caption = "FOTORAF";
            this.GcAvatar.FieldName = "Avatar";
            this.GcAvatar.MaxWidth = 60;
            this.GcAvatar.MinWidth = 60;
            this.GcAvatar.Name = "GcAvatar";
            this.GcAvatar.Visible = true;
            this.GcAvatar.VisibleIndex = 0;
            this.GcAvatar.Width = 60;
            // 
            // GcDateOfBirth
            // 
            this.GcDateOfBirth.Caption = "DOĞUM TARİHİ";
            this.GcDateOfBirth.FieldName = "DateOfBirth";
            this.GcDateOfBirth.Name = "GcDateOfBirth";
            this.GcDateOfBirth.Visible = true;
            this.GcDateOfBirth.VisibleIndex = 7;
            this.GcDateOfBirth.Width = 73;
            // 
            // GcMaritalStatus2
            // 
            this.GcMaritalStatus2.Caption = "MEDENİ HALİ";
            this.GcMaritalStatus2.FieldName = "MaritalStatus2";
            this.GcMaritalStatus2.Name = "GcMaritalStatus2";
            this.GcMaritalStatus2.Visible = true;
            this.GcMaritalStatus2.VisibleIndex = 8;
            this.GcMaritalStatus2.Width = 73;
            // 
            // GcMaritalStatus
            // 
            this.GcMaritalStatus.Caption = "medeni hali";
            this.GcMaritalStatus.FieldName = "MaritalStatus";
            this.GcMaritalStatus.Name = "GcMaritalStatus";
            this.GcMaritalStatus.Visible = true;
            this.GcMaritalStatus.VisibleIndex = 9;
            this.GcMaritalStatus.Width = 73;
            // 
            // GcUsername
            // 
            this.GcUsername.Caption = "KULLANICI ADI";
            this.GcUsername.FieldName = "Username";
            this.GcUsername.Name = "GcUsername";
            this.GcUsername.Visible = true;
            this.GcUsername.VisibleIndex = 10;
            this.GcUsername.Width = 73;
            // 
            // GcStatus2
            // 
            this.GcStatus2.Caption = "DURUM";
            this.GcStatus2.FieldName = "Status2";
            this.GcStatus2.Name = "GcStatus2";
            this.GcStatus2.Visible = true;
            this.GcStatus2.VisibleIndex = 15;
            this.GcStatus2.Width = 73;
            // 
            // GcStatus
            // 
            this.GcStatus.Caption = "durum";
            this.GcStatus.FieldName = "Status";
            this.GcStatus.Name = "GcStatus";
            this.GcStatus.Visible = true;
            this.GcStatus.VisibleIndex = 11;
            this.GcStatus.Width = 73;
            // 
            // GcFullName
            // 
            this.GcFullName.Caption = "TAM ADI";
            this.GcFullName.FieldName = "FullName";
            this.GcFullName.Name = "GcFullName";
            this.GcFullName.Visible = true;
            this.GcFullName.VisibleIndex = 3;
            this.GcFullName.Width = 73;
            // 
            // GcAddDate
            // 
            this.GcAddDate.Caption = "EKLENME TARİHİ";
            this.GcAddDate.FieldName = "AddDate";
            this.GcAddDate.Name = "GcAddDate";
            this.GcAddDate.Visible = true;
            this.GcAddDate.VisibleIndex = 13;
            this.GcAddDate.Width = 73;
            // 
            // GcUpdateDate
            // 
            this.GcUpdateDate.Caption = "GÜNCELLENME TARİHİ";
            this.GcUpdateDate.FieldName = "UpdateDate";
            this.GcUpdateDate.Name = "GcUpdateDate";
            this.GcUpdateDate.Visible = true;
            this.GcUpdateDate.VisibleIndex = 14;
            this.GcUpdateDate.Width = 73;
            // 
            // GcDelete
            // 
            this.GcDelete.Caption = "SİLME";
            this.GcDelete.ColumnEdit = this.BtnDelete;
            this.GcDelete.FieldName = "Delete";
            this.GcDelete.Name = "GcDelete";
            this.GcDelete.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            this.GcDelete.Visible = true;
            this.GcDelete.VisibleIndex = 16;
            this.GcDelete.Width = 73;
            // 
            // BtnDelete
            // 
            this.BtnDelete.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.BtnDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions1, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.BtnDelete.DoubleClick += new System.EventHandler(this.BtnDelete_DoubleClick_1);
            // 
            // GcEdit
            // 
            this.GcEdit.Caption = "DÜZENLE";
            this.GcEdit.ColumnEdit = this.BtnEdit;
            this.GcEdit.FieldName = "Edit";
            this.GcEdit.Name = "GcEdit";
            this.GcEdit.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            this.GcEdit.Visible = true;
            this.GcEdit.VisibleIndex = 17;
            this.GcEdit.Width = 96;
            // 
            // BtnEdit
            // 
            this.BtnEdit.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.BtnEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions2, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.BtnEdit.DoubleClick += new System.EventHandler(this.BtnEdit_DoubleClick);
            // 
            // GcSessionMovementLoginID2
            // 
            this.GcSessionMovementLoginID2.Caption = "EKLEYEN ADI";
            this.GcSessionMovementLoginID2.FieldName = "SessionMovementLoginID2";
            this.GcSessionMovementLoginID2.Name = "GcSessionMovementLoginID2";
            this.GcSessionMovementLoginID2.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.GcSessionMovementLoginID2.Visible = true;
            this.GcSessionMovementLoginID2.VisibleIndex = 12;
            // 
            // GcSessionMovementLoginID
            // 
            this.GcSessionMovementLoginID.Caption = "ekleyen adı";
            this.GcSessionMovementLoginID.FieldName = "SessionMovementLoginID";
            this.GcSessionMovementLoginID.Name = "GcSessionMovementLoginID";
            this.GcSessionMovementLoginID.Visible = true;
            this.GcSessionMovementLoginID.VisibleIndex = 18;
            // 
            // FrmEmployeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 683);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmEmployeList";
            this.Text = "FrmEmployeList";
            this.Load += new System.EventHandler(this.FrmEmployeList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton BtnClose;
        private DevExpress.XtraEditors.SimpleButton BtnClear;
        private DevExpress.XtraEditors.SimpleButton BtnSearch;
        private DevExpress.XtraEditors.TextEdit TxtTc;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit TxtSurname;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit TxtName;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn GcID;
        private DevExpress.XtraGrid.Columns.GridColumn GcAvatar;
        private DevExpress.XtraGrid.Columns.GridColumn GcName;
        private DevExpress.XtraGrid.Columns.GridColumn GcSurname;
        private DevExpress.XtraGrid.Columns.GridColumn GcFullName;
        private DevExpress.XtraGrid.Columns.GridColumn GcCitizenshipNumber;
        private DevExpress.XtraGrid.Columns.GridColumn GcGender2;
        private DevExpress.XtraGrid.Columns.GridColumn GcGender;
        private DevExpress.XtraGrid.Columns.GridColumn GcDateOfBirth;
        private DevExpress.XtraGrid.Columns.GridColumn GcMaritalStatus2;
        private DevExpress.XtraGrid.Columns.GridColumn GcMaritalStatus;
        private DevExpress.XtraGrid.Columns.GridColumn GcUsername;
        private DevExpress.XtraGrid.Columns.GridColumn GcStatus2;
        private DevExpress.XtraGrid.Columns.GridColumn GcStatus;
        private DevExpress.XtraGrid.Columns.GridColumn GcAddDate;
        private DevExpress.XtraGrid.Columns.GridColumn GcUpdateDate;
        private DevExpress.XtraGrid.Columns.GridColumn GcDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit BtnDelete;
        private DevExpress.XtraGrid.Columns.GridColumn GcEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit BtnEdit;
        private DevExpress.XtraGrid.Columns.GridColumn GcSessionMovementLoginID2;
        private DevExpress.XtraGrid.Columns.GridColumn GcSessionMovementLoginID;
    }
}