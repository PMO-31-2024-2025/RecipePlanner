using DataAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Principal;
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
    /// Interaction logic for RecipesWindow.xaml
    /// </summary>
    public partial class RecipesWindow : Page
    {
        private Frame mainFrame;
        private Account LoginedAccount;
        public RecipesWindow(Account account, Frame givenFrame)
        {
            mainFrame = givenFrame;
            LoginedAccount = account;

            InitializeComponent();
            ShowDishes();
        }

        private void ShowDishes(Func<Dish, bool>? filter = null, Func<Dish, int>? orderFilter = null)
        {
            if (filter != null && orderFilter != null)
            {
                RecipeListView.ItemsSource = LoginedAccount.Dishes!.Where(filter).OrderBy(orderFilter);
            }
            else if (filter != null && orderFilter == null)
            {
                RecipeListView.ItemsSource = LoginedAccount.Dishes!.Where(filter);
            }
            else if (filter == null && orderFilter != null)
            {
                RecipeListView.ItemsSource = LoginedAccount.Dishes!.OrderBy(orderFilter);
            }
            else
            {
                RecipeListView.ItemsSource = LoginedAccount.Dishes;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddRecipe window = new AddRecipe(LoginedAccount);
            mainFrame.Navigate(window);
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SeeRecipePage recipePage = new SeeRecipePage();
            mainFrame.Navigate(recipePage);
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            AddRecipe window = new AddRecipe(LoginedAccount);
            mainFrame.Navigate(window);
        }
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;

            string content = selectedItem.Content.ToString()!;
            switch (content)
            {
                case "Protein":
                    ShowDishes(null, dish => dish.Protein);
                    break;
                case "Carbs":
                    ShowDishes(null, dish => dish.Carbs);
                    break;
                case "Fat":
                    ShowDishes(null, dish => dish.Fat);
                    break;
            }
        }

        private void SearchTextbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string text = SearchTextbox.Text.ToString();
            if (string.IsNullOrEmpty(text) == false && char.IsDigit(text[0]))
            {
                ShowDishes((dish) => 
                {
                    int givenCaloriesCount = int.Parse(text);
                    int topBound = givenCaloriesCount + 250;
                    int bottomBound = givenCaloriesCount - 250;
                    return dish.Calories > bottomBound && dish.Calories < topBound;
                });
            }
            else if (string.IsNullOrEmpty(text) == false)
            {
                ShowDishes(dish => dish.Title.StartsWith(text));
            }
            else
            {
                ShowDishes();
            }
        }
    }
}
