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
                    //ShowDishes(null, dish => dish.Protein);
                    break;
                case "Carbs":
                    //ShowDishes(null, dish => dish.Carbs);
                    break;
                case "Fat":
                    //ShowDishes(null, dish => dish.Fat);
                    break;
            }
        }
    }
}
