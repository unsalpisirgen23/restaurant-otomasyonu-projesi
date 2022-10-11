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

namespace FrontOffice.Layout
{
    public partial class UcLayoutHeaderButton : DevExpress.XtraEditors.XtraUserControl
    {

        public string HeaderLabel { get { return label1.Text; } set { label1.Text = value; } }

        public event EventHandler BtnBackOrExit;

        public SimpleButton BtnBackOrExitObject;


        public UcLayoutHeaderButton()
        {
            InitializeComponent();

            if (simpleButton1 != null)
            {
                BtnBackOrExitObject = simpleButton1;
            }

            simpleButton1.Click += (oo, ee) =>
            {
                if (BtnBackOrExit != null)
                {
                    BtnBackOrExit(oo, ee);
                }
            };

        }
    }
}
