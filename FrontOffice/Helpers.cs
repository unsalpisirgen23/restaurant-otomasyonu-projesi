using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontOffice
{
    public  class Helpers
    { 

        public static ComboBox InitStatus(ComboBox com,int selected = -1)
        { 
            Dictionary<int, string> status = new Dictionary<int, string>();
            status.Add(1, "Onayla");
            status.Add(0, "Onaylama");
            com.DataSource = new BindingSource(status, null);
            com.DisplayMember = "Value";
            com.ValueMember = "Key";

            if (selected == 1)
            {
                com.SelectedValue = 1;
            }
            else if(selected == 0)
            {
                com.SelectedValue = 0;
            }

            return com;
        }



        public static ComboBox InitGroupListCom(ComboBox com, Dictionary<int, string> comboSource)
        {              
            com.DataSource = new BindingSource(comboSource, null);
            com.DisplayMember = "Value";
            com.ValueMember = "Key";
            return com;
        }




        public static GridView InitGridControlGender(GridView gridView)
        {
            gridView.Columns["Gender"].Visible = false;
            gridView.Columns["Gender2"].UnboundType = DevExpress.Data.UnboundColumnType.String;
            gridView.CustomUnboundColumnData += (o, e) => {
                GridView view = o as GridView;
                if (e.Column == view.Columns["Gender2"])
                {
                    int sourceValue = (int)view.GetRowCellValue(view.GetRowHandle(e.ListSourceRowIndex), view.Columns["Gender"]);
                    if (sourceValue == 1)
                    {
                        e.Value = "Erkek";
                    }
                    else if (sourceValue == 2)
                    {
                        e.Value = "Kadın";
                    }
                }
            };
            return gridView;
        }





        public static GridView InitGridControlMaritalStatus(GridView gridView)
        {
            gridView.Columns["MaritalStatus"].Visible = false;
            gridView.Columns["MaritalStatus2"].UnboundType = DevExpress.Data.UnboundColumnType.String;
            gridView.CustomUnboundColumnData += (o, e) => {
                GridView view = o as GridView;
                if (e.Column == view.Columns["MaritalStatus2"])
                {
                    int sourceValue = (int)view.GetRowCellValue(view.GetRowHandle(e.ListSourceRowIndex), view.Columns["MaritalStatus"]);
                    if (sourceValue == 1)
                    {
                        e.Value = "Bekar";
                    }
                    else if (sourceValue == 2)
                    {
                        e.Value = "Evli";
                    }
                }
            };
            return gridView;
        }



        public static GridView InitGridControlStatus(GridView gridView)
        { 
            gridView.Columns["Status"].Visible = false;
            gridView.Columns["Status2"].UnboundType = DevExpress.Data.UnboundColumnType.String;
            gridView.CustomUnboundColumnData += (o,e)=> {
                GridView view = o as GridView;
                if (e.Column == view.Columns["Status2"])
                {
                    int sourceValue = (int)view.GetRowCellValue(view.GetRowHandle(e.ListSourceRowIndex), view.Columns["Status"]);
                    if (sourceValue == 1)
                    {
                        e.Value = "Onaylı";
                    }
                    else if (sourceValue == 0)
                    {
                        e.Value = "Onaysız";
                    }
                }
            };
            return gridView;
        }

        public static GridView InitGridControlAddedUser(GridView gridView)
        { 
            gridView.Columns["SessionMovementLoginID"].Visible = false;
            gridView.Columns["SessionMovementLoginID2"].UnboundType = DevExpress.Data.UnboundColumnType.String;
            gridView.CustomUnboundColumnData += (o, e) => {
                GridView view = o as GridView;
                if (e.Column == view.Columns["SessionMovementLoginID2"])
                {
                    int sourceValue = (int)view.GetRowCellValue(view.GetRowHandle(e.ListSourceRowIndex), view.Columns["SessionMovementLoginID"]);
                   var dd = Model.Db.EmployeRepositories.Get(c => c.ID == sourceValue);
                    try
                    {
                        e.Value = dd.FullName;
                    }
                    catch (Exception ex)
                    {
                        e.Value = " ";
                    }
         
                }
            };
            return gridView;
        }






        public static int InitGridControlSelectedByID(GridView gv,GridColumn gc)
        {
            int ID = -1;
            int[] selectedRows = gv.GetSelectedRows();
            foreach (int rowHandle in selectedRows)
            {
                ID = (int)gv.GetRowCellValue(rowHandle, gc);
            }
            return ID;
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





        public static byte[] ImageToArray(System.Drawing.Image imageIn, System.Drawing.Imaging.ImageFormat types)
        {
            byte[] buff = null;
                using (MemoryStream ms = new MemoryStream())
                {
                    imageIn.Save(ms, types);
                    buff = ms.ToArray();
                }
            return buff;
        }



        public static Image ArrayToImage(byte[] byteArrayIn)
        {
            Image returnImage = null;
            try
            { 
                MemoryStream ms = new MemoryStream(byteArrayIn, 0, byteArrayIn.Length);
                ms.Write(byteArrayIn, 0, byteArrayIn.Length);
                returnImage = Image.FromStream(ms, true);//Exception occurs here
            }
            catch { }
            return returnImage;
        }



        public static DialogResult ConfirimOkCancel(string text, string head)
        {
            return MessageBox.Show(text, head, MessageBoxButtons.OKCancel);
        }







        /*


        private void PopulateCountryComboBox(string countrs = "en-US")
        {
            try
            {
                RegionInfo country = new RegionInfo(new CultureInfo(countrs, true).LCID);

                List<string> countryNames = new List<string>();

                foreach (CultureInfo cul in CultureInfo.GetCultures(CultureTypes.SpecificCultures))
                {
                    country = new RegionInfo(new CultureInfo(cul.Name, false).LCID);

                    countryNames.Add(country.DisplayName.ToString());
                }

                IEnumerable<string> nameAdded = countryNames.OrderBy(names => names).Distinct();
                foreach (string item in nameAdded) { ComAddressProvice.Items.Add(item); }
            }
            catch (Exception ex)
            {


            }
        }

        private void CountryListCom()
        {
            CultureInfo[] cinfo = CultureInfo.GetCultures(CultureTypes.SpecificCultures);

            Dictionary<string, string> items = new Dictionary<string, string>();

            foreach (CultureInfo cul in cinfo)
            {
                RegionInfo R = new RegionInfo(cul.LCID);
                try
                {
                    items.Add(R.Name, R.EnglishName);
                }
                catch (Exception ex)
                {


                }
            }

            ComAddressCountry.DataSource = new BindingSource(items, null);

            ComAddressCountry.DisplayMember = "Value";
            ComAddressCountry.ValueMember = "Key";
        }

    */














    }
}
