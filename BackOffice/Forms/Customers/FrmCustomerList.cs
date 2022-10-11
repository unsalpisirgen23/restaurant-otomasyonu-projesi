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
using System.Linq.Expressions;

namespace BackOffice.Forms.Customers
{
    public partial class FrmCustomerList : DevExpress.XtraEditors.XtraForm
    {
        public FrmCustomerList()
        {
            InitializeComponent();
        }

        private void LoadListCustomer(Expression<Func<Customer, bool>> filter = null)
        {
            gridControl1.DataSource = Model.Db.CustomerRepositories.GetList(filter, includes => includes.CustomerCommunication,includes=>includes.CustomerAddress);
            gridView1 = Helpers.InitGridControlGender(gridView1);
            gridView1 = Helpers.InitGridControlStatus(gridView1);
        }

        private void FrmCustomerList_Load(object sender, EventArgs e)
        {
            RgGender.SelectedIndex = 0;
            ComStatus = Helpers.InitStatus(ComStatus);
            LoadListCustomer();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        { 
            LoadListCustomer(c => c.Name.Contains(TxtName.Text));
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtName.Text = "";
            TxtSurname.Text = "";
            RgGender.SelectedIndex = 0;
            ComStatus = Helpers.InitStatus(ComStatus);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}