using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>();

            names.Add("İbrahim");
            names.Add("Engin");
            foreach (var item in names.Items)
            {
                Console.WriteLine(item);
            }

        }
    }
}
