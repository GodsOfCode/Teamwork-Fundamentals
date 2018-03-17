using System;

namespace Project3_MilesToKm
{
    class Program
    {
        //CONFIRMED from YaniLozanov.
        public static void Main(string[] args)
        {
            // Input milies.
            double mile = double.Parse(Console.ReadLine());

            // Milies to kilometers
            double kilometers = mile * 1.60934;

            // Print the result.
            Console.WriteLine("{0:f2}", kilometers);
        }
    }
}
