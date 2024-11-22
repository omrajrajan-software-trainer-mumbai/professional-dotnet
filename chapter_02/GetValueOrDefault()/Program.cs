// Program to demonstrate GetValueOrDefault() Method in C# with Visual Studio
// Programmer: Nikhil Patil


namespace GetValueOrDefault__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate GetValueOrDefault() Method in C# with Visual Studio");
            Console.WriteLine("Program to demonstrate GetValueOrDefault() Method in C# with Visual Studio\n");

            // Declaring a nullable decimal variable.
            decimal? currency = null;

            // Using the 'GetValueOrDefault()' method returns the value of 'currency'
            // or a default value (0.0f in the case of float) if it is null.
            decimal defaultValue = currency.GetValueOrDefault();

            Console.WriteLine($"Default Value: {defaultValue}");

            // Assigning a value to 'currency'.
            currency = 505.05M;

            // Now, 'GetValueOrDefault()' will return the actual value.
            decimal actualValue = currency.GetValueOrDefault();

            Console.WriteLine($"Actual Value: {actualValue}");  // Output: 505.05M
        }
    }
}
