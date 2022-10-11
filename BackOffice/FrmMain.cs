using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;


namespace BackOffice
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        /// <summary>
        /// Program Kapanış Denetleme durumu Değişkeni 
        /// </summary>
        public int CloseStatus { get; internal set; }
  
        public FrmMain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Program dan Çıkma Olayı
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseStatus = 1;
            e.Cancel = false;
        }
        /// <summary>
        /// Masa Ekleme Butonu Tıklama Olayı
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnItemTableAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            Forms.Tables.FrmTableAdd addtable = new Forms.Tables.FrmTableAdd();
            addtable.MdiParent = this;
            addtable.Show();
        }
        /// <summary>
        /// Masa Listeleme Tıklama Olayı
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnItemTableList_ItemClick(object sender, ItemClickEventArgs e)
        {
            Forms.Tables.FrmTableList tablelist = new Forms.Tables.FrmTableList();
            tablelist.MdiParent = this;
            tablelist.Show();
        }
        /// <summary>
        /// Masa Grup Ekleme Tıklama Olayı
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnItemTableGroupAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            Forms.Tables.FrmTableGroupAdd tablegroupadd = new Forms.Tables.FrmTableGroupAdd();
            tablegroupadd.MdiParent = this;
            tablegroupadd.Show();
        }
        /// <summary>
        /// Masa Grupları Listeleme Tıklama Olayı
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnItemTableGroupList_ItemClick(object sender, ItemClickEventArgs e)
        {
            Forms.Tables.FrmTableGroupList tablegrouplist = new Forms.Tables.FrmTableGroupList();
            tablegrouplist.MdiParent = this;
            tablegrouplist.Show();
        }
        /// <summary>
        /// Ürün Ekleme Tıklama Olayı
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnItemProductAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            Forms.Products.FrmProductAdd p = new Forms.Products.FrmProductAdd();
            p.MdiParent = this;
            p.Show();
        }
        /// <summary>
        /// Ürün Grupları Ekleme Tıklama Olayı
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnItemProductGroupAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            Forms.Products.FrmProductGroupAdd a = new Forms.Products.FrmProductGroupAdd();
            a.MdiParent = this;
            a.Show();
        }
        /// <summary>
        /// Ürün Grupları Listeleme Tıklama Olayı
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnItemProductGroupList_ItemClick(object sender, ItemClickEventArgs e)
        {
            Forms.Products.FrmProductGroupList g = new Forms.Products.FrmProductGroupList();
            g.MdiParent = this;
            g.Show();
        }
        /// <summary>
        /// Ürün Listeleme Tıklama Olayı
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnItemProductList_ItemClick(object sender, ItemClickEventArgs e)
        {
            Forms.Products.FrmProductList p = new Forms.Products.FrmProductList();
            p.MdiParent = this;
            p.Show();
        }
        /// <summary>
        /// Çalışan Ekleme Tıklama Olayı
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnItemEmployeAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            Forms.Employees.FrmEmployeAdd f = new Forms.Employees.FrmEmployeAdd();
            f.MdiParent = this;
            f.Show();
        }

        private void BtnItemEmployeList_ItemClick(object sender, ItemClickEventArgs e)
        {
            Forms.Employees.FrmEmployeList l = new Forms.Employees.FrmEmployeList();
            l.MdiParent = this;
            l.Show();
        }


        private void BtnCustomerAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            Forms.Customers.FrmCustomerAdd add = new Forms.Customers.FrmCustomerAdd();
            add.MdiParent = this;
            add.Show();
        }

        private void BtnCustomerList_ItemClick(object sender, ItemClickEventArgs e)
        {
            Forms.Customers.FrmCustomerList list = new Forms.Customers.FrmCustomerList();
            list.MdiParent = this;
            list.Show();
        }

    }
}