using RestaurantMVCCodeFirst.Repositories;

namespace RestaurantMVCCodeFirst.Services
{
    public class MenuService : IMenuService
    {
        private readonly IMenuRepo _menurepo;
        public MenuService(IMenuRepo menurepo)
        {
            _menurepo = menurepo;
        }
    }
}
