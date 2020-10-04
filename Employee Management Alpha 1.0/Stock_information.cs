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
    }
}
