using BusinessLogic;
using DataAccess.Models;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace UserInterface.Views
{
    public partial class RecipesWindow : Page
    {
        public RecipesWindow()
        {
            InitializeComponent();
        }

        private void ShowDishes(Func<Dish, bool>? filter = null, Func<Dish, int>? orderFilter = null)
        {
            if (filter != null && orderFilter != null)
            {
                RecipeListView.ItemsSource = Globals.LoginedAccount.Dishes!.Where(filter).OrderBy(orderFilter);
            }
            else if (filter != null && orderFilter == null)
            {
                RecipeListView.ItemsSource = Globals.LoginedAccount.Dishes!.Where(filter);
            }
            else if (filter == null && orderFilter != null)
            {
                RecipeListView.ItemsSource = Globals.LoginedAccount.Dishes!.OrderBy(orderFilter);
            }
            else
            {
                RecipeListView.ItemsSource = Globals.LoginedAccount.Dishes;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.RightSideFrame.Navigate(App.MyAddRecipeWindow);
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            App.RightSideFrame.Navigate(App.MySeeRecipeWindow);
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            App.RightSideFrame.Navigate(App.MyAddRecipeWindow);
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
