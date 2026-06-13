namespace OtherLibrary
{
    public class Shopper
    {
        public int Id {get; set;}
        public string Name { get; set; } = "";
        public void Promote()
        {
            RateCalculator rateCalculator = new RateCalculator();
            int rating = rateCalculator.Calculate(this);
            if(rating == 0)
            {
                Console.WriteLine("Promoted to level 1");
            }
            else
            {
                Console.WriteLine("Promoted to level 2");
            }
        }

        protected int GetPoints()
        {
            return 0;
        }
        
    }

    

    
}