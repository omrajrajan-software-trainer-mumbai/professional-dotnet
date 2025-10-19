// Program to demonstrate the purpose of deferred query in C# with Visual Studio
// Programmer: Kavya Krishnan

namespace DeferredQueryExecution_01
{
    internal class Program
    {
        static void DeferredQuery()
        {
            List<string> names = new() { "Nino", "Alberto", "Juan", "Mike", "Phil" };
            var namesWithJ = from n in names
                             where n.StartsWith("J")
                             orderby n
                             select n;
            Console.WriteLine("First iteration");
            foreach (string name in namesWithJ)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();
            names.Add("John");
            names.Add("Jim");
            names.Add("Jack");
            names.Add("Denny");
            Console.WriteLine("Second iteration");
            foreach (string name in namesWithJ)
            {
                Console.WriteLine(name);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate the purpose of deferred query in C# with Visual Studio");
            DeferredQuery();
        }
    }
}
