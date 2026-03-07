namespace CSharpIntermediate
{
    public class WebUsers
    {
        private Dictionary<string, string> _dictionary;
        

        public WebUsers()
        {
            _dictionary = new Dictionary<string, string>();

        }

        public string this[string key]
        {
            get {return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }
    }
}