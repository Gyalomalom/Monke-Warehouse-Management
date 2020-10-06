using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_Alpha_1._0
{
    public partial class Stock_information : Form
    {
        Stock stock;
        const string pattern = @"([^\s]+)"; //pattern to get the first string before a space
        Regex rg = new Regex(pattern);

        public Stock_information()
        {
            InitializeComponent();
            
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close(); //closes the form, serves as return button
        }

        private void StockList() // refreshes the stock list
        {
            lbStockInfo.Items.Clear();

            stock = new Stock();
            if (stock.GetAllItems() is null)
            {
                MessageBox.Show("The database is empty!");
                lbStockInfo.Items.Add("The database is empty!");
            }
            else
            {
                for (int i = 0; i < stock.GetAllItems().Count(); i++)
                {
                    lbStockInfo.Items.Add(stock.GetAllItems()[i].ItemInfo());
                }
            }

        }

        private void BtnRemoveStockItem_Click(object sender, EventArgs e)
        {
           // RemoveItem();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

            stock.ChangeItem(tbID.Text, tbNewItemName.Text, Convert.ToInt32(tbNewQuantity.Value), Convert.ToInt32(tbNewPricePerUnit.Value), tbNewCategory.Text);
                

                StockList(); // refresshing
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Stock_information_Shown(object sender, EventArgs e)
        {
            StockList();
        }

        private void Stock_information_Load(object sender, EventArgs e)
        {

        }

        private void Stock_information_Load_1(object sender, EventArgs e)
        {
            StockList();
        }

        private void LbStockInfo_Click(object sender, EventArgs e)
        {
            if(!(lbStockInfo.SelectedIndex.Equals(null)))
            {
                string ID = lbStockInfo.SelectedItem.ToString();
                Match match = Regex.Match(ID, pattern);
                if(match.Success)
                {
                    tbID.Text = match.Value;
                }
            }
        }

        private void TbID_TextChanged(object sender, EventArgs e)
        {
            Item item;
            item = new Item();
            item = stock.GetItemsById(Convert.ToInt32(tbID.Text));
            tbNewItemName.Text = item.name;
            tbNewCategory.Text = item.category;
            tbNewPricePerUnit.Value = Convert.ToDecimal(item.pricePerUnit);
            tbNewQuantity.Text = Convert.ToString(item.quantity);
        }
    }
}
