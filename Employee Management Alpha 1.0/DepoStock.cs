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
    public partial class DepoStock : Form
    {
        const string pattern = @"([^\s]+)"; //pattern to get the first string before a space
        Regex rg = new Regex(pattern);
        Stock stock;
        int Quantity;
        Item item;

        public DepoStock()
        {
            InitializeComponent();
        }

        private void StockList() // refreshes the stock list
        {
            lbDepoStock.Items.Clear();

            stock = new Stock();
            if (stock.GetAllDepoStock() is null)
            {
                lbDepoStock.Items.Add("The database is empty!");
            }
            else
            {
                for (int i = 0; i < stock.GetAllDepoStock().Count(); i++)
                {
                    lbDepoStock.Items.Add(stock.GetAllDepoStock()[i].ItemInfo());
                }
            }

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void DepoStock_Load(object sender, EventArgs e)
        {
            StockList();
        }

        private void BtnAddStockItem_Click(object sender, EventArgs e)
        {
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (tbID.Text == "" || tbNewCategory.Text == "" || tbNewItemName.Text == "")
            {
                MessageBox.Show("An item should be selected first!");
            }
            else
            {
                stock.ChangeDepoItem(tbID.Text, tbNewItemName.Text, Convert.ToInt32(tbNewQuantity.Value), Convert.ToInt32(tbNewPricePerUnit.Value), tbNewCategory.Text);
                stock.UpdateStockWithNoQuantity(tbID.Text, tbNewItemName.Text, Convert.ToInt32(tbNewQuantity.Value), Convert.ToInt32(tbNewPricePerUnit.Value), tbNewCategory.Text);
            }



            StockList(); // refresshing
        }

        private void LbDepoStock_Click(object sender, EventArgs e)
        {
            if (!(lbDepoStock.SelectedIndex.Equals(null)))
            {
                string ID = lbDepoStock.SelectedItem.ToString();
                Match match = Regex.Match(ID, pattern);
                if (match.Success)
                {
                    tbID.Text = match.Value;
                }
            }
        }

        private void TbID_TextChanged(object sender, EventArgs e)
        {
            Item item;
            item = new Item();
            item = stock.GetDepoItemsById(Convert.ToInt32(tbID.Text));
            tbNewItemName.Text = item.name;
            tbNewCategory.Text = item.category;
            tbNewPricePerUnit.Value = Convert.ToDecimal(item.pricePerUnit);
            tbNewQuantity.Text = Convert.ToString(item.quantity);
        }
    }
}
