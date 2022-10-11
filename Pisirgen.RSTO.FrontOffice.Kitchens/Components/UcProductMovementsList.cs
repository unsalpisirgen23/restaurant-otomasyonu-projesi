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
using DAL.Entities.Orders;
using DAL.Entities.Plugs;

namespace FrontOffice.Kitchens.Components
{
    public partial class UcProductMovementsList : DevExpress.XtraEditors.XtraUserControl
    {
        private List<Order> order;

        public event EventHandler BtnDiscountEventClick;
        public event EventHandler BtnBulkDiscountEventClick;


        public UcProductMovementsList()
        {
            order = new List<Order>();
            InitializeComponent();

            int w = Width / 5;
            BtnBulkDiscount.Width = w;
            BtnCancel.Width = w;
            BtnDecrease.Width = w;
            BtnDiscount.Width = w;
            BtnIncrease.Width = w;

            BtnDiscount.Click += (o, e) => { if (BtnDiscountEventClick != null) BtnDiscountEventClick(o, e); };
            BtnBulkDiscount.Click += (o, e) => { if (BtnBulkDiscountEventClick != null) BtnBulkDiscountEventClick(o, e); };
        }

        public void ProductOrderAdd(Order order)
        {
            this.order.Add(order);
            gridControl1.DataSource = this.order;
        }

        public List<Order> GetProductOrders()
        {
            return order;
        }

        private void BtnIncrease_Click(object sender, EventArgs e)
        {
            int id = -1;
            foreach (int item in layoutView1.GetSelectedRows())
            {
                id = (int)layoutView1.GetRowCellValue(item, ColID);
            }
            if (id > 0)
            {
                if (order != null)
                {
                    var get = order.Find(p => p.ID == id);
                    get.Piece += 1;
                    if (get.Piece == 0)
                    {
                        get.Piece = 1;
                    }
                    var indexOf = order.IndexOf(get);
                    order[indexOf] = get;
                }
                gridControl1.Refresh();
                gridControl1.RefreshDataSource();
            }
        }

        private void BtnDecrease_Click(object sender, EventArgs e)
        {
            int id = -1;
            foreach (int item in layoutView1.GetSelectedRows())
            {
                id = (int)layoutView1.GetRowCellValue(item, ColID);
            }
            if (id > 0)
            {
                if (order != null)
                {
                    var get = order.Find(p => p.ID == id);
                    get.Piece -= 1;
                    if (get.Piece == 0 || get.Piece == -1)
                    {
                        get.Piece = 1;
                    }
                    var indexOf = order.IndexOf(get);
                    order[indexOf] = get;
                }
                gridControl1.Refresh();
                gridControl1.RefreshDataSource();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            int id = -1;
            foreach (int item in layoutView1.GetSelectedRows())
            {
                id = (int)layoutView1.GetRowCellValue(item, ColID);
            }
            if (id > 0)
            {
                if (Helpers.ConfirimOkCancel("Bu ürünü iptal etmek istediğinize\nEminmisiniz?", "DİKKAT İPTAL EDİLEÇEK") == DialogResult.OK)
                {
                    Order orderDatabase = Model.Db.OrderRepositories.Get(d => d.ID == id);
                    if (orderDatabase != null)
                    {
                        Model.Db.OrderRepositories.Delete(c => c.ID == id);
                        Model.Save();
                        gridControl1.Refresh();
                        gridControl1.RefreshDataSource();

                    }
                    else
                    {
                        var get = order.Find(p => p.ID == id);
                        var indexOf = order.IndexOf(get);
                        order.Remove(get);
                        gridControl1.Refresh();
                        gridControl1.RefreshDataSource();
                    }
                }
            }
        }

        public void TotalCalculationPrinting()
        {
            foreach (var order in this.order)
            {
                LbPiece.Text += (int)order.Piece;
                LbPrice.Text += (decimal)order.Price;
            }
        }

        public int GetTotalCalculationPiece()
        {
            return Convert.ToInt32(LbPiece.Text);
        }

        public decimal GetTotalCalculationPrice()
        {
            return Convert.ToDecimal(LbPrice.Text);
        }

        private void UcProductMovementsList_Resize(object sender, EventArgs e)
        {
            int w = Width / 5;
            BtnBulkDiscount.Width = w;
            BtnCancel.Width = w;
            BtnDecrease.Width = w;
            BtnDiscount.Width = w;
            BtnIncrease.Width = w;
        }

    }
}
