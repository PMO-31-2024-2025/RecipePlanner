using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace UserInterface.MVVM.Commands.AccountCommands
{
    public class UpdateAccountInfoCommand : ICommand
    {
        private AccountViewModel VM;
        public UpdateAccountInfoCommand(AccountViewModel vm)
        {
            VM = vm;
        }
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            VM.ChangeAccountInfo();
        }
    }
}
