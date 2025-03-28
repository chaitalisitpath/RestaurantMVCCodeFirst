using System.ComponentModel.DataAnnotations;
using RestaurantMVCCodeFirst.Models;

namespace RestaurantMVCCodeFirst.ViewModel
{
    public class RegisterViewModel
    {
        public int UserId { get; set; }

        [Required(ErrorMessage = "Plase enter username")]
        [MaxLength(100)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please select user type")]
        public int RoleId { get; set; }

       
    }
   

}
