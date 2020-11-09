using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_Alpha_1._0
{
    public class StockRequestInfo
    {
        public string stockItemInfo { get; set; }

        public StockRequestInfo()
        {

        }

        public StockRequestInfo(string stockItemInfo)
        {
            this.stockItemInfo = stockItemInfo;
        }

        public string StocKRequestInformation()
        {
            string info = this.stockItemInfo; ;
            return info;
        }
    }
}
