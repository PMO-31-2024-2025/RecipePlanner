using DataAccess;
using DataAccess.Models;
class Program
{
    public static void Main(string[] args)
    {
        Account accFromDb = DbHelper.db.Accounts.Where(acc => acc.Email == "oleh.chyzhov@gmail.com").First();
        Console.WriteLine(accFromDb);
        Console.WriteLine(accFromDb);
    }
}