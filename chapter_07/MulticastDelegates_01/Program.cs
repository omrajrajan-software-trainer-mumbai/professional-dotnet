// Program to demonstrate the use of delegates to invoke multiple methods in C# with Visual Studio
// Programmer: Kavya Krishnan

namespace MulticastDelegates_01
{
    delegate double DoubleOp(double x);
    public static class MathOperations
    {
        public static void MultiplyByTwo(double value) =>
          Console.WriteLine($"Multiplying by 2: {value} gives {value * 2}");
        public static void Square(double value) =>
          Console.WriteLine($"Squaring: {value} gives {value * value}");
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate the use of delegates to invoke multiple methods in C# with Visual Studio\n");
            static void ProcessAndDisplayNumber(Action<double> action, double value)
            {
                Console.WriteLine($"ProcessAndDisplayNumber called with value = {value}");
                action(value);
                Console.WriteLine();
            }
            Action<double> operations = MathOperations.MultiplyByTwo;
            operations += MathOperations.Square;
            ProcessAndDisplayNumber(operations, 2.0);
            ProcessAndDisplayNumber(operations, 7.94);
            ProcessAndDisplayNumber(operations, 1.414);

        }
    }
}
