namespace BackOffice.Forms.Products
{
    partial class FrmProductGroupList
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
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GcID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GcPicture = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GcName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GcStatus2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GcStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.BtnClose = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.BtnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.TxtSearchName = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.BtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtEditName = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ComStatus = new System.Windows.Forms.ComboBox();
            this.tabNavigationPage3 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSearchName.Properties)).BeginInit();
            this.tabNavigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditName.Properties)).BeginInit();
            this.tabNavigationPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GcID,
            this.GcPicture,
            this.GcName,
            this.GcStatus2,
            this.GcStatus});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.GroupRowHeight = 60;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsCustomization.AllowGroup = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.RowHeight = 75;
            // 
            // GcID
            // 
            this.GcID.Caption = "ID";
            this.GcID.FieldName = "ID";
            this.GcID.Name = "GcID";
            // 
            // GcPicture
            // 
            this.GcPicture.Caption = "RESİM";
            this.GcPicture.FieldName = "Picture";
            this.GcPicture.MaxWidth = 110;
            this.GcPicture.MinWidth = 110;
            this.GcPicture.Name = "GcPicture";
            this.GcPicture.Visible = true;
            this.GcPicture.VisibleIndex = 1;
            this.GcPicture.Width = 110;
            // 
            // GcName
            // 
            this.GcName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GcName.AppearanceCell.Options.UseFont = true;
            this.GcName.Caption = "AD";
            this.GcName.FieldName = "Name";
            this.GcName.Name = "GcName";
            this.GcName.Visible = true;
            this.GcName.VisibleIndex = 0;
            this.GcName.Width = 605;
            // 
            // GcStatus2
            // 
            this.GcStatus2.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GcStatus2.AppearanceCell.Options.UseFont = true;
            this.GcStatus2.Caption = "DURUM";
            this.GcStatus2.FieldName = "Status2";
            this.GcStatus2.MaxWidth = 80;
            this.GcStatus2.MinWidth = 80;
            this.GcStatus2.Name = "GcStatus2";
            this.GcStatus2.Visible = true;
            this.GcStatus2.VisibleIndex = 2;
            this.GcStatus2.Width = 80;
            // 
            // GcStatus
            // 
            this.GcStatus.Caption = "DURUM";
            this.GcStatus.FieldName = "Status";
            this.GcStatus.Name = "GcStatus";
            this.GcStatus.Visible = true;
            this.GcStatus.VisibleIndex = 3;
            this.GcStatus.Width = 82;
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(2, 20);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(722, 607);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl2);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(446, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(726, 629);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Listeleme";
            // 
            // BtnClose
            // 
            this.BtnClose.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnClose.Appearance.Options.UseFont = true;
            this.BtnClose.Location = new System.Drawing.Point(13, 576);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(423, 41);
            this.BtnClose.TabIndex = 4;
            this.BtnClose.Text = "Kapat";
            // 
            // BtnDelete
            // 
            this.BtnDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDelete.Appearance.Options.UseFont = true;
            this.BtnDelete.Location = new System.Drawing.Point(82, 149);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(252, 41);
            this.BtnDelete.TabIndex = 3;
            this.BtnDelete.Text = "Sil";
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnEdit.Appearance.Options.UseFont = true;
            this.BtnEdit.Location = new System.Drawing.Point(85, 343);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(91, 41);
            this.BtnEdit.TabIndex = 2;
            this.BtnEdit.Text = "Düzenle";
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSearch.Appearance.Options.UseFont = true;
            this.BtnSearch.Location = new System.Drawing.Point(74, 200);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(324, 41);
            this.BtnSearch.TabIndex = 1;
            this.BtnSearch.Text = "Arama";
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.tabPane1);
            this.groupControl1.Controls.Add(this.BtnClose);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(446, 629);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Seçenekler";
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Controls.Add(this.tabNavigationPage3);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabPane1.Location = new System.Drawing.Point(2, 20);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2,
            this.tabNavigationPage3});
            this.tabPane1.RegularSize = new System.Drawing.Size(442, 483);
            this.tabPane1.SelectedPage = this.tabNavigationPage2;
            this.tabPane1.Size = new System.Drawing.Size(442, 483);
            this.tabPane1.TabIndex = 39;
            this.tabPane1.Text = "Sil";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Arama";
            this.tabNavigationPage1.Controls.Add(this.TxtSearchName);
            this.tabNavigationPage1.Controls.Add(this.label3);
            this.tabNavigationPage1.Controls.Add(this.BtnSearch);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(424, 438);
            // 
            // TxtSearchName
            // 
            this.TxtSearchName.Location = new System.Drawing.Point(74, 89);
            this.TxtSearchName.Margin = new System.Windows.Forms.Padding(7);
            this.TxtSearchName.Name = "TxtSearchName";
            this.TxtSearchName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSearchName.Properties.Appearance.Options.UseFont = true;
            this.TxtSearchName.Size = new System.Drawing.Size(324, 26);
            this.TxtSearchName.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(27, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 41;
            this.label3.Text = "Adı : ";
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "Düzenle";
            this.tabNavigationPage2.Controls.Add(this.BtnSave);
            this.tabNavigationPage2.Controls.Add(this.groupControl3);
            this.tabNavigationPage2.Controls.Add(this.TxtEditName);
            this.tabNavigationPage2.Controls.Add(this.label2);
            this.tabNavigationPage2.Controls.Add(this.BtnEdit);
            this.tabNavigationPage2.Controls.Add(this.label1);
            this.tabNavigationPage2.Controls.Add(this.ComStatus);
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(424, 438);
            // 
            // BtnSave
            // 
            this.BtnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSave.Appearance.Options.UseFont = true;
            this.BtnSave.Location = new System.Drawing.Point(318, 343);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(91, 41);
            this.BtnSave.TabIndex = 44;
            this.BtnSave.Text = "Kaydet";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.pictureBox1);
            this.groupControl3.Location = new System.Drawing.Point(85, 20);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(168, 135);
            this.groupControl3.TabIndex = 43;
            this.groupControl3.Text = "Resim Seç";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(2, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 113);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TxtEditName
            // 
            this.TxtEditName.Location = new System.Drawing.Point(85, 184);
            this.TxtEditName.Margin = new System.Windows.Forms.Padding(7);
            this.TxtEditName.Name = "TxtEditName";
            this.TxtEditName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtEditName.Properties.Appearance.Options.UseFont = true;
            this.TxtEditName.Size = new System.Drawing.Size(324, 26);
            this.TxtEditName.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(12, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 41;
            this.label2.Text = "Durum : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(38, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 18);
            this.label1.TabIndex = 39;
            this.label1.Text = "Adı : ";
            // 
            // ComStatus
            // 
            this.ComStatus.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ComStatus.FormattingEnabled = true;
            this.ComStatus.Location = new System.Drawing.Point(85, 243);
            this.ComStatus.Name = "ComStatus";
            this.ComStatus.Size = new System.Drawing.Size(324, 27);
            this.ComStatus.TabIndex = 42;
            // 
            // tabNavigationPage3
            // 
            this.tabNavigationPage3.Caption = "Sil";
            this.tabNavigationPage3.Controls.Add(this.BtnDelete);
            this.tabNavigationPage3.Name = "tabNavigationPage3";
            this.tabNavigationPage3.Size = new System.Drawing.Size(424, 438);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmProductGroupList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 629);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmProductGroupList";
            this.Text = "Ürün Grubu Listeleme İşlemi";
            this.Load += new System.EventHandler(this.FrmProductGroupList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.tabNavigationPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSearchName.Properties)).EndInit();
            this.tabNavigationPage2.ResumeLayout(false);
            this.tabNavigationPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditName.Properties)).EndInit();
            this.tabNavigationPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton BtnClose;
        private DevExpress.XtraEditors.SimpleButton BtnDelete;
        private DevExpress.XtraEditors.SimpleButton BtnEdit;
        private DevExpress.XtraEditors.SimpleButton BtnSearch;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComStatus;
        private DevExpress.XtraEditors.TextEdit TxtSearchName;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton BtnSave;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage3;
        private DevExpress.XtraEditors.TextEdit TxtEditName;
        private DevExpress.XtraGrid.Columns.GridColumn GcID;
        private DevExpress.XtraGrid.Columns.GridColumn GcPicture;
        private DevExpress.XtraGrid.Columns.GridColumn GcName;
        private DevExpress.XtraGrid.Columns.GridColumn GcStatus2;
        private DevExpress.XtraGrid.Columns.GridColumn GcStatus;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}