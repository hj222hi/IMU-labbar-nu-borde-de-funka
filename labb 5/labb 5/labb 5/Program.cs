﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labb_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------Multiplicera två bråk---------");
            // multiplicera 
            Fraction a = new Fraction(3, 4);
            Fraction b = new Fraction(1, 3);
            Console.WriteLine(a.add(b, a));
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();

            Console.WriteLine("---Addera två bråk med lika nämnare---");
            // adderar med lika nämnare
            Fraction a2 = new Fraction(1, 5);
            Fraction b2 = new Fraction(2, 5);
            Console.WriteLine(a2.add(b2, a2));
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();

            Console.WriteLine("--Adderar två bråk med olika nämnare--");
            // adderar med lika nämnare
            Fraction a3 = new Fraction(1, 4);
            Fraction b3 = new Fraction(1, 3);
            Console.WriteLine(a3.add(b3, a3));
          
            Console.WriteLine("-----Kolla om två bråk är samma-------");
            // adderar med lika nämnare
            Fraction a4 = new Fraction(1, 4);
            Fraction b4 = new Fraction(1, 3);
            Console.WriteLine(a4.isEqualTo(a4, b4));
            Console.WriteLine("--------------------------------------");
        }
    }
}
