namespace CSharpIntermediate
{
    public class Stopwatch
    {
        private DateTime startTime;
        private bool running = false;
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
            TimeSpan duration = DateTime.Now - startTime;
            return duration;
        }
    }
}