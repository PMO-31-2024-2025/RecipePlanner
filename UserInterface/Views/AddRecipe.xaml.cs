using BusinessLogic;
using DataAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UserInterface.Views
{
    /// <summary>
    /// Interaction logic for AddEditRecipe.xaml
    /// </summary>
    public partial class AddRecipe : Page
    {
        public ObservableCollection<Ingredient> Ingredients = new ObservableCollection<Ingredient>();
        
        Dish? dishToEdit;
        Account LoginedAccount;
        public AddRecipe(Account account, Dish? dish=null)
        {
            dishToEdit = dish;
            LoginedAccount = account;
            InitializeComponent();

            IngredientListView.ItemsSource = Ingredients;
        }
        private void AddRecipeButton_Click(object sender, RoutedEventArgs e)
        {
            string ingredients = "";
            foreach (Ingredient ingredient in Ingredients)
            {
                ingredients += $"{ingredient.IngredientName},";
            }
            ingredients = ingredients.Substring(0, ingredients.Length - 1);

            Dish dishToAdd = new Dish()
            {
                AccountEmail = LoginedAccount.Email,
                Title = RecipeTitle.Text,
                Recipe = RecipeTextBox.Text,
                Ingredients = ingredients,
                Calories = int.Parse(CaloriesTextBox.Text),
                Protein = int.Parse(ProteingTextBox.Text),
                Carbs = int.Parse(CarbsTextBox.Text),
                Fat = int.Parse(FatTextBox.Text),
            };

            DbHelper.db.Add(dishToAdd);
            DbHelper.db.SaveChanges();
            MessageBox.Show("Dish successfully added!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void IngredientAddButton_Click(object sender, RoutedEventArgs e)
        {
            Ingredients.Add(new Ingredient() { IngredientName = IngredientTextBox.Text });
        }

        private void IngredientRemoveButton_Click(object sender, RoutedEventArgs e)
        {
            Ingredient? selectedIngreditent = IngredientListView.SelectedItem as Ingredient;

            if (selectedIngreditent == null)
            {
                MessageBox.Show("No ingredient was selected", "Select Ingredient", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            Ingredients.Remove(selectedIngreditent);
        }
    }
}
