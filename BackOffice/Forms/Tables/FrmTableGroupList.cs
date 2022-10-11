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
using DAL;

namespace BackOffice.Forms.Tables
{
    public partial class FrmTableGroupList : DevExpress.XtraEditors.XtraForm
    {
        public FrmTableGroupList()
        {
            InitializeComponent();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            Status();
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

        private void FrmTableGroupList_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = Model.Db.TableGroupRepositories.GetList(null);
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

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSearch_Click_1(object sender, EventArgs e)
        {
            if (TxtSearchName.Text == "")
            {
            
                gridControl1.DataSource = Model.Db.TableGroupRepositories.GetList(null);
                gridView1.Columns["Status"].Visible = false;
                gridView1.Columns["Status2"].UnboundType = DevExpress.Data.UnboundColumnType.String;
                gridView1.CustomUnboundColumnData += GridView1_CustomUnboundColumnData;
            }
            else
            {
                gridControl1.Refresh();
        gridControl1.DataSource = Model.Db.TableGroupRepositories.GetList(g => g.Name.Contains(TxtSearchName.Text));
                gridView1.Columns["Status"].Visible = false;
                gridView1.Columns["Status2"].UnboundType = DevExpress.Data.UnboundColumnType.String;
                gridView1.CustomUnboundColumnData += GridView1_CustomUnboundColumnData;
            }
        }

        private int ID;

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            int[] selectedRows = gridView1.GetSelectedRows();
            foreach (int rowHandle in selectedRows)
            {
                ID = (int)gridView1.GetRowCellValue(rowHandle, GcID);
            }

           var group = Model.Db.TableGroupRepositories.Get(g => g.ID == ID);
            TxtEditName.Text = group.Name;
            if (group.Status == 1)
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
            DAL.Entities.Tables.TableGroup g = new DAL.Entities.Tables.TableGroup();
            g.ID = Model.Db.TableGroupRepositories.Get(t => t.ID == ID).ID;
            g.Name = TxtEditName.Text;
            g.Status = (int)ComEditStatus.SelectedValue;
            g.UpdateDate = DateTime.Now;
            Model.Db.TableGroupRepositories.Update(g);
            Model.Save();
            MessageBox.Show("Tebrikler Başarıyla Güncellendi.");
            TxtEditName.Text = "";
            Status();
            gridControl1.DataSource = Model.Db.TableGroupRepositories.GetList(null);
            gridView1.Columns["Status"].Visible = false;
            gridView1.Columns["Status2"].UnboundType = DevExpress.Data.UnboundColumnType.String;
            gridView1.CustomUnboundColumnData += GridView1_CustomUnboundColumnData;
       
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int[] selectedRows = gridView1.GetSelectedRows();
            foreach (int rowHandle in selectedRows)
            {
                ID = (int)gridView1.GetRowCellValue(rowHandle, GcID);
            }

            if (MessageBox.Show("Bu İçeriği Silmek İstediğiniz den Eminmisiniz", "DİKKAT SİLİNECEK", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                Model.Db.TableGroupRepositories.Delete(new DAL.Entities.Tables.TableGroup() { ID = ID });
                Model.Save();

                MessageBox.Show("Tebrikle Başarıyla Silindi!");
                gridControl1.DataSource = Model.Db.TableGroupRepositories.GetList(null);
                gridView1.Columns["Status"].Visible = false;
                gridView1.Columns["Status2"].UnboundType = DevExpress.Data.UnboundColumnType.String;
                gridView1.CustomUnboundColumnData += GridView1_CustomUnboundColumnData;
            }
        }
    }
}