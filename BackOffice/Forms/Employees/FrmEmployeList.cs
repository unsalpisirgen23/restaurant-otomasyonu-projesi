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
using DAL.Entities.Addresses;
using DAL.Entities.Employees;
using System.Linq.Expressions;

namespace BackOffice.Forms.Employees
{
    public partial class FrmEmployeList : DevExpress.XtraEditors.XtraForm
    {
        FrmEmployeEdit edit;

        public FrmEmployeList()
        {
            InitializeComponent();
        }
 

        private void ListEmployees(Expression<Func<Employe, bool>> filter = null)
        {
            gridControl1.DataSource = Model.Db.EmployeRepositories.GetList(filter);
            gridView1 = Helpers.InitGridControlGender(gridView1);
            gridView1 = Helpers.InitGridControlMaritalStatus(gridView1);
            gridView1 = Helpers.InitGridControlStatus(gridView1);
            gridView1 = Helpers.InitGridControlAddedUser(gridView1);
        }


        private void FrmEmployeList_Load(object sender, EventArgs e)
        {
            ListEmployees();
            gridControl1.Refresh();
        }

     

        private void BtnSearch_Click_1(object sender, EventArgs e)
        {
            if (TxtName.Text != "")
            {
                ListEmployees(c => c.Name.Contains(TxtName.Text));

            }
            else if (TxtSurname.Text != "")
            {
                ListEmployees(c => c.Surname.Contains(TxtSurname.Text));
            }
            else if (TxtTc.Text != "")
            {
                ListEmployees(c => c.CitizenshipNumber.Contains(TxtTc.Text));
            }
            else if (TxtName.Text != "" && TxtSurname.Text != "" && TxtTc.Text != "")
            {
                ListEmployees(c => c.Name.Contains(TxtName.Text) && c.Surname.Contains(TxtSurname.Text) && c.CitizenshipNumber.Contains(TxtTc.Text));
            }
            else
            {
                ListEmployees();
            }
        }


        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtName.Text = "";
            TxtSurname.Text = "";
            TxtTc.Text = "";
        }


        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
         

        private void BtnDelete_DoubleClick_1(object sender, EventArgs e)
        {
            if (Helpers.ConfirimOkCancel("Bu Personeli Silmek İstediğinize Eminmisiniz?", "DİKKAT SİLİNECEK") == DialogResult.OK)
            {
                if (Model.Db.EmployeRepositories.GetList(null).Count() < 2)
                {
                    MessageBox.Show("Bu son personeldir \n o yüzden bu personeli silemezsiniz!");
                }
                else
                {
                    int id = Helpers.InitGridControlSelectedByID(gridView1, GcID);
                    Model.Db.AddressRepositories.Delete(c => c.EmployeID == id);
                    Model.Save();
                    Model.Db.CommunicationRepositories.Delete(cc => cc.EmployeID == id);
                    Model.Save();
                    Model.Db.EmployeRepositories.Delete(d => d.ID == id);
                    Model.Save();
                    MessageBox.Show("Tebrikler başarıyla silindi!");
                    ListEmployees();
                }
            }
        }


        private void BtnEdit_DoubleClick(object sender, EventArgs e)
        {
            edit = new FrmEmployeEdit(Helpers.InitGridControlSelectedByID(gridView1, GcID));
            edit.FormClosed += (oo, ee) =>
            {
                ListEmployees();
                Model.Db.Db.SaveChanges();
            };
            edit.ShowDialog();
        }


    }
}