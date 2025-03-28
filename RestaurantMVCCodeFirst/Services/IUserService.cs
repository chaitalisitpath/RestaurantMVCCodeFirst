using RestaurantMVCCodeFirst.Models;
using RestaurantMVCCodeFirst.ViewModel;

namespace RestaurantMVCCodeFirst.Services
{
    public interface IUserService
    {
        Task<List<RoleModel>> GetRoles();
        Task<bool> Register(RegisterViewModel reg);
        Task<bool> Login (string username, string password);
    }
}
