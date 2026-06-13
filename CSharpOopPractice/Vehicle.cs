namespace CSharpIntermediate
{
    public class Vehicle
    {   
        private readonly string _registrationNumber;
        
        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;
            Console.WriteLine("Vehicle is inititalized " + registrationNumber);
        }
    }

    
}