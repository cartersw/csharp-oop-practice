namespace CSharpIntermediate
{
    public class Person
    {
        private string _name = "";
        public string _favoriteColor = "";

        public Person(string name)
        {
            SetName(name);
        }
    

        public void SetName(string name)
        {
            if (!String.IsNullOrEmpty(name))
            {
                this._name = name;
            }
        }

        public string GetName()
        {
            return _name;
        }

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, _name);
        }

    }
}