using DataAccess;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Managers
{
    public static class AuthorisationManager
    {
        public static bool Registered(string email)
        {
            Account? accFromDb = DbHelper.db.Accounts.FirstOrDefault(account => account.Email == email);
            if (accFromDb != null) 
            {
                return true;
            } 
            else
            {
                return false;
            }
        }

        public static Account GetAccountByEmail(string email)
        {
            if (Registered(email))
            {
                return DbHelper.db.Accounts.First(account => account.Email == email);
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        public static void Register(string email, string password)
        {
            DbHelper.db.Accounts.Add(new Account() { Email = email, Password = password });
            DbHelper.db.SaveChanges();
        }
    }
}
