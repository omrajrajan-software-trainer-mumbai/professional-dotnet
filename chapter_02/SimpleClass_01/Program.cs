// Program to create Simple Class
// Programmer : Priyanka Thakur

namespace SimpleClass_01
{
    // Defining a class named "Car"
    public class Car
    {
        // Fields: Data that the Car holds
        public string color; // Color of the car
        public int speed;    // Speed of the car

        // Method: An action that the Car can perform
        public void Drive()
        {
            // This method will print a message when called
            Console.WriteLine("The car is driving at " + speed + " km/h.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to create Simple Class\n");

            // Create an object of the Car class
            Car myCar = new Car(); // This is like building a new robot from the blueprint

            // Assign values to the fields of the object
            myCar.color = "Red";
            myCar.speed = 100;

            // Call the method to perform the action
            myCar.Drive(); // Output: The car is driving at 100 km/h.
        }
    }
}
