using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DAL.Entities.Tables;
using DAL.Entities.Plugs;
using DAL.Entities.Orders;
using DAL.Entities.Payments;
using DAL.Procedures;

namespace FrontOffice.Tables
{
    public partial class TableList : DevExpress.XtraEditors.XtraUserControl
    {

        public event EventHandler BtnTableEventClick;

        public TableList()
        {
            InitializeComponent();
        }

        public void TableGroupList()
        {
            IEnumerable<TableGroup> tbl = Model.Db.TableGroupRepositories.GetList(c => c.Status == 1);
            FlpTableGroupList.Controls.Clear();
            foreach (var tableGroup in tbl)
            {
                BtnTableGroupList btn = new BtnTableGroupList();
                btn.ID = tableGroup.ID;
                btn.Text = tableGroup.Name;
                FlpTableGroupList.Controls.Add(btn);
                btn.Click += BtnTableGroupEventClick;
            }
        }
        
        private void BtnTableGroupEventClick(object sender, EventArgs e)
        {
            BtnTableGroupList group = (BtnTableGroupList)sender;
            var tbl = Model.Db.TableRepositories.GetList(c => c.TableGroupID == group.ID && c.Status == 1);
            FlpTableList.Controls.Clear();
            foreach (var item in tbl)
            {
                BtnTableList btn = new BtnTableList();
                btn.ID = item.ID;
                btn.Text = item.No;
                var orders = Model.Db.OrderRepositories.GetList(t => t.PlugID == t.Plug.ID && t.Plug.TableID == item.ID, i => i.Plug);
                if (orders.Count() > 0)
                {
                    foreach (var order in orders)
                    {
                        btn.Appearance.BackColor = System.Drawing.Color.DarkRed;
                        btn.PlugID = (int)order.PlugID;
                    }
                }
                else
                {
                    btn.Appearance.BackColor = System.Drawing.Color.Green;
                    btn.PlugID = -1;
                }
                FlpTableList.Controls.Add(btn);
                btn.Click += (o, ee) => { if (BtnTableEventClick != null) { BtnTableEventClick(o, ee); } };
            }
        }


    }
}
