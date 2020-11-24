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
    public partial class DepoRequest : Form
    {
        const string pattern = @"([^\s]+)"; //pattern to get the first string before a space
        Regex rg = new Regex(pattern);
        Stock stock;
        Item item;
        int id;

        public DepoRequest()
        {
            InitializeComponent();
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
            this.Close(); 
        }

        private void LbRequests_Click(object sender, EventArgs e)
        {
            if (!(lbRequests.SelectedIndex.Equals(null)))
            {
                string ID = lbRequests.SelectedItem.ToString();
                Match match = Regex.Match(ID, pattern);
                if (match.Success)
                {
                    tbID.Text = match.Value;
                }
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void TbID_TextChanged(object sender, EventArgs e)
        {
            StockRequestInfo stockRequestInfo;
            stockRequestInfo = new StockRequestInfo();
            stockRequestInfo = stock.GetRequestByID(Convert.ToInt32(tbID.Text));
            numUpDownAmount.Value = stockRequestInfo.Amount;

        }

        private void DepoRequest_Load(object sender, EventArgs e)
        {
            RequestList();
        }

        private void BtnRequestStock_Click(object sender, EventArgs e)
        {
            Item item;
            item = new Item();
            item = stock.GetItemsById(Convert.ToInt32(tbID.Text));
            int quantity = item.quantity;

            if (tbID.Text == "")
            {
                MessageBox.Show("Please select an item first!");
            }
            else
            {
                int id = Convert.ToInt32(tbID.Text);
                int existingDepoStock = stock.GetQuantityFromDepo(id);

                if(existingDepoStock > Convert.ToInt32(numUpDownAmount.Value))
                {
                    stock.AcceptStockRequest(tbID.Text, Convert.ToInt32(quantity), Convert.ToInt32(numUpDownAmount.Value));
                    stock.RemoveRequestById(id);
                }
                else
                {
                    MessageBox.Show("Not enough items in depo!");
                }
            }
            RequestList();
        }
    }
}
