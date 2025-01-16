namespace DesignPatterns.Patterns
{
    public interface IConnection
    {
        void Connect();

        void Disconnect();
    }

    public class MssqlConnection : IConnection
    {
        public void Connect()
        {
            // Connects to MSSQL database
        }

        public void Disconnect()
        {
            // Disconnects from MSSQL database
        }
    }

    public class CosmosDbConnection : IConnection
    {
        public void Connect()
        {
            // Connects to Azure cloud database
        }

        public void Disconnect()
        {
            // Disconnects from Azure cloud database
        }
    }

    public interface IConnectionFactory
    {
        // Factory pattern allows you to pass parameters to base concrete implementation on
        IConnection CreateConnection();
    }

    public class ProductDataAccess
    {
        private readonly IConnectionFactory _factory;

        public ProductDataAccess(IConnectionFactory factory)
        {
            _factory = factory;
        }

        public void Add(Product product)
        {
            IConnection connection = _factory.CreateConnection();
            connection.Connect();

            // Adds product to database

            connection.Disconnect();
        }
    }
}
