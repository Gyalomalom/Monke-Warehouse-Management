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
                MessageBox.Show("The database is empty!");
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
                MessageBox.Show("The database is empty!");
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
            if (!(lbLowQuantityItems.SelectedIndex.Equals(null)))
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
                DateTime now = DateTime.Now;
                stock.AddStockRequest($"{name}  {now.ToString()}");
            }

            tbID.Text = "";
            StockList();
            RequestList();
        }
    }
}
