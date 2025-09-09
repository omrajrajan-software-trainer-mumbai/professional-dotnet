// Program to demonstrate Access Modifiers In Nested Classes in C# with Visual Studio
// Programmer: Nikhil Patil
// Programmer: Kavya Krishnan

namespace AccessModifiersInNestedClasses_01
{
    class OuterClass
    {
        private class InnerClass
        {
            // Private method within nested class or inner class
            public void InnerClassMethod()
            {
                Console.WriteLine("Inner Class Method");
            }
        }

        public void AccessInnerClass()
        {
            InnerClass innerClassReference = new InnerClass();
            innerClassReference.InnerClassMethod(); // Accessing private nested class method
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Access Modifiers In Nested Classes in C# with Visual Studio\n");

            OuterClass outerClassReference = new OuterClass();
            outerClassReference.AccessInnerClass(); // Output: Inner Class Method
        }
    }
}
