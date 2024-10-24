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
    /// Interaction logic for RecipesWindow.xaml
    /// </summary>
    public partial class RecipesWindow : Page
    {
        Frame mainFrame;
        public RecipesWindow(Frame givenFrame)
        {
            InitializeComponent();
            mainFrame = givenFrame;
            RecipeListView.Items.Clear();
            RecipeListView.ItemsSource = DbHelper.db.Dishes.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddEditRecipe window = new AddEditRecipe();
            mainFrame.Navigate(window);
        }
    }
}
