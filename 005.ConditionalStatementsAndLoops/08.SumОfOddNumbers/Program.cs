using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.SumОfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = n;
            int sum = 0;
            for (int i = 1; i <= counter; i= i +2)
            {
                Console.WriteLine(i);
                counter++;
                sum += i;

            }
            Console.WriteLine($"Sum: {sum}");
            
        }
    }
}
