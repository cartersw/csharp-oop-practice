namespace CSharpIntermediate
{
    public abstract class DbConnection
    {
        protected string ConnectionString { get; set; }    
        protected TimeSpan Timeout { get; set; }
        

        public DbConnection(string connectionString)
        {
            if(connectionString == null || connectionString == "")
            {
                throw new InvalidOperationException("Connection string is null or empty");
            }

            Timeout = TimeSpan.FromSeconds(15);

            ConnectionString = connectionString;

        }

        public abstract void Open();
        public abstract void Close();
    }
}