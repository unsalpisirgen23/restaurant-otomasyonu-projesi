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
using DAL.Entities.Customers;
using DAL.Entities.Communications;
using System.Linq.Expressions;
using DAL.Entities.Addresses;

namespace BackOffice.Forms.Customers
{
    public partial class FrmCustomerAdd : DevExpress.XtraEditors.XtraForm
    {
        private int ID;

        public FrmCustomerAdd()
        {
            InitializeComponent();
            ComStatus = Helpers.InitStatus(ComStatus);
        }

        #region Customer Add
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

        private int Gender()
        {
            if (RgGender.EditValue != null)
            {
                return Convert.ToInt32(RgGender.EditValue);
            }
            return 0;
        }

        public void Add(int step = 0)
        {
            if (TxtName.Text.Trim() == "")
            {
                MessageBox.Show("Ad Alanı Boş Olamaz!");
            }
            else
            {
                if (Model.Db.CustomerRepositories.Exist(z => z.FullName == TxtName.Text + " " + TxtSurname.Text))
                {
                    MessageBox.Show("Böyle bir müşteri daha önce eklenmiş gözüküyorsunuz!");
                }
                else
                {

                    Customer customer = new Customer()
                    {
                        AddDate = DateTime.Now,
                        SessionMovementLoginID = Program.LoginEmploye.ID,
                        Name = TxtName.Text,
                        Surname = TxtSurname.Text,
                        FullName = TxtName.Text + " " + TxtSurname.Text,
                        Gender = Gender(),
                        Status = (int)ComStatus.SelectedValue
                    };


                    Model.Db.CustomerRepositories.Add(customer);

                    int result = Model.Save();

                    if (result > 0)
                    {
                        ID = customer.ID;
                        MessageBox.Show("Tebrikler Müşteri başarıyla eklendi.");
                    }
                    else
                    {
                        MessageBox.Show("Bir Sorun oluştu üye eklenemedi?");
                    }

                    if (step == 1)
                    {
                        Close();
                    }
                    else
                    {

                        EnableContactAddressButton(true);
                        EnableContactTxt(true);
                        EnableAddressTxt(true);

                        TxtName.Text = "";
                        TxtSurname.Text = "";
                        ComStatus = Helpers.InitStatus(ComStatus);
                        RgGender.Reset();
                    }
                }
            }
        }

        private void BtnAddClose_Click(object sender, EventArgs e)
        {
            Add(1);
        }

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion


        private void FrmCustomerAdd_Load(object sender, EventArgs e)
        {
            EnableContactAddressButton(false);
            EnableContactTxt(false);
            EnableAddressTxt(false);
            RgGender.SelectedIndex = 0;
        }

        private void LoadListCommunication(Expression<Func<Communication, bool>> filter = null)
        {
            GcContactList.DataSource = Model.Db.CommunicationRepositories.GetList(filter);
        }

        /// <summary>
        /// Communication Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnContactAdd_Click(object sender, EventArgs e)
        {
            Model.Db.CommunicationRepositories.Add(new DAL.Entities.Communications.Communication()
            {
                AddDate = DateTime.Now,
                CustomerID = ID,
                SessionMovementLoginID = Program.LoginEmploye.ID,
                EMail = TxtContactMail.Text,
                Facebook = TxtContactFacebook.Text,
                Instagram = TxtContactInstagram.Text,
                Linkedin = TxtContactLinkedin.Text,
                Phone = TxtContactPhone.Text,
                Twitter = TxtContactTwitter.Text
            });

           int result =  Model.Save();

            if (result > 0)
            {
                MessageBox.Show("Tebrikler Başatıyla Eklendi.");
                LoadListCommunication(c => c.CustomerID == ID);
            }
            else
            {
                MessageBox.Show("Bir sorun oluştu \nve ekleme işlemi başarısız oldu!");
            }

        }
       
        private void LoadListAddress(Expression<Func<Address, bool>> filter = null)
        {
            GcAddressList.DataSource = Model.Db.AddressRepositories.GetList(filter);
        }

        /// <summary>
        /// Addresses Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddressAdd_Click(object sender, EventArgs e)
        {
            if (TxtAddressName.Text.Trim() == "" || TxtAddressCountry.Text.Trim() == "" || TxtAddressDistrict.Text.Trim() == "" || TxtAddressProvince.Text.Trim() == "")
            {
                MessageBox.Show("Tüm alanları doldurmanız gerek!");
            }
            else
            {
                Model.Db.AddressRepositories.Add(new DAL.Entities.Addresses.Address() {
                    AddDate = DateTime.Now,
                    CustomerID = ID,
                    SessionMovementLoginID = Program.LoginEmploye.ID,
                    Country = TxtAddressCountry.Text,
                    District = TxtAddressDistrict.Text,
                    DoorNumber = TxtAddressDoorNumber.Text,
                    Name = TxtAddressName.Text,
                    Neighborhood = TxtAddressNeighborhood.Text,
                    Province = TxtAddressProvince.Text,
                    Street = TxtAddressStreet.Text
                });

                int result = Model.Save();

                if (result > 0)
                {
                    MessageBox.Show("Tebrikler müşteri adresi başarıyla eklendi.");
                    LoadListAddress(c => c.CustomerID == ID);
                }
                else
                {
                    MessageBox.Show("Üzgünüz bir sorun oluştu \nMüşteri eklenemedi!");
                }

            }
        }



    }
}