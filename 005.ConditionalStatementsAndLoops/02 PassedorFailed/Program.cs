﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_PassedorFailed
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());

            if (grade >= 3.00)
                Console.WriteLine("Passed!");
            else if (grade < 3.00)
                Console.WriteLine("Failed!");
        }
    }
}
