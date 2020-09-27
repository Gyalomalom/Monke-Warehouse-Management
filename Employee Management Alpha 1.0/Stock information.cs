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
    public partial class Stock_information : Form
    {
        
        Stock stock;

        public Stock_information()
        {
            InitializeComponent();
            stock = new Stock(this);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close(); //closes the form, serves as return button
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




        public void AddItem() // Adds a new item to the stock list
        {
            if (!string.IsNullOrEmpty(tbName.Text))
            {
                string name = tbName.Text;
                int quantity = Convert.ToInt32(tbQuantity.Text);
                double pricePerUnit = Convert.ToDouble(tbPricePerUnit.Text);
                string category = cbCategory.Text;


                stock.AddStock(name, quantity, pricePerUnit, category);
                StockList();
            }
            else
            {
                MessageBox.Show("Please enter name, quantity and price per unit");
            }

            tbName.Text = "";
            tbPricePerUnit.Value = 0;
            tbQuantity.Value = 0;
            cbCategory.Text = "";

        }

        public void RemoveItem() // method for manually removing items
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

            tbName.Text = "";
            tbPricePerUnit.Value = 0;
            tbQuantity.Value = 0;
            cbCategory.Text = "";
        }

        public void Updates() // method for changing the quantity and price of the items
        {
            if (!string.IsNullOrEmpty(tbName.Text))
            {
                string name = tbName.Text;
                int quantity = Convert.ToInt32(tbQuantity.Text);
                double pricePerUnit = Convert.ToDouble(tbPricePerUnit.Text);



                if (!stock.UpdateStock(name, quantity, pricePerUnit))
                {
                    MessageBox.Show("There is no such item in the list!");
                }

                StockList();

                tbName.Text = "";
                tbPricePerUnit.Value = 0;
                tbQuantity.Value = 0;
                cbCategory.Text = "";
            }
        }


        private void BtnRemoveStockItem_Click(object sender, EventArgs e)
        {
            RemoveItem();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Updates();
        }

        private void BtnAddStockItem_Click_1(object sender, EventArgs e)
        {
            AddItem();
        }

        private void Stock_information_Load(object sender, EventArgs e)
        {

        }
        
    }
}
