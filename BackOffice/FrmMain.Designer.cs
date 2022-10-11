namespace BackOffice
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.BtnItemTableAdd = new DevExpress.XtraBars.BarButtonItem();
            this.BtnItemTableList = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.BtnItemTableGroupAdd = new DevExpress.XtraBars.BarButtonItem();
            this.BtnItemTableGroupList = new DevExpress.XtraBars.BarButtonItem();
            this.BtnItemProductAdd = new DevExpress.XtraBars.BarButtonItem();
            this.BtnItemProductGroupAdd = new DevExpress.XtraBars.BarButtonItem();
            this.BtnItemProductGroupList = new DevExpress.XtraBars.BarButtonItem();
            this.BtnItemProductList = new DevExpress.XtraBars.BarButtonItem();
            this.BtnItemEmployeAdd = new DevExpress.XtraBars.BarButtonItem();
            this.BtnItemEmployeList = new DevExpress.XtraBars.BarButtonItem();
            this.BtnCustomerAdd = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.BtnCustomerList = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barButtonItem1,
            this.BtnItemTableAdd,
            this.BtnItemTableList,
            this.barButtonItem4,
            this.BtnItemTableGroupAdd,
            this.BtnItemTableGroupList,
            this.BtnItemProductAdd,
            this.BtnItemProductGroupAdd,
            this.BtnItemProductGroupList,
            this.BtnItemProductList,
            this.BtnItemEmployeAdd,
            this.BtnItemEmployeList,
            this.BtnCustomerAdd,
            this.BtnCustomerList});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 15;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage2,
            this.ribbonPage3,
            this.ribbonPage1,
            this.ribbonPage4});
            this.ribbon.Size = new System.Drawing.Size(1059, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // BtnItemTableAdd
            // 
            this.BtnItemTableAdd.Caption = "Masa Ekle";
            this.BtnItemTableAdd.Id = 2;
            this.BtnItemTableAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnItemTableAdd.ImageOptions.Image")));
            this.BtnItemTableAdd.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnItemTableAdd.ImageOptions.LargeImage")));
            this.BtnItemTableAdd.Name = "BtnItemTableAdd";
            this.BtnItemTableAdd.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.BtnItemTableAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnItemTableAdd_ItemClick);
            // 
            // BtnItemTableList
            // 
            this.BtnItemTableList.Caption = "Masa Listele";
            this.BtnItemTableList.Id = 3;
            this.BtnItemTableList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnItemTableList.ImageOptions.Image")));
            this.BtnItemTableList.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnItemTableList.ImageOptions.LargeImage")));
            this.BtnItemTableList.Name = "BtnItemTableList";
            this.BtnItemTableList.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.BtnItemTableList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnItemTableList_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "barButtonItem4";
            this.barButtonItem4.Id = 4;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // BtnItemTableGroupAdd
            // 
            this.BtnItemTableGroupAdd.Caption = "Masa Grubu Ekle";
            this.BtnItemTableGroupAdd.Id = 5;
            this.BtnItemTableGroupAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnItemTableGroupAdd.ImageOptions.Image")));
            this.BtnItemTableGroupAdd.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnItemTableGroupAdd.ImageOptions.LargeImage")));
            this.BtnItemTableGroupAdd.Name = "BtnItemTableGroupAdd";
            this.BtnItemTableGroupAdd.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.BtnItemTableGroupAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnItemTableGroupAdd_ItemClick);
            // 
            // BtnItemTableGroupList
            // 
            this.BtnItemTableGroupList.Caption = "Masa Grubu Listele";
            this.BtnItemTableGroupList.Id = 6;
            this.BtnItemTableGroupList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnItemTableGroupList.ImageOptions.Image")));
            this.BtnItemTableGroupList.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnItemTableGroupList.ImageOptions.LargeImage")));
            this.BtnItemTableGroupList.Name = "BtnItemTableGroupList";
            this.BtnItemTableGroupList.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.BtnItemTableGroupList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnItemTableGroupList_ItemClick);
            // 
            // BtnItemProductAdd
            // 
            this.BtnItemProductAdd.Caption = "Ürün Ekle";
            this.BtnItemProductAdd.Id = 7;
            this.BtnItemProductAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnItemProductAdd.ImageOptions.Image")));
            this.BtnItemProductAdd.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnItemProductAdd.ImageOptions.LargeImage")));
            this.BtnItemProductAdd.Name = "BtnItemProductAdd";
            this.BtnItemProductAdd.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.BtnItemProductAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnItemProductAdd_ItemClick);
            // 
            // BtnItemProductGroupAdd
            // 
            this.BtnItemProductGroupAdd.Caption = "Ürün Grubu Ekle";
            this.BtnItemProductGroupAdd.Id = 8;
            this.BtnItemProductGroupAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnItemProductGroupAdd.ImageOptions.Image")));
            this.BtnItemProductGroupAdd.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnItemProductGroupAdd.ImageOptions.LargeImage")));
            this.BtnItemProductGroupAdd.Name = "BtnItemProductGroupAdd";
            this.BtnItemProductGroupAdd.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.BtnItemProductGroupAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnItemProductGroupAdd_ItemClick);
            // 
            // BtnItemProductGroupList
            // 
            this.BtnItemProductGroupList.Caption = "Ürün Grup Listesi";
            this.BtnItemProductGroupList.Id = 9;
            this.BtnItemProductGroupList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnItemProductGroupList.ImageOptions.Image")));
            this.BtnItemProductGroupList.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnItemProductGroupList.ImageOptions.LargeImage")));
            this.BtnItemProductGroupList.Name = "BtnItemProductGroupList";
            this.BtnItemProductGroupList.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.BtnItemProductGroupList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnItemProductGroupList_ItemClick);
            // 
            // BtnItemProductList
            // 
            this.BtnItemProductList.Caption = "Ürün Listesi";
            this.BtnItemProductList.Id = 10;
            this.BtnItemProductList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnItemProductList.ImageOptions.Image")));
            this.BtnItemProductList.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnItemProductList.ImageOptions.LargeImage")));
            this.BtnItemProductList.Name = "BtnItemProductList";
            this.BtnItemProductList.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.BtnItemProductList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnItemProductList_ItemClick);
            // 
            // BtnItemEmployeAdd
            // 
            this.BtnItemEmployeAdd.Caption = "Çalışan Ekle";
            this.BtnItemEmployeAdd.Id = 11;
            this.BtnItemEmployeAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnItemEmployeAdd.ImageOptions.Image")));
            this.BtnItemEmployeAdd.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnItemEmployeAdd.ImageOptions.LargeImage")));
            this.BtnItemEmployeAdd.Name = "BtnItemEmployeAdd";
            this.BtnItemEmployeAdd.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.BtnItemEmployeAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnItemEmployeAdd_ItemClick);
            // 
            // BtnItemEmployeList
            // 
            this.BtnItemEmployeList.Caption = "Çalışan Listesi";
            this.BtnItemEmployeList.Id = 12;
            this.BtnItemEmployeList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnItemEmployeList.ImageOptions.Image")));
            this.BtnItemEmployeList.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnItemEmployeList.ImageOptions.LargeImage")));
            this.BtnItemEmployeList.Name = "BtnItemEmployeList";
            this.BtnItemEmployeList.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.BtnItemEmployeList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnItemEmployeList_ItemClick);
            // 
            // BtnCustomerAdd
            // 
            this.BtnCustomerAdd.Caption = "Müşteri Ekle";
            this.BtnCustomerAdd.Id = 13;
            this.BtnCustomerAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnCustomerAdd.ImageOptions.Image")));
            this.BtnCustomerAdd.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnCustomerAdd.ImageOptions.LargeImage")));
            this.BtnCustomerAdd.Name = "BtnCustomerAdd";
            this.BtnCustomerAdd.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.BtnCustomerAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnCustomerAdd_ItemClick);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup4});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Ürünler";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnItemProductAdd);
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnItemProductList);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Ürünler";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.BtnItemProductGroupAdd);
            this.ribbonPageGroup4.ItemLinks.Add(this.BtnItemProductGroupList);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Kategoriler ";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Çalışanlar";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.BtnItemEmployeAdd);
            this.ribbonPageGroup5.ItemLinks.Add(this.BtnItemEmployeList);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "  Çalışanlar ";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Masalar";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnItemTableAdd);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnItemTableList);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Masa Ekle Düzenle";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.BtnItemTableGroupAdd);
            this.ribbonPageGroup3.ItemLinks.Add(this.BtnItemTableGroupList);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Masa Grupları";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6});
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Müşteriler";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.BtnCustomerAdd);
            this.ribbonPageGroup6.ItemLinks.Add(this.BtnCustomerList);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = " Müşteriler ";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 600);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1059, 31);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // BtnCustomerList
            // 
            this.BtnCustomerList.Caption = " Müşteri Listesi ";
            this.BtnCustomerList.Id = 14;
            this.BtnCustomerList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.BtnCustomerList.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.BtnCustomerList.Name = "BtnCustomerList";
            this.BtnCustomerList.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.BtnCustomerList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnCustomerList_ItemClick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 631);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "FrmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem BtnItemTableAdd;
        private DevExpress.XtraBars.BarButtonItem BtnItemTableList;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem BtnItemTableGroupAdd;
        private DevExpress.XtraBars.BarButtonItem BtnItemTableGroupList;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem BtnItemProductAdd;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem BtnItemProductGroupAdd;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem BtnItemProductGroupList;
        private DevExpress.XtraBars.BarButtonItem BtnItemProductList;
        private DevExpress.XtraBars.BarButtonItem BtnItemEmployeAdd;
        private DevExpress.XtraBars.BarButtonItem BtnItemEmployeList;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem BtnCustomerAdd;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem BtnCustomerList;
    }
}