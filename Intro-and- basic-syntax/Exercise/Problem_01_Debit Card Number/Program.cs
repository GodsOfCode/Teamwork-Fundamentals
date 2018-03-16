using System;

namespace Problem_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //We recieve from the Console four numbers(integers)
            int firstDigit = int.Parse(Console.ReadLine());
            int secondDigit = int.Parse(Console.ReadLine());
            int thirdDigit = int.Parse(Console.ReadLine());
            int fourthDigit = int.Parse(Console.ReadLine());
            //We print the numbers to the Console in the debit card format(with leading zeroes)
            Console.WriteLine($"{firstDigit:D4} {secondDigit:D4} {thirdDigit:D4} {fourthDigit:D4}");

        }
    }
}
