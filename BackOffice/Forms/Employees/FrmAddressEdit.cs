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
    public partial class FrmAddressEdit : DevExpress.XtraEditors.XtraForm
    {
        public int id { get; set; }
        public int employeID { get; set; }
        private DAL.Entities.Addresses.Address address;


        public FrmAddressEdit(int id = 0,int employeID = 0)
        {
            this.id = id;
            this.employeID = employeID;
            InitializeComponent();
        }

        private void FrmAddressEdit_Load(object sender, EventArgs e)
        {
            var edit = Model.Db.AddressRepositories.Get(c => c.ID == id && c.EmployeID == employeID);
            address = edit;
            TxtAddressCountry.Text = edit.Country;
            TxtAddressDistrict.Text = edit.District;
            TxtAddressDoorNumber.Text = edit.DoorNumber;
            TxtAddressName.Text = edit.Name;
            TxtAddressNeighborhood.Text = edit.Neighborhood;
            TxtAddressProvince.Text = edit.Province;
            TxtAddressStreet.Text = edit.Street;
        }

        private void BtnAddressAdd_Click(object sender, EventArgs e)
        {
            Model.Db.AddressRepositories.Update(new DAL.Entities.Addresses.Address()
            {
                AddDate = address.AddDate,
                SessionMovementLoginID = address.SessionMovementLoginID,
                ID = id,
                EmployeID = employeID,
                UpdateDate = DateTime.Now,
                Country = TxtAddressCountry.Text,
                District = TxtAddressDistrict.Text,
                DoorNumber = TxtAddressDoorNumber.Text,
                Name = TxtAddressName.Text,
                Neighborhood = TxtAddressNeighborhood.Text,
                Province = TxtAddressProvince.Text,
                Street = TxtAddressStreet.Text
            });
            Model.Save();
            MessageBox.Show("Tebrikler adres bilgileriniz başarıyla güncellendi.");
            Close();

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}