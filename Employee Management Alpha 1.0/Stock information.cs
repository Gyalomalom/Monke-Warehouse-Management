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
