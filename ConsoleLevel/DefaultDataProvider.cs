﻿using DataAccess.Models;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;

namespace ConsoleLevel
{
    public static class DefaultDataProvider
    {
        public static void FillAccountsTable()
        {
            DbHelper.db.Add(new Account() { Email = "oleh.chyzhov@gmail.com", Password = "Oleg2005" });
            DbHelper.db.Add(new Account() { Email = "nazar.valaga@gmail.com", Password = "12345" });
            DbHelper.db.Add(new Account() { Email = "yulia.tymochko@gmail.com", Password = "54321" });
            DbHelper.db.Add(new Account() { Email = "roman.torskiy@gmail.com", Password = "46532" });
            DbHelper.db.Add(new Account() { Email = "roman.shmyhelskiy@gmail.com", Password = "13562" });
            DbHelper.db.Add(new Account() { Email = "anastasiya.seliverstova@gmail.com", Password = "46532" });
            DbHelper.db.Add(new Account() { Email = "valeriya.ponomariova@gmail.com", Password = "53241" });
            DbHelper.db.Add(new Account() { Email = "olena.kupchak@gmail.com", Password = "52413" });
            DbHelper.db.Add(new Account() { Email = "veronika.filippova@gmail.com", Password = "46513" });
            DbHelper.db.Add(new Account() { Email = "lilya.voloshchuk@gmail.com", Password = "13524" });
            DbHelper.db.Add(new Account() { Email = "oleh.diduch@gmail.com", Password = "63425" });
            DbHelper.db.Add(new Account() { Email = "markian.kravets@gmail.com", Password = "13546" });
            DbHelper.db.Add(new Account() { Email = "oleh.kit@gmail.com", Password = "24531" });
            DbHelper.db.Add(new Account() { Email = "nazar.midyk@gmail.com", Password = "11111" });
            DbHelper.db.Add(new Account() { Email = "maks.salo@gmail.com", Password = "55555" });
            DbHelper.db.Add(new Account() { Email = "olesia.rudevych@gmail.com", Password = "olesia111" });
            DbHelper.db.Add(new Account() { Email = "pavlo.smahula@gmail.com", Password = "psmhl01" });
            DbHelper.db.Add(new Account() { Email = "yulia.holub@gmail.com", Password = "yuliah22" });
            DbHelper.db.Add(new Account() { Email = "maksym.slipkevych@gmail.com", Password = "maks02" });
            DbHelper.db.Add(new Account() { Email = "andriy.stefurak@gmail.com", Password = "stefchuk333" });
            DbHelper.db.Add(new Account() { Email = "maksym.kuzelyak@gmail.com", Password = "maksik03" });
            DbHelper.db.Add(new Account() { Email = "nastya.sashchack@gmail.com", Password = "nastya444" });
            DbHelper.db.Add(new Account() { Email = "vika.mochevynska@gmail.com", Password = "vikim04" });
            DbHelper.db.Add(new Account() { Email = "anna.lukianchuk@gmail.com", Password = "annaluk555" });
            DbHelper.db.Add(new Account() { Email = "anna.tkach@gmail.com", Password = "anyuta05" });
            DbHelper.db.Add(new Account() { Email = "uliana.maydanska@gmail.com", Password = "umdnsk666" });
            DbHelper.db.Add(new Account() { Email = "kristian.matiyishyn@gmail.com", Password = "krism06" });
            DbHelper.db.Add(new Account() { Email = "misha.chekan@gmail.com", Password = "miha777" });
            DbHelper.db.Add(new Account() { Email = "yulia.bohatyr@gmail.com", Password = "yuli07" });
            DbHelper.db.Add(new Account() { Email = "tanya.mazyr@gmail.com", Password = "tanya888" });
            DbHelper.db.SaveChanges();
        }
        public static void FillAccountsInfoTable()
        {
            DbHelper.db.Add(new AccountInfo() { Id = 1, Sex = Sex.Female, Age = 19, Weight = 69, Height = 163, DesiredWeight = 56, Goal = WeightGoal.Lose, DailyCalories = 1522, AccountEmail = "anastasiya.seliverstova@gmail.com" });
            DbHelper.db.Add(new AccountInfo() { Id = 2, Sex = Sex.Female, Age = 19, Weight = 49, Height = 157, DesiredWeight = 59, Goal = WeightGoal.Gain, DailyCalories = 1319, AccountEmail = "lilya.voloshchuk@gmail.com" });
            DbHelper.db.Add(new AccountInfo() { Id = 3, Sex = Sex.Male, Age = 19, Weight = 69, Height = 183, DesiredWeight = 83, Goal = WeightGoal.Gain, DailyCalories = 1797, AccountEmail = "maks.salo@gmail.com" });
            DbHelper.db.Add(new AccountInfo() { Id = 4, Sex = Sex.Male, Age = 19, Weight = 72, Height = 177, DesiredWeight = 85, Goal = WeightGoal.Gain, DailyCalories = 1724, AccountEmail = "markian.kravets@gmail.com" });
            DbHelper.db.Add(new AccountInfo() { Id = 5, Sex = Sex.Male, Age = 19, Weight = 89, Height = 173, DesiredWeight = 72, Goal = WeightGoal.Lose, DailyCalories = 1927, AccountEmail = "nazar.midyk@gmail.com" });
            DbHelper.db.Add(new AccountInfo() { Id = 6, Sex = Sex.Male, Age = 19, Weight = 62, Height = 182, DesiredWeight = 75, Goal = WeightGoal.Gain, DailyCalories = 1574, AccountEmail = "nazar.valaga@gmail.com" });
            DbHelper.db.Add(new AccountInfo() { Id = 7, Sex = Sex.Male, Age = 19, Weight = 75, Height = 178, DesiredWeight = 89, Goal = WeightGoal.Gain, DailyCalories = 1711, AccountEmail = "oleh.chyzhov@gmail.com" });
            DbHelper.db.Add(new AccountInfo() { Id = 8, Sex = Sex.Male, Age = 19, Weight = 72, Height = 177, DesiredWeight = 85, Goal = WeightGoal.Gain, DailyCalories = 1687, AccountEmail = "oleh.diduch@gmail.com" });
            DbHelper.db.Add(new AccountInfo() { Id = 9, Sex = Sex.Male, Age = 19, Weight = 75, Height = 173, DesiredWeight = 65, Goal = WeightGoal.Gain, DailyCalories = 1681, AccountEmail = "oleh.kit@gmail.com" });
            DbHelper.db.Add(new AccountInfo() { Id = 10, Sex = Sex.Female, Age = 19, Weight = 73, Height = 167, DesiredWeight = 65, Goal = WeightGoal.Lose, DailyCalories = 1683, AccountEmail = "olena.kupchak@gmail.com" });
            DbHelper.db.Add(new AccountInfo() { Id = 11, Sex = Sex.Male, Age = 19, Weight = 69, Height = 183, DesiredWeight = 78, Goal = WeightGoal.Gain, DailyCalories = 1743, AccountEmail = "roman.shmyhelskiy@gmail.com" });
            DbHelper.db.Add(new AccountInfo() { Id = 12, Sex = Sex.Male, Age = 19, Weight = 76, Height = 185, DesiredWeight = 96, Goal = WeightGoal.Gain, DailyCalories = 1791, AccountEmail = "roman.torskiy@gmail.com" });
            DbHelper.db.Add(new AccountInfo() { Id = 13, Sex = Sex.Female, Age = 19, Weight = 75, Height = 176, DesiredWeight = 65, Goal = WeightGoal.Lose, DailyCalories = 1475, AccountEmail = "valeriya.ponomariova@gmail.com" });
            DbHelper.db.Add(new AccountInfo() { Id = 14, Sex = Sex.Female, Age = 19, Weight = 53, Height = 177, DesiredWeight = 63, Goal = WeightGoal.Gain, DailyCalories = 1333, AccountEmail = "veronika.filippova@gmail.com" });
            DbHelper.db.Add(new AccountInfo() { Id = 15, Sex = Sex.Female, Age = 19, Weight = 72, Height = 166, DesiredWeight = 62, Goal = WeightGoal.Lose, DailyCalories = 1440, AccountEmail = "yulia.tymochko@gmail.com" });
            DbHelper.db.Add(new AccountInfo() { Id = 16, Sex = Sex.Male, Age = 19, Weight = 55, Height = 158, DesiredWeight = 60, Goal = WeightGoal.Gain, DailyCalories = 1448, AccountEmail = "andriy.stefurak@gmail.com" });
            DbHelper.db.Add(new AccountInfo() { Id = 17, Sex = Sex.Female, Age = 19, Weight = 65, Height = 175, DesiredWeight = 70, Goal = WeightGoal.Gain, DailyCalories = 1488, AccountEmail = "anna.lukianchuk@gmail.com" });
            DbHelper.db.Add(new AccountInfo() { Id = 18, Sex = Sex.Female, Age = 20, Weight = 67, Height = 170, DesiredWeight = 60, Goal = WeightGoal.Lose, DailyCalories = 1476, AccountEmail = "anna.tkach@gmail.com" });
            DbHelper.db.Add(new AccountInfo() { Id = 19, Sex = Sex.Male, Age = 20, Weight = 50, Height = 180, DesiredWeight = 65, Goal = WeightGoal.Gain, DailyCalories = 1680, AccountEmail = "kristian.matiyishyn@gmail.com" });
            DbHelper.db.Add(new AccountInfo() { Id = 20, Sex = Sex.Male, Age = 19, Weight = 57, Height = 165, DesiredWeight = 57, Goal = WeightGoal.Maintain, DailyCalories = 1520, AccountEmail = "maksym.kuzelyak@gmail.com" });
            DbHelper.db.Add(new AccountInfo() { Id = 21, Sex = Sex.Male, Age = 20, Weight = 59, Height = 173, DesiredWeight = 68, Goal = WeightGoal.Gain, DailyCalories = 1570, AccountEmail = "maksym.slipkevych@gmail.com" });
            DbHelper.db.Add(new AccountInfo() { Id = 22, Sex = Sex.Male, Age = 19, Weight = 79, Height = 172, DesiredWeight = 70, Goal = WeightGoal.Lose, DailyCalories = 1600, AccountEmail = "misha.chekan@gmail.com" });
            DbHelper.db.Add(new AccountInfo() { Id = 23, Sex = Sex.Female, Age = 20, Weight = 67, Height = 176, DesiredWeight = 67, Goal = WeightGoal.Maintain, DailyCalories = 1450, AccountEmail = "nastya.sashchack@gmail.com" });
            DbHelper.db.Add(new AccountInfo() { Id = 24, Sex = Sex.Female, Age = 20, Weight = 50, Height = 155, DesiredWeight = 55, Goal = WeightGoal.Gain, DailyCalories = 1430, AccountEmail = "olesia.rudevych@gmail.com" });
            DbHelper.db.Add(new AccountInfo() { Id = 25, Sex = Sex.Male, Age = 19, Weight = 69, Height = 171, DesiredWeight = 69, Goal = WeightGoal.Maintain, DailyCalories = 1670, AccountEmail = "pavlo.smahula@gmail.com" });
            DbHelper.db.Add(new AccountInfo() { Id = 26, Sex = Sex.Female, Age = 20, Weight = 62, Height = 178, DesiredWeight = 68, Goal = WeightGoal.Gain, DailyCalories = 1620, AccountEmail = "tanya.mazyr@gmail.com" });
            DbHelper.db.Add(new AccountInfo() { Id = 27, Sex = Sex.Female, Age = 19, Weight = 54, Height = 161, DesiredWeight = 61, Goal = WeightGoal.Gain, DailyCalories = 1320, AccountEmail = "uliana.maydanska@gmail.com" });
            DbHelper.db.Add(new AccountInfo() { Id = 28, Sex = Sex.Female, Age = 20, Weight = 52, Height = 163, DesiredWeight = 66, Goal = WeightGoal.Gain, DailyCalories = 1440, AccountEmail = "vika.mochevynska@gmail.com" });
            DbHelper.db.Add(new AccountInfo() { Id = 29, Sex = Sex.Female, Age = 19, Weight = 62, Height = 174, DesiredWeight = 56, Goal = WeightGoal.Lose, DailyCalories = 1310, AccountEmail = "yulia.bohatyr@gmail.com" });
            DbHelper.db.Add(new AccountInfo() { Id = 30, Sex = Sex.Female, Age = 20, Weight = 52, Height = 163, DesiredWeight = 52, Goal = WeightGoal.Maintain, DailyCalories = 1280, AccountEmail = "yulia.holub@gmail.com" });
            DbHelper.db.SaveChanges();
        }
        public static void FillDishTable()
        {
            DbHelper.db.Add(new Dish()
            {
                Id = 1,
                Title = "Spaghetti Carbonara",
                Calories = 300,
                Protein = 8,
                Carbs = 45,
                Fat = 7,
                Recipe = "Pour hot water over the oatmeal and let it brew for 5-10 minutes. Slice the banana and add to the oatmeal. Add the almonds and stir.",
                Ingredients = "Oatmeal,Banana,Apple,Almonds,Water",
                AccountEmail = "anastasiya.seliverstova@gmail.com"
            });
            DbHelper.db.Add(new Dish()
            {
                Id = 2,
                Title = "Chicken Tikka Masala",
                Calories = 300,
                Protein = 8,
                Carbs = 45,
                Fat = 7,
                Recipe = "Pour hot water over the oatmeal and let it brew for 5-10 minutes. Slice the banana and add to the oatmeal. Add the almonds and stir.",
                Ingredients = "Oatmeal,Banana,Apple,Almonds,Water",
                AccountEmail = "lilya.voloshchuk@gmail.com"
            });

            DbHelper.db.Add(new Dish()
            {
                Id = 3,
                Title = "Beef Wellington",
                Calories = 300,
                Protein = 8,
                Carbs = 45,
                Fat = 7,
                Recipe = "Pour hot water over the oatmeal and let it brew for 5-10 minutes. Slice the banana and add to the oatmeal. Add the almonds and stir.",
                Ingredients = "Oatmeal,Banana,Apple,Almonds,Water",
                AccountEmail = "maks.salo@gmail.com"
            });
            DbHelper.db.Add(new Dish()
            {
                Id = 4,
                Title = "Shrimp Scampi",
                Calories = 300,
                Protein = 8,
                Carbs = 45,
                Fat = 7,
                Recipe = "Pour hot water over the oatmeal and let it brew for 5-10 minutes. Slice the banana and add to the oatmeal. Add the almonds and stir.",
                Ingredients = "Oatmeal,Banana,Apple,Almonds,Water",
                AccountEmail = "markian.kravets@gmail.com"
            });
            DbHelper.db.Add(new Dish()
            {
                Id = 5,
                Title = "Pad Thai",
                Calories = 300,
                Protein = 8,
                Carbs = 45,
                Fat = 7,
                Recipe = "Pour hot water over the oatmeal and let it brew for 5-10 minutes. Slice the banana and add to the oatmeal. Add the almonds and stir.",
                Ingredients = "Oatmeal,Banana,Apple,Almonds,Water",
                AccountEmail = "nazar.midyk@gmail.com"
            });
            DbHelper.db.Add(new Dish()
            {
                Id = 6,
                Title = "Paella Valenciana",
                Calories = 300,
                Protein = 8,
                Carbs = 45,
                Fat = 7,
                Recipe = "Pour hot water over the oatmeal and let it brew for 5-10 minutes. Slice the banana and add to the oatmeal. Add the almonds and stir.",
                Ingredients = "Oatmeal,Banana,Apple,Almonds,Water",
                AccountEmail = "nazar.valaga@gmail.com"
            });
            DbHelper.db.Add(new Dish()
            {
                Id = 7,
                Title = "Sushi Nigiri",
                Calories = 300,
                Protein = 8,
                Carbs = 45,
                Fat = 7,
                Recipe = "Pour hot water over the oatmeal and let it brew for 5-10 minutes. Slice the banana and add to the oatmeal. Add the almonds and stir.",
                Ingredients = "Oatmeal,Banana,Apple,Almonds,Water",
                AccountEmail = "oleh.chyzhov@gmail.com"
            });
            DbHelper.db.Add(new Dish()
            {
                Id = 8,
                Title = "Moussaka",
                Calories = 300,
                Protein = 8,
                Carbs = 45,
                Fat = 7,
                Recipe = "Pour hot water over the oatmeal and let it brew for 5-10 minutes. Slice the banana and add to the oatmeal. Add the almonds and stir.",
                Ingredients = "Oatmeal,Banana,Apple,Almonds,Water",
                AccountEmail = "oleh.diduch@gmail.com"
            });
            DbHelper.db.Add(new Dish()
            {
                Id = 9,
                Title = "Beef Bourguignon",
                Calories = 300,
                Protein = 8,
                Carbs = 45,
                Fat = 7,
                Recipe = "Pour hot water over the oatmeal and let it brew for 5-10 minutes. Slice the banana and add to the oatmeal. Add the almonds and stir.",
                Ingredients = "Oatmeal,Banana,Apple,Almonds,Water",
                AccountEmail = "oleh.kit@gmail.com"
            });
            DbHelper.db.Add(new Dish()
            {
                Id = 10,
                Title = "Tom Yum Soup",
                Calories = 300,
                Protein = 8,
                Carbs = 45,
                Fat = 7,
                Recipe = "Pour hot water over the oatmeal and let it brew for 5-10 minutes. Slice the banana and add to the oatmeal. Add the almonds and stir.",
                Ingredients = "Oatmeal,Banana,Apple,Almonds,Water",
                AccountEmail = "olena.kupchak@gmail.com"
            });
            DbHelper.db.Add(new Dish()
            {
                Id = 11,
                Title = "Fish Tacos",
                Calories = 300,
                Protein = 8,
                Carbs = 45,
                Fat = 7,
                Recipe = "Pour hot water over the oatmeal and let it brew for 5-10 minutes. Slice the banana and add to the oatmeal. Add the almonds and stir.",
                Ingredients = "Oatmeal,Banana,Apple,Almonds,Water",
                AccountEmail = "roman.shmyhelskiy@gmail.com"
            });
            DbHelper.db.Add(new Dish()
            {
                Id = 12,
                Title = "Chicken Alfredo",
                Calories = 300,
                Protein = 8,
                Carbs = 45,
                Fat = 7,
                Recipe = "Pour hot water over the oatmeal and let it brew for 5-10 minutes. Slice the banana and add to the oatmeal. Add the almonds and stir.",
                Ingredients = "Oatmeal,Banana,Apple,Almonds,Water",
                AccountEmail = "roman.torskiy@gmail.com"
            });
            DbHelper.db.Add(new Dish()
            {
                Id = 13,
                Title = "Szechuan Pork",
                Calories = 300,
                Protein = 8,
                Carbs = 45,
                Fat = 7,
                Recipe = "Pour hot water over the oatmeal and let it brew for 5-10 minutes. Slice the banana and add to the oatmeal. Add the almonds and stir.",
                Ingredients = "Oatmeal,Banana,Apple,Almonds,Water",
                AccountEmail = "valeriya.ponomariova@gmail.com"
            });
            DbHelper.db.Add(new Dish()
            {
                Id = 14,
                Title = "Tandoori Chicken",
                Calories = 300,
                Protein = 8,
                Carbs = 45,
                Fat = 7,
                Recipe = "Pour hot water over he oatmeal and let it brew for 5-10 minutes. Slice the banana and add to the oatmeal. Add the almonds and stir.",
                Ingredients = "Oatmeal,Banana,Apple,Almonds,Water",
                AccountEmail = "veronika.filippova@gmail.com"
            });
            DbHelper.db.Add(new Dish()
            {
                Id = 15,
                Title = "Lasagna Bolognese",
                Calories = 300,
                Protein = 8,
                Carbs = 45,
                Fat = 7,
                Recipe = "Pour hot water over the oatmeal and let it brew for 5-10 minutes. Slice the banana and add to the oatmeal. Add the almonds and stir.",
                Ingredients = "Oatmeal,Banana,Apple,Almonds,Water",
                AccountEmail = "yulia.tymochko@gmail.com"
            });
            DbHelper.db.Add(new Dish()
            {
                Id = 16,
                Title = "Fettuccine Pesto",
                Calories = 300,
                Protein = 8,
                Carbs = 45,
                Fat = 7,
                Recipe = "Pour hot water over the oatmeal and let it brew for 5-10 minutes. Slice the banana and apple and add to the oatmeal.Add the almonds and stir.",
                Ingredients = " Oatmeal,Banana,Apple,Almonds,Water",
                AccountEmail = "andriy.stefurak@gmail.com"
            });
            DbHelper.db.Add(new Dish()
            {
                Id = 17,
                Title = "Ratatouille",
                Calories = 250,
                Protein = 30,
                Carbs = 10,
                Fat = 12,
                Recipe = "Mix the canned tuna with lettuce, chopped cucumber and olive oil.",
                Ingredients = "Tuna,Lettuce leaves,Cucumber,Olive oil",
                AccountEmail = "anna.lukianchuk@gmail.com"
            });
            DbHelper.db.Add(new Dish()
            {
                Id = 18,
                Title = "Lamb Rogan Josh",
                Calories = 250,
                Protein = 18,
                Carbs = 5,
                Fat = 18,
                Recipe = "Beat the eggs. Add chopped cheese and vegetables. Fry in a pan until cooked. ",
                Ingredients = "Eggs,cheese,tomatoes,pepper,oil",
                AccountEmail = "anna.tkach@gmail.com"
            });
            DbHelper.db.Add(new Dish()
            {
                Id = 19,
                Title = "Falafel with Hummus",
                Calories = 200,
                Protein = 8,
                Carbs = 35,
                Fat = 4,
                Recipe = "Cook the buckwheat. Fry mushrooms with onions. Mix and serve.",
                Ingredients = "Buckwheat,mushrooms,onions,oil.",
                AccountEmail = "kristian.matiyishyn@gmail.com"
            });
            DbHelper.db.Add(new Dish()
            {
                Id = 20,
                Title = "Peking Duck",
                Calories = 220,
                Protein = 25,
                Carbs = 10,
                Fat = 7,
                Recipe = "Fry the chicken fillet. Add the chopped vegetables and simmer until fully cooked.",
                Ingredients = "Chicken fillet,carrots,peppers,broccoli,oil",
                AccountEmail = "maksym.kuzelyak@gmail.com"
            });
            DbHelper.db.Add(new Dish()
            {
                Id = 21,
                Title = "Goulash",
                Calories = 400,
                Protein = 15,
                Carbs = 70,
                Fat = 10,
                Recipe = "Cook the pasta. Prepare the tomato sauce. Mix and serve.",
                Ingredients = "Pasta,tomato sauce,basil,parmesan cheese",
                AccountEmail = "maksym.slipkevych@gmail.com"
            });
            DbHelper.db.Add(new Dish()
            {
                Id = 22,
                Title = "Eggplant Parmesan",
                Calories = 150,
                Protein = 5,
                Carbs = 30,
                Fat = 2,
                Recipe = "Blend banana, spinach and water in a blender. Add ice for freshness",
                Ingredients = "Banana,spinach,water,ice",
                AccountEmail = "misha.chekan@gmail.com"
            });
            DbHelper.db.Add(new Dish()
            {
                Id = 23,
                Title = "Jollof Rice",
                Calories = 280,
                Protein = 6,
                Carbs = 50,
                Fat = 6,
                Recipe = "Cook the rice.Fry the vegetables. Mix with rice and serve.",
                Ingredients = "Rice,carrots,peppers,onions,soy sauce",
                AccountEmail = "nastya.sashchack@gmail.com"
            });
            DbHelper.db.Add(new Dish()
            {
                Id = 24,
                Title = "Salad with salmon and avocado",
                Calories = 320,
                Protein = 20,
                Carbs = 12,
                Fat = 22,
                Recipe = "Mix chopped avocado, salmon and vegetables. Drizzle with lemon juice.",
                Ingredients = "Avocado,salmon,lettuce,cucumber,lemon juice",
                AccountEmail = "olesia.rudevych@gmail.com"
            });
            DbHelper.db.Add(new Dish()
            {
                Id = 25,
                Title = "Pilaf with chicken",
                Calories = 380,
                Protein = 18,
                Carbs = 50,
                Fat = 12,
                Recipe = "Fry the chicken with carrots and onions.Add rice and cook until tender",
                Ingredients = "Chicken,rice,carrots,onions,spices",
                AccountEmail = "pavlo.smahula@gmail.com"
            });
            DbHelper.db.Add(new Dish()
            {
                Id = 26,
                Title = "Greek Yogurt with Honey and Nuts",
                Calories = 220,
                Protein = 12,
                Carbs = 20,
                Fat = 9,
                Recipe = "Spoon Greek yogurt into a bowl. Drizzle honey over the top. Add chopped nuts and stir.",
                Ingredients = "Greek yogurt,honey,walnuts,almonds",
                AccountEmail = "tanya.mazyr@gmail.com"
            });
            DbHelper.db.Add(new Dish()
            {
                Id = 27,
                Title = "Egg and Avocado Toast",
                Calories = 250,
                Protein = 10,
                Carbs = 28,
                Fat = 12,
                Recipe = "Toast whole grain bread. Spread mashed avocado on top. Add a poached or fried egg.",
                Ingredients = "Whole grain bread,avocado,egg,olive oil",
                AccountEmail = "uliana.maydanska@gmail.com"
            });
            DbHelper.db.Add(new Dish()
            {
                Id = 28,
                Title = "Smoothie Bowl with Granola",
                Calories = 300,
                Protein = 10,
                Carbs = 50,
                Fat = 8,
                Recipe = "Blend frozen berries, banana, and yogurt. Top with granola and chia seeds.",
                Ingredients = "Frozen berries,banana,ogurt,granola,chia seeds",
                AccountEmail = "vika.mochevynska@gmail.com"
            });
            DbHelper.db.Add(new Dish()
            {
                Id = 29,
                Title = "Pesto Pasta",
                Calories = 400,
                Protein = 12,
                Carbs = 60,
                Fat = 14,
                Recipe = "Cook pasta.Toss with homemade or store-bought pesto sauce.Garnish with Parmesan cheese.",
                Ingredients = "Pasta,basil pesto,Parmesan cheese",
                AccountEmail = "yulia.bohatyr@gmail.com"
            });
            DbHelper.db.Add(new Dish()
            {
                Id = 30,
                Title = "Chia Pudding with Berries",
                Calories = 250,
                Protein = 8,
                Carbs = 30,
                Fat = 12,
                Recipe = "Mix chia seeds with milk and let sit overnight.Top with fresh berries and nuts.",
                Ingredients = "Chia seeds,milk,strawberries,blueberries,almonds",
                AccountEmail = "yulia.holub@gmail.com"
            });
            DbHelper.db.SaveChanges();
        }
        public static void FillMealTable()
        {
            DbHelper.db.Add(new Meal() { Id = 1, Title = "Breakfast ", FoodPlanId = 1 });
            DbHelper.db.Add(new Meal() { Id = 2, Title = "Lunch", FoodPlanId = 2 });
            DbHelper.db.Add(new Meal() { Id = 3, Title = "Lunch", FoodPlanId = 3 });
            DbHelper.db.Add(new Meal() { Id = 4, Title = "Lunch", FoodPlanId = 4 });
            DbHelper.db.Add(new Meal() { Id = 5, Title = "Breakfast ", FoodPlanId = 5 });
            DbHelper.db.Add(new Meal() { Id = 6, Title = "Lunch", FoodPlanId = 6 });
            DbHelper.db.Add(new Meal() { Id = 7, Title = "Supper", FoodPlanId = 7 });
            DbHelper.db.Add(new Meal() { Id = 8, Title = "Lunch", FoodPlanId = 8 });
            DbHelper.db.Add(new Meal() { Id = 9, Title = "Supper", FoodPlanId = 9 });
            DbHelper.db.Add(new Meal() { Id = 10, Title = "Breakfast ", FoodPlanId = 10 });
            DbHelper.db.Add(new Meal() { Id = 11, Title = "Lunch", FoodPlanId = 11 });
            DbHelper.db.Add(new Meal() { Id = 12, Title = "Lunch", FoodPlanId = 12 });
            DbHelper.db.Add(new Meal() { Id = 13, Title = "Supper", FoodPlanId = 13 });
            DbHelper.db.Add(new Meal() { Id = 14, Title = "Breakfast ", FoodPlanId = 14 });
            DbHelper.db.Add(new Meal() { Id = 15, Title = "Breakfast ", FoodPlanId = 15 });
            DbHelper.db.Add(new Meal() { Id = 16, Title = "Breakfast ", FoodPlanId = 16 });
            DbHelper.db.Add(new Meal() { Id = 17, Title = "Supper", FoodPlanId = 17 });
            DbHelper.db.Add(new Meal() { Id = 18, Title = "Breakfast ", FoodPlanId = 18 });
            DbHelper.db.Add(new Meal() { Id = 19, Title = "Supper", FoodPlanId = 19 });
            DbHelper.db.Add(new Meal() { Id = 20, Title = "Breakfast ", FoodPlanId = 20 });
            DbHelper.db.Add(new Meal() { Id = 21, Title = "Lunch", FoodPlanId = 21 });
            DbHelper.db.Add(new Meal() { Id = 22, Title = "Lunch", FoodPlanId = 22 });
            DbHelper.db.Add(new Meal() { Id = 23, Title = "Breakfast ", FoodPlanId = 23 });
            DbHelper.db.Add(new Meal() { Id = 24, Title = "Supper", FoodPlanId = 24 });
            DbHelper.db.Add(new Meal() { Id = 25, Title = "Breakfast ", FoodPlanId = 25 });
            DbHelper.db.Add(new Meal() { Id = 26, Title = "Supper", FoodPlanId = 26 });
            DbHelper.db.Add(new Meal() { Id = 27, Title = "Lunch", FoodPlanId = 27 });
            DbHelper.db.Add(new Meal() { Id = 28, Title = "Lunch", FoodPlanId = 28 });
            DbHelper.db.Add(new Meal() { Id = 29, Title = "Supper", FoodPlanId = 29 });
            DbHelper.db.Add(new Meal() { Id = 30, Title = "Lunch", FoodPlanId = 30 });
            DbHelper.db.SaveChanges();
        }
        public static void ConnectDishAndMeals()
        {
            for (int i = 1; i < Math.Min(DbHelper.db.Dishes.Count(), DbHelper.db.Meals.Count()); i++)
            {
                Meal mealFromDb = DbHelper.db.Meals.First(meal => meal.Id == i);
                Dish dishFromDb = DbHelper.db.Dishes.First(dish => dish.Id == i);
                DbHelper.db.DishMealConnectTable.Add(new DishMeal() { DishId = dishFromDb.Id, MealId = mealFromDb.Id });
            }
            DbHelper.db.SaveChanges();
        }
        public static void FillFoodPlanTable()
        {
            DbHelper.db.Add(new FoodPlan() { Id = 1, Title = "Nourish & Thrive", Calories = 300, Protein = 8, Carbs = 45, Fat = 7, AccountEmail = "anastasiya.seliverstova@gmail.com" });
            DbHelper.db.Add(new FoodPlan() { Id = 2, Title = "Balanced Bites", Calories = 300, Protein = 8, Carbs = 45, Fat = 7, AccountEmail = "lilya.voloshchuk@gmail.com" });
            DbHelper.db.Add(new FoodPlan() { Id = 3, Title = "Plate Perfection", Calories = 300, Protein = 8, Carbs = 45, Fat = 7, AccountEmail = "maks.salo@gmail.com" });
            DbHelper.db.Add(new FoodPlan() { Id = 4, Title = "Mindful Meals", Calories = 300, Protein = 8, Carbs = 45, Fat = 7, AccountEmail = "markian.kravets@gmail.com" });
            DbHelper.db.Add(new FoodPlan() { Id = 5, Title = "The Wellness Feast", Calories = 300, Protein = 8, Carbs = 45, Fat = 7, AccountEmail = "nazar.midyk@gmail.com" });
            DbHelper.db.Add(new FoodPlan() { Id = 6, Title = "Fuel for Life", Calories = 300, Protein = 8, Carbs = 45, Fat = 7, AccountEmail = "nazar.valaga@gmail.com" });
            DbHelper.db.Add(new FoodPlan() { Id = 7, Title = "Lean & Green", Calories = 300, Protein = 8, Carbs = 45, Fat = 7, AccountEmail = "oleh.chyzhov@gmail.com" });
            DbHelper.db.Add(new FoodPlan() { Id = 8, Title = "The Daily Dish", Calories = 300, Protein = 8, Carbs = 45, Fat = 7, AccountEmail = "oleh.diduch@gmail.com" });
            DbHelper.db.Add(new FoodPlan() { Id = 9, Title = "Savor & Sustain", Calories = 300, Protein = 8, Carbs = 45, Fat = 7, AccountEmail = "oleh.kit@gmail.com" });
            DbHelper.db.Add(new FoodPlan() { Id = 10, Title = "Healthy Habits Menu", Calories = 300, Protein = 8, Carbs = 45, Fat = 7, AccountEmail = "olena.kupchak@gmail.com" });
            DbHelper.db.Add(new FoodPlan() { Id = 11, Title = "FitFuel Meal Plan", Calories = 300, Protein = 8, Carbs = 45, Fat = 7, AccountEmail = "roman.shmyhelskiy@gmail.com" });
            DbHelper.db.Add(new FoodPlan() { Id = 12, Title = "Wholesome Eats", Calories = 300, Protein = 8, Carbs = 45, Fat = 7, AccountEmail = "roman.torskiy@gmail.com" });
            DbHelper.db.Add(new FoodPlan() { Id = 13, Title = "Meal Mastery", Calories = 300, Protein = 8, Carbs = 45, Fat = 7, AccountEmail = "valeriya.ponomariova@gmail.com" });
            DbHelper.db.Add(new FoodPlan() { Id = 14, Title = "Smart Bites", Calories = 300, Protein = 8, Carbs = 45, Fat = 7, AccountEmail = "veronika.filippova@gmail.com" });
            DbHelper.db.Add(new FoodPlan() { Id = 15, Title = "NutriPlan", Calories = 300, Protein = 8, Carbs = 45, Fat = 7, AccountEmail = "yulia.tymochko@gmail.com" });
            DbHelper.db.Add(new FoodPlan() { Id = 16, Title = "The Vital Plate", Calories = 300, Protein = 8, Carbs = 45, Fat = 7, AccountEmail = "andriy.stefurak@gmail.com" });
            DbHelper.db.Add(new FoodPlan() { Id = 17, Title = "Clean Plate Project", Calories = 300, Protein = 8, Carbs = 45, Fat = 7, AccountEmail = "anna.lukianchuk@gmail.com" });
            DbHelper.db.Add(new FoodPlan() { Id = 18, Title = "Simply Satisfied", Calories = 300, Protein = 8, Carbs = 45, Fat = 7, AccountEmail = "anna.tkach@gmail.com" });
            DbHelper.db.Add(new FoodPlan() { Id = 19, Title = "Energy Boost Eats", Calories = 300, Protein = 8, Carbs = 45, Fat = 7, AccountEmail = "kristian.matiyishyn@gmail.com" });
            DbHelper.db.Add(new FoodPlan() { Id = 20, Title = "LifeFuel Menu", Calories = 300, Protein = 8, Carbs = 45, Fat = 7, AccountEmail = "maksym.kuzelyak@gmail.com" });
            DbHelper.db.Add(new FoodPlan() { Id = 21, Title = "Fresh Start Food Plan", Calories = 300, Protein = 8, Carbs = 45, Fat = 7, AccountEmail = "maksym.slipkevych@gmail.com" });
            DbHelper.db.Add(new FoodPlan() { Id = 22, Title = "Purely Nourished", Calories = 300, Protein = 8, Carbs = 45, Fat = 7, AccountEmail = "misha.chekan@gmail.com" });
            DbHelper.db.Add(new FoodPlan() { Id = 23, Title = "Vibrant Eats", Calories = 300, Protein = 8, Carbs = 45, Fat = 7, AccountEmail = "nastya.sashchack@gmail.com" });
            DbHelper.db.Add(new FoodPlan() { Id = 24, Title = "Green Plate Special", Calories = 300, Protein = 8, Carbs = 45, Fat = 7, AccountEmail = "olesia.rudevych@gmail.com" });
            DbHelper.db.Add(new FoodPlan() { Id = 25, Title = "EatWell Program", Calories = 300, Protein = 8, Carbs = 45, Fat = 7, AccountEmail = "pavlo.smahula@gmail.com" });
            DbHelper.db.Add(new FoodPlan() { Id = 26, Title = "Happy & Healthy Plate", Calories = 300, Protein = 8, Carbs = 45, Fat = 7, AccountEmail = "tanya.mazyr@gmail.com" });
            DbHelper.db.Add(new FoodPlan() { Id = 27, Title = "Balanced Nutrition Blueprint", Calories = 300, Protein = 8, Carbs = 45, Fat = 7, AccountEmail = "uliana.maydanska@gmail.com" });
            DbHelper.db.Add(new FoodPlan() { Id = 28, Title = "The Essential Plate", Calories = 300, Protein = 8, Carbs = 45, Fat = 7, AccountEmail = "vika.mochevynska@gmail.com" });
            DbHelper.db.Add(new FoodPlan() { Id = 29, Title = "Simple Sustenance", Calories = 300, Protein = 8, Carbs = 45, Fat = 7, AccountEmail = "yulia.bohatyr@gmail.com" });
            DbHelper.db.Add(new FoodPlan() { Id = 30, Title = "Whole Body Fuel", Calories = 300, Protein = 8, Carbs = 45, Fat = 7, AccountEmail = "yulia.holub@gmail.com" });
            DbHelper.db.SaveChanges();
        }
        public static void FillStatisticEntityTable()
        {
            DbHelper.db.Add(new StatisticEntity() { Id = 1, Date = DateTime.Now, Weight = 56, AccountEmail = "anastasiya.seliverstova@gmail.com" });
            DbHelper.db.Add(new StatisticEntity() { Id = 2, Date = DateTime.Now, Weight = 59, AccountEmail = "lilya.voloshchuk@gmail.com" });
            DbHelper.db.Add(new StatisticEntity() { Id = 3, Date = DateTime.Now, Weight = 83, AccountEmail = "maks.salo@gmail.com" });
            DbHelper.db.Add(new StatisticEntity() { Id = 4, Date = DateTime.Now, Weight = 85, AccountEmail = "markian.kravets@gmail.com" });
            DbHelper.db.Add(new StatisticEntity() { Id = 5, Date = DateTime.Now, Weight = 72, AccountEmail = "nazar.midyk@gmail.com" });
            DbHelper.db.Add(new StatisticEntity() { Id = 6, Date = DateTime.Now, Weight = 75, AccountEmail = "nazar.valaga@gmail.com" });
            DbHelper.db.Add(new StatisticEntity() { Id = 7, Date = DateTime.Now, Weight = 89, AccountEmail = "oleh.chyzhov@gmail.com" });
            DbHelper.db.Add(new StatisticEntity() { Id = 8, Date = DateTime.Now, Weight = 85, AccountEmail = "oleh.diduch@gmail.com" });
            DbHelper.db.Add(new StatisticEntity() { Id = 9, Date = DateTime.Now, Weight = 65, AccountEmail = "oleh.kit@gmail.com" });
            DbHelper.db.Add(new StatisticEntity() { Id = 10, Date = DateTime.Now, Weight = 65, AccountEmail = "olena.kupchak@gmail.com" });
            DbHelper.db.Add(new StatisticEntity() { Id = 11, Date = DateTime.Now, Weight = 78, AccountEmail = "roman.shmyhelskiy@gmail.com" });
            DbHelper.db.Add(new StatisticEntity() { Id = 12, Date = DateTime.Now, Weight = 96, AccountEmail = "roman.torskiy@gmail.com" });
            DbHelper.db.Add(new StatisticEntity() { Id = 13, Date = DateTime.Now, Weight = 65, AccountEmail = "valeriya.ponomariova@gmail.com" });
            DbHelper.db.Add(new StatisticEntity() { Id = 14, Date = DateTime.Now, Weight = 63, AccountEmail = "veronika.filippova@gmail.com" });
            DbHelper.db.Add(new StatisticEntity() { Id = 15, Date = DateTime.Now, Weight = 62, AccountEmail = "yulia.tymochko@gmail.com" });
            DbHelper.db.Add(new StatisticEntity() { Id = 16, Date = DateTime.Now, Weight = 60, AccountEmail = "andriy.stefurak@gmail.com" });
            DbHelper.db.Add(new StatisticEntity() { Id = 17, Date = DateTime.Now, Weight = 70, AccountEmail = "anna.lukianchuk@gmail.com" });
            DbHelper.db.Add(new StatisticEntity() { Id = 18, Date = DateTime.Now, Weight = 60, AccountEmail = "anna.tkach@gmail.com" });
            DbHelper.db.Add(new StatisticEntity() { Id = 19, Date = DateTime.Now, Weight = 65, AccountEmail = "kristian.matiyishyn@gmail.com" });
            DbHelper.db.Add(new StatisticEntity() { Id = 20, Date = DateTime.Now, Weight = 57, AccountEmail = "maksym.kuzelyak@gmail.com" });
            DbHelper.db.Add(new StatisticEntity() { Id = 21, Date = DateTime.Now, Weight = 68, AccountEmail = "maksym.slipkevych@gmail.com" });
            DbHelper.db.Add(new StatisticEntity() { Id = 22, Date = DateTime.Now, Weight = 70, AccountEmail = "misha.chekan@gmail.com" });
            DbHelper.db.Add(new StatisticEntity() { Id = 23, Date = DateTime.Now, Weight = 67, AccountEmail = "nastya.sashchack@gmail.com" });
            DbHelper.db.Add(new StatisticEntity() { Id = 24, Date = DateTime.Now, Weight = 55, AccountEmail = "olesia.rudevych@gmail.com" });
            DbHelper.db.Add(new StatisticEntity() { Id = 25, Date = DateTime.Now, Weight = 69, AccountEmail = "pavlo.smahula@gmail.com" });
            DbHelper.db.Add(new StatisticEntity() { Id = 26, Date = DateTime.Now, Weight = 68, AccountEmail = "tanya.mazyr@gmail.com" });
            DbHelper.db.Add(new StatisticEntity() { Id = 27, Date = DateTime.Now, Weight = 61, AccountEmail = "uliana.maydanska@gmail.com" });
            DbHelper.db.Add(new StatisticEntity() { Id = 28, Date = DateTime.Now, Weight = 66, AccountEmail = "vika.mochevynska@gmail.com" });
            DbHelper.db.Add(new StatisticEntity() { Id = 29, Date = DateTime.Now, Weight = 56, AccountEmail = "yulia.bohatyr@gmail.com" });
            DbHelper.db.Add(new StatisticEntity() { Id = 30, Date = DateTime.Now, Weight = 52, AccountEmail = "yulia.holub@gmail.com" });
            DbHelper.db.SaveChanges();
        }
    }
}
