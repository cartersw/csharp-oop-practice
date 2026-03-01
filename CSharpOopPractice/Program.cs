namespace CSharpIntermediate
{

    class Program
    {
        static void Main(string[] args)
        {
            Person person = Person.Parse("test");
            person.Introduce("person");
            Customer customer = new Customer(2, "person who shops");

            Console.WriteLine(customer.Id + " " + customer.Name);
            Console.WriteLine(customer.Orders.Count);

            //object initializer
            Person person1 = new Person
            {
                FavoriteColor = "red",
                Nickname = "joe"
            };

            Console.WriteLine("2nd person fav color is " + person1.FavoriteColor);

            int result = WeirdCalculator.Add(1, 2, 3, 4);
            Console.WriteLine(result);



        }
    }
}