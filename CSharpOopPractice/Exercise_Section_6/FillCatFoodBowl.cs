using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpIntermediate
{
    public class FillCatFoodBowl : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Filling cat's food bowl...");
        }
    }
}
