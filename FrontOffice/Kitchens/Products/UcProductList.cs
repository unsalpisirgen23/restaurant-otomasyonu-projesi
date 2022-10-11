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

namespace FrontOffice.Kitchens.Products
{
    public partial class UcProductList : DevExpress.XtraEditors.XtraUserControl
    {
        public event EventHandler BtnProductEventClick;

        public UcProductList()
        {
            InitializeComponent();
        }

        public void ProductGroupList()
        {
            var groups = Model.Db.ProductGroupRepositories.GetList(c => c.Status == 1);
            FlpProductGroupList.Controls.Clear();
            foreach (var item in groups)
            {
                BtnProductGroup btn = new BtnProductGroup();
                btn.BackgroundImage = Helpers.ArrayToImage(item.Picture);
                btn.ID = item.ID;

                btn.Controls.Add(new Label()
                {
                    Dock = DockStyle.Bottom,
                    BackColor = Color.Black,
                    ForeColor = Color.White,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Text = item.Name
                });

                FlpProductGroupList.Controls.Add(btn);
                btn.Click += ProductGroupEvent_Click;
            }
        }

        private void ProductGroupEvent_Click(object sender, EventArgs e)
        {
            BtnProductGroup g = (BtnProductGroup)sender;
            var products = Model.Db.ProductRepositories.GetList(c => c.Status == 1 && c.ProductGroupID == g.ID);
            FlpProductList.Controls.Clear();
            foreach (var item in products)
            {
                BtnProducts btn = new BtnProducts();

                btn.ID = item.ID;

                btn.LabelText = item.Name + " " + item.Price.ToString();

                btn.BackgroundImage = Helpers.ArrayToImage(item.Picture);

                FlpProductList.Controls.Add(btn);

                btn.BtnProductsClickEvent += (o, ee) => { if (BtnProductEventClick != null) BtnProductEventClick(o, ee); };
            }
        }

    }
}
