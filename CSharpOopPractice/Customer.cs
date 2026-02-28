
namespace CSharpIntermediate
{
    public class Customer
    {
        public int Id;
        public string Name = "";
        public List<Order> Orders;
        public Customer()
        {
            Orders = new List<Order>();
        }
        public Customer(int id)
            : this()
        {
            this.Id = id;
        }
        //overloading
        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }
    }
}