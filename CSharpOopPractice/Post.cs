namespace CSharpIntermediate  
{
    public class Post
    {
        public string Title {get; set;}
        public string Description {get; set;}
        public DateTime Date {get; private set;}
        public int Vote {get; private set;}

        public Post(string title)
        {
            Title = title;
            Description = "";
            Date = DateTime.Now;
        }

        public void Upvote()
        {
            Vote += 1;
        }

        public void Downvote()
        {
            Vote -= 1;
        }

        public void Show()
        {
            Console.WriteLine(
                Title + "\n" + Description + "\n" + Vote + "\nPosted: " + Date
            );
        }
    }
    
}