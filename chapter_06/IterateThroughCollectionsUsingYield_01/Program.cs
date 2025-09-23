// Program to demonstrate the use of yield return statement to iterate through a collection in C# with Visual Studio
// Programmer: Kavya Krishnan

namespace IterateThroughCollectionsUsingYield_01
{
    //  The class MusicTitles enables iterating the titles 
    public class MusicTitles
    {
        // An array named "names" that consist of titles
        string[] names = { "Tubular Bells", "Hergest Ridge", "Ommadawn", "Platinum" };
        // The iteration occurs  in a default way with the GetEnumerator method
        public IEnumerator<string> GetEnumerator()
        {
            for (int i = 0; i < 4; i++)
            {
                yield return names[i];
            }
        }
        // The iteration occurs in reverse order with the Reverse method
        public IEnumerable<string> Reverse()
        {
            for (int i = 3; i >= 0; i--)
            {
                yield return names[i];
            }
        }
        // The iteration occurs through a subset with the Subset method
        public IEnumerable<string> Subset(int index, int length)
        {
            for (int i = index; i < index + length; i++)
            {
                yield return names[i];
            }
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate the use of yield return statement to iterate through a collection in C# with Visual Studio\n");

            // Creating an instance named titles
            MusicTitles titles = new();
            // Iterating through the elements and printing the title
            foreach (var title in titles)
            {
                Console.WriteLine(title);
            }
            Console.WriteLine();
            Console.WriteLine("reverse");
            // Iterating through the elements and printing the title in reverse order
            foreach (var title in titles.Reverse())
            {
                Console.WriteLine(title);
            }
            Console.WriteLine();
            Console.WriteLine("subset");
            // The subset is iterated by passing the index and number of items to iterate to the Subset method
            foreach (var title in titles.Subset(2, 2))
            {
                Console.WriteLine(title);
            }

        }
    }
}