// Program to demonstrate the use of multiple catch blocks in C# with Visual Studio
// Programmer: Kavya Krishnan

namespace _01_MultipleCatchBlocks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate the use of multiple catch blocks in C# with Visual Studio\n");

            // Infinite loop to repeatedly take user input until the user decides to exit
            while (true)
            {
                try
                {
                    // Prompt the user to enter a number or hit return to exit
                    Console.Write("Input a number between 0 and 5 or just hit return to exit)> ");
                    string? userInput = Console.ReadLine();

                    // If the user presses Enter without typing anything, exit the loop
                    if (string.IsNullOrEmpty(userInput))
                    {
                        break;
                    }

                    // Convert the string input to an integer
                    int index = Convert.ToInt32(userInput);

                    // If the number is not between 0 and 5, throw a custom IndexOutOfRangeException
                    if (index < 0 || index > 5)
                    {
                        throw new IndexOutOfRangeException($"You typed in {userInput}");
                    }

                    // Display the valid number entered by the user
                    Console.WriteLine($"Your number was {index}");
                }
                // This block handles IndexOutOfRangeException specifically
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine($"Exception: Number should be between 0 and 5. {ex.Message}");
                }
                // This general catch block handles any other type of exception
                catch (Exception ex)
                {
                    Console.WriteLine($"An exception was thrown. Exception type: {ex.GetType().Name}, Message: {ex.Message}");
                }
                // The finally block always executes, whether an exception occurs or not
                finally
                {
                    Console.WriteLine("Thank you\n");
                }
            }
        }
    }
}
