﻿// Program to demonstrate out to Return Multiple Values in C# with Visual Studio
// Programmer: Nikhil Patil

namespace UsingOutToReturnMultipleValues_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate out to Return Multiple Values in C# with Visual Studio\n");

            // Variables that will receive multiple outputs from the method.
            int _sum, _product;

            // Calling the method with 'out' parameters.
            Calculate(2, 5, out _sum, out _product);

            Console.WriteLine($"Sum: {_sum} Product: {_product}"); // Output: Sum: 7 Product: 10
        }

        // Method to calculate sum and product using 'out' parameters.
        /// <summary>
        /// Calculate method calculates sum and product of two numbers
        /// </summary>
        /// <param name="number_1"></param>
        /// <param name="number_2"></param>
        /// <param name="sum"></param>
        /// <param name="product"></param>
        static void Calculate(int number_1, int number_2, out int sum, out int product)
        {
            sum = number_1 + number_2;
            product = number_1 * number_2;
        }
    }
}