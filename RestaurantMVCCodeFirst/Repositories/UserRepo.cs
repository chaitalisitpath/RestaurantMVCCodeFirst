using System.Data;
using Microsoft.EntityFrameworkCore;
using RestaurantMVCCodeFirst.Data;
using RestaurantMVCCodeFirst.Models;
using RestaurantMVCCodeFirst.ViewModel;

namespace RestaurantMVCCodeFirst.Repositories
{
    public class UserRepo : IUserRepo
    {
        private readonly AppDbContext _context;

        public UserRepo(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<RoleModel>> GetRoles()
        {
            return await _context.Roles.ToListAsync();
        }

        public async Task<bool> GetuserByUsername(string username)
        {
            return await _context.Users.AnyAsync(u => u.UserName == username);
        }

        public async Task<bool> Login(string username, string password)
        {
            return await _context.Users.AnyAsync(u => u.UserName == username && u.Password == password);
        }

        public async Task<bool> Register(UserModel user)
        {
            _context.Users.Add(user);
            int isAffected = await _context.SaveChangesAsync();
            return isAffected > 0 ? true : false;
        }
    }
}
