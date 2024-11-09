// Program to create Class with Constructor 
// Programmer : Priyanka Thakur


namespace ClassWithConstructor_01
{
    // Defining a class named "Person"
    public class Person
    {
        // Fields: Data that the Person holds
        public string name;
        public int age;

        // Constructor: Special method to initialize the Person's data
        public Person(string personName, int personAge)
        {
            name = personName; // Set the name field
            age = personAge;   // Set the age field
        }

        // Method: Action that prints the person's details
        public void Greet()
        {
            Console.WriteLine("Hello, My name is " + name + " and I am " + age + " years old.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to create Class with Constructor\n");

            // Create an object of the Person class using the constructor
            Person student = new Person("Alice", 16);

            // Call the Greet method
            student.Greet(); // Output: Hello, my name is Alice and I am 16 years old.
        }
    }
}
