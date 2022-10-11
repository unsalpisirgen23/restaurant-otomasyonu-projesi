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
using DAL.Entities.Products;
using System.Linq.Expressions;
using DevExpress.XtraEditors.Repository;

namespace BackOffice.Forms.Products
{
    public partial class FrmProductList : DevExpress.XtraEditors.XtraForm
    {

        private int id { get { return Helpers.InitGridControlSelectedByID(gridView2, GcID); } set { } }

        public FrmProductList()
        {
            InitializeComponent();
        }

        private void load(Expression<Func<Product, bool>> filter = null)
        {
            gridControl2.DataSource = Model.Db.ProductRepositories.GetList(filter);
            
            gridView2 = Helpers.InitGridControlStatus(gridView2);
        }

        private void FrmProductList_Load(object sender, EventArgs e)
        {
            load();
        }


        private void btnEdit_DoubleClick(object sender, EventArgs e)
        {
            FrmProductEdit edit = new FrmProductEdit(id);
            edit.ShowDialog();
            load();
        }

        private void btnDelete_DoubleClick(object sender, EventArgs e)
        {
            if (Helpers.ConfirimOkCancel("Bu içeriği seilmek istediğinizden eminmisiniz?","DİKKAT SİLİNECEK")==DialogResult.OK)
            {
                Model.Db.ProductRepositories.Delete(c => c.ID == id);
                Model.Save();
                MessageBox.Show("Tebrikler içeriğiniz başarıyla silindi.");
                load();
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            load(p => p.Name.Contains(TxtEditName.Text));
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtEditName.Text = "";
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}