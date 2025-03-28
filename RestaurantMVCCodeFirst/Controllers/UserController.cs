using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RestaurantMVCCodeFirst.Models;
using RestaurantMVCCodeFirst.Repositories;
using RestaurantMVCCodeFirst.Services;
using RestaurantMVCCodeFirst.ViewModel;

namespace RestaurantMVCCodeFirst.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public async Task<IActionResult> Register()
        {
            ViewBag.Roles = await _userService.GetRoles();
            var model = new RegisterViewModel();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            ViewBag.Roles = await _userService.GetRoles();
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                bool isRegistered = await _userService.Register(model);
                if (!isRegistered)
                {
                    TempData["SuccessMessage"] = "Registration successful. You can now log in.";
                    return RedirectToAction("Login");
                }
                else
                {
                    return View(model);
                    //ModelState.AddModelError("", "Username already exists. Please try another one.");
                }
            }
            catch (Exception ex)
            {
                return View(ex.Message);
                //ModelState.AddModelError("", "An unexpected error occurred. Please try again.");
                //ModelState.AddModelError("An unexpected error occurred. Please try again.",ex.Message);

            }

            //model.Roles = await _userService.GetRoles();
            return View(model);
        }
    }


}
