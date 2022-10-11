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
using System.Drawing.Imaging;

namespace BackOffice.Forms.Products
{
    public partial class FrmProductGroupAdd : DevExpress.XtraEditors.XtraForm
    {
        private byte[] img;

        public FrmProductGroupAdd()
        {
            InitializeComponent();
        }

        private void FrmProductGroupAdd_Load(object sender, EventArgs e)
        {
           ComStatus = Helpers.InitStatus(ComStatus);
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



        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (TxtName.Text.Trim() == "")
            {
                MessageBox.Show("Ürün Grubu Adı Boş Burakılamaz.");
            }
            else
            {
                if (openFileDialog1.FileName.Contains("png"))
                {
                    img = Helpers.ImageToArray(pictureBox1.BackgroundImage, ImageFormat.Png);
                }
                else if (openFileDialog1.FileName.Contains("jpg") || openFileDialog1.FileName.Contains("jpeg"))
                {
                    img = Helpers.ImageToArray(pictureBox1.BackgroundImage, ImageFormat.Jpeg);
                }

                Model.Db.ProductGroupRepositories.Add(new DAL.Entities.Products.ProductGroup()
                {
                    AddDate = DateTime.Now,
                    Status = (int)ComStatus.SelectedValue,
                    SessionMovementLoginID = Program.LoginEmploye.ID,
                    Name = TxtName.Text,
                    Picture = img
                });
                Model.Save();
                MessageBox.Show("Tebrikler Ürün Grubu Başarıyla Kaydedildi");
                TxtName.Text = "";
                ComStatus = Helpers.InitStatus(ComStatus);
                pictureBox1.BackgroundImage = null;
            }
 
        }




        private void BtnAddClose_Click(object sender, EventArgs e)
        {
            if (TxtName.Text.Trim() == "")
            {
                MessageBox.Show("Ürün Grubu Adı Boş Burakılamaz.");
            }
            else
            {
                if (openFileDialog1.FileName.Contains("png"))
                {
                    img = Helpers.ImageToArray(pictureBox1.BackgroundImage, ImageFormat.Png);
                }
                else if (openFileDialog1.FileName.Contains("jpg") || openFileDialog1.FileName.Contains("jpeg"))
                {
                    img = Helpers.ImageToArray(pictureBox1.BackgroundImage, ImageFormat.Jpeg);
                }

                Model.Db.ProductGroupRepositories.Add(new DAL.Entities.Products.ProductGroup()
                {
                    AddDate = DateTime.Now,
                    Status = (int)ComStatus.SelectedValue,
                    SessionMovementLoginID = Program.LoginEmploye.ID,
                    Name = TxtName.Text,
                    Picture = img
                });
                Model.Save();
                MessageBox.Show("Tebrikler Ürün Grubu Başarıyla Kaydedildi");
                TxtName.Text = "";
                ComStatus = Helpers.InitStatus(ComStatus);
                pictureBox1.BackgroundImage = null;
                Close();
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}