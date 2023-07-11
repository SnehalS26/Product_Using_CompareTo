using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Using_CompareTo
{
    public class Product:IComparable<Product>
    {
        private String name;
        private int price;
        public Product(String name , int price)
        {
            this.name = name;
            this.price = price;
        }
        public int CompareTo(Product other)
        {
            if(this.price < other.price)
            {
                return -1;
            }
            else if(this.price > other.price)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public override string ToString()
        {
            return $"{name} {price}";
        }
    }
}
