using System;
using System.Collections.Generic;
using System.Text;

namespace Mathematic
{
    public class FourOperations
    {
        public void Topla(int birinciSayi, int ikinciSayi)
        {
            Console.WriteLine($"Sonuç : {birinciSayi + ikinciSayi}");
        }
        public void Topla(int[] sayilar)
        {
            int result = 0;
            foreach (var item in sayilar)
            {
                result += item;
            }
            Console.WriteLine($"Sonuç : {result}");
        }
    }
}
