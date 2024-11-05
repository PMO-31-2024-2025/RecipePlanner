using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace UserInterface.MVVM.Commands.StatisticsCommands
{
    public class AddNewEntityCommand : ICommand
    {
        private StatisticsViewModel VM;
        public AddNewEntityCommand(StatisticsViewModel vm)
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
            VM.ExecuteAddNewEntityCommand();
        }
    }
}
