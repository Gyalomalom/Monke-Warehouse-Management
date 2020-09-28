using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_Alpha_1._0
{
    public class Stock
    {
        public Stock()
        {

        }

        private List<Item> Items = new List<Item>();

        public List<Item> GetStock()
        {
            return this.Items;
        }

        public void AddStock(string name, int quantity, double pricePerUnit, string category)// method to add stock
        {
            if (!Items.Any(item => item.getName() == name))
            {
                Items.Add(new Item(name, quantity, pricePerUnit, category));
            }
            else // if the item is already on the list, it adds quantity to that item
            {
                foreach (Item i in Items)
                {
                    if (i.getName() == name)
                    {
                        i.AddQuantity(quantity);
                        break;
                    }
                }
            }
        }

        public void UpdateStock(string name, int quantity, double pricePerUnit, string category)
        {
            {
                foreach (Item i in Items)
                {
                    i.SetName(name);
                    i.SetQuantity(quantity);
                    i.SetPricePerUnit(pricePerUnit);
                    i.SetCategory(category);
                    break;
                }
            }
        }


        public int GetStockCount()
        {
            return Items.Count();
        }

        public bool RemoveStock(Item selectedItem)
        {

            foreach (Item i in Items)
            {
                if (i.GetId() == selectedItem.GetId())
                {
                    Items.Remove(i);
                    return true;
                }
            }
            return false;
        }

    }
}
