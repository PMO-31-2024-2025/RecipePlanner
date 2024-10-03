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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            using (StreamReader SR = new StreamReader(@"D:\ConnectionString.txt"))
            {
                string connectionString = SR.ReadLine()!;
                optionsBuilder.UseSqlite(connectionString);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dish>()
                .HasMany(dish => dish.Meals)
                .WithMany(meal => meal.Dishes)
                .UsingEntity(entity => entity.ToTable("DishMeal"));
        }
    }
}
