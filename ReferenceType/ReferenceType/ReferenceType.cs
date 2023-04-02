namespace ReferenceType
{
    internal class Student
    {
        string Name;
        static void ChangeReferenceType(Student std2)
        {
            std2.Name = "Meghana Dasari";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("*****ReferenceType in C#*****");
            Student std1 = new Student();
            std1.Name = "Meghana";

            ChangeReferenceType(std1);

            Console.WriteLine(std1.Name);
        }
    }
}