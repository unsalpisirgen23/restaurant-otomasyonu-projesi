namespace BackOffice.Forms.Tables
{
    partial class FrmTableGroupList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTableGroupList));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.GcID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GcName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GcStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GcStatus2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.TxtSearchName = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.BtnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.tabNavigationPage3 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.BtnClose = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.BtnEditSave = new DevExpress.XtraEditors.SimpleButton();
            this.TxtEditName = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.ComEditStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSearchName.Properties)).BeginInit();
            this.tabNavigationPage2.SuspendLayout();
            this.tabNavigationPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GcID,
            this.GcName,
            this.GcStatus,
            this.GcStatus2});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowGroup = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 20);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(773, 606);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(323, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(777, 628);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Listeleme";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.BtnClose);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl3.Location = new System.Drawing.Point(2, 297);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(319, 329);
            this.groupControl3.TabIndex = 11;
            this.groupControl3.Text = "İşlemler";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.tabPane1);
            this.groupControl1.Controls.Add(this.groupControl3);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(323, 628);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Bilgiler";
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
            this.GcName.OptionsColumn.AllowEdit = false;
            this.GcName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.GcName.OptionsColumn.ReadOnly = true;
            this.GcName.Visible = true;
            this.GcName.VisibleIndex = 0;
            this.GcName.Width = 641;
            // 
            // GcStatus
            // 
            this.GcStatus.Caption = "Durum";
            this.GcStatus.FieldName = "Status";
            this.GcStatus.Name = "GcStatus";
            this.GcStatus.Visible = true;
            this.GcStatus.VisibleIndex = 1;
            this.GcStatus.Width = 67;
            // 
            // GcStatus2
            // 
            this.GcStatus2.Caption = "DURUM";
            this.GcStatus2.FieldName = "Status2";
            this.GcStatus2.Name = "GcStatus2";
            this.GcStatus2.OptionsColumn.AllowEdit = false;
            this.GcStatus2.OptionsColumn.AllowFocus = false;
            this.GcStatus2.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.GcStatus2.OptionsColumn.ReadOnly = true;
            this.GcStatus2.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.GcStatus2.Visible = true;
            this.GcStatus2.VisibleIndex = 2;
            this.GcStatus2.Width = 49;
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
            this.tabPane1.RegularSize = new System.Drawing.Size(319, 277);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(319, 277);
            this.tabPane1.TabIndex = 12;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Arama";
            this.tabNavigationPage1.Controls.Add(this.BtnSearch);
            this.tabNavigationPage1.Controls.Add(this.TxtSearchName);
            this.tabNavigationPage1.Controls.Add(this.label5);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(301, 232);
            // 
            // TxtSearchName
            // 
            this.TxtSearchName.Location = new System.Drawing.Point(49, 57);
            this.TxtSearchName.Name = "TxtSearchName";
            this.TxtSearchName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSearchName.Properties.Appearance.Options.UseFont = true;
            this.TxtSearchName.Size = new System.Drawing.Size(244, 24);
            this.TxtSearchName.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(7, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ad : ";
            // 
            // BtnSearch
            // 
            this.BtnSearch.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSearch.Appearance.Options.UseFont = true;
            this.BtnSearch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSearch.ImageOptions.Image")));
            this.BtnSearch.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.BtnSearch.Location = new System.Drawing.Point(12, 155);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(281, 65);
            this.BtnSearch.TabIndex = 12;
            this.BtnSearch.Text = "Arama";
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click_1);
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "Düzenle";
            this.tabNavigationPage2.Controls.Add(this.TxtEditName);
            this.tabNavigationPage2.Controls.Add(this.label1);
            this.tabNavigationPage2.Controls.Add(this.ComEditStatus);
            this.tabNavigationPage2.Controls.Add(this.label2);
            this.tabNavigationPage2.Controls.Add(this.BtnEditSave);
            this.tabNavigationPage2.Controls.Add(this.BtnEdit);
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(301, 232);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnEdit.Appearance.Options.UseFont = true;
            this.BtnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnEdit.ImageOptions.Image")));
            this.BtnEdit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.BtnEdit.Location = new System.Drawing.Point(8, 161);
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
            this.tabNavigationPage3.Size = new System.Drawing.Size(301, 232);
            // 
            // BtnClose
            // 
            this.BtnClose.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnClose.Appearance.Options.UseFont = true;
            this.BtnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.ImageOptions.Image")));
            this.BtnClose.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.BtnClose.Location = new System.Drawing.Point(13, 253);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(292, 65);
            this.BtnClose.TabIndex = 10;
            this.BtnClose.Text = "Kapat";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDelete.Appearance.Options.UseFont = true;
            this.BtnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelete.ImageOptions.Image")));
            this.BtnDelete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.BtnDelete.Location = new System.Drawing.Point(6, 75);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(290, 65);
            this.BtnDelete.TabIndex = 9;
            this.BtnDelete.Text = "Sil";
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnEditSave
            // 
            this.BtnEditSave.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnEditSave.Appearance.Options.UseFont = true;
            this.BtnEditSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.BtnEditSave.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.BtnEditSave.Location = new System.Drawing.Point(170, 161);
            this.BtnEditSave.Name = "BtnEditSave";
            this.BtnEditSave.Size = new System.Drawing.Size(128, 65);
            this.BtnEditSave.TabIndex = 12;
            this.BtnEditSave.Text = "Kaydet";
            this.BtnEditSave.Click += new System.EventHandler(this.BtnEditSave_Click);
            // 
            // TxtEditName
            // 
            this.TxtEditName.Location = new System.Drawing.Point(73, 28);
            this.TxtEditName.Name = "TxtEditName";
            this.TxtEditName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtEditName.Properties.Appearance.Options.UseFont = true;
            this.TxtEditName.Size = new System.Drawing.Size(219, 24);
            this.TxtEditName.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(31, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ad : ";
            // 
            // ComEditStatus
            // 
            this.ComEditStatus.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ComEditStatus.FormattingEnabled = true;
            this.ComEditStatus.Location = new System.Drawing.Point(73, 80);
            this.ComEditStatus.Name = "ComEditStatus";
            this.ComEditStatus.Size = new System.Drawing.Size(219, 26);
            this.ComEditStatus.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(8, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Durum : ";
            // 
            // FrmTableGroupList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 628);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmTableGroupList";
            this.Text = "Masa Grup Listesi";
            this.Load += new System.EventHandler(this.FrmTableGroupList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.tabNavigationPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSearchName.Properties)).EndInit();
            this.tabNavigationPage2.ResumeLayout(false);
            this.tabNavigationPage2.PerformLayout();
            this.tabNavigationPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.Columns.GridColumn GcID;
        private DevExpress.XtraGrid.Columns.GridColumn GcName;
        private DevExpress.XtraGrid.Columns.GridColumn GcStatus;
        private DevExpress.XtraGrid.Columns.GridColumn GcStatus2;
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraEditors.SimpleButton BtnSearch;
        private DevExpress.XtraEditors.TextEdit TxtSearchName;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton BtnClose;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private DevExpress.XtraEditors.SimpleButton BtnEditSave;
        private DevExpress.XtraEditors.SimpleButton BtnEdit;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage3;
        private DevExpress.XtraEditors.SimpleButton BtnDelete;
        private DevExpress.XtraEditors.TextEdit TxtEditName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComEditStatus;
        private System.Windows.Forms.Label label2;
    }
}