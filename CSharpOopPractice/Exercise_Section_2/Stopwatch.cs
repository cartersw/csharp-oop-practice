namespace CSharpIntermediate
{
    public class Stopwatch
    {
        private DateTime startTime;
        private bool running = false;
        private TimeSpan duration;
        public TimeSpan Duration
        {
            get
            {
                if(running)
                {
                    return DateTime.Now - startTime;
                }
                else
                {
                    return duration;
                }
            }
            private set
            {
                duration = value;
            }
        }

        public Stopwatch()
        {
            duration = TimeSpan.Zero;
        }
        public void Start()
        {
            if (running)
            {
                throw new InvalidOperationException("Stopwatch already started");
            }
            running = true;
            startTime = DateTime.Now;
        }
        public TimeSpan Stop()
        {
            if (!running)
            {
                throw new InvalidOperationException("Stopwatch not started");
            }
            running = false;
            duration = DateTime.Now - startTime;
            return duration;
        }
    }
}