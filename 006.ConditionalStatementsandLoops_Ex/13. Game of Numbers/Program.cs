using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());

            int counter = 0;
            int sum = 0;
            bool flag = false;


           // while (flag == false)
            //{
                sum = 0;
                for (int i = m; i >= n; i--)
                {
                    for (int j = m; j >= n; j--)
                    {
                        sum = i + j;
                        if (sum == magic)
                        {
                            Console.WriteLine($"Number found! {i} + {j} = {magic}");
                            flag = true;
                            break;
                        }
                        counter += 1;
                    }
                    if (flag == true) break;
                //}

            }
            
           if (sum != magic)
                Console.WriteLine($"{counter} combinations - neither equals {magic}");
           

        }
    }
}
