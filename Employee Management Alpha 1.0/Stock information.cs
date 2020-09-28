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
            int b = Form1.Items.Count();
            lbStockInfo.Items.Clear();

            string metadata = "Name" + " \t " + " \t " + "Quantity" + " \t " + " \t " + "Price per unit" + " \t " + " \t " + "Full price";
            lbStockInfo.Items.Add(metadata);

            for (int a = 0; a < b; a++)
            {
                lbStockInfo.Items.Add(StockData(a));
            }
        }

        private string StockData(int a)
        {
            string info = Form1.Items[a] + " \t " + " \t " + Form1.Quantity[a] + " \t " + " \t " + Form1.PricePerUnit[a] + " \t " + "\t" + " \t " + (Form1.Quantity[a] * Form1.PricePerUnit[a]);
            return info;
        }

        private void TbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddItem() // Adds a new item to the stock list
        {
            if (!string.IsNullOrEmpty(tbName.Text))
            {
                string name = tbName.Text;
                int quantity = Convert.ToInt32(tbQuantity.Text);
                double pricePerUnit = Convert.ToDouble(tbPricePerUnit.Text);

                if (!Form1.Items.Contains(name))
                {
                    Form1.Items.Add(name);
                    Form1.Quantity.Add(quantity);
                    Form1.PricePerUnit.Add(pricePerUnit);
                    StockList();
                }
                else // if the item is already on the list, it adds quantity to that item
                {
                    int index = Form1.Items.IndexOf(name);
                    int quan = Form1.Quantity[index];
                    Form1.Quantity[index] = quan + quantity;
                    StockList();
                }
            }
            else
            {
                MessageBox.Show("Please enter name, quantity and price per unit");
            }

            tbName.Text = "";
            tbPricePerUnit.Value = 0;
            tbQuantity.Value = 0;

        }

        private void RemoveItem() // method for manually removing items
        {
            if (!string.IsNullOrWhiteSpace(tbName.Text))
            {
                string name = tbName.Text;
                int i = Form1.Items.IndexOf(name);
                if (Form1.Items.Contains(name))
                {
                    Form1.Items.RemoveAt(i);
                    Form1.Quantity.RemoveAt(i);
                    Form1.PricePerUnit.RemoveAt(i);
                    StockList();
                }
                else
                { MessageBox.Show("Item is not in the list!"); }
            }
            else
            { MessageBox.Show("Please enter an item name first!"); }

            tbName.Text = "";
            tbPricePerUnit.Value = 0;
            tbQuantity.Value = 0;
        }

        private void Updates() // method for changing the quantity and price of the items
        {
            if (!string.IsNullOrEmpty(tbName.Text))
            {
                string name = tbName.Text;
                int quantity = Convert.ToInt32(tbQuantity.Text);
                double pricePerUnit = Convert.ToDouble(tbPricePerUnit.Text);

                if (!Form1.Items.Contains(name))
                {
                    MessageBox.Show("There is no such item in the list!");
                }
                else // if the item is already on the list, it adds quantity to that item
                {
                    int index = Form1.Items.IndexOf(name);
                    Form1.Quantity[index] = quantity;
                    Form1.PricePerUnit[index] = pricePerUnit;
                    StockList();
                }

                tbName.Text = "";
                tbPricePerUnit.Value = 0;
                tbQuantity.Value = 0;
            }
        

        }
        private void BtnAddStockItem_Click(object sender, EventArgs e)
        {
            AddItem();

        }
        private void BtnRemoveStockItem_Click(object sender, EventArgs e)
        {
           // RemoveItem();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
           // Updates();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
