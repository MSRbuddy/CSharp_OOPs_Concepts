namespace TypesOfInheritance
{
    internal class Inheritance
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********Types of Inheritance in C-Sharp**********");
            Console.WriteLine("\n");

            Console.WriteLine("*****Single Inheritance*****");
            TextBook tb = new TextBook();
            tb.Read("TB-1", 6);
            tb.ReadTextBook();
            Console.WriteLine("\n");

            Console.WriteLine("*****Multi-level Inheritance*****");
            Physics ph = new Physics();
            ph.Read("TB-2", 7);
            ph.ReadMathsBook();
            ph.ReadPhysicsBook();
            Console.WriteLine("\n");

            Console.WriteLine("*****Hierarchical Inheritance*****");
            Botany bt = new Botany();
            bt.Read("TB-3", 8);
            bt.ReadBiologyBook();
            bt.ReadBotanyBook();

            Zoology zg = new Zoology();
            zg.Read("TB-4", 9);
            zg.ReadBiologyBook();
            zg.ReadZoologyBook();
            Console.WriteLine("\n");

            Console.WriteLine("*****Multiple Inheritance*****");
            Language ln = new Language();
            ln.ReadTeluguBook();
            ln.ReadHindiBook();
        }
    }
}