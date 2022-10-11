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

namespace FrontOffice.Kitchens.Components
{
    public partial class UcKeyped : DevExpress.XtraEditors.XtraUserControl
    {
        public event EventHandler BtnApplyEventClick;

        public UcKeyped()
        {
            InitializeComponent();
            BtnApply.Click += (o, e) => { if (BtnApplyEventClick != null) BtnApplyEventClick(o, e); };
        }


        private void BtnGroup_Click(object sender, EventArgs e)
        {
            SimpleButton btns = (SimpleButton)sender;
            TxtNumberText.Text += btns.Text;
        }

        private void BtnPrev_Click(object sender, EventArgs e)
        {
            if (TxtNumberText.Text != "")
            {
                TxtNumberText.Text.Substring(TxtNumberText.Text.Length - 1);
                TxtNumberText.Text = TxtNumberText.Text.Remove(TxtNumberText.Text.Length - 1);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            TxtNumberText.Text = "";
            TxtNumberText.ResetText();
        }

    }
}
