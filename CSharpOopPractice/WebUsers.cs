namespace CSharpIntermediate
{
    public class WebUsers
    {
        private Dictionary<string, string> _dictionary;
        public string Id { get; private set; } = "";

        public WebUsers()
        {
            _dictionary = new Dictionary<string, string>();

        }

        public void Leave()
        {
            _dictionary.Remove(Id);
        }

        public string this[string key]
        {
            get {return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }
    }
}