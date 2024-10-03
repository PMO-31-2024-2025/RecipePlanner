﻿// <auto-generated />
using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    partial class DataBaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("DataAccess.Models.Account", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccountInfoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Email");

                    b.HasIndex("AccountInfoId");

                    b.ToTable("accounts");
                });

            modelBuilder.Entity("DataAccess.Models.AccountInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AccountEmail")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DailyCalories")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DesiredWeight")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Goal")
                        .HasColumnType("TEXT");

                    b.Property<int>("Height")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Weight")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("AccountEmail");

                    b.ToTable("account_informations");
                });

            modelBuilder.Entity("DataAccess.Models.Dish", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AccountEmail")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Calories")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Carbs")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Fat")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("Ingredients")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Protein")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Recipe")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AccountEmail");

                    b.ToTable("dish");
                });

            modelBuilder.Entity("DataAccess.Models.FoodPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AccountEmail")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Calories")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Carbs")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Fat")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Protein")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AccountEmail");

                    b.ToTable("food_plan");
                });

            modelBuilder.Entity("DataAccess.Models.Meal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Calories")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Carbs")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Fat")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FoodPlanId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Protein")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("FoodPlanId");

                    b.ToTable("meal");
                });

            modelBuilder.Entity("DataAccess.Models.StatisticEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AccountEmail")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<int>("Weight")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("AccountEmail");

                    b.ToTable("statistic_entity");
                });

            modelBuilder.Entity("DishMeal", b =>
                {
                    b.Property<int>("DishesId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MealsId")
                        .HasColumnType("INTEGER");

                    b.HasKey("DishesId", "MealsId");

                    b.HasIndex("MealsId");

                    b.ToTable("DishMeal");
                });

            modelBuilder.Entity("DataAccess.Models.Account", b =>
                {
                    b.HasOne("DataAccess.Models.AccountInfo", "AccountInfo")
                        .WithMany()
                        .HasForeignKey("AccountInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AccountInfo");
                });

            modelBuilder.Entity("DataAccess.Models.AccountInfo", b =>
                {
                    b.HasOne("DataAccess.Models.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountEmail")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("DataAccess.Models.Dish", b =>
                {
                    b.HasOne("DataAccess.Models.Account", "Account")
                        .WithMany("Dishes")
                        .HasForeignKey("AccountEmail")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("DataAccess.Models.FoodPlan", b =>
                {
                    b.HasOne("DataAccess.Models.Account", "Account")
                        .WithMany("FoodPlans")
                        .HasForeignKey("AccountEmail")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("DataAccess.Models.Meal", b =>
                {
                    b.HasOne("DataAccess.Models.FoodPlan", "FoodPlan")
                        .WithMany("Meals")
                        .HasForeignKey("FoodPlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FoodPlan");
                });

            modelBuilder.Entity("DataAccess.Models.StatisticEntity", b =>
                {
                    b.HasOne("DataAccess.Models.Account", "Account")
                        .WithMany("StatisticEntities")
                        .HasForeignKey("AccountEmail")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("DishMeal", b =>
                {
                    b.HasOne("DataAccess.Models.Dish", null)
                        .WithMany()
                        .HasForeignKey("DishesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Models.Meal", null)
                        .WithMany()
                        .HasForeignKey("MealsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataAccess.Models.Account", b =>
                {
                    b.Navigation("Dishes");

                    b.Navigation("FoodPlans");

                    b.Navigation("StatisticEntities");
                });

            modelBuilder.Entity("DataAccess.Models.FoodPlan", b =>
                {
                    b.Navigation("Meals");
                });
#pragma warning restore 612, 618
        }
    }
}
