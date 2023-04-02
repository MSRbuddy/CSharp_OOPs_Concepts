namespace Variables
{
    internal class Program
    {
        const float PI = 3.14f; //Constant Variable
        static int x = 10; //Static Variable
        //We are going to initialize variable y through constructor
        int y; //Non-Static or Instance Variable
        //Constructor
        public Program(int a)
        {
            //Initializing non-static variable
            y = a;
        }
        static void Main(string[] args)
        {
            //Accessing the static variable without instance
            Console.WriteLine($"x value: {x}");
            //Accessing the constant variable without instance
            Console.WriteLine($"PI value: {PI}");
            Program obj1 = new Program(5);
            Program obj2 = new Program(25);
            //Accessing Non-Static variable using instance
            Console.WriteLine($"obj1 y value: {obj1.y}");
            Console.WriteLine($"obj2 y value: {obj2.y}");
        }
    }
}