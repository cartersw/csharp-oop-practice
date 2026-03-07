namespace CSharpIntermediate
{
    public class AnotherPerson
    {
        public DateTime Birthdate { get; set; }

        public string Name { get; set; } = "";

        public int Age
        {
            get 
            { 
            var timeSpan = DateTime.Today - Birthdate;
            int years = timeSpan.Days / 365;
            
            return years;
            }
        }

        
        
    }

}