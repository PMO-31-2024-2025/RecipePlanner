﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace UserInterface.MVVM.Commands.StatisticsCommands
{
    public class RemoveSelectedEntityCommand : ICommand
    {
        private StatisticsViewModel VM;
        public RemoveSelectedEntityCommand(StatisticsViewModel vm)
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
            VM.ExecuteRemoveSelectedEntityCommand();
        }
    }
}
