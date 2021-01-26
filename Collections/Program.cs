using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] {"Mert","Berk","Maral","Hülya" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);

            Console.WriteLine("----------");

            isimler = new string[5];
            isimler[4] = "Bulent";
            Console.WriteLine(isimler[4]);

            Console.WriteLine("-------");

            List<string> isimler2 = new List<string> { "Mert", "Berk", "Maral", "Hülya" };
            isimler2.Add("Bulent");
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            Console.WriteLine(isimler2[4]);


        }
    }
}
