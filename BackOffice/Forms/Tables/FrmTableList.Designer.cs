namespace BackOffice.Forms.Tables
{
    partial class FrmTableList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTableList));
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GcID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GcNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GcCapacity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GcGroup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GcStatus2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GcStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.BtnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.TxtSearchNo = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.TxtEditCapasite = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.ComEditStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtEditNo = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.ComEditGroup = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnEditSave = new DevExpress.XtraEditors.SimpleButton();
            this.BtnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.tabNavigationPage3 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.BtnClose = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSearchNo.Properties)).BeginInit();
            this.tabNavigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditCapasite.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditNo.Properties)).BeginInit();
            this.tabNavigationPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(323, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(838, 622);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Listeleme";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 20);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(834, 600);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GcID,
            this.GcNo,
            this.GcCapacity,
            this.GcGroup,
            this.GcStatus2,
            this.GcStatus});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // GcID
            // 
            this.GcID.Caption = "ID";
            this.GcID.FieldName = "ID";
            this.GcID.Name = "GcID";
            // 
            // GcNo
            // 
            this.GcNo.Caption = "No";
            this.GcNo.FieldName = "No";
            this.GcNo.Name = "GcNo";
            this.GcNo.Visible = true;
            this.GcNo.VisibleIndex = 0;
            this.GcNo.Width = 310;
            // 
            // GcCapacity
            // 
            this.GcCapacity.Caption = "Kapasite";
            this.GcCapacity.FieldName = "Capacity";
            this.GcCapacity.Name = "GcCapacity";
            this.GcCapacity.Visible = true;
            this.GcCapacity.VisibleIndex = 1;
            this.GcCapacity.Width = 96;
            // 
            // GcGroup
            // 
            this.GcGroup.Caption = "Kategori";
            this.GcGroup.FieldName = "TableGroup.Name";
            this.GcGroup.Name = "GcGroup";
            this.GcGroup.Visible = true;
            this.GcGroup.VisibleIndex = 2;
            this.GcGroup.Width = 257;
            // 
            // GcStatus2
            // 
            this.GcStatus2.Caption = "Durum";
            this.GcStatus2.FieldName = "Status2";
            this.GcStatus2.Name = "GcStatus2";
            this.GcStatus2.Visible = true;
            this.GcStatus2.VisibleIndex = 3;
            this.GcStatus2.Width = 82;
            // 
            // GcStatus
            // 
            this.GcStatus.Caption = "Durum";
            this.GcStatus.FieldName = "Status";
            this.GcStatus.Name = "GcStatus";
            this.GcStatus.Visible = true;
            this.GcStatus.VisibleIndex = 4;
            this.GcStatus.Width = 73;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.tabPane1);
            this.groupControl1.Controls.Add(this.groupControl3);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(323, 622);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Bilgiler";
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Controls.Add(this.tabNavigationPage3);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Location = new System.Drawing.Point(2, 20);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2,
            this.tabNavigationPage3});
            this.tabPane1.RegularSize = new System.Drawing.Size(319, 362);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(319, 362);
            this.tabPane1.TabIndex = 12;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Arama";
            this.tabNavigationPage1.Controls.Add(this.BtnSearch);
            this.tabNavigationPage1.Controls.Add(this.TxtSearchNo);
            this.tabNavigationPage1.Controls.Add(this.label5);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(301, 317);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSearch.Appearance.Options.UseFont = true;
            this.BtnSearch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSearch.ImageOptions.Image")));
            this.BtnSearch.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.BtnSearch.Location = new System.Drawing.Point(12, 145);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(281, 65);
            this.BtnSearch.TabIndex = 12;
            this.BtnSearch.Text = "Arama";
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // TxtSearchNo
            // 
            this.TxtSearchNo.Location = new System.Drawing.Point(51, 72);
            this.TxtSearchNo.Name = "TxtSearchNo";
            this.TxtSearchNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSearchNo.Properties.Appearance.Options.UseFont = true;
            this.TxtSearchNo.Size = new System.Drawing.Size(242, 24);
            this.TxtSearchNo.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(9, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ad : ";
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "Düzenle";
            this.tabNavigationPage2.Controls.Add(this.TxtEditCapasite);
            this.tabNavigationPage2.Controls.Add(this.label7);
            this.tabNavigationPage2.Controls.Add(this.ComEditStatus);
            this.tabNavigationPage2.Controls.Add(this.label3);
            this.tabNavigationPage2.Controls.Add(this.TxtEditNo);
            this.tabNavigationPage2.Controls.Add(this.label1);
            this.tabNavigationPage2.Controls.Add(this.ComEditGroup);
            this.tabNavigationPage2.Controls.Add(this.label2);
            this.tabNavigationPage2.Controls.Add(this.BtnEditSave);
            this.tabNavigationPage2.Controls.Add(this.BtnEdit);
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(301, 317);
            // 
            // TxtEditCapasite
            // 
            this.TxtEditCapasite.Location = new System.Drawing.Point(81, 74);
            this.TxtEditCapasite.Name = "TxtEditCapasite";
            this.TxtEditCapasite.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtEditCapasite.Properties.Appearance.Options.UseFont = true;
            this.TxtEditCapasite.Size = new System.Drawing.Size(211, 24);
            this.TxtEditCapasite.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(6, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Kapasite : ";
            // 
            // ComEditStatus
            // 
            this.ComEditStatus.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ComEditStatus.FormattingEnabled = true;
            this.ComEditStatus.Location = new System.Drawing.Point(81, 171);
            this.ComEditStatus.Name = "ComEditStatus";
            this.ComEditStatus.Size = new System.Drawing.Size(211, 26);
            this.ComEditStatus.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(16, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Durum : ";
            // 
            // TxtEditNo
            // 
            this.TxtEditNo.Location = new System.Drawing.Point(81, 28);
            this.TxtEditNo.Name = "TxtEditNo";
            this.TxtEditNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtEditNo.Properties.Appearance.Options.UseFont = true;
            this.TxtEditNo.Size = new System.Drawing.Size(211, 24);
            this.TxtEditNo.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(39, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ad : ";
            // 
            // ComEditGroup
            // 
            this.ComEditGroup.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ComEditGroup.FormattingEnabled = true;
            this.ComEditGroup.Location = new System.Drawing.Point(81, 119);
            this.ComEditGroup.Name = "ComEditGroup";
            this.ComEditGroup.Size = new System.Drawing.Size(211, 26);
            this.ComEditGroup.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(27, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Grup : ";
            // 
            // BtnEditSave
            // 
            this.BtnEditSave.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnEditSave.Appearance.Options.UseFont = true;
            this.BtnEditSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnEditSave.ImageOptions.Image")));
            this.BtnEditSave.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.BtnEditSave.Location = new System.Drawing.Point(168, 241);
            this.BtnEditSave.Name = "BtnEditSave";
            this.BtnEditSave.Size = new System.Drawing.Size(128, 65);
            this.BtnEditSave.TabIndex = 12;
            this.BtnEditSave.Text = "Kaydet";
            this.BtnEditSave.Click += new System.EventHandler(this.BtnEditSave_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnEdit.Appearance.Options.UseFont = true;
            this.BtnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnEdit.ImageOptions.Image")));
            this.BtnEdit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.BtnEdit.Location = new System.Drawing.Point(6, 241);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(128, 65);
            this.BtnEdit.TabIndex = 5;
            this.BtnEdit.Text = "Düzenle";
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // tabNavigationPage3
            // 
            this.tabNavigationPage3.Caption = "Sil";
            this.tabNavigationPage3.Controls.Add(this.BtnDelete);
            this.tabNavigationPage3.Name = "tabNavigationPage3";
            this.tabNavigationPage3.Size = new System.Drawing.Size(301, 317);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDelete.Appearance.Options.UseFont = true;
            this.BtnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelete.ImageOptions.Image")));
            this.BtnDelete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.BtnDelete.Location = new System.Drawing.Point(6, 120);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(290, 65);
            this.BtnDelete.TabIndex = 9;
            this.BtnDelete.Text = "Sil";
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.BtnClose);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl3.Location = new System.Drawing.Point(2, 382);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(319, 238);
            this.groupControl3.TabIndex = 11;
            this.groupControl3.Text = "İşlemler";
            // 
            // BtnClose
            // 
            this.BtnClose.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnClose.Appearance.Options.UseFont = true;
            this.BtnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.ImageOptions.Image")));
            this.BtnClose.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.BtnClose.Location = new System.Drawing.Point(18, 47);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(292, 65);
            this.BtnClose.TabIndex = 10;
            this.BtnClose.Text = "Kapat";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // FrmTableList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 622);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmTableList";
            this.Text = "Masa Listesi";
            this.Load += new System.EventHandler(this.FrmTableList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.tabNavigationPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSearchNo.Properties)).EndInit();
            this.tabNavigationPage2.ResumeLayout(false);
            this.tabNavigationPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditCapasite.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditNo.Properties)).EndInit();
            this.tabNavigationPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraEditors.SimpleButton BtnSearch;
        private DevExpress.XtraEditors.TextEdit TxtSearchNo;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private DevExpress.XtraEditors.TextEdit TxtEditNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComEditGroup;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton BtnEditSave;
        private DevExpress.XtraEditors.SimpleButton BtnEdit;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage3;
        private DevExpress.XtraEditors.SimpleButton BtnDelete;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton BtnClose;
        private System.Windows.Forms.ComboBox ComEditStatus;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.Columns.GridColumn GcID;
        private DevExpress.XtraGrid.Columns.GridColumn GcNo;
        private DevExpress.XtraGrid.Columns.GridColumn GcGroup;
        private DevExpress.XtraGrid.Columns.GridColumn GcStatus2;
        private DevExpress.XtraGrid.Columns.GridColumn GcStatus;
        private DevExpress.XtraGrid.Columns.GridColumn GcCapacity;
        private DevExpress.XtraEditors.TextEdit TxtEditCapasite;
        private System.Windows.Forms.Label label7;
    }
}