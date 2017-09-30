using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Backin30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes = minutes + 30;

            if (minutes  >= 60 )
            {
                hour = hour + 1;
                minutes = minutes - 60;
            }
            if (hour > 23)
            {
                hour = hour - 24;
            }

            Console.WriteLine($"{hour}:{minutes:D2}");
        }
    }
}
