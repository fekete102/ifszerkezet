﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifszerkezet
{
    class Program
    {
        static void Main(string[] args)
        {
            DiakBeker diak = new DiakBeker("Márkus Regő", 14);

            diak.AdatKiir();

            Console.ReadKey(true);
        }
    }
}
