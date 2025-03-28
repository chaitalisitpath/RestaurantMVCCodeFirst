using RestaurantMVCCodeFirst.Models;
using RestaurantMVCCodeFirst.ViewModel;

namespace RestaurantMVCCodeFirst.Repositories
{
    public interface IUserRepo
    {
        Task<List<RoleModel>> GetRoles();
        Task<bool> Register(UserModel user);
        Task<bool> GetuserByUsername(string username);
    }
}
