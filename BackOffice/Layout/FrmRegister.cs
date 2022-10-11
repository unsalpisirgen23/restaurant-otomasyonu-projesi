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

namespace BackOffice.Layout
{
    public partial class FrmRegister : DevExpress.XtraEditors.XtraForm
    {
        public FrmRegister()
        {
            InitializeComponent();
        }
          
        private void FrmRegister_Load(object sender, EventArgs e)
        {
            TnPUser.PageVisible = false;
            TnPServer.PageVisible = false;
            TnPBusiness.PageVisible = false;
 


        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            TnPUser.PageVisible = true;
            tabPane1.SelectedPage = TnPUser;
        }

        private void cBDemo_CheckedChanged(object sender, EventArgs e)
        {
            if (TxtSerialKey.ReadOnly == false)
            {
               TxtSerialKey.ReadOnly = true;
            }
            else
            {
                TxtSerialKey.ReadOnly = false;
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TnPUser_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}