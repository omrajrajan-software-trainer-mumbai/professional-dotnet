// Program to demonstrate sealed classes and methods in C# with Visual Studio
// Programmer: Kavya Krishnan
// Chapter 04 pgno.102

namespace SealedClassesAndMethods_01
{
    // Base class
    class MyBaseClass
    {
        // Virtual method - can be overridden
        public virtual void FinalMethod()
        {
            Console.WriteLine("MyBaseClass implementation of FinalMethod");
        }
    }
    // Derived class
    class MyClass : MyBaseClass
    {
        // Override FinalMethod and seal it so it cannot be overridden again
        public sealed override void FinalMethod()
        {
            Console.WriteLine("MyClass sealed implementation of FinalMethod");
        }
    }
    // Attempting to override will cause a compilation error
    sealed class DerivedClass : MyClass
    {
        /*
        public override void FinalMethod()   //  Not allowed
        {
            Console.WriteLine("DerivedClass trying to override FinalMethod");
        }
        */
    }
    // Cannot Derive from sealed class
    class CannotDeriveClass : DerivedClass
    {

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate sealed classes and methods in C# with Visual Studio");

            MyBaseClass b = new MyBaseClass();
            b.FinalMethod();   // Calls base implementation

            MyClass m = new MyClass();
            m.FinalMethod();   // Calls sealed implementation

            DerivedClass d = new DerivedClass();
            d.FinalMethod();   // Inherits MyClass version (cannot override it)
        }
    }
}
