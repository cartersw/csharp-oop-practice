using System.Drawing;
using System.Collections;
using System.Threading.Tasks;
using OtherLibrary;

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

            /*

            // exercises section 2


            Stopwatch stopwatch = new Stopwatch();
            // stop without starting stopwatch.Stop();
            Console.WriteLine(stopwatch.Duration);
            stopwatch.Start();
            // start after already starting stopwatch.Start();
            
            await Task.Delay(1000);
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(stopwatch.Duration);
            }
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Duration);
            stopwatch.Start();
            await Task.Delay(500);
            Console.WriteLine(stopwatch.Stop());
            Console.WriteLine(stopwatch.Duration);

            Post post = new Post("Test", "new post test");




            post.Upvote();
            post.Upvote();
            post.Downvote();


            post.Show();

            */

            /*
            // section 3

            Text text = new Text();
            text.Paste();

            DbMigrator dbMigrator = new DbMigrator(new Logger());
            Logger logger = new Logger();
            Installer installer = new Installer(logger);

            dbMigrator.Migrate();
            installer.Install();

            */

            
            // section 4

            /*

            Shopper shopper = new Shopper();
            shopper.Promote();
            GoldShopper gold = new GoldShopper();
            gold.OfferVoucher();
            // breaks
            // shopper.GetPoints();
            // RateCalculator c = new RateCalculator();

            Car car = new Car("Default");

            Label label = new Label();
            Shape shape = label;

            label.Width = 200;
            shape.Width = 100;

            Console.WriteLine(label.Width);

            StreamReader reader = new StreamReader(new MemoryStream());

            List<Shape> e3List = new List<Shape>();

            e3List.Add(shape);
            e3List.Add(label);

            Shape sh = new Label();
            Label la = (Label) sh;
            la.FontSize = 1;

            ArrayList list = new ArrayList();
            //boxing occurs
            list.Add(1);
            list.Add("test");

            // exercise section 4

            var stack = new EverythingStack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            stack.Clear();

            */

            //section 5

            List<OtherShape> list5 = new List<OtherShape>();

            list5.Add(new Cube());
            list5.Add(new Sphere());

            Canvas.DrawOtherShapes(list5);




            

            


        }
    }
}