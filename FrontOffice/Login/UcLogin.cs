using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace FrontOffice.Login
{
    public partial class UcLogin : DevExpress.XtraEditors.XtraUserControl
    {

        public int LoginID { get; set; }

        public event EventHandler BtnOkClick;

        public UcLogin()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            int x = Width - GcLoginContainer.Width + 120;
            int y = Height - GcLoginContainer.Height + 50;
            GcLoginContainer.Location = new Point(x,y);
            BtnOk.Click += (oo, ee) =>
            {
                if (BtnOkClick != null)
                {
                    BtnOkClick(oo, ee);
                }
            };
        }

        public void UserNameList()
        {
            Dictionary<string, string> comboSource = new Dictionary<string, string>();
            comboSource.Add("", "Bir Kullanıcı Seçiniz");
            var employees = Model.Db.EmployeRepositories.GetList(c => c.Status == 1);
            foreach (var employe in employees)
            {
                comboSource.Add(employe.Username, employe.Username);
            }
            ComUsername.DataSource = new BindingSource(comboSource, null);
            ComUsername.DisplayMember = "Value";
            ComUsername.ValueMember = "Key";
        }
 

        private void BtnGroup(object sender, EventArgs e)
        {
            SimpleButton btns = (SimpleButton)sender;
            TxtKeypedPassword.Text += btns.Text;
        }


        private void BtnPrev_Click(object sender, EventArgs e)
        {
            if (TxtKeypedPassword.Text != "")
            {
                TxtKeypedPassword.Text.Substring(TxtKeypedPassword.Text.Length - 1);
                TxtKeypedPassword.Text = TxtKeypedPassword.Text.Remove(TxtKeypedPassword.Text.Length - 1);
            }
        }


        private void BtnDelete_Click(object sender, EventArgs e)
        {
            TxtKeypedPassword.Text = "";
            TxtKeypedPassword.ResetText();
        }


    }
}
