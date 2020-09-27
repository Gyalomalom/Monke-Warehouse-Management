using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_Alpha_1._0
{
    class Item
    {
        //variables
        private static int nextFreeIdNumber = 001;
        private int id;
        private string name;
        private string category;
        private double pricePerUnit;
        private int quantity;


        //constructor
        public Item(string name, int quantity, double pricePerUnit, string category)
        {
            this.name = name;
            this.quantity = quantity;
            this.pricePerUnit = pricePerUnit;
            this.category = category;
            this.id = nextFreeIdNumber;
            nextFreeIdNumber++;
        }

        //methods
        public string getName()
        {
            return this.name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void AddQuantity(int quantity)
        {
            this.quantity += quantity;
        }

        public void setPricePerUnit(double pricePerUnit)
        {
            this.pricePerUnit = pricePerUnit;
        }

        public void setQuantity(int quantity)
        {
            this.quantity = quantity;
        }

        public int GetId()
        {
            return this.id;
        }

        public override string ToString()
        {
            string info = this.id + "\t" + this.name + " \t " + " \t " + this.category + " \t " + " \t " + this.quantity + " \t " + " \t " + this.pricePerUnit + " \t " + "\t" + " \t " + (this.quantity * this.pricePerUnit);
            return info;
        }
    }
}
