using System;
using System.Collections.Generic;
using System.Linq;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "İbrahim", "Engin", "Murat", "Kerem", "Bilgin" };
            Console.WriteLine(names.ElementAtOrDefault(4));
            Console.WriteLine(names.ElementAtOrDefault(5));

            List<string> names2 = new List<string> { "İbrahim", "Batuhan" };
            names2.Add("Ali");
            foreach (var item in names2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(names2.FirstOrDefault(x => x.Contains("Bat")));
        }
    }
}
