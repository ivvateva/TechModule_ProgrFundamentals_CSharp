using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
                for (int k= 0; k< i-1; k++)
                { 
                    Console.Write(i +" ");
                }
                Console.WriteLine();
            }
        }
    }
}
