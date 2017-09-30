using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            string hallName;
            double price = 0;
            
            if (people <= 50)
            {
                hallName = "Small Hall";
                price = 2500;
                Console.WriteLine("We can offer you the {0}", hallName);
            }
            else if (people > 50 && people <= 100)
            {
                hallName = "Terrace";
                price = 5000;
                Console.WriteLine("We can offer you the {0}", hallName);
            }
            else if (people > 100 && people <=120)
            {
                hallName = "Great Hall";
                price = 7500;
                Console.WriteLine("We can offer you the {0}", hallName);
            }
            else Console.WriteLine("We do not have an appropriate hall.");

            if (package == "Normal")
            {
                price = (price + 500) * 0.95;
            }
            else if (package == "Gold")
            {
                price = (price + 750) * 0.90;
            }
            else if (package == "Platinum")
            {
                price = (price + 1000) * 0.85;
            }

            if (people <= 120)
            {
                Console.WriteLine("The price per person is {0:0.00}$", price / people);
            }

        }
    }
}
