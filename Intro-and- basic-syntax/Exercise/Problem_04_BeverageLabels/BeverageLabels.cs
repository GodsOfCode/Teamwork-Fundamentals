using System;

namespace Project04_BeverageLabels
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // The name of product.
            string productsName = Console.ReadLine();

            // The volume of product.
            var productsVolume = double.Parse(Console.ReadLine());

            // Energy content per 100 ml.
            var energyContentInTheProduct = double.Parse(Console.ReadLine());

            // Sugar content per 100 ml.
            var sugarContentInTheProduct = double.Parse(Console.ReadLine());

            // Calculate the  energy for the given volume.
            energyContentInTheProduct *= (productsVolume / 100);

            // Calculate the  sugar for the given volume.
            sugarContentInTheProduct *= (productsVolume / 100);
            
            // Print the volume and the products name
            Console.WriteLine($"{productsVolume}ml {productsName}:");

            // Print: how many energy and sugar content the product.
            Console.WriteLine($"{energyContentInTheProduct}kcal, {sugarContentInTheProduct}g sugars");
        }
    }
}