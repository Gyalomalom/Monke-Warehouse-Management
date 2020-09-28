using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_Alpha_1._0
{
    class Stock
    {
        Stock_information form;

        public Stock(Stock_information form)
        {
            this.form = form;
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


                    if(form.cbCategory.Items.Contains(category)) // checks if the combobox contains the newly entered category
                    {
                        return;
                    }
                    else
                    {
                        form.cbCategory.Items.Add(category); // if it is a new category, it adds that category to the combobox
                    }


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

        public bool UpdateStock(string name, int quantity, double pricePerUnit)
        {
            if (!Items.Any(item => item.getName() == name))
            {
                return false;
            }
            else // if the item is already on the list, it adds quantity to that item
            {
                foreach (Item i in Items)
                {
                    if (i.getName() == name)
                    {
                        i.setQuantity(quantity);
                        i.setPricePerUnit(pricePerUnit);
                        break;
                    }
                }
            }

            return true;
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
