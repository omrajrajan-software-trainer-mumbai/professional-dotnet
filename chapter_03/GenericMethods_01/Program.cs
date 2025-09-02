// Program to demonstrate the use of generic methods in C# with Visual Studio
// Programmer: Kavya Krishnan

namespace GenericMethods_01
{
    class GenericMethods
    {
        public static void Swap<T>(ref T x, ref T y)
        {
            T temp;
            temp = x;
            x = y;
            y = temp;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate the use of generic methods in C# with Visual Studio\n");

            // Example 1: Swap integers
            Console.WriteLine("Swapping Integers values\n");
            int a = 10, b = 20;
            Console.WriteLine($"Before Swap: a = {a}, b = {b}");
            GenericMethods.Swap<int>(ref a, ref b);
            Console.WriteLine($"After Swap: a = {a}, b = {b}");
            Console.WriteLine();

            // Example 2: Swap doubles
            Console.WriteLine("Swapping Float values\n");
            double x = 1.5, y = 9.3;
            Console.WriteLine($"Before Swap: x = {x}, y = {y}");
            GenericMethods.Swap<double>(ref x, ref y);
            Console.WriteLine($"After Swap: x = {x}, y = {y}");
            Console.WriteLine();

            // Example 3: Swap strings
            Console.WriteLine("Swapping Strings\n");
            string s1 = "Hello", s2 = "World";
            Console.WriteLine($"Before Swap: s1 = {s1}, s2 = {s2}");
            GenericMethods.Swap<string>(ref s1, ref s2);
            Console.WriteLine($"After Swap: s1 = {s1}, s2 = {s2}");
        }
    }
}
