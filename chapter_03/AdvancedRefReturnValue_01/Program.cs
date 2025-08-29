// Program to demonstrate Advanced Ref Return Value in C# with Visual Studio
// Programmer: Priyanka Thakur 
// Programmer: Kavya Krishnan 

using System.Xml.Linq;

namespace AdvancedRefReturnValue_01
{
    internal class Program
    {
        static ref int GetElement(ref int[] numbers, int index)
        {
            // Modifying the element directly affects the original array
            numbers[index] = 70;
            return ref numbers[index];
        }


        static void Main()
        {
            Console.WriteLine("Program to demonstrate Advanced Ref Return Value in C# with Visual Studio\n");

            int[] numbers = { 7, 9, 1, 5 };

            ref int element = ref GetElement(ref numbers, 1);

            Console.WriteLine(string.Join(", ", numbers)); // Output: 7, 70, 1, 5
        }
    }
}
