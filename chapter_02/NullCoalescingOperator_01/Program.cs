// Program to demonstrate Null Coalescing Operator in C# with Visual Studio
// Programmer: Nikhil Patil

namespace NullCoalescingOperator_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Program to demonstrate Null Coalescing Operator in C# with Visual Studio");
            string? name = null;

            // Using the null-coalescing operator (??) to provide a default value.
            string result = name ?? "Nick";

            Console.WriteLine($"Result: {result}"); // Output: Nick
        }
    }
}
