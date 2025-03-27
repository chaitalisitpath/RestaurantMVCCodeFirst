using System.Data;
using RestaurantMVCCodeFirst.Data;
using RestaurantMVCCodeFirst.Models;

namespace RestaurantMVCCodeFirst.Repositories
{
    public class UserRepo : IUserRepo
    {
        private readonly AppDbContext _context;

        public UserRepo(AppDbContext context)
        {
            _context = context;
        }
        public bool Add(UserModel user)
        {
            return true;
        }
        public List<UserModel> Get()
        {
            var res = _context.Users.ToList();
            return res;
        }
    }
}
