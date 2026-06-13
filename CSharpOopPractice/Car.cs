namespace CSharpIntermediate
{
    public class Car : Vehicle
    {
        public Car(string registrationNumber)
            : base(registrationNumber)
        {
            Console.WriteLine("Car is initialized " + registrationNumber);
        }
    }
}