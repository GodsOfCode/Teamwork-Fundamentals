using System;

namespace Project04_BeverageLabels
{
    internal class Program
    {
        //CONFIRMED for YaniLozanov.
        public static void Main(string[] args)
        {
            // Define a variable which type is string for reading from the Console
            string name = Console.ReadLine();
            // Define a variable which type is double for reading from the Console
            var volume = double.Parse(Console.ReadLine());
            // Define a variable which type is double for reading from the Console
            var energyContent = double.Parse(Console.ReadLine());
            // Define a variable which type is double for reading from the Console
            var sugarContent = double.Parse(Console.ReadLine());
            // Calculating energyContent multiplying the division of the volume by 100
            energyContent *= (volume / 100);
            // Calculating energyContent multiplying the division of the volume by 100
            sugarContent *= (volume / 100);
            // Writing on the Console the volume which unit is ml using WriteLine
            Console.WriteLine($"{volume}ml {name}:");
            // Writing on the Console the energyContent which unit is kcal and the sugarContent which unit is g
            Console.WriteLine($"{energyContent}kcal, {sugarContent}g sugars");
        }
    }
}