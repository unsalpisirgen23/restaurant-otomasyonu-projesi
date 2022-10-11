using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


   public class Helpers
    {
        private static string _FieldName;

        public static object BomboBoxList(System.Windows.Forms.ComboBox comboBox, Dictionary<int, string> comboSource)
        {
            comboBox.DataSource = new BindingSource(comboSource, null);
            return comboBox.DataSource;
        }


        public static GridColumn addColumn(string FieldName,string Caption)
        {
            GridColumn customColPrice = new GridColumn();
            _FieldName = FieldName;
            customColPrice.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            customColPrice.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            customColPrice.AppearanceCell.Options.UseFont = true;
            customColPrice.AppearanceHeader.Options.UseFont = true;
            customColPrice.OptionsColumn.AllowEdit = false;
            customColPrice.OptionsColumn.AllowFocus = false;
            customColPrice.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            customColPrice.OptionsColumn.AllowSize = false;
            customColPrice.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            customColPrice.OptionsColumn.FixedWidth = true;
            customColPrice.VisibleIndex = 1;
            customColPrice.Width = 110;
            customColPrice.FieldName = FieldName;
            customColPrice.UnboundType = DevExpress.Data.UnboundColumnType.String;
            customColPrice.Caption = Caption;
            customColPrice.Visible = true;
            return customColPrice;
        }

        public static void ColunmStatus(GridView gridView1, GridColumn customColPrice )
        {
            //create a column that replaces the hidden column       
            gridView1.Columns.Add(customColPrice);
            //handle CustomUnboundColumnData
            gridView1.CustomUnboundColumnData += GridView1_CustomUnboundColumnData;
        }


      static  void GridView1_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Column == view.Columns[_FieldName])
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
        }


    }
