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
using System.Linq.Expressions;
using DAL.Entities.Products;
using System.IO;
using System.Drawing.Imaging;

namespace BackOffice.Forms.Products
{
    public partial class FrmProductGroupList : DevExpress.XtraEditors.XtraForm
    {
        public FrmProductGroupList()
        {
            InitializeComponent();
        }

        private void Status()
        {
            ComStatus = Helpers.InitStatus(ComStatus);
        }

        private void load(Expression<Func<ProductGroup, bool>> filter = null)
        {
            gridControl2.DataSource = Model.Db.ProductGroupRepositories.GetList(filter);
            gridView2 = Helpers.InitGridControlStatus(gridView2);
        }

        private int id { get { int id = Helpers.InitGridControlSelectedByID(gridView2, GcID); return id; } set {  } }

        private void FrmProductGroupList_Load(object sender, EventArgs e)
        {
            Status();
            load();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (TxtSearchName.Text == "")
            {
                load();
            }
            else
            {
                load(c => c.Name.Contains(TxtSearchName.Text));
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Resim Türleri (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            openFileDialog1.Title = "Bir Resim Seçiniz";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackgroundImage = System.Drawing.Image.FromFile(openFileDialog1.FileName);
                pictureBox1.BackgroundImage = Helpers.ResizeImage(pictureBox1.BackgroundImage, 170, 137);
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }



        private void BtnEdit_Click(object sender, EventArgs e)
        {
            var  p = Model.Db.ProductGroupRepositories.Get(c => c.ID == id);
              TxtEditName.Text = p.Name;   
              pictureBox1.BackgroundImage = Helpers.ArrayToImage(p.Picture);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (TxtEditName.Text == "")
            {
                MessageBox.Show("Ad Alanı Boş Burakılamaz!");
            }
            else
            {
                byte[] img = null;

                if (openFileDialog1.FileName.Contains("jpg") || openFileDialog1.FileName.Contains("jpeg"))
                {
                    img = Helpers.ImageToArray(pictureBox1.BackgroundImage, ImageFormat.Jpeg);
                }
                else if (openFileDialog1.FileName.Contains("png"))
                {
                    img = Helpers.ImageToArray(pictureBox1.BackgroundImage, ImageFormat.Png);
                }

                Model.Db.ProductGroupRepositories.Update(new ProductGroup()
                {
                    ID = id,
                    Name = TxtEditName.Text,
                    SessionMovementLoginID = 1,
                    UpdateDate = DateTime.Now,
                    Status = (int)ComStatus.SelectedValue,
                    Picture = img
                });
                Model.Save();
                MessageBox.Show("Tebrikler Ürün Başarıyla Kaydedildi.");
                TxtEditName.Text = "";
                id = 0;
                pictureBox1.BackgroundImage = null;
                load();
            }

        }

     

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (Helpers.ConfirimOkCancel("Bu İçeriği Silmek İstediğinizden Emin Misiniz?","DİKKAT SİLİNECEK") == DialogResult.OK)
            {
                  Model.Db.ProductGroupRepositories.Delete(c => c.ID == id);
                  Model.Save();
                  load();
            }
              
        }



    }
}