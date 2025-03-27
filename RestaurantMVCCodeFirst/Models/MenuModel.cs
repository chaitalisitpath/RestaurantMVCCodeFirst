using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantMVCCodeFirst.Models
{
    public class MenuModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MenuId { get; set; }

        [Required]
        public string Name { get; set; }    

        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public bool IsActive { get; set; } = true;

        [Required]
        public DateTime CreatedDT { get; set; } = DateTime.UtcNow;

        [Required]
        public int CreatedBy { get; set; }

        public int UpdatedBy { get; set; }
        public DateTime UpdatedDT { get; set; }

        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public CategoryModel Category { get; set; }

    }
}
