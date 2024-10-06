using DataAccess;
using DataAccess.Models;
class Program
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
        DbHelper.db.SaveChanges();
    }
    public static void Main(string[] args)
    {
        //FillAccountsTable();
        foreach (var item in DbHelper.db.Accounts)
        {
            Console.WriteLine(item);
        }
    }
}