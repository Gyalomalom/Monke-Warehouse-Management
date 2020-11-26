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
    public partial class AddStock : Form
    {
        Stock stock;

        public AddStock()
        {
            InitializeComponent();
            stock = new Stock();
        }


        private void StockList() // refreshes the stock list
        {
            lbStockInfo.Items.Clear();

            stock = new Stock();
            if (stock.GetAllItems() is null)
            {
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


        private void BtnAddStockItem_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            int quantity = Convert.ToInt32(tbQuantity.Text);
            double pricePerUnit = Convert.ToDouble(tbPricePerUnit.Text);
            string category = cbCategory.Text;

            lbStockInfo.Items.Clear();

            if(tbName.Text == "" || tbQuantity.Value == 0 || cbCategory.Text == "")
            {
                MessageBox.Show("Please enter the data before adding items!");
            }
            else
            {
                stock.AddItem(name, quantity, pricePerUnit, category);
                stock.AddDepoItem(name, quantity, pricePerUnit, category);
            }
            


            StockList();

            tbName.Text = "";
            tbQuantity.Text = "";
            tbPricePerUnit.Text = "";
            cbCategory.Text = "";


            //if (!string.IsNullOrEmpty(tbName.Text))
            //{
            //    string name = tbName.Text;
            //    int quantity = Convert.ToInt32(tbQuantity.Text);
            //    double pricePerUnit = Convert.ToDouble(tbPricePerUnit.Text);
            //    string category = cbCategory.Text;


            //    if (cbCategory.Items.Contains(category)) // checks if the combobox contains the newly entered category
            //    {

            //    }
            //    else
            //    {
            //        cbCategory.Items.Add(category); // if it is a new category, it adds that category to the combobox
            //    }

            //    //stock.AddStock(name, quantity, pricePerUnit, category);
            //    StockList();
            //}
            //else
            //{
            //    MessageBox.Show("Please enter name, quantity and price per unit");
            //}

            //tbName.Text = "";
            //tbPricePerUnit.Value = 0;
            //tbQuantity.Value = 0;
            //cbCategory.Text = "";
        }

        private void AddStock_Shown(object sender, EventArgs e)
        {
            StockList();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close(); //closes the form, serves as return button
        }

        private void AddStock_Load(object sender, EventArgs e)
        {
            StockList();
        }
    }
}
