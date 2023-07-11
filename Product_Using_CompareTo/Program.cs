using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Using_CompareTo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Product Laptop = new Product("Laptop", 2000);
            Product Mobile = new Product("Mobile", 1500);

            int result = Laptop.CompareTo(Mobile);

            if (result < 0)
            {
                Console.WriteLine("Laptop has less price than Mobile");
            }
            else if (result > 0)
            {
                Console.WriteLine("Laptop has more price than Mobile");
            }
            else
            {
                Console.WriteLine("Laptop & Mobile has same price ");
            }

        }
    }
}
