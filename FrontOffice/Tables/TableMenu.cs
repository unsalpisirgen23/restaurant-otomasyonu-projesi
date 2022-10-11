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
using DAL.Entities.Plugs;

namespace FrontOffice.Tables
{
    public partial class TableMenu : DevExpress.XtraEditors.XtraUserControl
    {

        public int TableID { get; set; }

        public Plug Plug { get; set; } = new Plug();

        public event EventHandler BtnKitchenEventClick = null;

        public event EventHandler BtnTableToPrevEventClick = null;

        public event EventHandler BtnGetPaymentEventClick = null;

        public event EventHandler BtnTableChangeEventClick = null;

        public event EventHandler BtnTableJoinEventClick = null;

        public TableMenu()
        {

            InitializeComponent();

            int x = Width - panelControl2.Width + 230;

            int y = Height - panelControl2.Height + 50;

            panelControl2.Location = new Point(x, y);

            BtnKitchen.Click += (o, e) =>{if (BtnKitchenEventClick != null) BtnKitchenEventClick(o, e);};

            BtnTableToPrev.Click += (o, e) => { if (BtnTableToPrevEventClick != null) BtnTableToPrevEventClick(o, e); };

            BtnGetPayment.Click += (o, e) => { if (BtnGetPaymentEventClick != null) BtnGetPaymentEventClick(o, e); };

            BtnTableChange.Click += (o, e) => { if (BtnTableChangeEventClick != null) BtnTableChangeEventClick(o, e); };

            BtnTableJoin.Click += (o, e) => { if (BtnTableJoinEventClick != null) BtnTableJoinEventClick(o, e); };

        }



    }
}
