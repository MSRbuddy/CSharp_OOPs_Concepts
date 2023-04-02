namespace Inheritance
{
    class A
    {
        public void Method1()
        {
            Console.WriteLine("Method 1: Hi");
        }
        public void Method2()
        {
            Console.WriteLine("Method 2: Hello");
        }
    }
    class B : A
    {
        public void Method3()
        {
            Console.WriteLine("Method 3: Everyone");
        }
        static void Main()
        {
            B obj = new B();
            obj.Method1();
            obj.Method2();
            obj.Method3();
            Console.ReadKey();
        }
    }
}