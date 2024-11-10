using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace UserInterface.MVVM.Commands.RecipeCommands
{
    public class AddNewDishCommand : ICommand
    {
        public RecipesViewModel VM;
        public AddNewDishCommand(RecipesViewModel vm)
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
            bool res = VM.SaveNewDish(VM.NewDish);
            if (res == true)
            {
                VM.ShowDishes();
                MessageBox.Show("Recipe Added Successfully", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                App.RightSideFrame.Navigate(App.MyRecipesWindow);
            }
        }
    }
}
