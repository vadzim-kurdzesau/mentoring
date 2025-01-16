namespace SolidPrinciples
{
    // "Depend upon abstractions, not concretes."
    public class Product
    {
        public string Id { get; set; }

        public string Name { get; set; }
    }

    public interface IProductDataAccess
    {
        void Add(Product product);
    }

    public class MssqlDataAccess : IProductDataAccess
    {
        public void Add(Product product)
        {
            // Adds product to MSSQL database
        }
    }

    public class CosmosDbDataAccess : IProductDataAccess
    {
        public void Add(Product product)
        {
            // Adds product to Azure cloud database
        }
    }

    public class InMemoryDataAccess : IProductDataAccess
    {
        private readonly Dictionary<string, Product> _products = new Dictionary<string, Product>();

        public void Add(Product product)
        {
            _products.Add(product.Id, product);
        }
    }

    public class ProductUserInterface
    {
        private readonly IProductDataAccess _dataAccess;

        public ProductUserInterface(IProductDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public void AddNewProductToStore()
        {
            Console.Write("Enter product name: ");
            string productName = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(productName))
            {
                throw new ArgumentException("Product name can't be null, empty or a whitespace.");
            }

            Product product = new Product
            {
                Id = Guid.NewGuid().ToString(),
                Name = productName,
            };

            _dataAccess.Add(product);
        }
    }
}
