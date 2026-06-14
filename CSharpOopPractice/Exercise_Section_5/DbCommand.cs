namespace CSharpIntermediate
{
    public class DbCommand
    {
        private readonly DbConnection _dbConnection;
        public DbCommand(DbConnection dbConnection)
        {
            
            if(dbConnection == null)
            {
                throw new ArgumentException("Connection is null");
            }

            _dbConnection = dbConnection;

        }

        public void Execute(string command)
        {
            if (string.IsNullOrWhiteSpace(command))
            {
                throw new ArgumentException("Command is null or empty");
            }
            _dbConnection.Open();
            Console.WriteLine("Executing: \n" + command);
            _dbConnection.Close();
        }
    }
}