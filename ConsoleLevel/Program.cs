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
       DbHelper.db.Add(new Dish() { Id = 1, Title = "Oatmeal with fruits", Calories = 300, Protein = 8, Carbs = 45, Fat = 7,
       Recipe = "Pour hot water over the oatmeal and let it brew for 5-10 minutes. Slice the banana and add to the oatmeal. Add the almonds and stir.",
           Ingredients = "Oatmeal,Banana,Apple,Almonds,Water",
           AccountEmail = "anastasiya.seliverstova@gmail.com" });
        DbHelper.db.Add(new Dish()
        {
            Id = 2,
            Title = "Oatmeal with fruits",
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
            Title = "Oatmeal with fruits",
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
            Title = "Oatmeal with fruits",
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
            Title = "Oatmeal with fruits",
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
            Title = "Oatmeal with fruits",
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
            Title = "Oatmeal with fruits",
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
            Title = "Oatmeal with fruits",
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
            Title = "Oatmeal with fruits",
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
            Title = "Oatmeal with fruits",
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
            Title = "Oatmeal with fruits",
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
            Title = "Oatmeal with fruits",
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
            Title = "Oatmeal with fruits",
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
            Title = "Oatmeal with fruits",
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
            Title = "Oatmeal with fruits",
            Calories = 300,
            Protein = 8,
            Carbs = 45,
            Fat = 7,
            Recipe = "Pour hot water over the oatmeal and let it brew for 5-10 minutes. Slice the banana and add to the oatmeal. Add the almonds and stir.",
            Ingredients = "Oatmeal,Banana,Apple,Almonds,Water",
            AccountEmail = "yulia.tymochko@gmail.com"
        });
        DbHelper.db.SaveChanges();
    }

    public static void FillFoodPlanTable()
    {
        DbHelper.db.Add(new FoodPlan() { Id = 1, Title = "Name of the plan", Calories = 300, Protein = 8, Carbs = 45, Fat = 7, AccountEmail = "anastasiya.seliverstova@gmail.com"});
        DbHelper.db.Add(new FoodPlan() { Id = 2, Title = "Name of the plan", Calories = 300, Protein = 8, Carbs = 45, Fat = 7, AccountEmail = "lilya.voloshchuk@gmail.com" });
        DbHelper.db.Add(new FoodPlan() { Id = 3, Title = "Name of the plan", Calories = 300, Protein = 8, Carbs = 45, Fat = 7, AccountEmail = "maks.salo@gmail.com" });
        DbHelper.db.Add(new FoodPlan() { Id = 4, Title = "Name of the plan", Calories = 300, Protein = 8, Carbs = 45, Fat = 7, AccountEmail = "markian.kravets@gmail.com" });
        DbHelper.db.Add(new FoodPlan() { Id = 5, Title = "Name of the plan", Calories = 300, Protein = 8, Carbs = 45, Fat = 7, AccountEmail = "nazar.midyk@gmail.com" });
        DbHelper.db.Add(new FoodPlan() { Id = 6, Title = "Name of the plan", Calories = 300, Protein = 8, Carbs = 45, Fat = 7, AccountEmail = "nazar.valaga@gmail.com" });
        DbHelper.db.Add(new FoodPlan() { Id = 7, Title = "Name of the plan", Calories = 300, Protein = 8, Carbs = 45, Fat = 7, AccountEmail = "oleh.chyzhov@gmail.com" });
        DbHelper.db.Add(new FoodPlan() { Id = 8, Title = "Name of the plan", Calories = 300, Protein = 8, Carbs = 45, Fat = 7, AccountEmail = "oleh.diduch@gmail.com" });
        DbHelper.db.Add(new FoodPlan() { Id = 9, Title = "Name of the plan", Calories = 300, Protein = 8, Carbs = 45, Fat = 7, AccountEmail = "oleh.kit@gmail.com" });
        DbHelper.db.Add(new FoodPlan() { Id = 10, Title = "Name of the plan", Calories = 300, Protein = 8, Carbs = 45, Fat = 7, AccountEmail = "olena.kupchak@gmail.com" });
        DbHelper.db.Add(new FoodPlan() { Id = 11, Title = "Name of the plan", Calories = 300, Protein = 8, Carbs = 45, Fat = 7, AccountEmail = "roman.shmyhelskiy@gmail.com" });
        DbHelper.db.Add(new FoodPlan() { Id = 12, Title = "Name of the plan", Calories = 300, Protein = 8, Carbs = 45, Fat = 7, AccountEmail = "roman.torskiy@gmail.com" });
        DbHelper.db.Add(new FoodPlan() { Id = 13, Title = "Name of the plan", Calories = 300, Protein = 8, Carbs = 45, Fat = 7, AccountEmail = "valeriya.ponomariova@gmail.com" });
        DbHelper.db.Add(new FoodPlan() { Id = 14, Title = "Name of the plan", Calories = 300, Protein = 8, Carbs = 45, Fat = 7, AccountEmail = "veronika.filippova@gmail.com" });
        DbHelper.db.Add(new FoodPlan() { Id = 15, Title = "Name of the plan", Calories = 300, Protein = 8, Carbs = 45, Fat = 7, AccountEmail = "yulia.tymochko@gmail.com" });
    }

    public static void FillMealTable()
    {
        DbHelper.db.Add(new Meal() { Id = 1, Title = "Name of Meal", Calories = 500, Protein = 20, Carbs = 35, Fat = 10, FoodPlanId = 1});
        DbHelper.db.Add(new Meal() { Id = 2, Title = "Name of Meal", Calories = 690, Protein = 30, Carbs = 25, Fat = 5, FoodPlanId = 1 });
        DbHelper.db.Add(new Meal() { Id = 3, Title = "Name of Meal", Calories = 800, Protein = 10, Carbs = 35, Fat = 10, FoodPlanId = 1 });
        DbHelper.db.Add(new Meal() { Id = 4, Title = "Name of Meal", Calories = 500, Protein = 20, Carbs = 35, Fat = 10, FoodPlanId = 1 });
        DbHelper.db.Add(new Meal() { Id = 5, Title = "Name of Meal", Calories = 760, Protein = 20, Carbs = 35, Fat = 10, FoodPlanId = 1 });
        DbHelper.db.Add(new Meal() { Id = 6, Title = "Name of Meal", Calories = 500, Protein = 20, Carbs = 35, Fat = 10, FoodPlanId = 1 });
        DbHelper.db.Add(new Meal() { Id = 7, Title = "Name of Meal", Calories = 400, Protein = 20, Carbs = 35, Fat = 10, FoodPlanId = 1 });
        DbHelper.db.Add(new Meal() { Id = 8, Title = "Name of Meal", Calories = 200, Protein = 10, Carbs = 35, Fat = 10, FoodPlanId = 1 });
        DbHelper.db.Add(new Meal() { Id = 9, Title = "Name of Meal", Calories = 640, Protein = 15, Carbs = 35, Fat = 10, FoodPlanId = 1 });
        DbHelper.db.Add(new Meal() { Id = 10, Title = "Name of Meal", Calories = 530, Protein = 30, Carbs = 35, Fat = 10, FoodPlanId = 1 });
        DbHelper.db.Add(new Meal() { Id = 11, Title = "Name of Meal", Calories = 580, Protein = 40, Carbs = 35, Fat = 10, FoodPlanId = 1 });
        DbHelper.db.Add(new Meal() { Id = 12, Title = "Name of Meal", Calories = 350, Protein = 20, Carbs = 5, Fat = 11, FoodPlanId = 1 });
        DbHelper.db.Add(new Meal() { Id = 13, Title = "Name of Meal", Calories = 700, Protein = 20, Carbs = 35, Fat = 10, FoodPlanId = 1 });
        DbHelper.db.Add(new Meal() { Id = 14, Title = "Name of Meal", Calories = 430, Protein = 20, Carbs = 35, Fat = 10, FoodPlanId = 1 });
        DbHelper.db.Add(new Meal() { Id = 15, Title = "Name of Meal", Calories = 250, Protein = 20, Carbs = 35, Fat = 10, FoodPlanId = 1 });
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
        DbHelper.db.Add(new StatisticEntity() { Id = 12, Date = DateTime.Now, Weight = 96, AccountEmail = "roman.torskiy-@gmail.com" });
        DbHelper.db.Add(new StatisticEntity() { Id = 13, Date = DateTime.Now, Weight = 65, AccountEmail = "valeriya.ponomariova@gmail.com" });
        DbHelper.db.Add(new StatisticEntity() { Id = 14, Date = DateTime.Now, Weight = 63, AccountEmail = "veronika.filippova@gmail.com" });
        DbHelper.db.Add(new StatisticEntity() { Id = 15, Date = DateTime.Now, Weight = 62, AccountEmail = "yulia.tymochko@gmail.com" });
        DbHelper.db.SaveChanges();
    }

    public static void Main(string[] args)
    {
        //FillAccountsTable();
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
        //FillDishTable
        Console.WriteLine("\n" + "Table Dish:" + "\n");
        foreach(var item in DbHelper.db.Dishes)
        {
            Console.WriteLine(item + "\n");
        }
        //FillFoodPlanTable
        Console.WriteLine("\n" + "Table FoodPlan" + "\n");
        foreach(var item in DbHelper.db.FoodPlans)
        {
            Console.WriteLine(item + "\n");
        }
        //FillMealTable
        Console.WriteLine("\n" + "Table Meal" + "\n");
        foreach(var item in DbHelper.db.Meals)
        {
            Console.WriteLine(item + "\n");
        }
    }
}