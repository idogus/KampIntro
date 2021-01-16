using System;

namespace HackerRankSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            plusMinus(arr);
        }
        static void plusMinus(int[] arr)
        {
            double positiveNumber = 0.0;
            double negativeNumber = 0.0;
            double zero = 0.0;
            foreach (double item in arr)
            {
                if (item > 0)
                {
                    positiveNumber++;
                }
                else if (item < 0)
                {
                    negativeNumber++;
                }
                else
                {
                    zero++;
                };
            };
            
            Console.WriteLine(Convert.ToDouble(positiveNumber / arr.Length).ToString("0.000000"));
            Console.WriteLine(Convert.ToDouble(negativeNumber / arr.Length).ToString("0.000000"));
            Console.WriteLine(Convert.ToDouble(zero / arr.Length).ToString("0.000000"));
        }
    }
}
