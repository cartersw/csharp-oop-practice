using System.Drawing;
using System.Threading.Tasks;

namespace CSharpIntermediate
{

    class Program
    {
        static async Task Main(string[] args)
        {
            
            /*

            // initial class practice
            
            Person person = new Person("newguy");
            person.Introduce("person");

            person.SetName("dude");
            Console.WriteLine(person.GetName());


            Customer customer = new Customer(2, "person who shops");

            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            Console.WriteLine(customer.Orders.Count);

            Console.WriteLine(customer.Id + " " + customer.Name);
            Console.WriteLine(customer.Orders.Count);


            int result = WeirdCalculator.Add(1, 2, 3, 4);
            Console.WriteLine(result);

            int result1 = WeirdCalculator.Add();
            Console.WriteLine(result1);


            try
            {
                Point testPoint = new Point(1, 2);

                //testPoint.Move(null);
                
                testPoint.Move(3, 4);

                Console.WriteLine(testPoint.X + " " + testPoint.Y);
                
            }
            catch (System.Exception)
            {
                Console.WriteLine("An unexpected error occured.");
            }


            int number;

            var res = int.TryParse("abc", out number);

            if (res)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Conversion failed");
            }

            */


            // exercises section 2


            Stopwatch stopwatch = new Stopwatch();
            // stop without starting stopwatch.Stop();
            stopwatch.Start();
            // start after already starting stopwatch.Start();

            await Task.Delay(1000);
            Console.WriteLine(stopwatch.Stop());
            stopwatch.Start();
            await Task.Delay(500);
            Console.WriteLine(stopwatch.Stop());

            


        }
    }
}