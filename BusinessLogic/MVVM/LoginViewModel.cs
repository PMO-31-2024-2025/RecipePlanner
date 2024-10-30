using BusinessLogic.MVVM.Commands.AuthenticationCommands;
using DataAccess;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace BusinessLogic.MVVM
{
    public class LoginViewModel : BaseViewModel
    {
        #region Fields
        private string _email = "UserName";
        private string _password = "Password";
        private string _errorMessage;
        private bool _isLoginSuccessful = false;
        private bool _timeToStartGainingAdditionalInformation = false;
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
        public bool IsLoginSuccessful
        {
            get
            {
                return _isLoginSuccessful;
            }
            set
            {
                _isLoginSuccessful = value;
                OnPropertyChanged(nameof(IsLoginSuccessful));
            }
        }
        public bool GainAdditionalInformation
        {
            get
            {
                return _timeToStartGainingAdditionalInformation;
            }
            set
            {
                _timeToStartGainingAdditionalInformation = value;
                OnPropertyChanged(nameof(GainAdditionalInformation));
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
            Globals.LoginedAccount = DbHelper.db.Accounts.Where(acc => acc.Email == Email).Include("AccountInfo").Include("Dishes").First();
            IsLoginSuccessful = true;
        }

        public void ExecuteRegisterCommand()
        {
            Account registeredAccount = new Account()
            {
                Email = Email,
                Password = Password
            };

            DbHelper.db.Accounts.Add(registeredAccount);
            //DbHelper.db.SaveChanges();

            GainAdditionalInformation = true;
        }
        #endregion
    }
}
