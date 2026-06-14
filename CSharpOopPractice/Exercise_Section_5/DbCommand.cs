namespace CSharpIntermediate
{
    public class DbCommand
    {
        private readonly DbConnection _dbConnection;
        private string _command {get; set;}
        public DbCommand(DbConnection dbConnection, string command)
        {
            
            if(dbConnection == null)
            {
                throw new ArgumentException("Connection is null");
            }
            if (string.IsNullOrWhiteSpace(command))
            {
                throw new ArgumentException("Command is null or whitespace");
            }

            _dbConnection = dbConnection;
            _command = command;

        }

        public void Execute()
        {
            
            _dbConnection.Open();
            Console.WriteLine("Executing: \n" + _command);
            _dbConnection.Close();
        }
    }
}