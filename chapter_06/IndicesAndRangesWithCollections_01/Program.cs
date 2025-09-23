// Program to demonstrate the use of the use of indices and ranges with custom collection in C# with Visual Studio
// Programmer: Kavya Krishnan

using System;
using System.Linq;

namespace IndicesAndRangesWithCollections_01
{
    public class MyCollection
    {
        private int[] _array = Enumerable.Range(1, 100).ToArray();
        public int Length => _array.Length;
        public int this[int index]
        {
            get => _array[index];
            set => _array[index] = value;
        }
        public int[] Slice(int start, int length)
        {
            var slice = new int[length];
            Array.Copy(_array, start, slice, 0, length);
            return slice;
        }
        public void ShowRange(string title, int[] data)
        {
            Console.WriteLine(title);
            Console.WriteLine(string.Join(" ", data));
            Console.WriteLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate the use of the use of indices and ranges with custom collection in C# with Visual Studio\n");

            MyCollection coll = new();
            int n = coll[^20];
            Console.WriteLine($"Item from the collection: {n}");
            coll.ShowRange("Using custom collection", coll[45..^40]);
        }
    }
}
