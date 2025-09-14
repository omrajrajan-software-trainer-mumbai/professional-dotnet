// Program to demonstrate the use of predefined interfaces using IComparable<T> in C# with Visual Studio
// Programmer: Kavya Krishnan
// Chapter 04 pgno.101

namespace PredefinedInterfaces_01
{
    public interface IComparable<in T>
    {
        int CompareTo(T? other);
    }
    public record Person(string FirstName, string LastName) : IComparable<Person>
    {
        public int CompareTo(Person? other)
        {
            int compare = LastName.CompareTo(other?.LastName);
            if (compare is 0)
            {
                return FirstName.CompareTo(other?.FirstName);
            }
            
            return compare;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate the use of predefined interfaces using IComparable<T> in C# with Visual Studio");

            Person p1 = new("Jackie", "Stewart");
            Person p2 = new("Graham", "Hill");
            Person p3 = new("Damon", "Hill");
            Person[] people = { p1, p2, p3 };
            Array.Sort(people);
            foreach (var p in people)
            {
                Console.WriteLine(p);
            }
        }
    }
}