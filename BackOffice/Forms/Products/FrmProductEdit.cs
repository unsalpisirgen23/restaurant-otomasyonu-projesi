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
using System.Drawing.Imaging;

namespace BackOffice.Forms.Products
{
    public partial class FrmProductEdit : DevExpress.XtraEditors.XtraForm
    {
        private int id;
        private Product product;
        private int Chenc = 0;

        public FrmProductEdit(int id = 0)
        {
            this.id = id;
            InitializeComponent();
        }

        private void FrmProductEdit_Load(object sender, EventArgs e)
        {
            product = Model.Db.ProductRepositories.Get(p => p.ID == id,i=>i.ProductGroup);
            ComStatus = Helpers.InitStatus(ComStatus,product.Status);
            var d = new Dictionary<int, string>();
            var g = Model.Db.ProductGroupRepositories.GetList(gg => gg.Status == 1);
            foreach (var item in g)
            {
                d.Add(item.ID, item.Name);
            }
            ComGroup = Helpers.InitGroupListCom(ComGroup,d); 
                ComGroup.SelectedValue = product.ProductGroup.ID;
            TxtName.Text = product.Name;
            TxtPrice.Text = product.Price.ToString();
            pictureBox1.BackgroundImage = Helpers.ArrayToImage(product.Picture);
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
            Chenc = 1;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public byte[] imageToByteArray()
        {
            byte[] buff = null;

            if (Chenc == 1)
            {
                if (openFileDialog1.FileName.Contains("png"))
                {
                    buff = Helpers.ImageToArray(pictureBox1.BackgroundImage, ImageFormat.Png);
                }
                else if (openFileDialog1.FileName.Contains("jpg") || openFileDialog1.FileName.Contains("jpeg"))
                {
                    buff = Helpers.ImageToArray(pictureBox1.BackgroundImage, ImageFormat.Jpeg);
                }
            }
            else
            {
                buff = product.Picture;
            }
            return buff;
        }


        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (TxtName.Text == "")
            {
                MessageBox.Show("Ürün adı boş burakılamaz!");
            }
            else
            {
                Model.Db.ProductRepositories.Update(new Product()
                {
                    ID = id,
                    Name = TxtName.Text,
                    Picture = imageToByteArray(),
                    Price = Convert.ToDecimal(TxtPrice.Text),
                    ProductGroupID = (int)ComGroup.SelectedValue,
                    Status = (int)ComStatus.SelectedValue,
                    UpdateDate = DateTime.Now,
                    SessionMovementLoginID = 1
                });
                Model.Save();
                MessageBox.Show("Tebrikler ürün başarıyla güncellendi.");
                Close();
            }
        }



    }
}