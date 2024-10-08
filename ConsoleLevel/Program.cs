using ConsoleLevel;
using DataAccess;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;
class Program
{
    public static void SimplePrint()
    {
        Console.WriteLine("Table accounts" + "\n");
        foreach (var item in DbHelper.db.Accounts)
        {
            Console.WriteLine(item + "\n");
        }

        Console.WriteLine("\n" + "Table account_informations" + "\n");
        foreach (var item in DbHelper.db.AccountInformations)
        {
            Console.WriteLine(item + "\n");
        }

        Console.WriteLine("\n" + "Table dish" + "\n");
        foreach (var item in DbHelper.db.Dishes)
        {
            Console.WriteLine(item + "\n");
        }

        Console.WriteLine("\n" + "Table food_plan" + "\n");
        foreach (var item in DbHelper.db.FoodPlans)
        {
            Console.WriteLine(item + "\n");
        }

        Console.WriteLine("\n" + "Table meal" + "\n");
        foreach (var item in DbHelper.db.Meals)
        {
            Console.WriteLine(item + "\n");
        }

        Console.WriteLine("\n" + "Table statistic_entity" + "\n");
        foreach (var item in DbHelper.db.StatisticEntities)
        {
            Console.WriteLine(item + "\n");
        }
    }
    public static void SmartPrint()
    {
        foreach (Account user in DbHelper.db.Accounts.Include("AccountInfo").Include("FoodPlans").Include("Dishes"))
        {
            Console.WriteLine("***********NEW_USER_ENTITY***********");
            Console.WriteLine($"User: {user.Email}, Password: {user.Password}");
            Console.WriteLine($"User sex: {user.AccountInfo.Sex}");
            Console.WriteLine($"User age: {user.AccountInfo.Age}");
            Console.WriteLine($"User goal: {user.AccountInfo.Goal}");
            Console.WriteLine($"User desired weight: {user.AccountInfo.DesiredWeight}");
            Console.WriteLine($"User current weight: {user.AccountInfo.Weight}");
            Console.WriteLine($"User daily calories: {user.AccountInfo.DailyCalories}");
            Console.WriteLine($"USER_DISHES:");
            if (user.Dishes != null)
            {
                foreach (Dish user_dish in user.Dishes)
                {
                    Console.WriteLine(user_dish.Title);
                }
            }
            Console.WriteLine($"\nUSER_FOODPLANS:");
            if (user.FoodPlans != null)
            {
                foreach (FoodPlan user_foodplan in user.FoodPlans)
                {
                    Console.WriteLine($"Foodplan: {user_foodplan.Title}");
                    Console.WriteLine("This foodplan contains meals:");
                    foreach (var meal in DbHelper.db.Meals.Include("FoodPlan").Include("DishMeals")
                        .Where(meal => meal.FoodPlanId == user_foodplan.Id))
                    {
                        Console.WriteLine(meal);
                        Console.WriteLine("This meal contains dishes:");
                        foreach (var dish_meal in meal.DishMeals.Where(dm => dm.MealId == meal.Id))
                        {
                            Console.WriteLine($"Dish:'{dish_meal.Dish.Title}' | ID:'{dish_meal.DishId}'");
                        }
                    }
                }
            }
        }
        //Console.WriteLine("DISH-MEAL RELATIONSHIP:");
        //foreach (var meal in DbHelper.db.Meals.Include("DishMeals"))
        //{
        //    Console.WriteLine($"Meal:'{meal.Title}' | ID:'{meal.Id}' has following dishes:");
        //    foreach (var dish_meal in meal.DishMeals.Where(dm => dm.MealId == meal.Id))
        //    {
        //        Console.WriteLine($"Dish:'{dish_meal.Dish.Title}' | ID:'{dish_meal.DishId}'");
        //    }
        //    Console.WriteLine();
        //}
    }
    public static void Main(string[] args)
    {
        SmartPrint();
        SimplePrint();
    }
}