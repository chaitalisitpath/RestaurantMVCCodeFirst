using Microsoft.AspNetCore.Mvc;
using RestaurantMVCCodeFirst.Repositories;
using RestaurantMVCCodeFirst.Services;

namespace RestaurantMVCCodeFirst.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepo _userService;

        public UserController(IUserRepo userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            //_userService.Get();
            return View();
        }

    }
}
