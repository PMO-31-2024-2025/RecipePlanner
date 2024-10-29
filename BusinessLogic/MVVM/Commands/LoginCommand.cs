﻿using DataAccess;
using DataAccess.Models;
using System.Windows.Input;

namespace BusinessLogic.MVVM.Commands
{
    public class LoginCommand : ICommand
    {
        LoginViewModel VM;
        public LoginCommand(LoginViewModel vm)
        {
            VM = vm;
        }
        public event EventHandler? CanExecuteChanged;
        
        public void FireEvent()
        {
            CanExecuteChanged?.Invoke(this, new EventArgs());
        }
        public bool CanExecute(object? parameter)
        {
            bool validData = false;
            Account? account = DbHelper.db.Accounts.FirstOrDefault(acc => acc.Email == VM.Email);
            
            if (account != null && account.Password == VM.Password)
            {
                validData = true;
                VM.ErrorMessage = "";
            }
            else
            {
                VM.ErrorMessage = "Wrong Password";
            }

            return validData;
        }

        public void Execute(object? parameter)
        {
            VM.ExecuteLoginCommand();
        }
    }
}
