// Program to demonstrate Null Coalescing Operator in C# with Visual Studio
// Programmer: Nikhil Patil
// Programmer: Kavya Krishnan

namespace NullCoalescingOperator_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Program to demonstrate Null Coalescing Operator in C# with Visual Studio");
            string? name = null;

            // Using the null-coalescing operator (??) to provide a default value.
            string result = name ?? "Kavya";

            // Output: Kavya
            Console.WriteLine($"Result: {result}"); 
        }
    }
}
