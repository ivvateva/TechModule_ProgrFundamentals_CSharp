using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());

            int counter = 0;
            int sum = 0;
            //while (sum <= max)
            //{
                for (int i = n; i >= 1; i--)
                {
                    for (int j = 1; j <= m; j++)
                    {
                        if (sum >= max)
                            break;
                        counter += 1;
                        sum += (3 * (i * j));
                        
                    }
                }
            //}

            Console.WriteLine($"{counter} combinations");
            if (sum >= max)
            {
                Console.WriteLine($"Sum: {sum} >= {max}");
            }
            else
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
