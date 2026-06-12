namespace CSharpIntermediate
{
    public class PresentationObject
    {
        public int Width {get; set;}
        public int Height {get; set;}
        

        public void Copy()
        {
            Console.WriteLine("Object copied to clipboard");
        }
        public void Paste()
        {
            Console.WriteLine("Object was pasted");
        }
    }
}