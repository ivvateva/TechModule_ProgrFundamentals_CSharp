using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {

            string word;
            int counter = 0;
            /*do
            {
                word = Console.ReadLine();
                counter += 1;
                if (word != "Bake!")
                {
                    Console.WriteLine("Adding ingredient {0}.", word);
                }
            }
            while (word == "Bake");
            Console.WriteLine("Preparing cake with {0} ingredients.", counter);
            */

            while (true)
            {
                word = Console.ReadLine();
                if (word != "Bake!")
                {
                    counter += 1;
                    Console.WriteLine("Adding ingredient {0}.", word);
                }
                    
                if (word == "Bake!")
                {
                    Console.WriteLine("Preparing cake with {0} ingredients.", counter);
                    break;
                }
                
            }

            /* while (cake > 0)
             {
                 input = Console.ReadLine();
                 if (input == "STOP")
                 {
                     Console.WriteLine("{0} pieces are left.", cake);
                     break;
                 }
                 else
                 {
                     numbers = Convert.ToInt32(input);
                     cake = cake - numbers;
                 }
             }*/
        }
    }
}
