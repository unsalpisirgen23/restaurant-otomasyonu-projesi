using DAL;
using DevExpress.XtraEditors;
using DAL.Entities.Employees;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BackOffice.Layout
{
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        private RestaurantContext Rc;
        private UnitOfWork Db;

        public int CloseStatus = 0;
        public int LoginStatus = 0;
        
        public FrmLogin()
        {
            InitializeComponent();
            Rc = new RestaurantContext("name=RMSContext");
            Db = new UnitOfWork(Rc);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (TxtUsername.Text.Trim() =="" || TxtPassword.Text.Trim() == "")
            {
                XtraMessageBox.Show("Kullanıcı adı veya şifre boş burakılamaz!");
            }
            else
            {
              Employe employe =  Db.EmployeRepositories.Get(E => E.Username == TxtUsername.Text.Trim() && E.Password == TxtPassword.Text.Trim());
                if (employe != null)
                {
                    Program.Login = 1;
                    Program.LoginEmploye = employe;
                    XtraMessageBox.Show("Tebrikler Başarıyla Giriş Yaptınız.");
                    LoginStatus = 1;
                    Close();
                }
                else
                {
                    XtraMessageBox.Show("Bir Sorun oluş giriş başarısız oldu!");
                }
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            CloseStatus = 1;
            Close();
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
    }
}
