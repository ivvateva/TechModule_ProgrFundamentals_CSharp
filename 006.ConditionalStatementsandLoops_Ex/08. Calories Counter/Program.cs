using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int cheese = 500;
            int tomato = 150;
            int salami = 600;
            int pepper = 50;
            string ingredient;
            int calories = 0;

            for (int i = 0; i < number; i++)
            {
                ingredient = Console.ReadLine().ToLower();
                switch (ingredient)
                {
                    case "cheese": calories += cheese; break;
                    case "tomato sauce": calories += tomato; break;
                    case "salami": calories += salami; break;
                    case "pepper": calories += pepper; break;
                    default: break;
                }
            }
            Console.WriteLine("Total calories: {0}",calories);
        }
    }
}
