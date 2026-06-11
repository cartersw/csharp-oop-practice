namespace CSharpIntermediate  
{
    public class Post
    {
        public string Title {get; set;}
        public string Description {get; set;}
        public DateTime CreatedAt {get; private set;}
        public int Votes {get; private set;}

        public Post(string title, string description)
        {
            Title = title;
            Description = description;
            CreatedAt = DateTime.Now;
        }

        public void Upvote()
        {
            Votes += 1;
        }

        public void Downvote()
        {
            Votes -= 1;
        }

        public void Show()
        {
            Console.WriteLine(
                Title + "\n" + Description + "\n" + Votes + "\nPosted: " + CreatedAt
            );
        }
    }
    
}