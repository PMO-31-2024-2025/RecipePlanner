using UserInterface.MVVM.Commands.AuthenticationCommands;
using DataAccess;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using BusinessLogic;
using System.Windows;
using UserInterface.Views;
using UserInterface.MVVM.Helpers;

namespace UserInterface.MVVM
{
    public class LoginViewModel : BaseViewModel
    {
        #region Fields
        private string _email = "oleh.chyzhov@gmail.com";
        private string _password = "Oleg2005";
        private string _errorMessage;
        #endregion

        #region Properties
        public string Email 
        { 
            get
            {
                return _email;
            } 
            set
            {
                _email = value;
                OnPropertyChanged(nameof(Email));
                LoginCommand.FireEvent();
                RegisterCommand.FireEvent();
            } 
        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
                LoginCommand.FireEvent();
                RegisterCommand.FireEvent();
            }
        }
        public string ErrorMessage
        {
            get
            {
                return _errorMessage;
            }
            set
            {
                _errorMessage = value;
                OnPropertyChanged(nameof(ErrorMessage));
            }
        }
        #endregion

        #region Commands
        public LoginCommand LoginCommand { get; }
        public RegisterCommand RegisterCommand { get; }
        
        #endregion

        #region Constructors
        public LoginViewModel()
        {
            LoginCommand = new LoginCommand(this);
            RegisterCommand = new RegisterCommand(this);
        }
        #endregion

        #region Methods
        public void ExecuteLoginCommand()
        {
            AccountManager.LoginedAccount = AccountManager.UpdateLoginedAccount(Email);
            App.MyMainWindow = WindowIntitializer.InitMainWindow();
            App.MyMainWindow.Show();
            App.MyLoginWindow.Close();
        }

        public void ExecuteRegisterCommand()
        {
            if (!Email.Contains("@gmail."))
            {
                MessageBox.Show("Invalid Email", "Register Failure", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            Account registeredAccount = new Account()
            {
                Email = Email,
                Password = Password
            };
            try
            {
                DbHelper.db.Accounts.Add(registeredAccount);
                //DbHelper.db.SaveChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show("Account already exists", "Register Failure", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            App.MyLoginWindow.LoginBorder.Visibility = Visibility.Hidden;
            App.MyLoginWindow.SurviesBorder.Visibility = Visibility.Visible;
            App.MyLoginWindow.SurviesFrame.Navigate(App.SurveyWindow_1);
        }
        #endregion
    }
}
