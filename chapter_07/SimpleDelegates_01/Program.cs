// Program to demonstrate the use of delegates to invoke methods in C# with Visual Studio
// Programmer: Kavya Krishnan
using System;

namespace SimpleDelegates_01
{
    delegate double DoubleOp(double x);

    // Defining MathOperations class that uses static method to perform two operations on doubles
    public static class MathOperations
    {
        public static double MultiplyByTwo(double value) => value * 2;
        public static double Square(double value) => value * value;
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate the use of delegates to invoke methods in C# with Visual Studio\n");

            // Creating an array operations of type DoubleOp and calling the functions
            DoubleOp[] operations =
            {
                MathOperations.MultiplyByTwo,
                MathOperations.Square,
            };

            // A function named ProcessAndDisplayNumber that takes 2 parameters
            // Displays the output in formatted way
            void ProcessAndDisplayNumber(DoubleOp action, double value)
            {
                double result = action(value);
                Console.WriteLine($"Value is {value}, result of operation is {result}");
            }

            // Loop to invoke the ProcessAndDisplayNumber method with different indexers
            for (int i = 0; i < operations.Length; i++)
            {
                Console.WriteLine($"Using operations[{i}]");
                ProcessAndDisplayNumber(operations[i], 2.0);
                ProcessAndDisplayNumber(operations[i], 7.94);
                ProcessAndDisplayNumber(operations[i], 1.414);
                Console.WriteLine();

            }
        }
    }
}
