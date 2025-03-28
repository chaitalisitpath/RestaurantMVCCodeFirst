using RestaurantMVCCodeFirst.Models;
using RestaurantMVCCodeFirst.Repositories;
using RestaurantMVCCodeFirst.ViewModel;

namespace RestaurantMVCCodeFirst.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepo _userRepo;
        public UserService(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }

      
        public async Task<List<RoleModel>> GetRoles()
        {
            return await _userRepo.GetRoles();
        }

      
        public async Task<bool> Register(RegisterViewModel reg)
        {
            bool userExists = await _userRepo.GetuserByUsername(reg.UserName);
            if (userExists)
            {
                return false;
            }
            var user = new UserModel
            {
                UserName = reg.UserName,
                Password = reg.Password,
                RoleId = reg.RoleId,
                IsActive = true,
                CreatedDT = DateTime.UtcNow,
                UpdatedDT = DateTime.UtcNow
            };
            return await _userRepo.Register(user);
        }
    }
}
