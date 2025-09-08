// Program to demonstrate overriding with virtual methods in C# with Visual Studio
// Programmer: Kavya Krishnan
// Chapter 04 pgno.97

namespace VirtualMethods_01
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
    public class Shape
    {
        public Position Position { get; set;  } = new Position();
        public Size Size { get; set; } = new Size();
        public void Draw() => DisplayShape();
        protected virtual void DisplayShape()
        {
            Console.WriteLine($"Shape with {Position} and {Size}");
        }
    }
    public class Rectangle : Shape
    {
        protected override void DisplayShape()
        {
            Console.WriteLine($"Rectangle at position ({Position.X}, {Position.Y}) with size {Size.Width}x{Size.Height}");
        }
    }
    

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate overriding with virtual methods in C# with Visual Studio");

            // Create a rectangle
            Shape rect = new Rectangle();
            rect.Position.X = 10;
            rect.Position.Y = 20;
            rect.Size.Width = 100;
            rect.Size.Height = 50;

            // Call Draw() on shapes
            rect.Draw();
        }
    }
}
