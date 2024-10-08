using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DataBaseContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountInfo> AccountInformations { get; set; }
        public DbSet<StatisticEntity> StatisticEntities { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<FoodPlan> FoodPlans { get; set; }
        public DbSet<DishMeal> DishMealConnectTable { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            using (StreamReader SR = new StreamReader(@"D:\ConnectionString.txt"))
            {
                string connectionString = SR.ReadLine()!;
                optionsBuilder.UseSqlite(connectionString);
            }
        }
        // Only in many-to-many relationship
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DishMeal>().HasKey(dm => new { dm.DishId, dm.MealId });
            modelBuilder.Entity<DishMeal>().HasOne(dm => dm.Dish).WithMany(m => m.DishMeals).HasForeignKey(dm => dm.DishId);
            modelBuilder.Entity<DishMeal>().HasOne(dm => dm.Meal).WithMany(m => m.DishMeals).HasForeignKey(dm => dm.MealId);
        }
    }
}
