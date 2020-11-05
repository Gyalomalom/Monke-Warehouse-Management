using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_Alpha_1._0
{
    public class StockSales
    {
        public int id { get; set; }
        public int sales { get; set; }

        public StockSales(int id, int sales)
        {
            this.id = id;
            this.sales = sales;
        }
        
        public StockSales()
        {

        }

        public string StockSaleInfo()
        {
            return $"ID:{this.id}    Sales:{this.sales}";
        }
    }
}
