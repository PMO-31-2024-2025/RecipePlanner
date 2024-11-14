// <copyright file="LoginTests.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace UnitTests
{
    using BusinessLogic;
    using DataAccess;
    using DataAccess.Models;
    using UserInterface.MVVM;

    [TestClass]
    public class LoginTests
    {
        [TestMethod]
        public void LoginTest()
        {
            LoginViewModel vm = new LoginViewModel();
            vm.Email = "oleh.chyzhov@gmail.com";
            vm.Password = "Oleg2005";
            vm.ExecuteLoginCommand();
            Assert.AreEqual(AccountManager.LoginedAccount.Email, "oleh.chyzhov@gmail.com");
        }

        [TestMethod]
        public void RegisterTest()
        {
            LoginViewModel vm = new LoginViewModel();
            vm.Email = "testUser@gmail.com";
            vm.Password = "12345";
            vm.ExecuteRegisterCommand();
            AccountManager.UpdateLoginedAccount("testUser@gmail.com");
            Assert.AreEqual("testUser@gmail.com", AccountManager.LoginedAccount.Email);

            Account account = DbHelper.db.Accounts.First(acc => acc.Email == "testUser@gmail.com");
            DbHelper.db.Accounts.Remove(account);
            DbHelper.db.SaveChanges();
        }
    }
}
