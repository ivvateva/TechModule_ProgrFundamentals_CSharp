﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Choose_a_Drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            if (profession == "Athlete")
                Console.WriteLine("The {0} has to pay {1:0.00}.", profession, 0.70 * quantity );
            else if (profession == "Businessman" || profession == "Businesswoman")
                Console.WriteLine("The {0} has to pay {1:0.00}.", profession, 1.00 * quantity);
            else if (profession == "SoftUni Student")
                Console.WriteLine("The {0} has to pay {1:0.00}.", profession, 1.70 * quantity);
            else Console.WriteLine("The {0} has to pay {1:0.00}.", profession, 1.20 * quantity);
        }
    }
}
