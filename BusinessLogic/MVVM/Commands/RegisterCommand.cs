using DataAccess;
using System.Windows.Input;

namespace BusinessLogic.MVVM.Commands
{
    public class RegisterCommand : ICommand
    {
        private LoginViewModel VM;
        public RegisterCommand(LoginViewModel vm)
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
            bool isValid = false;
            if (DbHelper.db.Accounts.FirstOrDefault(acc => acc.Email == VM.Email) == null)
            {
                isValid = true;
            }
            return isValid;
        }

        public void Execute(object? parameter)
        {
            VM.ExecuteRegisterCommand();
        }
    }
}
