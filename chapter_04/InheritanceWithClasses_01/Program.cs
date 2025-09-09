// Program to demonstrate inheritance with classes in C# with Visual Studio
// Programmer: Kavya Krishnan
// Chapter 04 pgno.96

namespace InheritanceWithClasses_01
{
    public class Position
    {
        // Auto-implemented properties for X and Y coordinate
        public int X{ get; set; }
        public int Y{ get; set; }
    }
    public class Size
    {
        // Auto-implemented properties for Width and Height
        public int Width {  get; set; }
        public int Height { get; set; }
    }
    // The Shape class defines read- only properties Position and Size
    // that are initialized using auto properties with property initializers
    public class Shape
    {
        public Position Position { get; } = new Position();
        public Size Size { get; } = new Size();

    }
    // Derived class: Rectangle 
    public class Rectangle : Shape
    {
        // draw() to display the properties
        public void Draw()
        {
            Console.WriteLine($"Drawing Rectangle at ({Position.X},{Position.Y}) with size {Size.Width}x{Size.Height}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate inheritance with classes in C# with Visual Studio");

            // Create a new Rectangle object
            Rectangle rectangle_object_reference = new Rectangle();
            // Setting values to properties
            rectangle_object_reference.Position.X = 10;
            rectangle_object_reference.Position.Y = 20;
            rectangle_object_reference.Size.Width = 100;
            rectangle_object_reference.Size.Height = 50;

            rectangle_object_reference.Draw();
        }
    }
}