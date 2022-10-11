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

namespace FrontOffice.Kitchens
{
    public partial class UcKitchen : DevExpress.XtraEditors.XtraUserControl
    {
        public int ProductID { get; set; }
        public int TableID { get; set; }
         

        public UcKitchen()
        {
          
            InitializeComponent();
            Run();
        }

        public void Run()
        {
            ucProductList1.ProductGroupList();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            DAL.Entities.Plugs.Plug plug = new DAL.Entities.Plugs.Plug()
            {
                AddDate = DateTime.Now,
                ParentID = 0,
                SeriNo = Guid.NewGuid(),
                SessionMovementLoginID = 0,
                TableID = TableID
            };
            Model.Db.PlugRepositories.Add(plug);
            Model.Save();
        }
         
        private void ucProductList1_BtnProductEventClick(object sender, EventArgs e)
        {
            BtnProducts g = (BtnProducts)sender;
            ProductID = g.ID;
        }
 

        private void ucProductMovementsList1_BtnBulkDiscountEventClick(object sender, EventArgs e)
        {

        }

        private void ucProductMovementsList1_BtnDiscountEventClick(object sender, EventArgs e)
        {

        }

        private void ucKeyped1_BtnApplyEventClick(object sender, EventArgs e)
        {

        }
    }
}
