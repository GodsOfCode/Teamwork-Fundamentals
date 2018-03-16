using System;

namespace Project3_MilesToKm
{
    class Program
    {
        static void Main(string[] args)
        {
            double mile = double.Parse(Console.ReadLine());
            double res = mile * 1.60934;
            Console.WriteLine("{0:f2}", res);
        }
    }
}
