using System;

namespace Mileage
{
    public static class Program
    {
        public static void Main()
        {
            Console.Write("How many miles have you driven? ");

            int drivenMiles = int.Parse(Console.ReadLine());
            // Get input from the user and save it to a variable.

            Console.Write("How many gallons of gas have you consumed? ");
            int gallonsGas = int.Parse(Console.ReadLine());
            // Get input from the user and save it to a second variable.

            int milesPerGallon = drivenMiles / gallonsGas;

            Console.WriteLine($"Your miles per gallon is{milesPerGallon}");
            // Output - Your miles per gallon is (computed value)

            Console.ReadLine();
        }
    }
}
