using DataAccess;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
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
    }
    public static void Main(string[] args)
    {
        //DbHelper.db.Add(new Dish()
        //{
        //    Title = "Spaghetti Carbonara",
        //    Calories = 900,
        //    Protein = 8,
        //    Carbs = 45,
        //    Fat = 7,
        //    Recipe = "Pour hot water over the oatmeal and let it brew for 5-10 minutes. Slice the banana and add to the oatmeal. Add the almonds and stir.",
        //    Ingredients = "Oatmeal,Banana,Apple,Almonds,Water",
        //    AccountEmail = "oleh.chyzhov@gmail.com"
        //});
        //DbHelper.db.Add(new Dish()
        //{
        //    Title = "Paella",
        //    Calories = 1000,
        //    Protein = 56,
        //    Carbs = 23,
        //    Fat = 7,
        //    Recipe = "Pour hot water over the oatmeal and let it brew for 5-10 minutes. Slice the banana and add to the oatmeal. Add the almonds and stir.",
        //    Ingredients = "Oatmeal,Banana,Apple,Almonds,Water",
        //    AccountEmail = "oleh.chyzhov@gmail.com"
        //});
        //DbHelper.db.Add(new Dish()
        //{
        //    Title = "Sushi",
        //    Calories = 430,
        //    Protein = 24,
        //    Carbs = 5,
        //    Fat = 7,
        //    Recipe = "Pour hot water over the oatmeal and let it brew for 5-10 minutes. Slice the banana and add to the oatmeal. Add the almonds and stir.",
        //    Ingredients = "Fish,Rice,Salmon,Salt,Water",
        //    AccountEmail = "oleh.chyzhov@gmail.com"
        //});
        //DbHelper.db.Add(new Dish()
        //{
        //    Title = "Tacos al Pastor",
        //    Calories = 532,
        //    Protein = 12,
        //    Carbs = 63,
        //    Fat = 10,
        //    Recipe = "Pour hot water over the oatmeal and let it brew for 5-10 minutes. Slice the banana and add to the oatmeal. Add the almonds and stir.",
        //    Ingredients = "Oatmeal,Banana,Apple,Almonds,Water",
        //    AccountEmail = "oleh.chyzhov@gmail.com"
        //});
        //DbHelper.db.Add(new Dish()
        //{
        //    Title = "Falafel",
        //    Calories = 156,
        //    Protein = 12,
        //    Carbs = 21,
        //    Fat = 4,
        //    Recipe = "Pour hot water over the oatmeal and let it brew for 5-10 minutes. Slice the banana and add to the oatmeal. Add the almonds and stir.",
        //    Ingredients = "Oatmeal,Banana,Apple,Almonds,Water",
        //    AccountEmail = "oleh.chyzhov@gmail.com"
        //});

        //DbHelper.db.SaveChanges();

        foreach (var item in DbHelper.db.StatisticEntities.Where(entity => entity.AccountEmail == "oleh.chyzhov@gmail.com"))
        {
            DbHelper.db.StatisticEntities.Remove(item);
        }

        DbHelper.db.StatisticEntities.Add(new StatisticEntity()
        {
            AccountEmail = "oleh.chyzhov@gmail.com",
            Date = DateTime.Now,
            Weight = 70,
        });
        DbHelper.db.StatisticEntities.Add(new StatisticEntity()
        {
            AccountEmail = "oleh.chyzhov@gmail.com",
            Date = DateTime.Now.AddDays(7),
            Weight = 72,
        });
        DbHelper.db.StatisticEntities.Add(new StatisticEntity()
        {
            AccountEmail = "oleh.chyzhov@gmail.com",
            Date = DateTime.Now.AddDays(14),
            Weight = 73,
        });
        DbHelper.db.StatisticEntities.Add(new StatisticEntity()
        {
            AccountEmail = "oleh.chyzhov@gmail.com",
            Date = DateTime.Now.AddDays(21),
            Weight = 73,
        });
        DbHelper.db.StatisticEntities.Add(new StatisticEntity()
        {
            AccountEmail = "oleh.chyzhov@gmail.com",
            Date = DateTime.Now.AddDays(28),
            Weight = 74,
        });
        DbHelper.db.StatisticEntities.Add(new StatisticEntity()
        {
            AccountEmail = "oleh.chyzhov@gmail.com",
            Date = DateTime.Now.AddDays(35),
            Weight = 76,
        });
        DbHelper.db.StatisticEntities.Add(new StatisticEntity()
        {
            AccountEmail = "oleh.chyzhov@gmail.com",
            Date = DateTime.Now.AddDays(42),
            Weight = 78,
        });
        DbHelper.db.StatisticEntities.Add(new StatisticEntity()
        {
            AccountEmail = "oleh.chyzhov@gmail.com",
            Date = DateTime.Now.AddDays(49),
            Weight = 80,
        });
        DbHelper.db.StatisticEntities.Add(new StatisticEntity()
        {
            AccountEmail = "oleh.chyzhov@gmail.com",
            Date = DateTime.Now.AddDays(56),
            Weight = 79,
        });
        DbHelper.db.StatisticEntities.Add(new StatisticEntity()
        {
            AccountEmail = "oleh.chyzhov@gmail.com",
            Date = DateTime.Now.AddDays(61),
            Weight = 83,
        });
        DbHelper.db.StatisticEntities.Add(new StatisticEntity()
        {
            AccountEmail = "oleh.chyzhov@gmail.com",
            Date = DateTime.Now.AddDays(68),
            Weight = 84,
        });
        DbHelper.db.StatisticEntities.Add(new StatisticEntity()
        {
            AccountEmail = "oleh.chyzhov@gmail.com",
            Date = DateTime.Now.AddDays(75),
            Weight = 86,
        });

        DbHelper.db.SaveChanges();
    }
}