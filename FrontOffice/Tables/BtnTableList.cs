using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontOffice.Tables
{
    public class BtnTableList : SimpleButton
    {

        public int ID { get; set; }

        public int PlugID { get; set; }

        public BtnTableList()
        {
            this.Appearance.BorderColor = System.Drawing.Color.Black;
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F);
            this.Appearance.ForeColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseBorderColor = true;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AppearanceHovered.Options.UseBackColor = true;
            this.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BtnProduct";
            this.Size = new System.Drawing.Size(110, 90);
            this.TabIndex = 1;
        }

    }
}
