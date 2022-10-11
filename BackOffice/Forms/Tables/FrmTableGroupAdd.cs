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

namespace BackOffice.Forms.Tables
{
    public partial class FrmTableGroupAdd : DevExpress.XtraEditors.XtraForm
    {
        public FrmTableGroupAdd()
        {
            InitializeComponent();
        }

        private void BtnAddClose_Click(object sender, EventArgs e)
        {
            if (TxtName.Text.Trim() == "" || (int)ComStatus.SelectedValue == -1)
            {
                MessageBox.Show("Masa Grup Adı Boş Burakılamaz!");
            }
            else
            {
                if (Model.Db.TableGroupRepositories.Get(g=>g.Name == TxtName.Text.Trim())!=null)
                {
                    MessageBox.Show("Böyle Bir Grup Adı Daha Önce Eklenmiş \n Lütfen Başka Bir Tane Deneyin!");
                }
                else
                {
                    Model.Db.TableGroupRepositories.Add(new DAL.Entities.Tables.TableGroup()
                    {
                        AddDate = DateTime.Now,
                        Name = TxtName.Text.Trim(),
                        SessionMovementLoginID = Program.LoginEmploye.ID,
                        Status = (int)ComStatus.SelectedValue
                    });
                   int result = Model.Save();
                    if (result > 0)
                    {
                        MessageBox.Show("Tebrikler Başarıyla Eklendiniz");
                    }
                    else
                    {
                        MessageBox.Show("Üzgünüz Bir Sorun Oluştu Ekleme İşlemi \n Başarısız Oldu!");
                    }
                    Close();
                }
            }
        }

         
        private void FrmTableGroupAdd_Load(object sender, EventArgs e)
        {
            Dictionary<int, string> status = new Dictionary<int, string>();
            status.Add(1, "Onayla");
            status.Add(0, "Onaylama");
            ComStatus.DataSource = new BindingSource(status, null);
            ComStatus.DisplayMember = "Value";
            ComStatus.ValueMember = "Key";
        }

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            if (TxtName.Text.Trim() == "" || (int)ComStatus.SelectedValue == -1)
            {
                MessageBox.Show("Masa Grup Adı Boş Burakılamaz!");
            }
            else
            {
                if (Model.Db.TableGroupRepositories.Get(g => g.Name == TxtName.Text.Trim()) != null)
                {
                    MessageBox.Show("Böyle Bir Grup Adı Daha Önce Eklenmiş \n Lütfen Başka Bir Tane Deneyin!");
                }
                else
                {
                    Model.Db.TableGroupRepositories.Add(new DAL.Entities.Tables.TableGroup()
                    {
                        AddDate = DateTime.Now,
                        Name = TxtName.Text.Trim(),
                        SessionMovementLoginID = Program.LoginEmploye.ID,
                        Status = (int)ComStatus.SelectedValue
                    });
                    int result = Model.Save();
                    if (result > 0)
                    {
                        MessageBox.Show("Tebrikler Başarıyla Eklendiniz");
                    }
                    else
                    {
                        MessageBox.Show("Üzgünüz Bir Sorun Oluştu Ekleme İşlemi \n Başarısız Oldu!");
                    }
                    TxtName.Text = "";
                }
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}