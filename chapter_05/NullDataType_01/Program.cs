// Program to demonstrate nullable data types in C# with Visual Studio
// Programmer: Kavya Krishnan
// Chapter 05

using System.Net;

namespace NullDataType_01
{
    public class MyClass
    {
        public string Name { get; set; } = "Default Instance";
    }
    // Example Person class to demonstrate null-conditional operator
    public class Person
    {
        public string? FirstName { get; set; }
        public int? Age { get; set; }    // Nullable int
        public Address? HomeAddress { get; set; }
    }
    public class Address
    {
        public string? City { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate nullable data types in C# with Visual Studio\n");

            // -------------------------------
            // 1. Null-Coalescing Operator (??)
            // -------------------------------

            // A nullable integer (int?) is declared with a null value.
            int? nullableNumber = null;

            // If nullableNumber is null, then 100 will be used as default.
            int result1 = nullableNumber ?? 100;
            Console.WriteLine($"1) nullableNumber ?? 100 = {result1}"); // Output: 100

            // Assign a value to nullableNumber
            nullableNumber = 50;

            // Now, since nullableNumber is not null, ?? returns its value
            int result2 = nullableNumber ?? 100;
            Console.WriteLine($"2) nullableNumber ?? 100 = {result2}"); // Output: 50

            // Teaching point:
            // The ?? operator acts like: "If left side is NOT null, use it; else use right side."


            // ---------------------------------------------------
            // 2. Null-Coalescing Assignment Operator (??=)
            // ---------------------------------------------------

            MyClass? object_reference = null;

            // With ??=, if obj is null, assign a new MyClass instance.
            object_reference ??= new MyClass();
            Console.WriteLine($"\n3) obj.Name after ??= new MyClass(): {object_reference.Name}");

            // If obj is NOT null, ??= does nothing.
            object_reference ??= new MyClass { Name = "Another Instance" };
            Console.WriteLine($"4) obj.Name after second ??=: {object_reference.Name}");

            // Teaching point:
            // ??= is shorthand for:
            // if (obj == null) obj = new MyClass();


            // ----------------------------------------------
            // 3. Null-Conditional Operator (?.) with ?? combo
            // ----------------------------------------------

            Person? person = null;

            // Using traditional null-check:
            // if (person != null) { string name = person.FirstName; }

            // Using ?. operator:
            string? safeFirstName = person?.FirstName;
            Console.WriteLine($"\n5) person?.FirstName = {safeFirstName ?? "NULL"}");

            // Assign a new Person with no HomeAddress
            person = new Person { FirstName = "Rahul", Age = null };

            // Access Age with ?? to handle nulls
            int safeAge = person.Age ?? 0;
            Console.WriteLine($"6) Person Age (with ??): {safeAge}");

            // Access HomeAddress.City safely
            string? city = person?.HomeAddress?.City ?? "City not available";
            Console.WriteLine($"7) person?.HomeAddress?.City = {city}");


            // ----------------------------------------------
            // 4. Null-Conditional with Arrays
            // ----------------------------------------------

            int[]? numbers = null;

            // Using ?[0] ensures no NullReferenceException if numbers is null.
            int safeNumber = numbers?[0] ?? -1;
            Console.WriteLine($"\n8) numbers?[0] ?? -1 = {safeNumber}");

            // Now assign array
            numbers = new int[] { 42, 99, 100 };

            // Safe access now returns actual value
            safeNumber = numbers?[0] ?? -1;
            Console.WriteLine($"9) numbers?[0] ?? -1 = {safeNumber}");
        }
    }
}
