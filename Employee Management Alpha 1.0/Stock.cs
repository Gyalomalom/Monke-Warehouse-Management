using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_Alpha_1._0
{
    public class Stock
    {
        //variables
        private string stockName;
        private double pricePerUnit;
        private int quantity;
        

        //constructors
        public Stock(string stockName, double pricePerUnit, int quantity)
        {
            this.stockName = stockName;
            this.pricePerUnit = pricePerUnit;
            this.quantity = quantity;
        }

        //methods
        public void AddItem()
        {
            
        }
    }
}
