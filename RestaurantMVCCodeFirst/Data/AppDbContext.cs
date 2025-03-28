using System.Data;
using Microsoft.EntityFrameworkCore;
using RestaurantMVCCodeFirst.Models;

namespace RestaurantMVCCodeFirst.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<UserModel> Users { get; set; }
        public DbSet<RoleModel> Roles { get; set; }
        public DbSet<CategoryModel> Categories { get; set; }
        public DbSet<MenuModel> Menu { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserModel>()
                .HasIndex(u => u.UserName)
                .IsUnique();

            modelBuilder.Entity<RoleModel>().HasData(
                    new RoleModel { RoleId = 1, RoleName = "User" },
                    new RoleModel { RoleId = 2, RoleName = "Admin" }
                    );
           

            modelBuilder.Entity<CategoryModel>(entity =>
            {
                entity.HasData(
                new CategoryModel { CategoryId = 1, CategoryName = "Italian" },
                new CategoryModel { CategoryId = 2, CategoryName = "Chinese" },
                new CategoryModel { CategoryId = 3, CategoryName = "Mexican" },
                new CategoryModel { CategoryId = 4, CategoryName = "Thai" },
                new CategoryModel { CategoryId = 5, CategoryName = "Street Food / Chaat - Indian" },
                new CategoryModel { CategoryId = 6, CategoryName = "South Indian" }
            );


            });
            modelBuilder.Entity<UserModel>().Property(u => u.CreatedDT).HasDefaultValueSql("GETDATE()");

        }
    }
}
