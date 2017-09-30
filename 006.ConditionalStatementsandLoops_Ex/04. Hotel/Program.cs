using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            

            if (month == "May" || month == "October")
            {
                if (nights > 7 && month == "May")
                {
                    Console.WriteLine("Studio: {0:0.00} lv.", 50 * nights * 0.95);
                }
                else if (month == "October" && nights > 7)
                {
                    Console.WriteLine("Studio: {0:0.00} lv.", 50 * (nights - 1) * 0.95);
                }
                else
                Console.WriteLine("Studio: {0:0.00} lv.", 50 * nights);
                Console.WriteLine("Double: {0:0.00} lv.", 65 * nights);
                Console.WriteLine("Suite: {0:0.00} lv.", 75 * nights);
            }

            else if (month == "June" || month == "September")
            {
                if (month == "September" && nights > 7)
                {
                    Console.WriteLine("Studio: {0:0.00} lv.", 60 * (nights -1));
                }
                else
                {
                    Console.WriteLine("Studio: {0:0.00} lv.", 60 * nights);
                }
                
                if (nights > 14)
                {
                    Console.WriteLine("Double: {0:0.00} lv.", 72 * nights * 0.90);
                }
                else
                {
                    Console.WriteLine("Double: {0:0.00} lv.", 72 * nights);
                }

               
                Console.WriteLine("Suite: {0:0.00} lv.", 82 * nights);
            }

            else if (month == "July" || month == "August" || month == "December")
            {
                Console.WriteLine("Studio: {0:0.00} lv.", 68 * nights);
                Console.WriteLine("Double: {0:0.00} lv.", 77 * nights);
                if (nights > 14)
                {
                    Console.WriteLine("Suite: {0:0.00} lv.", 89 * nights * 0.85);
                }
                else
                {
                    Console.WriteLine("Suite: {0:0.00} lv.", 89 * nights);
                }
            }

        }
    }
}
