using DAL.Entities.Employees;
using DAL.Entities.Orders;
using DAL.Entities.Payments;
using DAL.Entities.Plugs;
using DAL.Procedures;
using DevExpress.XtraEditors;
using FrontOffice.Notifications;
using FrontOffice.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace FrontOffice
{
    public partial class FrmMain : DevExpress.XtraEditors.XtraForm
    {
        public static int ID { get; set; }

        public FrmMain()
        {
            InitializeComponent();
            ucLayoutHeaderButton1.label1.Text = "Restaurant Otomasyonu";
        }

        private void tableMenu1_BtnTableToPrevEventClick(object sender, EventArgs e)
        {
            navigationFrame1.SelectedPage = NpTableList;
            tableList1.TableGroupList();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            ucLogin1.UserNameList();
        }

        private void ucLogin1_BtnOkClick(object sender, EventArgs e)
        {
            Employe employe = Model.Db.EmployeRepositories.Get(
                c =>
                c.Username == (string)ucLogin1.ComUsername.SelectedValue
                && c.Password == ucLogin1.TxtKeypedPassword.Text
                && c.Status == 1
                );
            if (employe == null)
            {
                Success.Message("Böyle bir kullanıcı olmaya bilir!");
            }
            else
            {
                ucLogin1.TxtKeypedPassword.Text = "";
                ucLogin1.UserNameList();
                ucLayoutHeaderButton1.BtnBackOrExitObject.ImageOptions.ImageIndex = 0;

                Success.Message("Tebrikler\nBaşarıyla giriş yaptınız.");


                ID = employe.ID;
                navigationFrame1.SelectNextPage();
            }
        }

        private void BtnBackOrExit(object sender, EventArgs e)
        {
            if (navigationFrame1.SelectedPage == NpLogin)
            {
                Close();
            }
            else
            {
                navigationFrame1.SelectPrevPage();
            }
        }

        private void navigationFrame1_SelectedPageChanged(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs e)
        {
            if (navigationFrame1.SelectedPage == NpLogin)
            {
                ucLayoutHeaderButton1.BtnBackOrExitObject.ImageOptions.ImageIndex = 1;
            }
            else
            {
                ucLayoutHeaderButton1.BtnBackOrExitObject.ImageOptions.ImageIndex = 0;
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Helpers.ConfirimOkCancel("Program dan çıkmak istediğinizden eminmisiniz?", "BİLDİRİM") == DialogResult.OK)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void ucMainMenu1_BtnTableOpenEventClick(object sender, EventArgs e)
        {
            navigationFrame1.SelectedPage = NpTableList;
            tableList1.TableGroupList();
        }

        private void tableList1_BtnTableEventClick(object sender, EventArgs e)
        {
            Tables.BtnTableList btn = (Tables.BtnTableList)sender;
            tableMenu1.TableID = btn.ID;
            if (btn.PlugID > 0)
            {
                tableMenu1.Plug.ID = btn.PlugID;
                navigationFrame1.SelectedPage = NpTableMenu;
            }
            else
            {
                tableMenu1.Plug = new DAL.Entities.Plugs.Plug()
                {
                    AddDate = DateTime.Now,
                    SessionMovementLoginID = ID,
                    TableID = tableMenu1.TableID
                };
                navigationFrame1.SelectedPage = NpTableMenu;
            }
        }


        private void tableMenu1_BtnKitchenEventClick(object sender, EventArgs e)
        {
            ucKitchen1.Plug = tableMenu1.Plug;
            ucKitchen1.Run();          
            navigationFrame1.SelectedPage = NpKitchenMain;
        }


    }
}
