﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, s;
            a=int.Parse(Console.ReadLine());
            if(a<=5)
            { s = 0; }
            else if(a<=20)
            { s = (a - 5) * 1000; }
            else { s = (20 - 5) * 1000 + (a - 20) * 5000; }
            s = s + 1000;
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
