using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontOffice.Kitchens.Products
{
    public class BtnProducts : SimpleButton
    {
        private int _Height = 150;
        private int _Width = 180;

        public string LabelText { set { ll.Text = value; } get { return ll.Text; } }

        public int ID { get; set; }

        public event EventHandler BtnProductsClickEvent;

        private Label ll;

        public BtnProducts()
        {
            Width = _Width;
            Height = _Height;
            Text = "";

            Controls.Clear();

            ll = new Label()
            {
                Dock = DockStyle.Bottom,
                Width = _Width,
                Height = 20,
                BackColor = Color.Black,
                Font = new Font("Tahoma", 10F, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.White
            };

            Controls.Add(ll);

            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Appearance.BorderColor = System.Drawing.Color.Black;
            AllowFocus = false;
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseBorderColor = true;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(3);
            this.TabIndex = 0;



            Click += (o, e) => { if (BtnProductsClickEvent != null) BtnProductsClickEvent(o, e); };











        }





    }
}
