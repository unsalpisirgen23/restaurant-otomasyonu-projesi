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

namespace BackOffice.UserControls
{
    public partial class TextBoxMoney : DevExpress.XtraEditors.XtraUserControl
    {
        public string Money { get; set; }

        public string TextBoxText { get { return textEdit1.Text; } set { textEdit1.Text = value; } }


        public TextBoxMoney()
        {
            InitializeComponent();
        }

        private void textEdit1_TextChanged(object sender, EventArgs e)
        {
            if (Money == "")
            {
                Money = "TL";
            }

            string value = textEdit1.Text.Replace(".", "").Replace(Money, "");
            decimal ul;
            //Check we are indeed handling a number
            if (decimal.TryParse(value, out ul))
            {
                //Unsub the event so we don't enter a loop
                textEdit1.TextChanged -= textEdit1_TextChanged;
                //Format the text as currency
                textEdit1.Text = string.Format("{0:C2}", ul);
                textEdit1.TextChanged += textEdit1_TextChanged;
            }
        }


    }
}
