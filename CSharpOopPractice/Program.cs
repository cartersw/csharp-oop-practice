namespace Classes
{
    public class Person
    {
        public string Name = "";

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "test";
            
        }
    }
}