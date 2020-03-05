using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cashRegister
{
    class Item
    {
        String name;
        int quantity;
        double price;

        public Item(String name, int quantity, double price)
        {
            this.name = name;
            this.quantity = quantity;
            this.price = price;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public String getName()
        {
            return this.name;
        }

        public void setQuantity(int quantity)
        {
            this.quantity = quantity;
        }

        public int getQuantity()
        {
            return this.quantity;
        }

        public void setPrice(double price)
        {
            this.price = price;
        }

        public double getPrice()
        {
            return this.price;
        }


        public String toString()
        {
            String ret = String.Format("{0}  :  ${1}  :  {2}", this.name, this.price.ToString("F2"), this.quantity);
            return ret;
        }
    }
}
