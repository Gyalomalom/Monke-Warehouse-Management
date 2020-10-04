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
    public partial class Stock_information : Form
    {
        Stock stock;
        const string pattern = @"([^\s]+)"; //pattern to get the first string before a space
        Regex rg = new Regex(pattern);

        public Stock_information()
        {
            InitializeComponent();
            //stock = new Stock();
            UpdateList();


        }

        private void UpdateList()
        {
            lbStockInfo.Items.Clear();
            stock = new Stock();
            if (stock.GetAllItems() is null)
            {
                MessageBox.Show("The database is empty!");
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

        
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close(); //closes the form, serves as return button
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
            else
            {
                return;
            }
        }

        private void TbID_TextChanged(object sender, EventArgs e)
        {
            string newName = tbNewItemName.Text;
            string newCategory = tbNewCategory.Text;
            double newPricePerUnit = Convert.ToDouble(tbNewPricePerUnit.Value);
            int newQuantity = Convert.ToInt32(tbNewQuantity.Value);

            Item item;
            item = new Item();
            item = stock.GetItemsById(Convert.ToInt32(tbID.Text));
            tbNewItemName.Text = item.name;
            tbNewCategory.Text = item.category;
            tbNewPricePerUnit.Value = Convert.ToDecimal(item.pricePerUnit);
            tbNewQuantity.Value = item.quantity;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string newName = tbNewItemName.Text;
            string newCategory = tbNewCategory.Text;
            double newPricePerUnit = Convert.ToDouble(tbNewPricePerUnit.Value);
            int newQuantity = Convert.ToInt32(tbNewQuantity.Value);
            stock.ChangeItem(tbID.Text, newName, newQuantity, newPricePerUnit, newCategory);
            UpdateList();
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

        private void BtnRemoveStockItem_Click(object sender, EventArgs e)
        {
           // RemoveItem();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (lbStockInfo.SelectedIndex < 1)
            {
                MessageBox.Show("Please select an item first!");
            }
            else
            {
                Item selectedItem = (Item)lbStockInfo.SelectedItem;
                string text = lbStockInfo.GetItemText(lbStockInfo.SelectedItem);

                UpdateInformation updateInformation = new UpdateInformation(text, stock);


                if (Application.OpenForms.OfType<UpdateInformation>().Count() == 1)
                {
                    Application.OpenForms.OfType<UpdateInformation>().First().Close();
                }

                updateInformation.Show();

                

                StockList(); // refresshing
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Stock_information_Shown(object sender, EventArgs e)
        {
            StockList();
        }

        private void Stock_information_Load(object sender, EventArgs e)
        {

        }
        */
    }
}
