namespace CSharpIntermediate
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; private set; }    
        public TimeSpan Timeout { get; set; }
        

        protected DbConnection(string connectionString)
        {
            if(string.IsNullOrWhiteSpace(connectionString))
            {
                throw new ArgumentException("Connection string is null or empty");
            }
            Timeout = TimeSpan.FromSeconds(15);
            ConnectionString = connectionString;
        }

        public abstract void Open();
        public abstract void Close();
    }
}