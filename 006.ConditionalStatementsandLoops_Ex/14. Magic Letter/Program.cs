﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Magic_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char skip = char.Parse(Console.ReadLine());

            for (char i = first; i <= second; i++)
            {
                for (char j = first ; j<= second;j ++)
                {
                    for (char k = first;k  <= second;k ++)
                    {
                        if (i != skip && j != skip && k != skip)
                            Console.Write($"{i}{j}{k} ");
                    }
                }
            }
        }
    }
}
