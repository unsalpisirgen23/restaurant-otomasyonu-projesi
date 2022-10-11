using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace BackOffice.Forms.Employees
{
    public partial class FrmContactEdit : DevExpress.XtraEditors.XtraForm
    {
        public int id { get; set; }
        public int employeID { get; set; }
        DAL.Entities.Communications.Communication com;

        public FrmContactEdit(int id = 0,int employeID = 0)
        {
            this.id = id;
            this.employeID = employeID;
            InitializeComponent();
        }

        private void FrmContactEdit_Load(object sender, EventArgs e)
        {
            var edit = Model.Db.CommunicationRepositories.Get(c => c.ID == id && c.EmployeID == employeID);
            com = edit;
            TxtContactFacebook.Text = edit.Facebook;
            TxtContactInstagram.Text = edit.Instagram;
            TxtContactLinkedin.Text = edit.Linkedin;
            TxtContactMail.Text = edit.EMail;
            TxtContactPhone.Text = edit.Phone;
            TxtContactTwitter.Text = edit.Twitter;
        }

        private void BtnContactAdd_Click(object sender, EventArgs e)
        {
            Model.Db.CommunicationRepositories.Update(new DAL.Entities.Communications.Communication()
            {
                ID = id,
                EmployeID = employeID,
                AddDate = com.AddDate,
                SessionMovementLoginID = com.SessionMovementLoginID,
                UpdateDate = DateTime.Now,
                EMail = TxtContactMail.Text,
                Facebook = TxtContactFacebook.Text,
                Instagram = TxtContactInstagram.Text,
                Linkedin = TxtContactLinkedin.Text,
                Phone = TxtContactPhone.Text,
                Twitter = TxtContactTwitter.Text
            });
            Model.Save();
            MessageBox.Show("Tebrikler işletişim bilgileriniz başarıyla güncellendi.");
            Close();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}