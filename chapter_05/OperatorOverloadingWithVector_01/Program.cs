// Program to demonstrate the use of Operator Overloading with the vector type in C# with visual studio
// Programmer: Kavya Krishnan

using System.Text.RegularExpressions;

namespace OperatorOverloadingWithVector_01
{
    readonly struct Vector
    {
        // Constructor 1- Specifies the initial value of the vector 
        public Vector(double x, double y, double z) => (X, Y, Z) = (x, y, z);
        // Constructor 2- Copy constructor; initialize a class or struct instance by copying another instance
        public Vector(Vector v) => (X, Y, Z) = (v.X, v.Y, v.Z);
        public readonly double X;
        public readonly double Y;
        public readonly double Z;
        public override string ToString() => $"( {X}, {Y}, {Z} )";

        // The operator overload that provides support for the addition operator
        // 'operator' keyword tells the compiler it is actually an operator overload you are defining.
        public static Vector operator +(Vector left, Vector right) => new Vector(left.X + right.X, left.Y + right.Y, left.Z + right.Z);
        // Multiplying a vector with a vector
        public static Vector operator *(Vector left, Vector right) => new Vector(left.X * right.X, left.Y * right.Y, left.Z * right.Z);
        // Multiplying a vector with a double
        public static Vector operator *(double left, Vector right) => new Vector(left * right.X, left * right.Y, left * right.Z);
        public static Vector operator *(Vector left, double right) => right * left;
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate the use of Operator Overloading with the vector type in C# with visual studio\n");
            Vector vect1, vect2, vect3;
            vect1 = new Vector(3.0, 3.0, 1.0);
            vect2 = new Vector(2.0, -4.0, -4.0);
            vect3 = vect1 + vect2;
            Console.WriteLine($"vect1 = {vect1}");
            Console.WriteLine($"vect2 = {vect2}");
            Console.WriteLine($"vect3 = {vect3}\n");

            // Just by implementing the + operator, you can use the compound assignment operator +=. 
            vect3 += vect2;
            Console.WriteLine($"vect3 = {vect3}\n");

            // The int number used is converted to a double because this is the best match for the overload
            Console.WriteLine($"2 * vect3 = {2 * vect3}");
            Console.WriteLine($"vect3 += vect2 gives {vect3 += vect2}");
            Console.WriteLine($"vect3 = vect1 * 2 gives {vect3 = vect1 * 2}");
            Console.WriteLine($"vect1 * vect3 = {vect1 * vect3}");
        }
    }
}
