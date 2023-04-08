namespace TypesOfInheritance
{
        //Single-Inheritance
        class Book
        {
            public string Title;
            public int Standard;
            public void Read(string name,int standard)
            {
                Title= name;
                Standard= standard;
                Console.WriteLine("This is a Book: {0} of class: {1}",name,standard);
            }
        }
        class TextBook : Book
        {
            public void ReadTextBook()
            {
                Console.WriteLine("This is a TextBook.");
            }
        }

        //Multi-level Inheritance
        class Maths : Book
        {
            public void ReadMathsBook()
            {
                Console.WriteLine("This is a Maths Book.");
            }
        }
        class Physics : Maths
        {
            public void ReadPhysicsBook()
            {
                Console.WriteLine("This is a Physics Book.");
            }
        }

        //Hierarchical Inheritance
        class Biology : Book
        {
            public void ReadBiologyBook()
            {
                Console.WriteLine("This is a Biology Book.");
            }
        }
        class Botany : Biology
        {
            public void ReadBotanyBook()
            {
                Console.WriteLine("This is a Botany Book.");
            }
        }
        class Zoology : Biology
        {
            public void ReadZoologyBook()
            {
                Console.WriteLine("This is a Zoology Book.");
            }
        }

        //Multiple Inheritance
        interface ITelugu
        {
            public void ReadTeluguBook()
            { 
            }
        }
        interface IHindi
        {
            public void ReadHindiBook()
            {
            }
        }
        class Language : ITelugu,IHindi
        {
            public void ReadTeluguBook()
            {
                Console.WriteLine("This is a Telugu Book");
            }
            public void ReadHindiBook()
            {
                Console.WriteLine("This is a Hindi Book");
            }
        }
}
