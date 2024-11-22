// Program to Calculate Average In Array in C# with Visual Studio
// Programmer: Nikhil Patil

namespace AverageInArray_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to Calculate Average In Array in C# with Visual Studio");
            int[] numbers = { 4, 6, 7, 9, 12 };

            int sum = 0;

            foreach (int number in numbers)
            {
                sum += number;
            }

            Console.WriteLine($"Average: {(double)sum / numbers.Length}");
            Console.WriteLine($"Average: {numbers.Average()}");
        }
    }
}
