using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] apcfans = { 23, 17, 21, 31, 27, 18 };
            int total = 0;
            foreach (var youthAge in apcfans)
            {
                total = total + youthAge;
             
            }

            int sum = total;
            Console.WriteLine ($"The sum of apcfans is {total}");

            Console.ReadLine();



        }
    }
}
