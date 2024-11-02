using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace UserInterface.MVVM.Commands.RecipeCommands
{
    public class SeeRecipeCommand : ICommand
    {
        private RecipesViewModel VM;
        public SeeRecipeCommand(RecipesViewModel vm)
        {
            VM = vm;
        }
        public void FireEvent()
        {
            CanExecuteChanged?.Invoke(this, new EventArgs());
        }
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            VM.ExecuteSeeRecipeCommand(parameter!);
        }
    }
}
