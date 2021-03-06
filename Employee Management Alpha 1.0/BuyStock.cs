﻿using System;
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
    public partial class BuyStock : Form
    {
        const string pattern = @"([^\s]+)"; //pattern to get the first string before a space
        Regex rg = new Regex(pattern);
        Stock stock;
        int Quantity;

        public BuyStock()
        {
            InitializeComponent();  
        }


        private void LbStockInfo_Click(object sender, EventArgs e)
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
        }

        private void SalesList() // refreshes the sales list
        {
            lbStockSalesInfo.Items.Clear();

            stock = new Stock();
            if (stock.GetAllSales() is null)
            {
                MessageBox.Show("The database is empty!");
                lbStockSalesInfo.Items.Add("The database is empty!");
            }
            else
            {
                for (int i = 0; i < stock.GetAllSales().Count(); i++)
                {
                    lbStockSalesInfo.Items.Add(stock.GetAllSales()[i].StockSaleInfo());
                }
            }

        }

        private void StockList() // refreshes the stock list
        {
            lbStockInfo.Items.Clear();

            stock = new Stock();
            if (stock.GetAllDepoStockWithLowQuantity() is null)
            {
                MessageBox.Show("The database is empty!");
                lbStockInfo.Items.Add("The database is empty!");
            }
            else
            {
                for (int i = 0; i < stock.GetAllDepoStockWithLowQuantity().Count(); i++)
                {
                    lbStockInfo.Items.Add(stock.GetAllDepoStockWithLowQuantity()[i].ItemInfo());
                }
            }

        }

        private void BtnBuyStock_Click(object sender, EventArgs e)
        {
                Item item;
                item = new Item();
                item = stock.GetDepoItemsById(Convert.ToInt32(tbID.Text));
                int Quantity = item.quantity;
                int amount = Convert.ToInt32(numUpDownAmount.Value);

                string id = tbID.Text;


                if (tbID.Text == "")
                {
                    MessageBox.Show("An item must be selected before performing this opperation!");
                }
                else
                {
                    stock.BuyItem(id, Quantity, amount);
                    string sales = stock.GetSales(Convert.ToInt32(id));
                    stock.AddSale(Convert.ToInt32(id), Convert.ToInt32(sales), Convert.ToInt32(numUpDownAmount.Value));
                }


                StockList();
                tbID.Text = "";
                numUpDownAmount.Value = 1;
                StockList();
                SalesList();


        }

        private void BuyStock_Load(object sender, EventArgs e)
        {
            StockList();
            SalesList(); //refreshes both lists before when loading the data
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close(); //closes the form, serves as return button
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            StockRequest stockRequest = new StockRequest();
            stockRequest.Show();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            lbStockInfo.Items.Clear();
            stock = new Stock();
            stock.SearchDepoStock(tbSearchBar.Text);


            if (stock.SearchDepoStock(tbSearchBar.Text) is null)
            {
                lbStockInfo.Items.Add("No items with such name!");
            }
            else
            {
                for (int i = 0; i < stock.SearchDepoStock(tbSearchBar.Text).Count(); i++)
                {
                    lbStockInfo.Items.Add(stock.SearchDepoStock(tbSearchBar.Text)[i].ItemInfo());
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

