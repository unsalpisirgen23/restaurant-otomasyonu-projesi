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
        public event EventHandler BtnDiscountEventClick;
        public event EventHandler BtnBulkDiscountEventClick;
        public event EventHandler BtnCancelEventClick;
        public event EventHandler BtnDecreaseEventClick;
        public event EventHandler BtnIncreaseEventClick;

        public UcProductMovementsList()
        {
            InitializeComponent();
            int w = Width / 5;
            BtnBulkDiscount.Width = w;
            BtnCancel.Width = w;
            BtnDecrease.Width = w;
            BtnDiscount.Width = w;
            BtnIncrease.Width = w;

            int lbw = Width / 2;
            LbPiece.Width = lbw;
            LbPrice.Width = lbw;

            BtnDiscount.Click += (o, e) => { if (BtnDiscountEventClick != null) BtnDiscountEventClick(o, e); };
            BtnBulkDiscount.Click += (o, e) => { if (BtnBulkDiscountEventClick != null) BtnBulkDiscountEventClick(o, e); };

            BtnCancel.Click += (o, e) => { if (BtnCancelEventClick != null) BtnCancelEventClick(o, e); };
            BtnDecrease.Click += (o, e) => { if (BtnDecreaseEventClick != null) BtnDecreaseEventClick(o, e); };
            BtnIncrease.Click += (o, e) => { if (BtnIncreaseEventClick != null) BtnIncreaseEventClick(o, e); };
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
