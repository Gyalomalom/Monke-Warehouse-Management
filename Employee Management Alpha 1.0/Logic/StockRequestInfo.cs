using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_Alpha_1._0
{
    public class StockRequestInfo
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }

        public StockRequestInfo()
        {

        }

        public StockRequestInfo(int id, string name, int amount)
        {
            this.ID = id;
            this.Name = name;
            this.Amount = amount;
        }


        public string StocKRequestInformation()
        {
            string info = $"{ID} {Name} {Amount}";
            return info;
        }
    }
}
