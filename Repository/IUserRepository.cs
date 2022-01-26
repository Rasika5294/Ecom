using ShopBridge.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopBridge.Repository
{
    public interface IUserRepository
    {
        public int AddUser(User user);
        Task<Admin> CheckIfUserisValid(string email, string password);
        Task<IEnumerable<Product>> GetProductByCategury(string category);
        public int AddOrder(Order order);
        public int UpdateOrder(Order order);
        public int DeleteOrder(int id);
        public IEnumerable<Order> GetAllOrders(int id);

    }
}
