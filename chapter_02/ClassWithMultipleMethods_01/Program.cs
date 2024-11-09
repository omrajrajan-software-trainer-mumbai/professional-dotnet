// Program to create Class with Multiple Methods.
// Programmer : Priyanka Thakur

namespace ClassWithMultipleMethods_01
{
    // Defining a class named "Calculator"
    public class Calculator
    {
        // Method to add two numbers
        public int Add(int a, int b)
        {
            return a + b; // Returns the sum
        }

        // Method to subtract two numbers
        public int Subtract(int a, int b)
        {
            return a - b; // Returns the difference
        }

        // Method to multiply two numbers
        public int Multiply(int a, int b)
        {
            return a * b; // Returns the product
        }

        // Method to divide two numbers
        public int Divide(int a, int b)
        {
            return a / b; // Returns the division
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to create Class with Multiple Methods.\n");

            // Create an object of the Calculator class
            Calculator calc = new Calculator();

            // Call the methods and print the results
            Console.WriteLine("Addition: " + calc.Add(6, 3));        // Output: 9
            Console.WriteLine("Subtraction: " + calc.Subtract(6, 3)); // Output: 3
            Console.WriteLine("Multiplication: " + calc.Multiply(6, 3)); // Output: 18
            Console.WriteLine("Division: " + calc.Divide(6, 3)); // Output: 2

        }
    }
}
