using DataAccess;
using DataAccess.Models;
class Program
{

    public static void FillAccountsTable()
    {
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
        DbHelper.db.Add(new AccountInfo() { Id = 1, Sex = "female", Age = 19, Weight = 69, Height = 163, DesiredWeight = 56, Goal = "lose weight", DailyCalories = 1522, AccountEmail = "anastasiya.seliverstova@gmail.com"});
        DbHelper.db.Add(new AccountInfo() { Id = 2, Sex = "female", Age = 19, Weight = 49, Height = 157, DesiredWeight = 59, Goal = "gain weight", DailyCalories = 1319, AccountEmail = "lilya.voloshchuk@gmail.com" });
        DbHelper.db.Add(new AccountInfo() { Id = 3, Sex = "male", Age = 19, Weight = 69, Height = 183, DesiredWeight = 83, Goal = "gain weight", DailyCalories = 1797, AccountEmail = "maks.salo@gmail.com" });
        DbHelper.db.Add(new AccountInfo() { Id = 4, Sex = "male", Age = 19, Weight = 72, Height = 177, DesiredWeight = 85, Goal = "gain weight", DailyCalories = 1724, AccountEmail = "markian.kravets@gmail.com" });
        DbHelper.db.Add(new AccountInfo() { Id = 5, Sex = "male", Age = 19, Weight = 89, Height = 173, DesiredWeight = 72, Goal = "lose weight", DailyCalories = 1927, AccountEmail = "nazar.midyk@gmail.com" });
        DbHelper.db.Add(new AccountInfo() { Id = 6, Sex = "male", Age = 19, Weight = 62, Height = 182, DesiredWeight = 75, Goal = "gain weight", DailyCalories = 1574, AccountEmail = "nazar.valaga@gmail.com" });
        DbHelper.db.Add(new AccountInfo() { Id = 7, Sex = "male", Age = 19, Weight = 75, Height = 178, DesiredWeight = 89, Goal = "gain weight", DailyCalories = 1711, AccountEmail = "oleh.chyzhov@gmail.com" });
        DbHelper.db.Add(new AccountInfo() { Id = 8, Sex = "male", Age = 19, Weight = 72, Height = 177, DesiredWeight = 85, Goal = "gain weight", DailyCalories = 1687, AccountEmail = "oleh.diduch@gmail.com" });
        DbHelper.db.Add(new AccountInfo() { Id = 9, Sex = "male", Age = 19, Weight = 75, Height = 173, DesiredWeight = 65, Goal = "gain weight", DailyCalories = 1681, AccountEmail = "oleh.kit@gmail.com" });
        DbHelper.db.Add(new AccountInfo() { Id = 10, Sex = "female", Age = 19, Weight = 73, Height = 167, DesiredWeight = 65, Goal = "lose weight", DailyCalories = 1683, AccountEmail = "olena.kupchak@gmail.com" });
        DbHelper.db.Add(new AccountInfo() { Id = 11, Sex = "male", Age = 19, Weight = 69, Height = 183, DesiredWeight = 78, Goal = "gain weight", DailyCalories = 1743, AccountEmail = "roman.shmyhelskiy@gmail.com" });
        DbHelper.db.Add(new AccountInfo() { Id = 12, Sex = "male", Age = 19, Weight = 76, Height = 185, DesiredWeight = 96, Goal = "gain weight", DailyCalories = 1791, AccountEmail = "roman.torskiy@gmail.com" });
        DbHelper.db.Add(new AccountInfo() { Id = 13, Sex = "female", Age = 19, Weight = 75, Height = 176, DesiredWeight = 65, Goal = "lose weight", DailyCalories = 1475, AccountEmail = "valeriya.ponomariova@gmail.com" });
        DbHelper.db.Add(new AccountInfo() { Id = 14, Sex = "female", Age = 19, Weight = 53, Height = 177, DesiredWeight = 63, Goal = "gain weight", DailyCalories = 1333, AccountEmail = "veronika.filippova@gmail.com" });
        DbHelper.db.Add(new AccountInfo() { Id = 15, Sex = "female", Age = 19, Weight = 72, Height = 166, DesiredWeight = 62, Goal = "lose weight", DailyCalories = 1440, AccountEmail = "yulia.tymochko@gmail.com" });
        DbHelper.db.SaveChanges();
    }

    public static void Main(string[] args)
    {
        //FillAccountsTable();
        foreach (var item in DbHelper.db.Accounts)
        {
            Console.WriteLine(item);
        }
        //FillAccountsInfoTable();
        foreach(var item in DbHelper.db.AccountInformations)
        {
            Console.WriteLine(item);
        }
    }
}