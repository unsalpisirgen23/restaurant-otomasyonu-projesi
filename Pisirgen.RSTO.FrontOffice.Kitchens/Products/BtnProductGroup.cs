using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontOffice.Kitchens.Products
{
    public class BtnProductGroup : SimpleButton
    {
        public int ID { get; set; }

        public BtnProductGroup()
        {
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

            this.Margin = new System.Windows.Forms.Padding(1);

            this.Size = new System.Drawing.Size(120, 85);

            this.TabIndex = 0;

        }

    }
}
