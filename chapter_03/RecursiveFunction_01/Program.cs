// Program to demonstrate Recursive Function in C# with Visual Studio
// Programmer: Nikhil Patil

namespace RecursiveFunction_01
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Recursive Function in C# with Visual Studio\n");

            int number = 5;

            Console.WriteLine($"Factorial of {number} is {Factorial(number)}"); // Factorial of 7 is 5040
        }

        // Recursive function to calculate factorial.
        static int Factorial(int number)
        {
            // Base condition
            if (number <= 0)
                return 1;
            else
                // Decremental recursive calling
                return number * Factorial(number - 1);
        }
    }
}