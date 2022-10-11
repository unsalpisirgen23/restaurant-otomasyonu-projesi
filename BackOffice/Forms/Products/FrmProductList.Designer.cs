namespace BackOffice.Forms.Products
{
    partial class FrmProductList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductList));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.TxtEditName = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnClose = new DevExpress.XtraEditors.SimpleButton();
            this.BtnClear = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GcID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GcName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GcPicture = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GcPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GcProductGroupName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GcStatus2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GcStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GcEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.GcDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.TxtEditName);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.BtnClose);
            this.groupControl1.Controls.Add(this.BtnClear);
            this.groupControl1.Controls.Add(this.BtnSearch);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1222, 59);
            this.groupControl1.TabIndex = 0;
            // 
            // TxtEditName
            // 
            this.TxtEditName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtEditName.Location = new System.Drawing.Point(62, 22);
            this.TxtEditName.Margin = new System.Windows.Forms.Padding(7);
            this.TxtEditName.Name = "TxtEditName";
            this.TxtEditName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtEditName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtEditName.Properties.Appearance.Options.UseFont = true;
            this.TxtEditName.Properties.Appearance.Options.UseForeColor = true;
            this.TxtEditName.Size = new System.Drawing.Size(823, 32);
            this.TxtEditName.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(8, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 43;
            this.label1.Text = "Adı : ";
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnClose.Appearance.Options.UseFont = true;
            this.BtnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.BtnClose.Location = new System.Drawing.Point(1120, 23);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(94, 31);
            this.BtnClose.TabIndex = 40;
            this.BtnClose.Text = "Kapat";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClear.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnClear.Appearance.Options.UseFont = true;
            this.BtnClear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.BtnClear.Location = new System.Drawing.Point(1000, 23);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(101, 31);
            this.BtnClear.TabIndex = 39;
            this.BtnClear.Text = "Temizle";
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSearch.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSearch.Appearance.Options.UseFont = true;
            this.BtnSearch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.BtnSearch.Location = new System.Drawing.Point(895, 23);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(87, 29);
            this.BtnSearch.TabIndex = 38;
            this.BtnSearch.Text = "Ara";
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl2);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 59);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1222, 489);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Listeleme";
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(2, 20);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnDelete,
            this.btnEdit});
            this.gridControl2.Size = new System.Drawing.Size(1218, 467);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GcID,
            this.GcName,
            this.GcPicture,
            this.GcPrice,
            this.GcProductGroupName,
            this.GcStatus2,
            this.GcStatus,
            this.GcEdit,
            this.GcDelete});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsCustomization.AllowGroup = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.RowHeight = 80;
            // 
            // GcID
            // 
            this.GcID.Caption = "ID";
            this.GcID.FieldName = "ID";
            this.GcID.Name = "GcID";
            this.GcID.OptionsColumn.AllowEdit = false;
            this.GcID.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.GcID.OptionsColumn.ReadOnly = true;
            // 
            // GcName
            // 
            this.GcName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.GcName.AppearanceCell.Options.UseFont = true;
            this.GcName.Caption = "AD";
            this.GcName.FieldName = "Name";
            this.GcName.Name = "GcName";
            this.GcName.OptionsColumn.AllowEdit = false;
            this.GcName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.GcName.OptionsColumn.ReadOnly = true;
            this.GcName.Visible = true;
            this.GcName.VisibleIndex = 0;
            this.GcName.Width = 216;
            // 
            // GcPicture
            // 
            this.GcPicture.Caption = "RESİM";
            this.GcPicture.FieldName = "Picture";
            this.GcPicture.MaxWidth = 105;
            this.GcPicture.MinWidth = 105;
            this.GcPicture.Name = "GcPicture";
            this.GcPicture.OptionsColumn.AllowEdit = false;
            this.GcPicture.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.GcPicture.OptionsColumn.ReadOnly = true;
            this.GcPicture.Visible = true;
            this.GcPicture.VisibleIndex = 1;
            this.GcPicture.Width = 105;
            // 
            // GcPrice
            // 
            this.GcPrice.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.GcPrice.AppearanceCell.Options.UseFont = true;
            this.GcPrice.Caption = "FİYAT";
            this.GcPrice.FieldName = "Price";
            this.GcPrice.Name = "GcPrice";
            this.GcPrice.OptionsColumn.AllowEdit = false;
            this.GcPrice.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.GcPrice.OptionsColumn.ReadOnly = true;
            this.GcPrice.Visible = true;
            this.GcPrice.VisibleIndex = 2;
            this.GcPrice.Width = 73;
            // 
            // GcProductGroupName
            // 
            this.GcProductGroupName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.GcProductGroupName.AppearanceCell.Options.UseFont = true;
            this.GcProductGroupName.Caption = "GRUP ADI";
            this.GcProductGroupName.FieldName = "ProductGroup.Name";
            this.GcProductGroupName.Name = "GcProductGroupName";
            this.GcProductGroupName.OptionsColumn.AllowEdit = false;
            this.GcProductGroupName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.GcProductGroupName.OptionsColumn.ReadOnly = true;
            this.GcProductGroupName.Visible = true;
            this.GcProductGroupName.VisibleIndex = 3;
            this.GcProductGroupName.Width = 93;
            // 
            // GcStatus2
            // 
            this.GcStatus2.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.GcStatus2.AppearanceCell.Options.UseFont = true;
            this.GcStatus2.Caption = "DURUM";
            this.GcStatus2.FieldName = "Status2";
            this.GcStatus2.Name = "GcStatus2";
            this.GcStatus2.OptionsColumn.AllowEdit = false;
            this.GcStatus2.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.GcStatus2.OptionsColumn.ReadOnly = true;
            this.GcStatus2.Visible = true;
            this.GcStatus2.VisibleIndex = 4;
            this.GcStatus2.Width = 39;
            // 
            // GcStatus
            // 
            this.GcStatus.Caption = "DURUM";
            this.GcStatus.FieldName = "Status";
            this.GcStatus.Name = "GcStatus";
            this.GcStatus.OptionsColumn.AllowEdit = false;
            this.GcStatus.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.GcStatus.OptionsColumn.ReadOnly = true;
            this.GcStatus.Visible = true;
            this.GcStatus.VisibleIndex = 5;
            this.GcStatus.Width = 41;
            // 
            // GcEdit
            // 
            this.GcEdit.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GcEdit.AppearanceHeader.Options.UseFont = true;
            this.GcEdit.AppearanceHeader.Options.UseTextOptions = true;
            this.GcEdit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GcEdit.Caption = "DÜZENLEME";
            this.GcEdit.ColumnEdit = this.btnEdit;
            this.GcEdit.FieldName = "Edit";
            this.GcEdit.MaxWidth = 78;
            this.GcEdit.MinWidth = 78;
            this.GcEdit.Name = "GcEdit";
            this.GcEdit.Visible = true;
            this.GcEdit.VisibleIndex = 7;
            this.GcEdit.Width = 78;
            // 
            // btnEdit
            // 
            this.btnEdit.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions1, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnEdit.DoubleClick += new System.EventHandler(this.btnEdit_DoubleClick);
            // 
            // GcDelete
            // 
            this.GcDelete.AppearanceHeader.Options.UseTextOptions = true;
            this.GcDelete.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GcDelete.Caption = "SİLME";
            this.GcDelete.ColumnEdit = this.btnDelete;
            this.GcDelete.FieldName = "Delete";
            this.GcDelete.MaxWidth = 70;
            this.GcDelete.MinWidth = 70;
            this.GcDelete.Name = "GcDelete";
            this.GcDelete.Visible = true;
            this.GcDelete.VisibleIndex = 6;
            this.GcDelete.Width = 70;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.btnDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions2, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnDelete.DoubleClick += new System.EventHandler(this.btnDelete_DoubleClick);
            // 
            // FrmProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 548);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmProductList";
            this.Text = "FrmProductList";
            this.Load += new System.EventHandler(this.FrmProductList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn GcID;
        private DevExpress.XtraGrid.Columns.GridColumn GcName;
        private DevExpress.XtraGrid.Columns.GridColumn GcPicture;
        private DevExpress.XtraGrid.Columns.GridColumn GcPrice;
        private DevExpress.XtraGrid.Columns.GridColumn GcProductGroupName;
        private DevExpress.XtraGrid.Columns.GridColumn GcStatus2;
        private DevExpress.XtraGrid.Columns.GridColumn GcStatus;
        private DevExpress.XtraGrid.Columns.GridColumn GcDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDelete;
        private DevExpress.XtraGrid.Columns.GridColumn GcEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEdit;
        private DevExpress.XtraEditors.SimpleButton BtnClear;
        private DevExpress.XtraEditors.SimpleButton BtnSearch;
        private DevExpress.XtraEditors.SimpleButton BtnClose;
        private DevExpress.XtraEditors.TextEdit TxtEditName;
        private System.Windows.Forms.Label label1;
    }
}