namespace CSharpIntermediate
{
    public class Point
    {
<<<<<<< HEAD
        public void Move(int x, int y)
        {
            
        }
        public void Move(Point newLocation)
        {
            
        }
        public void Move(Point newLocation, int speed)
        {
            
=======
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        
        public void Move(Point newLocation)
        {
            if(newLocation == null)
            {
                throw new ArgumentNullException("newLocation");
            }

            Move(newLocation.X, newLocation.Y);
>>>>>>> a4fbf09 (point class functionality and error handling)
        }

    }
}