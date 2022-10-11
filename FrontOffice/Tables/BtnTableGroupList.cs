using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontOffice.Tables
{
    public class BtnTableGroupList : SimpleButton
    {
        public int ID { get; set; }

        public BtnTableGroupList()
        {
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.Appearance.BorderColor = System.Drawing.Color.Black;
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 10.75F);
            this.Appearance.ForeColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseBorderColor = true;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AppearanceHovered.Options.UseBackColor = true;
            this.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BtnProductGroup";
            this.Size = new System.Drawing.Size(123, 50);
            this.TabIndex = 1;
        }
    }
}
