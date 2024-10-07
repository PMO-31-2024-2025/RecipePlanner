using DataAccess;
using DataAccess.Models;
class Program
{

    //public static void FillAccountsTable()
    //{
    //DbHelper.db.Add(new Account() { Email = "oleh.chyzhov@gmail.com", Password = "Oleg2005" });
    //DbHelper.db.Add(new Account() { Email = "nazar.valaga@gmail.com", Password = "12345" });
    //DbHelper.db.Add(new Account() { Email = "yulia.tymochko@gmail.com", Password = "54321" });
    //DbHelper.db.Add(new Account() { Email = "roman.torskiy@gmail.com", Password = "46532" });
    //DbHelper.db.Add(new Account() { Email = "roman.shmyhelskiy@gmail.com", Password = "13562" });
    //DbHelper.db.Add(new Account() { Email = "anastasiya.seliverstova@gmail.com", Password = "46532" });
    //DbHelper.db.Add(new Account() { Email = "valeriya.ponomariova@gmail.com", Password = "53241" });
    //DbHelper.db.Add(new Account() { Email = "olena.kupchak@gmail.com", Password = "52413" });
    //DbHelper.db.Add(new Account() { Email = "veronika.filippova@gmail.com", Password = "46513" });
    //DbHelper.db.Add(new Account() { Email = "lilya.voloshchuk@gmail.com", Password = "13524" });
    //DbHelper.db.Add(new Account() { Email = "oleh.diduch@gmail.com", Password = "63425" });
    //DbHelper.db.Add(new Account() { Email = "markian.kravets@gmail.com", Password = "13546" });
    //DbHelper.db.Add(new Account() { Email = "oleh.kit@gmail.com", Password = "24531" });
    //DbHelper.db.Add(new Account() { Email = "nazar.midyk@gmail.com", Password = "11111" });
    //DbHelper.db.Add(new Account() { Email = "maks.salo@gmail.com", Password = "55555" });
    //DbHelper.db.Add(new Account() { Email = "olesia.rudevych@gmail.com", Password = "olesia111" });
    //DbHelper.db.Add(new Account() { Email = "pavlo.smahula@gmail.com", Password = "psmhl01" });
    //DbHelper.db.Add(new Account() { Email = "yulia.holub@gmail.com", Password = "yuliah22" });
    //DbHelper.db.Add(new Account() { Email = "maksym.slipkevych@gmail.com", Password = "maks02" });
    //DbHelper.db.Add(new Account() { Email = "andriy.stefurak@gmail.com", Password = "stefchuk333" });
    //DbHelper.db.Add(new Account() { Email = "maksym.kuzelyak@gmail.com", Password = "maksik03" });
    //DbHelper.db.Add(new Account() { Email = "nastya.sashchack@gmail.com", Password = "nastya444" });
    //DbHelper.db.Add(new Account() { Email = "vika.mochevynska@gmail.com", Password = "vikim04" });
    //DbHelper.db.Add(new Account() { Email = "anna.lukianchuk@gmail.com", Password = "annaluk555" });
    //DbHelper.db.Add(new Account() { Email = "anna.tkach@gmail.com", Password = "anyuta05" });
    //DbHelper.db.Add(new Account() { Email = "uliana.maydanska@gmail.com", Password = "umdnsk666" });
    //DbHelper.db.Add(new Account() { Email = "kristian.matiyishyn@gmail.com", Password = "krism06" });
    //DbHelper.db.Add(new Account() { Email = "misha.chekan@gmail.com", Password = "miha777" });
    //DbHelper.db.Add(new Account() { Email = "yulia.bohatyr@gmail.com", Password = "yuli07" });
    //DbHelper.db.Add(new Account() { Email = "tanya.mazyr@gmail.com", Password = "tanya888" });
    //DbHelper.db.SaveChanges();
    //}

    //public static void FillAccountsInfoTable()
    //{
    //    DbHelper.db.Add(new AccountInfo() { Id = 1, Sex = "female", Age = 19, Weight = 69, Height = 163, DesiredWeight = 56, Goal = "lose weight", DailyCalories = 1522, AccountEmail = "anastasiya.seliverstova@gmail.com"});
    //    DbHelper.db.Add(new AccountInfo() { Id = 2, Sex = "female", Age = 19, Weight = 49, Height = 157, DesiredWeight = 59, Goal = "gain weight", DailyCalories = 1319, AccountEmail = "lilya.voloshchuk@gmail.com" });
    //    DbHelper.db.Add(new AccountInfo() { Id = 3, Sex = "male", Age = 19, Weight = 69, Height = 183, DesiredWeight = 83, Goal = "gain weight", DailyCalories = 1797, AccountEmail = "maks.salo@gmail.com" });
    //    DbHelper.db.Add(new AccountInfo() { Id = 4, Sex = "male", Age = 19, Weight = 72, Height = 177, DesiredWeight = 85, Goal = "gain weight", DailyCalories = 1724, AccountEmail = "markian.kravets@gmail.com" });
    //    DbHelper.db.Add(new AccountInfo() { Id = 5, Sex = "male", Age = 19, Weight = 89, Height = 173, DesiredWeight = 72, Goal = "lose weight", DailyCalories = 1927, AccountEmail = "nazar.midyk@gmail.com" });
    //    DbHelper.db.Add(new AccountInfo() { Id = 6, Sex = "male", Age = 19, Weight = 62, Height = 182, DesiredWeight = 75, Goal = "gain weight", DailyCalories = 1574, AccountEmail = "nazar.valaga@gmail.com" });
    //    DbHelper.db.Add(new AccountInfo() { Id = 7, Sex = "male", Age = 19, Weight = 75, Height = 178, DesiredWeight = 89, Goal = "gain weight", DailyCalories = 1711, AccountEmail = "oleh.chyzhov@gmail.com" });
    //    DbHelper.db.Add(new AccountInfo() { Id = 8, Sex = "male", Age = 19, Weight = 72, Height = 177, DesiredWeight = 85, Goal = "gain weight", DailyCalories = 1687, AccountEmail = "oleh.diduch@gmail.com" });
    //    DbHelper.db.Add(new AccountInfo() { Id = 9, Sex = "male", Age = 19, Weight = 75, Height = 173, DesiredWeight = 65, Goal = "gain weight", DailyCalories = 1681, AccountEmail = "oleh.kit@gmail.com" });
    //    DbHelper.db.Add(new AccountInfo() { Id = 10, Sex = "female", Age = 19, Weight = 73, Height = 167, DesiredWeight = 65, Goal = "lose weight", DailyCalories = 1683, AccountEmail = "olena.kupchak@gmail.com" });
    //    DbHelper.db.Add(new AccountInfo() { Id = 11, Sex = "male", Age = 19, Weight = 69, Height = 183, DesiredWeight = 78, Goal = "gain weight", DailyCalories = 1743, AccountEmail = "roman.shmyhelskiy@gmail.com" });
    //    DbHelper.db.Add(new AccountInfo() { Id = 12, Sex = "male", Age = 19, Weight = 76, Height = 185, DesiredWeight = 96, Goal = "gain weight", DailyCalories = 1791, AccountEmail = "roman.torskiy@gmail.com" });
    //    DbHelper.db.Add(new AccountInfo() { Id = 13, Sex = "female", Age = 19, Weight = 75, Height = 176, DesiredWeight = 65, Goal = "lose weight", DailyCalories = 1475, AccountEmail = "valeriya.ponomariova@gmail.com" });
    //    DbHelper.db.Add(new AccountInfo() { Id = 14, Sex = "female", Age = 19, Weight = 53, Height = 177, DesiredWeight = 63, Goal = "gain weight", DailyCalories = 1333, AccountEmail = "veronika.filippova@gmail.com" });
    //    DbHelper.db.Add(new AccountInfo() { Id = 15, Sex = "female", Age = 19, Weight = 72, Height = 166, DesiredWeight = 62, Goal = "lose weight", DailyCalories = 1440, AccountEmail = "yulia.tymochko@gmail.com" });

    //    DbHelper.db.Add(new AccountInfo() { Id = 16, Sex = "male", Age = 19, Weight = 55, Height = 158, DesiredWeight = 60, Goal = "gain weight", DailyCalories = 1448, AccountEmail = "andriy.stefurak@gmail.com" });
    //    DbHelper.db.Add(new AccountInfo() { Id = 17, Sex = "female", Age = 19, Weight = 65, Height = 175, DesiredWeight = 70, Goal = "gain weight", DailyCalories = 1488, AccountEmail = "anna.lukianchuk@gmail.com" });
    //    DbHelper.db.Add(new AccountInfo() { Id = 18, Sex = "female", Age = 20, Weight = 67, Height = 170, DesiredWeight = 60, Goal = "lose weight", DailyCalories = 1476, AccountEmail = "anna.tkach@gmail.com" });
    //    DbHelper.db.Add(new AccountInfo() { Id = 19, Sex = "male", Age = 20, Weight = 50, Height = 180, DesiredWeight = 65, Goal = "gain weight", DailyCalories = 1680, AccountEmail = "kristian.matiyishyn@gmail.com" });
    //    DbHelper.db.Add(new AccountInfo() { Id = 20, Sex = "male", Age = 19, Weight = 57, Height = 165, DesiredWeight = 57, Goal = "maintain weight", DailyCalories = 1520, AccountEmail = "maksym.kuzelyak@gmail.com" });
    //    DbHelper.db.Add(new AccountInfo() { Id = 21, Sex = "male", Age = 20, Weight = 59, Height = 173, DesiredWeight = 68, Goal = "gain weight", DailyCalories = 1570, AccountEmail = "maksym.slipkevych@gmail.com" });
    //    DbHelper.db.Add(new AccountInfo() { Id = 22, Sex = "male", Age = 19, Weight = 79, Height = 172, DesiredWeight = 70, Goal = "lose weight", DailyCalories = 1600, AccountEmail = "misha.chekan@gmail.com" });
    //    DbHelper.db.Add(new AccountInfo() { Id = 23, Sex = "female", Age = 20, Weight = 67, Height = 176, DesiredWeight = 67, Goal = "maintain weight", DailyCalories = 1450, AccountEmail = "nastya.sashchack@gmail.com" });
    //    DbHelper.db.Add(new AccountInfo() { Id = 24, Sex = "female", Age = 20, Weight = 50, Height = 155, DesiredWeight = 55, Goal = "gain weight", DailyCalories = 1430, AccountEmail = "olesia.rudevych@gmail.com" });
    //    DbHelper.db.Add(new AccountInfo() { Id = 25, Sex = "male", Age = 19, Weight = 69, Height = 171, DesiredWeight = 69, Goal = "maintain weight", DailyCalories = 1670, AccountEmail = "pavlo.smahula@gmail.com" });
    //    DbHelper.db.Add(new AccountInfo() { Id = 26, Sex = "female", Age = 20, Weight = 62, Height = 178, DesiredWeight = 68, Goal = "gain weight", DailyCalories = 1620, AccountEmail = "tanya.mazyr@gmail.com" });
    //    DbHelper.db.Add(new AccountInfo() { Id = 27, Sex = "female", Age = 19, Weight = 54, Height = 161, DesiredWeight = 61, Goal = "gain weight", DailyCalories = 1320, AccountEmail = "uliana.maydanska@gmail.com" });
    //    DbHelper.db.Add(new AccountInfo() { Id = 28, Sex = "female", Age = 20, Weight = 52, Height = 163, DesiredWeight = 66, Goal = "gain weight", DailyCalories = 1440, AccountEmail = "vika.mochevynska@gmail.com" });
    //    DbHelper.db.Add(new AccountInfo() { Id = 29, Sex = "female", Age = 19, Weight = 62, Height = 174, DesiredWeight = 56, Goal = "lose weight", DailyCalories = 1310, AccountEmail = "yulia.bohatyr@gmail.com" });
    //    DbHelper.db.Add(new AccountInfo() { Id = 30, Sex = "female", Age = 20, Weight = 52, Height = 163, DesiredWeight = 52, Goal = "maintain weight", DailyCalories = 1280, AccountEmail = "yulia.holub@gmail.com" });
    //    DbHelper.db.SaveChanges();
    //}

    public static void FillDishTable()
    {
        DbHelper.db.Add(new Dish()
        {
            Id = 16,
            Title = "Oatmeal with fruits",
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
            Title = "Salad with tuna",
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
            Title = "Omelet with cheese and vegetables",
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
            Title = "Buckwheat with mushrooms",
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
            Title = "Chicken with vegetables",
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
            Title = "Pasta with tomato sauce",
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
            Title = "Smoothie with banana and spinach",
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
            Title = "Rice with vegetables",
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







    }


    public static void Main(string[] args)
    {
        //FillAccountsTable();
        Console.WriteLine("Table accounts" + "\n");
        foreach (var item in DbHelper.db.Accounts)
        {
            Console.WriteLine(item + "\n");
        }

        //FillAccountsInfoTable();
        Console.WriteLine("\n" + "Table account_informations" + "\n");
        foreach (var item in DbHelper.db.AccountInformations)
        {
            Console.WriteLine(item + "\n");
        }

    }
}