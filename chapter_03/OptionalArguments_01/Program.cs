// Program to demonstrate the use of optional arguments in C# with Visual Studio
// Programmer: Kavya Krishnan

Console.WriteLine("Program to demonstrate the use of optional arguments in C# with Visual Studio\n");
Console.WriteLine("Testing methods with single optional parameters\n");
void TestMethod(int notOptionalNumber, int optionalNumber = 42)
{
    Console.WriteLine(optionalNumber + notOptionalNumber);
}
TestMethod(11);
TestMethod(11, 42);

Console.WriteLine("\nTesting methods with multiple optional parameters\n");
void TestMethod_MultipleOptional(int n, int opt1 = 11, int opt2 = 22, int opt3 = 33)
{
    Console.WriteLine(n + opt1 + opt2 + opt3);
}
TestMethod_MultipleOptional(1);
TestMethod_MultipleOptional(1, 2, 3);

Console.WriteLine("\nTesting methods with multiple optional parameters and named parameters\n");

TestMethod_MultipleOptional(1, opt3: 4);