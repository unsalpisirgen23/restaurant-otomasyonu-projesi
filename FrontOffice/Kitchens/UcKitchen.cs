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
using FrontOffice.Kitchens.Products;
using DAL.Entities.Orders;
using System.Globalization;
using DAL.Entities.Plugs;

namespace FrontOffice.Kitchens
{
    public partial class UcKitchen : DevExpress.XtraEditors.XtraUserControl
    {
        private List<Order> orders;

        private Order order;

        public int ProductID { get; set; }

        public Plug Plug { get; set; }

        public int TableID { get; set; }

        public UcKitchen()
        {
            InitializeComponent();
            /*
            int id = -1;
            foreach (int item in layoutView1.GetSelectedRows())
            {
                id = (int)layoutView1.GetRowCellValue(item, ColID);
            }
            */
        }

        private void UcKitchen_Load(object sender, EventArgs e)
        {
             
        }

        public void Run()
        {
            ucProductList1.ProductGroupList();
            orders = new List<Order>();
            List<Order> newOrders = new List<Order>();

            ucProductMovementsList1.gridControl1.DataSource = null;
            ucProductMovementsList1.gridControl1.RefreshDataSource();

            var _order = Model.Db.OrderRepositories.GetList(c => c.PlugID == Plug.ID).ToList();

            if (_order.Count() > 0 && Model.Db.PaymentRepositories.GetList(c => c.PlugID != Plug.ID).Count() < 1)
            {
                newOrders.AddRange(_order);
            }

            newOrders.AddRange(orders);

            ucProductMovementsList1.gridControl1.DataSource = newOrders;

            ucProductMovementsList1.gridControl1.RefreshDataSource();

            ucProductMovementsList1.LbPiece.Text = "";
            ucProductMovementsList1.LbPrice.Text = "";
            ucKeyped1.TxtNumberText.Text = "";
        }


        public List<Order> OldOrderList()
        {
            return (List<Order>)ucProductMovementsList1.gridControl1.DataSource;
        }


        private void ucProductList1_BtnProductEventClick(object sender, EventArgs e)
        {
            BtnProducts product = (BtnProducts)sender;
            ProductID = product.ID;
            order = new Order
            {
                PlugID = Plug.ID,
                EmployeID = FrmMain.ID,
                ProductID = ProductID,
                SessionMovementLoginID = FrmMain.ID,
                AddDate = DateTime.Now,
                Product = Model.Db.ProductRepositories.Get(c => c.ID == ProductID && c.Status == 1)
            };
        }




        private void ucKeyped1_BtnApplyEventClick(object sender, EventArgs e)
        {
            if (ucKeyped1.TxtNumberText.Text == "")
            {
                ucKeyped1.TxtNumberText.Text = "1";
            }
            if (ucKeyped1.TxtNumberText.Text == "0")
            {
                ucKeyped1.TxtNumberText.Text = "1";
            }

            if (order != null)
            {

                if (ucKeyped1.TxtNumberText.Text.IndexOf(',') > 0)
                {
                    MessageBox.Show("Adet girişin de virgül kullanılmaz!");
                    return;
                }

                int piece = Convert.ToInt32(ucKeyped1.TxtNumberText.Text);

                order.Piece = piece;
                order.Price = piece * order.Product.Price;
                orders.Add(order);
                ucProductMovementsList1.gridControl1.RefreshDataSource();

                TotalPieceAndTotalPrice();

                ucKeyped1.TxtNumberText.Text = "";

            }
            else
            {
                MessageBox.Show("Bir Ürün Seçin");
            }

            order = null;
        }


        private void TotalPieceAndTotalPrice()
        {
            decimal? _price = 0;
            int? _piece = 0;
            foreach (var item in orders)
            {
                _piece += item.Piece;
                _price += item.Price;
            }
            ucProductMovementsList1.LbPiece.Text = _piece.ToString();
            ucProductMovementsList1.LbPrice.Text = TryParse(_price);
            _price = 0;
            _piece = 0;
        }


        private string TryParse(decimal? money)
        {
            decimal Money;
            decimal.TryParse(string.Format(CultureInfo.CreateSpecificCulture("tr-TR"), "{0:C}", money), NumberStyles.Currency, CultureInfo.CurrentUICulture.NumberFormat, out Money);
            return string.Format(CultureInfo.CreateSpecificCulture("tr-TR"), "{0:C}", Money);
        }


        private void BtnSave_Click(object sender, EventArgs e)
        {
            Model.Db.PlugRepositories.Add(Plug);
            Model.Save();
            //List<Order> Orders = (List<Order>)ucProductMovementsList1.gridControl1.DataSource;
            if (orders != null)
            {
                foreach (var order in orders)
                {
                    Model.Db.OrderRepositories.Add(new Order()
                    {
                        AddDate = DateTime.Now,
                        EmployeID = FrmMain.ID,
                        Piece = Convert.ToInt32(ucProductMovementsList1.LbPiece.Text.Trim()),
                        Price = Convert.ToDecimal(ucProductMovementsList1.LbPrice.Text.Trim('?')),
                        PlugID = Plug.ID,
                        ProductID = order.ProductID,
                        SessionMovementLoginID = FrmMain.ID
                    });
                    Model.Save();
                }
            }
        }


        private void ucProductMovementsList1_BtnBulkDiscountEventClick(object sender, EventArgs e)
        {

        }

        private void ucProductMovementsList1_BtnCancelEventClick(object sender, EventArgs e)
        {

        }

        private void ucProductMovementsList1_BtnDecreaseEventClick(object sender, EventArgs e)
        {

        }

        private void ucProductMovementsList1_BtnDiscountEventClick(object sender, EventArgs e)
        {

        }

        private void ucProductMovementsList1_BtnIncreaseEventClick(object sender, EventArgs e)
        {

        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            NfKitchenMenu.SelectedPage = NpKitchenMenu;
        }

        private void BtnKitchenMenuPrev_Click(object sender, EventArgs e)
        {
            NfKitchenMenu.SelectedPage = NpKitchenMenuHomePage;
        }


    }
}
