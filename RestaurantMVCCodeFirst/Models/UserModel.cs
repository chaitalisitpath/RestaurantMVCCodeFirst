using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace RestaurantMVCCodeFirst.Models
{
    public class UserModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Please enter your name")]
        [MaxLength(100)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter password")]
        public string Password { get; set; }

        [Required]
        public bool IsActive { get; set; } = true;

        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedDT { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedDT { get; set; } 
        public int RoleId { get; set; }

        [ForeignKey("RoleId")]
        public RoleModel Roles{ get; set; }

    }
    
}
