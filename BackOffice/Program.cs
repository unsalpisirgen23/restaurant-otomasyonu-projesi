using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DAL.Entities.Employees;

namespace BackOffice
{
    static class Program
    {
        public static int Login = 0;
        public static Employe LoginEmploye;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");

            LoginEmploye = new Employe() {
                AddDate = DateTime.Now,
                CitizenshipNumber = "gg",
                FullName = "gg",
                Gender = 1,
                ID = 1,
                Name = "gg",
                Password = "fff",
                Surname = "bbb",
                SessionMovementLoginID = 1,
                Username = "fg",
                MaritalStatus = 2,
                Status = 1,
                DateOfBirth = DateTime.Now
            };

            Application.Run(new FrmMain());

            /*
              StartGoto:
              if (Login == 0)
              {
                  FrmLogin login = new FrmLogin();
                  Application.Run(login);
                  if (login.CloseStatus == 1)
                  {
                      Application.Exit();
                      return;
                  }
                  if (login.LoginStatus == 1)
                  {
                      Application.Exit();
                      Login = 1;
                  }
              }
              else
              {
                  FrmMain frmMain = new FrmMain();
                  Application.Run(frmMain);
                  if (frmMain.CloseStatus == 1)
                  {
                      Application.Exit();
                      return;
                  }
              }
              goto StartGoto;
            */


        }
    }
}
