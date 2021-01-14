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
    public partial class StockRequest : Form
    {
        const string pattern = @"([^\s]+)"; //pattern to get the first string before a space
        Regex rg = new Regex(pattern);
        Stock stock;
        int Quantity;
        Item item;
        

        public StockRequest()
        {
            InitializeComponent();
        }

        private void StockList() // refreshes the stock list
        {
            lbLowQuantityItems.Items.Clear();

            stock = new Stock();
            if (stock.GetAllItems() is null)
            {
                lbLowQuantityItems.Items.Add("The database is empty!");
            }
            else
            {
                for (int i = 0; i < stock.GetAllItems().Count(); i++)
                {
                    lbLowQuantityItems.Items.Add(stock.GetAllItems()[i].ItemInfo());
                }
            }

        }

        private void RequestList()
        {
            lbRequests.Items.Clear();

            stock = new Stock();
            if (stock.GetAllRequests() is null)
            {
                lbRequests.Items.Add("The database is empty!");
            }
            else
            {
                for (int i = 0; i < stock.GetAllRequests().Count(); i++)
                {
                   lbRequests.Items.Add(stock.GetAllRequests()[i].StocKRequestInformation());
                }
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close(); //closes the form, serves as return button
        }

        private void StockRequest_Load(object sender, EventArgs e)
        {
            StockList();
            RequestList();
        }

        private void LbLowQuantityItems_Click(object sender, EventArgs e)
        {
            if (!(lbLowQuantityItems.SelectedItem == null))
            {
                string ID = lbLowQuantityItems.SelectedItem.ToString();
                Match match = Regex.Match(ID, pattern);
                if (match.Success)
                {
                    tbID.Text = match.Value;
                }
            }
        }

        private void BtnBuyStock_Click(object sender, EventArgs e)
        {
            if(tbID.Text == "")
            {
                MessageBox.Show("Please select an item first");
            }
            else
            {
                item = new Item();
                item = stock.GetItemsById(Convert.ToInt32(tbID.Text));
                string name = item.name;
                int amount = Convert.ToInt32(numUpDownAmount.Value);
                int id = item.id;
                DateTime now = DateTime.Now;
                stock.AddStockRequest(id, name, amount);
            }

            tbID.Text = "";
            numUpDownAmount.Value = 1;
            StockList();
            RequestList();
        }

        private void LbRequests_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            lbLowQuantityItems.Items.Clear();
            stock = new Stock();
            stock.SearchItemStock(tbSearchBar.Text);


            if (stock.SearchItemStock(tbSearchBar.Text) is null)
            {
                lbLowQuantityItems.Items.Add("No items with such name!");
            }
            else
            {
                for (int i = 0; i < stock.SearchItemStock(tbSearchBar.Text).Count(); i++)
                {
                    lbLowQuantityItems.Items.Add(stock.SearchItemStock(tbSearchBar.Text)[i].ItemInfo());
                }
            }
        }

        private void TbSearchBar_TextChanged(object sender, EventArgs e)
        {
            if(tbSearchBar.Text == "")
            {
                StockList();
            }
        }
    }
}
