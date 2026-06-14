namespace CSharpIntermediate
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }    
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            if(connectionString == null || connectionString == "")
            {
                throw new InvalidOperationException("Connection string is null or empty");
            }

            ConnectionString = connectionString;

        }

        public abstract void Open();
        public abstract void Close();
    }
}