using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_Alpha_1._0
{
    public class Item
    {
        //variables
        public int id { get; set; }
        public string name { get; set; }
        public int quantity { get; set; }
        public double pricePerUnit { get; set; }
        public string category { get; set; }

        public int Id
        {
            get { return this.id; }
        }

        public string Name
        {
            get { return this.name; }
        }

        public int Quantity
        {
            get { return this.quantity; }
        }

        public double PricePerUnit
        {
            get { return this.PricePerUnit; }
        }

        public string Category
        {
            get { return this.category; }
        }

        public Item(string name, int quantity, double pricePerUnit, string category)
        {
            this.name = name;
            this.quantity = quantity;
            this.pricePerUnit = pricePerUnit;
            this.category = category;
        }

        public Item(int id, string name, int quantity, double pricePerUnit, string category)
        {
            this.id = id;
            this.name = name;
            this.quantity = quantity;
            this.pricePerUnit = pricePerUnit;
            this.category = category;
        }

        public Item()
        {

        }

        public string ItemInfo()
        {
            string info = $"{this.id} {this.name} {this.category} {this.quantity} {this.pricePerUnit} {this.quantity * this.pricePerUnit}";
            return info;
        }



        /*
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

    public void SetPricePerUnit(double pricePerUnit)
    {
        this.pricePerUnit = pricePerUnit;
    }

    public void SetQuantity(int quantity)
    {
        this.quantity = quantity;
    }

    public void SetCategory(string category)
    {
        this.category = category;
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

*/
    }
}
