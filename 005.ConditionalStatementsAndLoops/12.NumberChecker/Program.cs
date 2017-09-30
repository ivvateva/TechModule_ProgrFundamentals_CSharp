using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.NumberChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            int number = 0;
            if (Int32.TryParse(input,out number))
            {
                Console.WriteLine("It is a number.");
            }
            else Console.WriteLine("Invalid input!");
        }
    }
}
