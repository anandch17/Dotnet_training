using RepositoryWebApi.DBContext;
using RepositoryWebApi.Models;

namespace RepositoryWebApi.Repository
{
    public class ProductRepository: IProductRepository
    {

        private readonly ProductDBContext _context;

        public ProductRepository(ProductDBContext context)
        {
            _context = context;
        }

        public void DeleteProduct(int id)
        {
            var product = _context.Products.Find(id);
            if (product != null)
            {
                _context.Products.Remove(product);
                Save();
            }
        }

        public Product GetProductById(int id)
        {
            var product = _context.Products.Find(id);
            if (product == null)
            {
                throw new KeyNotFoundException($"Product with id {id} not found.");
            }
            return product;
        }
        public IEnumerable<Product> GetProducts()
        {
            return _context.Products.ToList();
        }

        public void InsertProduct(Product product)
        {
            _context.Products.Add(product);
             Save();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
             
          _context.Entry(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Save();
            
        }
    }
}