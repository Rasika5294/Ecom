using ShopBridge.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopBridge.Services
{
    public interface IUserServices
    {
        public int AddUser(User user);  
        Task<Admin> CheckIfUserisValid(string email, string password);
        Task<IEnumerable<Product>> GetProductByCategury(string category);
        public int AddOrder(Order order);
        public IEnumerable<Order> GetAllOrders(int id);
        public int UpdateOrder(Order order);
        public int DeleteOrder(int id);

    }
}
