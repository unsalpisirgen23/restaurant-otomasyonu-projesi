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
    public partial class FrmTableAdd : DevExpress.XtraEditors.XtraForm
    {

        public FrmTableAdd()
        {
            InitializeComponent();
        }

        private void TableGroupListCom()
        {

            Dictionary<int, string> comboSource = new Dictionary<int, string>();
            comboSource.Add(-1, "Masa Grubu Seçiniz");
            var tableGroupList = Model.Db.TableGroupRepositories.GetList(g => g.Status == 1);
            foreach (var tg in tableGroupList)
            {
                comboSource.Add(tg.ID, tg.Name);
            }
            ComTableGroupList.DataSource = new BindingSource(comboSource, null);
            ComTableGroupList.DisplayMember = "Value";
            ComTableGroupList.ValueMember = "Key";
        }


        private void BtnAddClose_Click(object sender, EventArgs e)
        {
            if (TxtName.Text.Trim() == "")
            {
                MessageBox.Show("Masa Grup Adı Boş Burakılamaz!");
            }
            else
            {
                if (Model.Db.TableRepositories.Get(t => t.No == TxtName.Text.Trim()) != null)
                {
                    MessageBox.Show("Böyle Bir Masa Daha Önce Eklenmiş!");
                }
                else
                {

                    Model.Db.TableRepositories.Add(new DAL.Entities.Tables.Table()
                    {
                        AddDate = DateTime.Now,
                        No = TxtName.Text,
                        SessionMovementLoginID = Program.LoginEmploye.ID,
                        TableGroupID = (int)ComTableGroupList.SelectedValue,
                        Status = (int)ComStatus.SelectedValue,
                        Capacity = Convert.ToInt32(TxtCapasite.Text)
                    });
                    int result = Model.Save();

                    if (result > 0)
                    {
                        MessageBox.Show("Tebrikler Masa Başarıyla Eklendi!");
                    }
                    else
                    {
                        MessageBox.Show("Üzgünüz Bir Sorun Oluştu!\n Masa Eklenemedi.");
                    }
                    Close();
                }
            }
        }

        public void Status()
        {
            Dictionary<int, string> status = new Dictionary<int, string>();
            status.Add(1, "Onayla");
            status.Add(0, "Onaylama");
            ComStatus.DataSource = new BindingSource(status, null);
            ComStatus.DisplayMember = "Value";
            ComStatus.ValueMember = "Key";
        }

        private void FrmTableAdd_Load(object sender, EventArgs e)
        {
            TableGroupListCom();
            Status();
        }

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            if (TxtName.Text.Trim() == "")
            {
                MessageBox.Show("Masa Grup Adı Boş Burakılamaz!");
            }
            else
            {
                if (Model.Db.TableRepositories.Get(t => t.No == TxtName.Text.Trim()) != null)
                {
                    MessageBox.Show("Böyle Bir Masa Daha Önce Eklenmiş!");
                }
                else
                {

                    Model.Db.TableRepositories.Add(new DAL.Entities.Tables.Table()
                    {
                        AddDate = DateTime.Now,
                        No = TxtName.Text,
                        SessionMovementLoginID = Program.LoginEmploye.ID,
                        TableGroupID = (int)ComTableGroupList.SelectedValue,
                        Status = (int)ComStatus.SelectedValue,
                        Capacity = Convert.ToInt32(TxtCapasite.Text)
                    });
                    int result = Model.Save();

                    if (result > 0)
                    {
                        MessageBox.Show("Tebrikler Masa Başarıyla Eklendi!");
                    }
                    else
                    {
                        MessageBox.Show("Üzgünüz Bir Sorun Oluştu!\n Masa Eklenemedi.");
                    }
                    TxtName.Text = "";
                    TxtCapasite.Text = "";
                    TableGroupListCom();
                    Status();
                }
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}