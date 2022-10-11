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

namespace FrontOffice.MainMenu
{
    public partial class UcMainMenu : DevExpress.XtraEditors.XtraUserControl
    {

        public event EventHandler BtnTableOpenEventClick;

        public UcMainMenu()
        {
            InitializeComponent();

            Dock = DockStyle.Fill;

            int x = Width - panelControl1.Width;

            int y = Height - panelControl1.Height - 80;

            panelControl1.Location = new Point(x, y);

            BtnTableOpen.Click += (ob, ev) =>
            {
                if (BtnTableOpenEventClick != null)
                {
                    BtnTableOpenEventClick(ob, ev);
                }
            };

        }

      
    }
}
