using BusinessLogic;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace UserInterface.MVVM.Commands.RecipeCommands
{
    public class SaveNewDishCommand : ICommand
    {
        private RecipesViewModel VM;
        public SaveNewDishCommand(RecipesViewModel vm)
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
            bool res = VM.SaveNewDish(VM.DishToEditOrDelete);
            if (res == true)
            {
                MessageBox.Show($"{VM.DishToEditOrDelete.Title} has been updated successfully", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                App.RightSideFrame.Navigate(App.MyRecipesWindow);
            }
        }
    }
}
