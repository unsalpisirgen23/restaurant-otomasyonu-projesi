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
using DevExpress.XtraGrid.Views.Grid;

namespace BackOffice.Forms.Tables
{
    public partial class FrmTableList : DevExpress.XtraEditors.XtraForm
    {

        private int ID;

        public FrmTableList()
        {
            InitializeComponent();
        }

        public void Status()
        {
            Dictionary<int, string> status = new Dictionary<int, string>();
            status.Add(1, "Onayla");
            status.Add(0, "Onaylama");
            ComEditStatus.DataSource = new BindingSource(status, null);
            ComEditStatus.DisplayMember = "Value";
            ComEditStatus.ValueMember = "Key";
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
            ComEditGroup.DataSource = new BindingSource(comboSource, null);
            ComEditGroup.DisplayMember = "Value";
            ComEditGroup.ValueMember = "Key";
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmTableList_Load(object sender, EventArgs e)
        {
            Status();
            TableGroupListCom();
            gridControl1.DataSource = Model.Db.TableRepositories.GetList(null);
            gridView1.Columns["Status"].Visible = false;
            gridView1.Columns["Status2"].UnboundType = DevExpress.Data.UnboundColumnType.String;
            gridView1.CustomUnboundColumnData += GridView1_CustomUnboundColumnData;
        }


        private void GridView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Column == view.Columns["Status2"])
            {
                int sourceValue = (int)view.GetRowCellValue(view.GetRowHandle(e.ListSourceRowIndex), view.Columns["Status"]);

                if (sourceValue == 1)
                {
                    e.Value = "Onaylı";
                }
                else if (sourceValue == 0)
                {
                    e.Value = "Onaysız";
                }
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (TxtSearchNo.Text == "")
            {

                gridControl1.DataSource = Model.Db.TableRepositories.GetList(null);
                gridView1.Columns["Status"].Visible = false;
                gridView1.Columns["Status2"].UnboundType = DevExpress.Data.UnboundColumnType.String;
                gridView1.CustomUnboundColumnData += GridView1_CustomUnboundColumnData;
            }    
            else
            {
                gridControl1.Refresh();
                gridControl1.DataSource = Model.Db.TableRepositories.GetList(
                    g => g.No.Contains(TxtSearchNo.Text)
                    );
                gridView1.Columns["Status"].Visible = false;
                gridView1.Columns["Status2"].UnboundType = DevExpress.Data.UnboundColumnType.String;
                gridView1.CustomUnboundColumnData += GridView1_CustomUnboundColumnData;
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            int[] selectedRows = gridView1.GetSelectedRows();
            foreach (int rowHandle in selectedRows)
            {
                ID = (int)gridView1.GetRowCellValue(rowHandle, GcID);
            }

            var table = Model.Db.TableRepositories.Get(g => g.ID == ID,t=>t.TableGroup);
            TxtEditNo.Text = table.No;
            TxtEditCapasite.Text = table.Capacity.ToString();
            ComEditGroup.SelectedValue = table.TableGroup.ID;
            if (table.Status == 1)
            {
                Dictionary<int, string> status = new Dictionary<int, string>();
                status.Add(1, "Onayla");
                status.Add(0, "Onaylama");
                ComEditStatus.DataSource = new BindingSource(status, null);
                ComEditStatus.DisplayMember = "Value";
                ComEditStatus.ValueMember = "Key";
            }
            else
            {
                Dictionary<int, string> status = new Dictionary<int, string>();
                status.Add(0, "Onaylama");
                status.Add(1, "Onayla");
                ComEditStatus.DataSource = new BindingSource(status, null);
                ComEditStatus.DisplayMember = "Value";
                ComEditStatus.ValueMember = "Key";
            }

        }

        private void BtnEditSave_Click(object sender, EventArgs e)
        {
            DAL.Entities.Tables.Table g = new DAL.Entities.Tables.Table();
            g.ID = Model.Db.TableRepositories.Get(t => t.ID == ID).ID;
            g.No = TxtEditNo.Text;
            g.Capacity = Convert.ToInt32(TxtEditCapasite.Text);
            g.Status = (int)ComEditStatus.SelectedValue;

            g.TableGroupID = (int)ComEditGroup.SelectedValue;   
            
            g.UpdateDate = DateTime.Now;

            Model.Db.TableRepositories.Update(g);
            Model.Save();
            MessageBox.Show("Tebrikler Masa Başarıyla Güncellendi.");
            gridControl1.DataSource = Model.Db.TableRepositories.GetList(null);
            gridView1.Columns["Status"].Visible = false;
            gridView1.Columns["Status2"].UnboundType = DevExpress.Data.UnboundColumnType.String;
            gridView1.CustomUnboundColumnData += GridView1_CustomUnboundColumnData;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        { 
            if (MessageBox.Show("Bu İçeriği Silmek İstediğiniz den Eminmisiniz", "DİKKAT SİLİNECEK", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int[] selectedRows = gridView1.GetSelectedRows();
                foreach (int rowHandle in selectedRows)
                {
                    ID = (int)gridView1.GetRowCellValue(rowHandle, GcID);
                }
                Model.Db.TableRepositories.Delete(c => c.ID == ID);
            Model.Save();
            MessageBox.Show("Tebrikler Masa Başarıyla Silindi.");
            gridControl1.DataSource = Model.Db.TableRepositories.GetList(null);
            gridView1.Columns["Status"].Visible = false;
            gridView1.Columns["Status2"].UnboundType = DevExpress.Data.UnboundColumnType.String;
            gridView1.CustomUnboundColumnData += GridView1_CustomUnboundColumnData;
            }
             
        }
    }
}