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
using System.Drawing.Imaging;
using DAL.Entities.Employees;
using System.Globalization;
using DAL.Entities.Addresses;

namespace BackOffice.Forms.Employees
{
    public partial class FrmEmployeEdit : DevExpress.XtraEditors.XtraForm
    {
        public int id { get; set; }

        private Employe UpdateEmploye;

        public FrmEmployeEdit(int id = 0)
        {
            this.id = id;
            UpdateEmploye = Model.Db.EmployeRepositories.Get(c => c.ID == id);
            InitializeComponent();
        }

        DAL.Entities.Employees.Employe employe;

        public void EnableContactAddressButton(bool s = true)
        {
            BtnContactAdd.Enabled = s;
            BtnAddressAdd.Enabled = s;
        }

        public void EnableContactTxt(bool s = true)
        {
            TxtContactFacebook.Enabled = s;
            TxtContactInstagram.Enabled = s;
            TxtContactLinkedin.Enabled = s;
            TxtContactMail.Enabled = s;
            TxtContactPhone.Enabled = s;
            TxtContactTwitter.Enabled = s;
        }

        private void EnableAddressTxt(bool s = true)
        {
            TxtAddressDoorNumber.Enabled = s;
            TxtAddressStreet.Enabled = s;
            TxtAddressName.Enabled = s;
            TxtAddressCountry.Enabled = s;
            TxtAddressDistrict.Enabled = s;
            TxtAddressNeighborhood.Enabled = s;
            TxtAddressProvince.Enabled = s;
        }




        private void FrmEmployeEdit_Load(object sender, EventArgs e)
        {

            EnableContactAddressButton(true);
            EnableContactTxt(true);
            EnableAddressTxt(true);
            RgGender.EditValue = RgGender.Properties.Items[0].Value;
            RgMaritalStatus.EditValue = RgMaritalStatus.Properties.Items[0].Value;
            ComStatus = Helpers.InitStatus(ComStatus);

   

            TxtName.Text = UpdateEmploye.Name;
            TxtSurname.Text = UpdateEmploye.Surname;
            TxtCitizenshipNumber.Text = UpdateEmploye.CitizenshipNumber;
            TxtUsername.Text = UpdateEmploye.Username;

            if (UpdateEmploye.Gender == 1)
            {
                RgGender.SelectedIndex = 0;
            }
            else
            {
                RgGender.SelectedIndex = 1;
            }

            if (UpdateEmploye.MaritalStatus == 1)
            {
                   RgMaritalStatus.SelectedIndex = 0;
            }
            else
            {
                RgMaritalStatus.SelectedIndex = 1;
            }

            pictureBox1.BackgroundImage = Helpers.ArrayToImage(UpdateEmploye.Avatar);

            DeDateOfBirth.DateTime = (DateTime)UpdateEmploye.DateOfBirth;

            ComStatus = Helpers.InitStatus(ComStatus, (int)UpdateEmploye.Status);

            if (Model.Db.AddressRepositories.Exist(c=>c.EmployeID == UpdateEmploye.ID))
            {
                GcAddressList.DataSource = Model.Db.AddressRepositories.GetList(c => c.EmployeID == UpdateEmploye.ID);
            }

            if (Model.Db.CommunicationRepositories.Exist(c=>c.EmployeID == UpdateEmploye.ID))
            {
                GcContactList.DataSource = Model.Db.CommunicationRepositories.GetList(c => c.EmployeID == UpdateEmploye.ID);
            }

            
        }





        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Resim Türleri (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            openFileDialog1.Title = "Bir Resim Seçiniz";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackgroundImage = System.Drawing.Image.FromFile(openFileDialog1.FileName);
                pictureBox1.BackgroundImage = Helpers.ResizeImage(pictureBox1.BackgroundImage, 170, 137);
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }



        public byte[] imageToByteArray()
        {
            byte[] buff = null;
            if (openFileDialog1.FileName.Contains("png"))
            {
                buff = Helpers.ImageToArray(pictureBox1.BackgroundImage, ImageFormat.Png);
            }
            else if (openFileDialog1.FileName.Contains("jpg") || openFileDialog1.FileName.Contains("jpeg"))
            {
                buff = Helpers.ImageToArray(pictureBox1.BackgroundImage, ImageFormat.Jpeg);
            }
            if (buff == null)
            {
                buff = UpdateEmploye.Avatar;
            }
            return buff;
        }

        private int Gender()  
        {
           return Convert.ToInt32(RgGender.EditValue);
        }

        private int MaritalStatus()
        {
            return Convert.ToInt32(RgMaritalStatus.EditValue);
        }
        
        private DateTime? DateOfBirth()
        {
            if (DeDateOfBirth.EditValue == null)
            {
                return null;
            }
           return Convert.ToDateTime(DeDateOfBirth.EditValue);
        }

        private void Add(int status = 0)
        {
            if (TxtName.Text.Trim() == "" || TxtSurname.Text.Trim() == "")
            {
                MessageBox.Show("Ad ve Soyad boş burakılamaz!");
            }
            else
            {
                if (TxtPassword.Text != "")
                {
                    if (TxtPassword.Text != TxtPassword2.Text)
                    {
                        MessageBox.Show("Şifreniz uyuşmamaktadır!");
                        return;
                    }
                }

                string pass = "";

                if (TxtPassword.Text == "")
                {
                    pass = UpdateEmploye.Password;
                }
                else
                {
                    pass = TxtPassword.Text;
                }

                employe = new DAL.Entities.Employees.Employe()
                {
                    ID = id,
                    AddDate = UpdateEmploye.AddDate,
                    SessionMovementLoginID = UpdateEmploye.SessionMovementLoginID,
                    UpdateDate = DateTime.Now,
                    Avatar = imageToByteArray(),
                    CitizenshipNumber = TxtCitizenshipNumber.Text,
                    DateOfBirth = DateOfBirth(),
                    FullName = TxtName.Text + " " + TxtSurname.Text,
                    Gender = Gender(),
                    MaritalStatus = MaritalStatus(),
                    Name = TxtName.Text,
                    Username = TxtUsername.Text,
                    Password = pass,
                    Status = (int)ComStatus.SelectedValue,
                    Surname = TxtSurname.Text
                };

                Model.Db.EmployeRepositories.Update(employe);

                Model.Save();

                MessageBox.Show("Tebrikler Kullanıcı Başarıyla Güncellendi");

                EnableContactAddressButton(true);

                EnableContactTxt(true);

                EnableAddressTxt(true);


                if (status == 1)
                {
                    Close();
                }
                else
                {
                    TxtName.Text = "";
                    TxtSurname.Text = "";
                    TxtUsername.Text = "";
                    TxtPassword.Text = "";
                    TxtPassword2.Text = "";
                    TxtCitizenshipNumber.Text = "";

                    RgGender.EditValue = RgGender.Properties.Items[0].Value;
                    RgMaritalStatus.EditValue = RgMaritalStatus.Properties.Items[0].Value;
                    ComStatus = Helpers.InitStatus(ComStatus);
                    pictureBox1.BackgroundImage = null;

                    ContactLoad(employe);

                }
            }
        }


        private void BtnAddClose_Click(object sender, EventArgs e)
        {
            Add(1);
        }


        private void ContactLoad(Employe emp)
        {
            if (emp != null)
            {
            GcContactList.DataSource = Model.Db.CommunicationRepositories.GetList(c => c.EmployeID == emp.ID);
            }
        }

        private void BtnContactDelete_DoubleClick(object sender, EventArgs e)
        {
            if (Helpers.ConfirimOkCancel("Bu iletişim bilgisini silmek istediğinize eminmisiniz?", "DİKKAT SİLİNECEK") == DialogResult.OK)
            {
                int _id = Helpers.InitGridControlSelectedByID(gridView1, GcID);
                Model.Db.CommunicationRepositories.Delete(c => c.ID == _id && c.EmployeID == UpdateEmploye.ID);
                Model.Save();
                MessageBox.Show("Tebrikler başarıyla silindi.");
                ContactLoad(UpdateEmploye);
            }
        }

        private void BtnContactEdit_DoubleClick(object sender, EventArgs e)
        {
            int _id = Helpers.InitGridControlSelectedByID(gridView1, GcID);
            FrmContactEdit edit = new FrmContactEdit(_id, UpdateEmploye.ID);
            edit.FormClosed += (oo, ee) =>
            {
                ContactLoad(UpdateEmploye);
            };
            edit.ShowDialog();
        }

        private void BtnContactAdd_Click(object sender, EventArgs e)
        {
            if (TxtContactPhone.Text == "" && TxtContactFacebook.Text == "" && TxtContactInstagram.Text == "" && TxtContactLinkedin.Text == "" && TxtContactMail.Text == "" && TxtContactTwitter.Text == "")
            {
                MessageBox.Show("En az bir alanı doldurmalısınız!");
            }
            else
            {
            
                    Model.Db.CommunicationRepositories.Add(new DAL.Entities.Communications.Communication()
                    {
                        AddDate = DateTime.Now,
                        EMail = TxtContactMail.Text,
                        EmployeID = id,
                        Facebook = TxtContactFacebook.Text,
                        Instagram = TxtContactInstagram.Text,
                        Linkedin = TxtContactLinkedin.Text,
                        Phone = TxtContactPhone.Text,
                        Twitter = TxtContactTwitter.Text,
                        SessionMovementLoginID = Program.LoginEmploye.ID
                    });

                    Model.Save();

                    MessageBox.Show("Tebrikler iletişim bilgileriniz başarıyla kaydedildi.");

                     TxtContactMail.Text = "";

                     TxtContactFacebook.Text = "";

                     TxtContactInstagram.Text = "";

                     TxtContactLinkedin.Text = "";

                     TxtContactPhone.Text = "";

                     TxtContactTwitter.Text = "";

                    ContactLoad(UpdateEmploye);

               
            }
        }


 

        private void AddressLoadList()
        {
            GcAddressList.DataSource = Model.Db.AddressRepositories.GetList(a => a.EmployeID == UpdateEmploye.ID);
        }

        private void BtnAddressAdd_Click(object sender, EventArgs e)
        {
            if (TxtAddressName.Text.Trim() == "")
            {
                MessageBox.Show("Adres adı boş burakılamaz!");
            }
            else
            {
                Address a = new Address()
                {
                    AddDate = DateTime.Now,
                    Country = TxtAddressCountry.Text,
                    District = TxtAddressDistrict.Text,
                    DoorNumber = TxtAddressDoorNumber.Text,
                    Name = TxtAddressName.Text,
                    Neighborhood = TxtAddressNeighborhood.Text,
                    Province = TxtAddressProvince.Text,
                    SessionMovementLoginID = Program.LoginEmploye.ID,
                    EmployeID = id,
                    Street = TxtAddressStreet.Text
                };

                Model.Db.AddressRepositories.Add(a);

                Model.Save();

                MessageBox.Show("Tebrikler adresiniz başarıyla eklendi.");

                TxtAddressDoorNumber.Text = "";
                TxtAddressStreet.Text = "";
                TxtAddressName.Text = "";
                TxtAddressCountry.Text = "";
                TxtAddressDistrict.Text = "";
                TxtAddressNeighborhood.Text = "";
                TxtAddressProvince.Text = "";

                AddressLoadList();

            }
        }

        private void BtnAddressEdit_DoubleClick(object sender, EventArgs e)
        {
            int _id = Helpers.InitGridControlSelectedByID(gridView2, GcAddressID);
            FrmAddressEdit edit = new FrmAddressEdit(_id, UpdateEmploye.ID);
            edit.FormClosed += (oo, ee) =>
            {
                AddressLoadList();
            };
            edit.ShowDialog();
        }

        private void BtnAddressDelete_DoubleClick(object sender, EventArgs e)
        {
            if (Helpers.ConfirimOkCancel("Bu adres bilgisini silmek istediğinize eminmisiniz?", "DİKKAT SİLİNECEK") == DialogResult.OK)
            {
                int _id = Helpers.InitGridControlSelectedByID(gridView2, GcAddressID);
                Model.Db.AddressRepositories.Delete(c => c.ID == _id && c.EmployeID == UpdateEmploye.ID);
                Model.Save();
                MessageBox.Show("Tebrikler başarıyla silindi.");
                AddressLoadList();
            }
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            /*
            EnableContactAddressButton(false);
            EnableContactTxt(false);
            EnableAddressTxt(false);
            TxtAddressDoorNumber.Text = "";
            TxtAddressStreet.Text = "";
            TxtAddressName.Text = "";
            TxtAddressCountry.Text = "";
            TxtAddressDistrict.Text = "";
            TxtAddressNeighborhood.Text = "";
            TxtAddressProvince.Text = "";
            GcAddressList.DataSource = null;
            GcContactList.DataSource = null;
            TxtContactMail.Text = "";

            TxtContactFacebook.Text = "";

            TxtContactInstagram.Text = "";

            TxtContactLinkedin.Text = "";

            TxtContactPhone.Text = "";

            TxtContactTwitter.Text = "";
            */
        }

        private void TxtSurname_TextChanged(object sender, EventArgs e)
        {
            /*
            EnableContactAddressButton(false);
            EnableContactTxt(false);
            EnableAddressTxt(false);
            GcAddressList.DataSource = null;
            GcContactList.DataSource = null;
            TxtContactMail.Text = "";

            TxtContactFacebook.Text = "";

            TxtContactInstagram.Text = "";

            TxtContactLinkedin.Text = "";

            TxtContactPhone.Text = "";

            TxtContactTwitter.Text = "";
            */
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
