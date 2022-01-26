using ShopBridge.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopBridge.Repository
{
    public interface IAdminRepository
    {
        Task<Admin> CheckIfAdminisValid(string email, string password);
        public int AddProduct(Product product);
        Task<IEnumerable<Product>> GetAllProducts();
        public int DeleteProduct(int id);
        public int UpdateProduct(Product product);
        Task<Product> GetProductById(int id);
        public int AddUser(User user);
        Task<IEnumerable<User>> GetAllUsers();

    }
}
