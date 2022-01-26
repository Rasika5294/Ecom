using Microsoft.EntityFrameworkCore;
using ShopBridge.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBridge.Repository
{
    public class UserRepository : IUserRepository
    {
        public readonly ShopBridgeContext _context;
        public UserRepository(ShopBridgeContext context)
        {
            this._context = context;
        }

        public int AddOrder(Order order)
        {
            try
            {
                _context.Orders.Add(order);
                _context.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

        public int AddUser(User user)
        {
            try
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

        public async Task<Admin> CheckIfUserisValid(string email, string password)
        {
            return await _context.Admins.Where(user => user.Email == email && user.Password == password).SingleOrDefaultAsync();
        }

        public int DeleteOrder(int id)
        {
            try
            {
                Order order = _context.Orders.Find(id);
                _context.Orders.Remove(order);
                _context.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

        public  IEnumerable<Order> GetAllOrders(int id)
        {
            return _context.Orders.Where(order => order.UserId == id).ToList();
        }

        public async Task<IEnumerable<Product>> GetProductByCategury(string category)
        {
           return await _context.Products.Where(product => product.Category == category).ToListAsync(); 
        }

        public int UpdateOrder(Order order)
        {
            try
            {
                _context.Entry(order).State = EntityState.Modified;
                _context.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }
    }
}
