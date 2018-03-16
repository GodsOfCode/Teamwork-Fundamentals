using System;

namespace Project05_CharacterStats
{
    internal class Program
    {
        //CONFIRMED for YaniLozanov.
        public static void Main(string[] args)
        {
            // Receive the name of the character.
            string charctersName = Console.ReadLine();

            // Receive the current health.
            int currentHealth = int.Parse(Console.ReadLine());

            // Receive the max health.
            int maxHP = int.Parse(Console.ReadLine());

            // Receive the current energy.
            int currentEnergy = int.Parse(Console.ReadLine());

            // Receive the max energy.
            int maxEnergy = int.Parse(Console.ReadLine());
            
            // How much health we have.
            string hp = new string('|', currentHealth);

            // How much health is missing.
            string missingHealth = new string('.', (maxHP - currentHealth));

            // How much health we have.
            string energy = new string('|', currentEnergy);

            // How much energy is missing.
            string missingEnergy = new string('.', (maxEnergy - currentEnergy));
            
            // Print the character`s name.
            Console.WriteLine($"Name: {charctersName}");

            // Print: How much health we have and how much health is missing.
            Console.WriteLine($"Health: |{hp}{missingHealth}|");

            // Print: How much energy we have and how much energy is missing.
            Console.WriteLine($"Energy: |{energy}{missingEnergy}|");
        }
    }
}