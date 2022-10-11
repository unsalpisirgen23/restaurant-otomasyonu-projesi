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
using System.IO;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace BackOffice.Forms.Products
{
    public partial class FrmProductAdd : DevExpress.XtraEditors.XtraForm
    {
        private byte[] image = null;

        public FrmProductAdd()
        {
            InitializeComponent();
        }

        public void Status()
        {
            Dictionary<int, string> status = new Dictionary<int, string>();
            status.Add(1, "Onayla");
            status.Add(0, "Onaylama");
            ComStatus.DataSource = new BindingSource(status, null);
            ComStatus.DisplayMember = "Value";
            ComStatus.ValueMember = "Key";
        }

        private void TableGroupListCom()
        {

            Dictionary<int, string> comboSource = new Dictionary<int, string>();
            comboSource.Add(-1, "Masa Grubu Seçiniz");
            var tableGroupList = Model.Db.ProductGroupRepositories.GetList(g => g.Status == 1);

            foreach (var tg in tableGroupList)
            {
                comboSource.Add(tg.ID, tg.Name);
            }

            ComGroup.DataSource = new BindingSource(comboSource, null);
            ComGroup.DisplayMember = "Value";
            ComGroup.ValueMember = "Key";
        }
        
        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Resim Türleri (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";  
            openFileDialog1.Title = "Bir Resim Seçiniz";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackgroundImage = System.Drawing.Image.FromFile(openFileDialog1.FileName);
                pictureBox1.BackgroundImage = ResizeImage(pictureBox1.BackgroundImage, 170 , 137);
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;               
            }
        }

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            byte[] buff = null;
            if (openFileDialog1.FileName.Contains("png"))
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    buff = ms.ToArray();
                }
              
            }
            else if (openFileDialog1.FileName.Contains("jpg") || openFileDialog1.FileName.Contains("jpeg"))
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    buff = ms.ToArray();
                }
            }
            return buff;
        }

     

        private void BtnAdd_Click_1(object sender, EventArgs e)
        {
            if (TxtName.Text == "" || pictureBox1.BackgroundImage == null)
            {
                MessageBox.Show("Ürün adı,Ürün Fiyatı veya Ürün Resmi Boş Olamaz!");
            }
            else
            {     
                Model.Db.ProductRepositories.Add(new DAL.Entities.Products.Product()
                {
                    AddDate = DateTime.Now,
                    Name = TxtName.Text,
                    Price = Convert.ToDecimal(TxtPrice.Text.Trim('₺')),
                    ProductGroupID = (int)ComGroup.SelectedValue,
                    SessionMovementLoginID = Program.LoginEmploye.ID,
                    Status = (int)ComStatus.SelectedValue,
                    Picture = imageToByteArray(pictureBox1.BackgroundImage)
                });
                Model.Save();
                MessageBox.Show("Tebrikler Ürün Başarıyla Eklendi.");
                TxtName.Text = "";
                TxtPrice.Text = "";
                TableGroupListCom();
                Status();
            }
        }

        private void FrmProductAdd_Load(object sender, EventArgs e)
        {
            TableGroupListCom();
            Status();
        }

        private void TxtPrice_TextChanged(object sender, EventArgs e)
        {
            string value = TxtPrice.Text.Replace(".", "").Replace("TL", "");
            decimal ul;
            //Check we are indeed handling a number
            if (decimal.TryParse(value, out ul))
            {
                //Unsub the event so we don't enter a loop
                TxtPrice.TextChanged -= TxtPrice_TextChanged;
                //Format the text as currency
                TxtPrice.Text = string.Format("{0:C2}", ul);
                TxtPrice.TextChanged += TxtPrice_TextChanged;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (TxtName.Text == "" || pictureBox1.BackgroundImage == null)
            {
                MessageBox.Show("Ürün adı,Ürün Fiyatı veya Ürün Resmi Boş Olamaz!");
            }
            else
            {
                Model.Db.ProductRepositories.Add(new DAL.Entities.Products.Product()
                {
                    AddDate = DateTime.Now,
                    Name = TxtName.Text,
                    Price = Convert.ToDecimal(TxtPrice.Text.Trim('₺')),
                    ProductGroupID = (int)ComGroup.SelectedValue,
                    SessionMovementLoginID = Program.LoginEmploye.ID,
                    Status = (int)ComStatus.SelectedValue,
                    Picture = imageToByteArray(pictureBox1.BackgroundImage)
                });
                Model.Save();
                MessageBox.Show("Tebrikler Ürün Başarıyla Eklendi.");
                TxtName.Text = "";
                TxtPrice.Text = "";
                TableGroupListCom();
                Status();
                Close();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}