using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace FrontOffice.Notifications
{
    public partial class Success : DevExpress.XtraEditors.XtraForm
    {
        public Success()
        {
            InitializeComponent();
        }

        public static void Message(string msg)
        {
           var success = new Success();
            success.label1.Text = msg;
            success.Left = Screen.PrimaryScreen.Bounds.Width - 420;
           // success.Top = Screen.PrimaryScreen.Bounds.Height - 101;
            success.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Close();
        }
    }
}