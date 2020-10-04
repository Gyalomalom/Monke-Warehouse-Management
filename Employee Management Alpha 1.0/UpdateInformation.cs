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
    public partial class UpdateInformation : Form
    {
        //string information;
        //Stock stock;

        public UpdateInformation(string information, Stock stock)
        {
            InitializeComponent();
            //this.information = information;
            //lblCurrentItemInfo.Text = $"Current item info: {information}";
            //this.stock = stock;

        }




        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close(); //closes the form, serves as return button
        }

        private void UpdateInformation_Load(object sender, EventArgs e)
        {

        }

        private void BtnNewUpdate_Click(object sender, EventArgs e)
        {
            string newName = tbNewItemName.Text;
            string newCategory = tbNewCategory.Text;
            double newPricePerUnit = Convert.ToDouble(tbNewPricePerUnit.Value);
            int newQuantity = Convert.ToInt32(tbNewQuantity.Value);
            

            //stock.ChangeItem()
            

            //if(newName == "" || newCategory == "")
            //{
            //    MessageBox.Show("Please enter a name and a category first!");
            //}
            //else
            //{
            //    stock.UpdateStock(newName, newQuantity, newPricePerUnit, newCategory);
            //    this.Close();
            //}

            



        }

        private void UpdateInformation_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
        
    }
}
