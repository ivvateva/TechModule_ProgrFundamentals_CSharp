using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            while (true)
            {
                var input = Console.ReadLine();
                int value;
                if (int.TryParse(input, out value))
                {
                    counter += 1;
                }
                else break;
            }
            Console.WriteLine(counter);
        }
    }
}
