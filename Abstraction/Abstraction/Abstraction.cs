namespace Abstraction
{
    abstract class Book
    {
        // abstract method
        public abstract void bookSubject();
    }

    // inheriting from abstract class
    class TextBook : Book
    {
        // provide implementation of abstract method
        public override void bookSubject()
        {
            Console.WriteLine("English");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // create an object of TextBook class
            TextBook obj = new TextBook();
            obj.bookSubject();
        }
    }
}
