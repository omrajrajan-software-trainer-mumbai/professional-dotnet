// Program to demonstrate the use of Span<T> to access parts or slices of an array in C# with Visual Studio
// Programmer: Kavya Krishnan

namespace CreatingSlicesUsingSpan_01
{
    internal class Program
    {
        private static Span<int> CreateSlices(Span<int> span1)
        {
            Console.WriteLine(nameof(CreateSlices));
            int[] arr2 = { 3, 5, 7, 9, 11, 13, 15 };
            Span<int> span2 = new(arr2);
            Span<int> span3 = new(arr2, start: 3, length: 3);
            Span<int> span4 = span1.Slice(start: 2, length: 4);
            DisplaySpan("content of span3", span3);
            DisplaySpan("content of span4", span4);
            Console.WriteLine();
            return span2;
        }
        private static void DisplaySpan(string title, ReadOnlySpan<int> span)
        {
            Console.WriteLine(title);
            for (int i = 0; i < span.Length; i++)
            {
                Console.Write($"{span[i]}.");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate the use of Span<T> to access parts or slices of an array in C# with Visual Studio\n");

        }
    }
}
