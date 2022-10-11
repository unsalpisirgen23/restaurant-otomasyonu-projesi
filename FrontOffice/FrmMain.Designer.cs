namespace FrontOffice
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
            this.navigationFrame1 = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.NpLogin = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.ucLogin1 = new FrontOffice.Login.UcLogin();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.ucMainMenu1 = new FrontOffice.MainMenu.UcMainMenu();
            this.NpTableList = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.tableList1 = new FrontOffice.Tables.TableList();
            this.NpTableMenu = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.tableMenu1 = new FrontOffice.Tables.TableMenu();
            this.NpKitchenMain = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.ucKitchen1 = new FrontOffice.Kitchens.UcKitchen();
            this.ucLayoutHeaderButton1 = new FrontOffice.Layout.UcLayoutHeaderButton();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).BeginInit();
            this.navigationFrame1.SuspendLayout();
            this.NpLogin.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            this.NpTableList.SuspendLayout();
            this.NpTableMenu.SuspendLayout();
            this.NpKitchenMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationFrame1
            // 
            this.navigationFrame1.Appearance.BackColor = System.Drawing.Color.Gray;
            this.navigationFrame1.Appearance.Options.UseBackColor = true;
            this.navigationFrame1.Controls.Add(this.NpLogin);
            this.navigationFrame1.Controls.Add(this.navigationPage1);
            this.navigationFrame1.Controls.Add(this.NpTableList);
            this.navigationFrame1.Controls.Add(this.NpTableMenu);
            this.navigationFrame1.Controls.Add(this.NpKitchenMain);
            this.navigationFrame1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame1.Location = new System.Drawing.Point(0, 39);
            this.navigationFrame1.Name = "navigationFrame1";
            this.navigationFrame1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.NpLogin,
            this.navigationPage1,
            this.NpTableList,
            this.NpTableMenu,
            this.NpKitchenMain});
            this.navigationFrame1.SelectedPage = this.NpLogin;
            this.navigationFrame1.Size = new System.Drawing.Size(1291, 755);
            this.navigationFrame1.TabIndex = 0;
            this.navigationFrame1.Text = "navigationFrame1";
            this.navigationFrame1.SelectedPageChanged += new DevExpress.XtraBars.Navigation.SelectedPageChangedEventHandler(this.navigationFrame1_SelectedPageChanged);
            // 
            // NpLogin
            // 
            this.NpLogin.Caption = "NpLogin";
            this.NpLogin.Controls.Add(this.ucLogin1);
            this.NpLogin.Name = "NpLogin";
            this.NpLogin.Size = new System.Drawing.Size(1291, 755);
            // 
            // ucLogin1
            // 
            this.ucLogin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucLogin1.Location = new System.Drawing.Point(0, 0);
            this.ucLogin1.LoginID = 0;
            this.ucLogin1.Name = "ucLogin1";
            this.ucLogin1.Size = new System.Drawing.Size(1291, 755);
            this.ucLogin1.TabIndex = 1;
            this.ucLogin1.BtnOkClick += new System.EventHandler(this.ucLogin1_BtnOkClick);
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "navigationPage1";
            this.navigationPage1.Controls.Add(this.ucMainMenu1);
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(1291, 755);
            // 
            // ucMainMenu1
            // 
            this.ucMainMenu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucMainMenu1.Location = new System.Drawing.Point(0, 0);
            this.ucMainMenu1.Name = "ucMainMenu1";
            this.ucMainMenu1.Size = new System.Drawing.Size(1291, 755);
            this.ucMainMenu1.TabIndex = 0;
            this.ucMainMenu1.BtnTableOpenEventClick += new System.EventHandler(this.ucMainMenu1_BtnTableOpenEventClick);
            // 
            // NpTableList
            // 
            this.NpTableList.Caption = "NpTableList";
            this.NpTableList.Controls.Add(this.tableList1);
            this.NpTableList.Name = "NpTableList";
            this.NpTableList.Size = new System.Drawing.Size(1291, 755);
            // 
            // tableList1
            // 
            this.tableList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableList1.Location = new System.Drawing.Point(0, 0);
            this.tableList1.Name = "tableList1";
            this.tableList1.Size = new System.Drawing.Size(1291, 755);
            this.tableList1.TabIndex = 0;
            this.tableList1.BtnTableEventClick += new System.EventHandler(this.tableList1_BtnTableEventClick);
            // 
            // NpTableMenu
            // 
            this.NpTableMenu.Caption = "NpTableMenu";
            this.NpTableMenu.Controls.Add(this.tableMenu1);
            this.NpTableMenu.Name = "NpTableMenu";
            this.NpTableMenu.Size = new System.Drawing.Size(1291, 755);
            // 
            // tableMenu1
            // 
            this.tableMenu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMenu1.Location = new System.Drawing.Point(0, 0);
            this.tableMenu1.Name = "tableMenu1";
            this.tableMenu1.Size = new System.Drawing.Size(1291, 755);
            this.tableMenu1.TabIndex = 0;
            this.tableMenu1.TableID = 0;
            this.tableMenu1.BtnKitchenEventClick += new System.EventHandler(this.tableMenu1_BtnKitchenEventClick);
            this.tableMenu1.BtnTableToPrevEventClick += new System.EventHandler(this.tableMenu1_BtnTableToPrevEventClick);
            // 
            // NpKitchenMain
            // 
            this.NpKitchenMain.Caption = "NpKitchenMain";
            this.NpKitchenMain.Controls.Add(this.ucKitchen1);
            this.NpKitchenMain.Name = "NpKitchenMain";
            this.NpKitchenMain.Size = new System.Drawing.Size(1291, 755);
            // 
            // ucKitchen1
            // 
            this.ucKitchen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucKitchen1.Location = new System.Drawing.Point(0, 0);
            this.ucKitchen1.Name = "ucKitchen1";
            this.ucKitchen1.ProductID = 0;
            this.ucKitchen1.Size = new System.Drawing.Size(1291, 755);
            this.ucKitchen1.TabIndex = 0;
            this.ucKitchen1.TableID = 0;
            // 
            // ucLayoutHeaderButton1
            // 
            this.ucLayoutHeaderButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucLayoutHeaderButton1.HeaderLabel = "label1";
            this.ucLayoutHeaderButton1.Location = new System.Drawing.Point(0, 0);
            this.ucLayoutHeaderButton1.Name = "ucLayoutHeaderButton1";
            this.ucLayoutHeaderButton1.Size = new System.Drawing.Size(1291, 39);
            this.ucLayoutHeaderButton1.TabIndex = 1;
            this.ucLayoutHeaderButton1.BtnBackOrExit += new System.EventHandler(this.BtnBackOrExit);
            // 
            // FrmMain
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 794);
            this.Controls.Add(this.navigationFrame1);
            this.Controls.Add(this.ucLayoutHeaderButton1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).EndInit();
            this.navigationFrame1.ResumeLayout(false);
            this.NpLogin.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            this.NpTableList.ResumeLayout(false);
            this.NpTableMenu.ResumeLayout(false);
            this.NpKitchenMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame1;
        private DevExpress.XtraBars.Navigation.NavigationPage NpLogin;
        private Login.UcLogin ucLogin1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private Layout.UcLayoutHeaderButton ucLayoutHeaderButton1;
        private DevExpress.XtraBars.Navigation.NavigationPage NpTableList;
        private MainMenu.UcMainMenu ucMainMenu1;
        private Tables.TableList tableList1;
        private DevExpress.XtraBars.Navigation.NavigationPage NpTableMenu;
        private Tables.TableMenu tableMenu1;
        private DevExpress.XtraBars.Navigation.NavigationPage NpKitchenMain;
        private Kitchens.UcKitchen ucKitchen1;
    }
}

