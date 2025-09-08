// Program to demonstrate abstract classes and methods in C# with Visual Studio
// Programmer: Kavya Krishnan
// Chapter 04 pgno.101

namespace AbstractClassesAndMethods_01
{
    public class Position
    {
        // Auto-implemented properties for X and Y coordinate
        public int X { get; set; }
        public int Y { get; set; }
    }
    public class Size
    {
        // Auto-implemented properties for Width and Height
        public int Width { get; set; }
        public int Height { get; set; }
    }
    public abstract class Shape
    {
        public Position Position { get; } = new Position();
        public Size Size { get; } = new Size();


        public abstract Shape Clone(); // abstract method
    }
    public class Rectangle : Shape
    {
        public void Draw()
        {
            Console.WriteLine($"Drawing Rectangle at ({Position.X},{Position.Y}) with size {Size.Width}x{Size.Height}");
        }
        // Abstract method Overriden
        public override Rectangle Clone()
        {
            Rectangle rectangle_object = new();
            rectangle_object.Position.X = Position.X;
            rectangle_object.Position.Y = Position.Y;
            rectangle_object.Size.Width = Size.Width;
            rectangle_object.Size.Height = Size.Height;
            return rectangle_object;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate abstract classes and methods in C# with Visual Studio");

            // Create a new Rectangle object
            Rectangle rect = new Rectangle();
            // Setting values to properties
            rect.Position.X = 10;
            rect.Position.Y = 20;
            rect.Size.Width = 100;
            rect.Size.Height = 50;

            rect.Clone();
            rect.Draw();

            // Shape s1 = new Shape();      // Not possible as Shape is abstract
        }
    }
}
