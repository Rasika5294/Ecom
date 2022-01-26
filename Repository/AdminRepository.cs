using Microsoft.EntityFrameworkCore;
using ShopBridge.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBridge.Repository
{
    public class AdminRepository : IAdminRepository
    {
        private readonly ShopBridgeContext _context;
        public AdminRepository(ShopBridgeContext context)
        {
            this._context = context;
        }
        public async Task<Admin> CheckIfAdminisValid(string email, string password)
        {
            return await _context.Admins.Where(admin => admin.Email == email && admin.Password == password).SingleOrDefaultAsync();
        }
        //Get List of all the avilable Products
        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await _context.Products.ToListAsync();
        }
        //To add Product in Product table
        public int AddProduct(Product product)
        {
            try
            {
               _context.Products.Add(product);
               _context.SaveChanges();
                return 1;   
            }
            catch
            {
                throw;
            }
        }

        public async Task<Product> GetProductById(int id)
        {
            var result = await _context.Products.Where(product => product.ProductId == id).SingleOrDefaultAsync();

            return result;
        }

        public int DeleteProduct(int id)
        {
            try
            {
                Product product = _context.Products.Find(id);
                _context.Products.Remove(product);
                _context.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }

        }

        public int UpdateProduct(Product product)
        {
            try
            {
                _context.Entry(product).State = EntityState.Modified;
                _context.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            return await _context.Users.ToListAsync();
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
    }
}
