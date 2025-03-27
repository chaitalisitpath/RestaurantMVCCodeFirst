using System.ComponentModel.DataAnnotations;

namespace RestaurantMVCCodeFirst.ViewModel
{
    public class Register
    {
        public int UserId { get; set; }

        [Required(ErrorMessage = "Plase enter username")]
        [MaxLength(100)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please select user type")]
        public int RoleId { get; set; }

        public List<RoleDropdownItems> Roles { get; set; }

    }
    public class RoleDropdownItems
    { 
        public int RoleId { get; set; }
        public string RoleName { get; set; }
    }

}
