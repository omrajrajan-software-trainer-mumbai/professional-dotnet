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
            Rectangle rect = new Rectangle();
            // Setting values to properties
            rect.Position.X = 10;
            rect.Position.Y = 20;
            rect.Size.Width = 100;
            rect.Size.Height = 50;

            rect.Draw();
        }
    }
}