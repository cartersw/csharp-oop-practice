namespace CSharpIntermediate
{
    public abstract class OtherShape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Position Position { get; set; }
        public abstract void Draw();
    }
}