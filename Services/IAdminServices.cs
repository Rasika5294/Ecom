using ShopBridge.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopBridge.Services
{
    public interface IAdminServices
    {
        Task<Admin> CheckIfAdminisValid(string email, string password);
        public int AddProduct(Product product);
        Task<IEnumerable<Product>> GetAllProducts();
        Task<Product> GetProductById(int id);
        public int DeleteProduct(int id);
        public int UpdateProduct(Product product);
        public int AddUser(User user);
        Task<IEnumerable<User>> GetAllUsers();
    }
}
