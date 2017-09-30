using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Interval_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            /*if (first > second)
            {
                int c;
                c = first;
                first = second;
                second = c;             
            }

            for (int i = first; i <= second; i++)
            {
                Console.WriteLine(i);
            }
            */

            for (int i = Math.Min(first, second); i <= Math.Max(first, second) ; i++)
            {
                Console.WriteLine(i);
            }
            {

            }
        }
    }
}
