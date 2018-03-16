using System;

namespace Problem_02_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            //We recieve the parameters of the rectangle (width and height)
            //from the Console in the form of Floating Point numbers
            double rectangleWidth = double.Parse(Console.ReadLine());
            double rectangleHeight = double.Parse(Console.ReadLine());
            //Then we proceed to calculate the area of the rectangle
            double rectangleArea = rectangleWidth * rectangleHeight;
            //Finally we print the result to the Console
            Console.WriteLine($"{rectangleArea:f2}");
        }
    }
}
