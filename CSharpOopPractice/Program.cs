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
        }
    }
}