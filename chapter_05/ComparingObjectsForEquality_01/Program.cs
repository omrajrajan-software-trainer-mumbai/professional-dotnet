// Program to demonstrate how objects are compared for equality in C# with visual studio
// Programmer: Kavya Krishnan
// Chapter 05

namespace ComparingObjectsForEquality_01
{
    class Book : IEquatable<Book>
    {
        public Book(string title, string publisher)
        {
            Title = title;
            Publisher = publisher;
        }
        public string Title { get; }
        public string Publisher { get; }
        protected virtual Type EqualityContract { get; } = typeof(Book);
        public override string ToString() => Title;
        public override bool Equals(object? obj) => this == obj as Book;
        public override int GetHashCode() => Title.GetHashCode() ^ Publisher.GetHashCode();
        public virtual bool Equals(Book? other) => this == other;
        public static bool operator ==(Book? left, Book? right) => left?.Title == right?.Title && left?.Publisher == right?.Publisher && left?.EqualityContract == right?.EqualityContract;
        public static bool operator !=(Book? left, Book? right) => !(left == right);
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate how objects are compared for equality in C# with visual studio\n");

            Book book1 = new("Professional C#", "Wrox Press");
            Book book2 = new("Professional C#", "Wrox Press");
            if (!object.ReferenceEquals(book1, book2))
            {
                Console.WriteLine("Not the same reference");
            }
            if (book1.Equals(book2))
            {
                Console.WriteLine("The same object using the generic Equals method");
            }
            object book3 = book2;
            if (book1.Equals(book3))
            {
                Console.WriteLine("The same object using the overridden Equals method");
            }
            if (book1 == book2)
            {
                Console.WriteLine("The same book using the == operator");
            }
        }
    }
}
