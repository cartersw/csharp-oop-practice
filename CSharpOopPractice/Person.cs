namespace CSharpIntermediate
{
    public class Person
    {
        private string Name = "";
        public string FavoriteColor = "";
        public string Nickname = "";

        public void SetName(string name)
        {
            if (!String.IsNullOrEmpty(name))
            {
                this.Name = name;
            }
        }

        public string GetName()
        {
            return Name;
        }

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }

        public static Person Parse(string str)
        {
            Person person = new Person();
            person.Name = str;

            return person;
        }
    }
}