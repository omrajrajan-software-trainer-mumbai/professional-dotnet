// Program to demonstrate the use of extension methods in C# with Visual Studio
// Programmer: Kavya Krishnan

namespace ExtensionMethods_01
{
    public static class StringExtensions
    {
        public static int GetWordCount(this string s) => s.Split().Length;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate the use of extension methods in C# with Visual Studio\n");
            string fox = "the quick brown fox jumped over the lazy dogs";
            int wordCount = fox.GetWordCount();
            Console.WriteLine($"{wordCount} words");
            int wordcount = StringExtensions.GetWordCount(fox);
        }
    }
}
