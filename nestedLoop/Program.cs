﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nestedLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    //Console.WriteLine($"{i} * {j} = {i * j}");
                    Console.WriteLine("{0} * {1} = {2}", i, j, i*j);
                }
            }

        }
    }
}
