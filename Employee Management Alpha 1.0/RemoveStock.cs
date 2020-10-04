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
    
    public partial class RemoveStock : Form
    {
        Stock stock;
        const string pattern = @"([^\s]+)"; //pattern to get the first string before a space
        private Regex rg = new Regex(pattern);

        public RemoveStock()
        {
            InitializeComponent();
            UpdateList();
        }


        private void UpdateList()
        {
            lbStockInfo.Items.Clear();
            stock = new Stock();
            if(stock.GetAllItems() is null)
            {
                MessageBox.Show("The database is empty!");
                lbStockInfo.Items.Add("The database is empty!");
            }
            else
            {
                for(int i = 0; i < stock.GetAllItems().Count(); i++)
                {
                    lbStockInfo.Items.Add(stock.GetAllItems()[i].ItemInfo());
                }
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close(); //closes the form, serves as return button
        }

        private void BtnRemoveStockItem_Click(object sender, EventArgs e) //Removes selected stock
        {
            string id = tbID.Text;

            stock.RemoveItembyId(id);
            UpdateList();
        }

        private void LbStockInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(lbStockInfo.SelectedIndex.Equals(null)))
            {
                string ID = lbStockInfo.SelectedItem.ToString();
                Match match = Regex.Match(ID, pattern);
                if (match.Success)
                {
                    tbID.Text = match.Value;
                }
            }
            else
            {
                return;
            }
        }

        /*
        private void StockList() // refreshes the stock list
        {
            lbStockInfo.Items.Clear();


            string metadata = "ID" + "\t" + "Name" + " \t " + " \t " + "Category" + "\t" + "\t" + "Quantity" + " \t " + " \t " + "Price per unit" + " \t " + " \t " + "Full price";
            lbStockInfo.Items.Add(metadata);

            foreach (Item itm in stock.GetStock())
            {
                lbStockInfo.Items.Add(itm);
            }
        }

        private void BtnRemoveStockItem_Click(object sender, EventArgs e) //Removes selected stock
        {
            if (lbStockInfo.SelectedIndex < 1)
            {
                MessageBox.Show("Please select an item first!");
            }
            else
            {
                Item selectedItem = (Item)lbStockInfo.SelectedItem;

                if (!stock.RemoveStock(selectedItem))
                {
                    MessageBox.Show("Item is not in the list!");
                }
                StockList(); // refresshing
            }
        }

        private void RemoveStock_Shown(object sender, EventArgs e)
        {
            StockList();
        }

        

        private void RemoveStock_Load(object sender, EventArgs e)
        {

        }

    */

    }
}
