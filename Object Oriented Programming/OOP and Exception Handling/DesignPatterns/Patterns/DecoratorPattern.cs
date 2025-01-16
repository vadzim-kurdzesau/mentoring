using System.Text.Json;

namespace DesignPatterns.Patterns
{
    public interface IProductRepository
    {
        void Add(Product product);

        Product? Get(string id);
    }

    // Stores data in a JSON file
    public class FileRepository : IProductRepository
    {
        private readonly string _directory;

        public FileRepository(string directory)
        {
            _directory = directory;
        }

        public void Add(Product product)
        {
            product.Id = Guid.NewGuid().ToString(); // Create new unique ID
            var json = JsonSerializer.Serialize(product);
            File.WriteAllText(Path.Combine(_directory, product.Id), json);
        }

        public Product? Get(string id)
        {
            try
            {
                var json = File.ReadAllText(Path.Combine(_directory, id));
                return JsonSerializer.Deserialize<Product>(json);
            }
            catch (DirectoryNotFoundException)
            {
                return default;
            }
        }
}
