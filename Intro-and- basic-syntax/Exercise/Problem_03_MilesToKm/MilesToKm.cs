﻿using System;

namespace Project03_MilesToKm
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Input: miles.
            double miles = Double.Parse(Console.ReadLine());

            // Convert milies in kilometers(1 mile == 1.60934 kilometers),
            double km = miles * 1.60934;

            // Print the result (To the 2nd decimal place).
            Console.WriteLine($"{km:f2}");
        }
    }
}