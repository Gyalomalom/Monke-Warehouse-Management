using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_Alpha_1._0
{
    public partial class RemoveStock : Form
    {
        Stock stock;

        public RemoveStock(Stock stock)
        {
            InitializeComponent();
            this.stock = stock;
        }

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

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close(); //closes the form, serves as return button
        }
    }
}
