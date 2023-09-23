using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GetBalance.DATA;
using Microsoft.EntityFrameworkCore;

namespace GetBalance.DAL
{
	public class AppDbContext : DbContext
	{
		public DbSet<User> Users { get; set; }
		public DbSet<UserDetail> UserDetails { get; set; }
		public DbSet<Food> Foods { get; set; }
		public DbSet<Meal> Meals { get; set; }
		public DbSet<FoodCategory> FoodCategories { get; set; }
		public DbSet<Portion> Portions { get; set; }
        public DbSet<UserTarget> UserTargets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=DESKTOP-HF14TQL;Database=DietProjeDb;Trusted_Connection=True;"); //TODO:Change Connection string
        }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new Mapping.FoodCategoryMapping());
			modelBuilder.ApplyConfiguration(new Mapping.FoodMapping());
			modelBuilder.ApplyConfiguration(new Mapping.MealMapping());
			modelBuilder.ApplyConfiguration(new Mapping.PortionMapping());
			modelBuilder.ApplyConfiguration(new Mapping.UserDetailMapping());
			modelBuilder.ApplyConfiguration(new Mapping.UserMapping());
			modelBuilder.ApplyConfiguration(new Mapping.UserTargetMapping());

			base.OnModelCreating(modelBuilder);
		}
	}
}
