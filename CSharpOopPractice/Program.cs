<<<<<<< HEAD
﻿namespace CSharpIntermediate
=======
﻿using System.Drawing;

namespace CSharpIntermediate
>>>>>>> a4fbf09 (point class functionality and error handling)
{

    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
=======

            
>>>>>>> a4fbf09 (point class functionality and error handling)
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

            int result1 = WeirdCalculator.Add();
            Console.WriteLine(result1);


<<<<<<< HEAD
=======
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


>>>>>>> a4fbf09 (point class functionality and error handling)

        }
    }
}