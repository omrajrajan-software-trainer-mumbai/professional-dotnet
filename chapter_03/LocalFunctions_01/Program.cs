// Program to demonstrate the use of Local functions in C# with Visual Studio
// Programmer: Kavya Krishnan

Console.WriteLine("Program to demonstrate the use of Local functions in C# with Visual Studio\n");
Console.WriteLine("In this code the function Add() is declared with the static modifier\n");
static void IntroLocalFunnctions()
{
    static int Add(int x, int y) => x + y;
    int result = Add(3, 7);
    Console.WriteLine($"Called the local function with this result: {result}");
}
IntroLocalFunnctions();

// In this code the function Add is declared without the static modifier
Console.WriteLine("\nIn this code the function Add() is declared without the static modifier\n");
static void LocalFunctionWithClosure()
{
    int z = 3;
    int result = Add(1, 2);
    Console.WriteLine($"Called the local function with this result: {result}");
    int Add(int x, int y) => x + y + z;
}
LocalFunctionWithClosure();