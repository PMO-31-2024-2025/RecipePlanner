﻿using BusinessLogic;
using DataAccess;
using DataAccess.Models;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using UserInterface.MVVM.Commands.RecipeCommands;

namespace UserInterface.MVVM
{
    public class RecipesViewModel : BaseViewModel 
    {
        #region Fields
        private string _searchFilter = "";
        private string _orderFilter = "";
        private Dish _dishToEditOrDelete;
        private string _newIngredient = "New Ingredient";
        #endregion

        #region Properties
        public ObservableCollection<Dish> Dishes { get; set; }
        public Dish DishToEditOrDelete
        { 
            get 
            {
                return _dishToEditOrDelete;
            }
            set
            {
                _dishToEditOrDelete = value;
                OnPropertyChanged(nameof(DishToEditOrDelete));
            } 
        }
        public ObservableCollection<string> IngredientsOfDishToEditOrDelete { get; set; }
        public string SearchFilter 
        {
            get { return _searchFilter; } 
            set
            {
                _searchFilter = value;
                OnPropertyChanged(nameof(SearchFilter));
                FilterCommand.FireEvent();
            } 
        }
        public string OrderFilter
        {
            get { return _orderFilter; }
            set
            {
                _orderFilter = value.Replace(" ", "").Split(":")[1];
                OnPropertyChanged(nameof(OrderFilter));
                ExecuteOrderCommand();
            }
        }
        public string NewIngredient
        {
            get { return _newIngredient; }
            set
            {
                _newIngredient = value;
                OnPropertyChanged(nameof(NewIngredient));
            }
        }
        #endregion

        #region Commands
        public FilterCommand FilterCommand { get; }
        public SeeRecipeCommand SeeRecipeCommand { get; }
        public AddRecipeCommand AddRecipeCommand { get; }
        public EditRecipeCommand EditRecipeCommand { get; }
        public RemoveRecipeCommand RemoveRecipeCommand { get; }
        public SaveNewDishCommand UpdateOrAddDishCommand { get; }
        public AddIngredientCommand AddIngredientCommand { get; }
        public RemoveIngredient RemoveIngedientCommand { get; }
        #endregion

        #region Constructors
        public RecipesViewModel()
        {
            FilterCommand = new FilterCommand(this);
            SeeRecipeCommand = new SeeRecipeCommand(this);
            AddRecipeCommand = new AddRecipeCommand(this);
            EditRecipeCommand = new EditRecipeCommand(this);
            RemoveRecipeCommand = new RemoveRecipeCommand(this);
            UpdateOrAddDishCommand = new SaveNewDishCommand(this);
            AddIngredientCommand = new AddIngredientCommand(this);
            RemoveIngedientCommand = new RemoveIngredient(this);

            Dishes = new ObservableCollection<Dish>();
            IngredientsOfDishToEditOrDelete = new ObservableCollection<string>();
            ShowDishes();
        }
        #endregion

        #region MainWindow Methods
        public void ExecuteFilterCommand()
        {
            bool isValue = true;
            foreach (char letter in SearchFilter)
            {
                if (char.IsLetter(letter))
                {
                    isValue = false;
                }
            }
            if (string.IsNullOrEmpty(SearchFilter) == false && isValue)
            {
                ShowDishes((dish) =>
                {
                    int givenCaloriesCount = int.Parse(SearchFilter);
                    int topBound = givenCaloriesCount + 250;
                    int bottomBound = givenCaloriesCount - 250;
                    return dish.Calories > bottomBound && dish.Calories < topBound;
                });
            }
            else if (string.IsNullOrEmpty(SearchFilter) == false)
            {
                ShowDishes(dish => dish.Title.StartsWith(SearchFilter));
            }
            else
            {
                ShowDishes();
            }
        }
        public void ExecuteOrderCommand()
        {
            List<Dish> dishesCopy = Dishes.ToList();

            switch (OrderFilter)
            {
                case "Protein":
                    dishesCopy = Dishes.OrderBy(dish => dish.Protein).ToList();
                    break;
                case "Carbs":
                    dishesCopy = Dishes.OrderBy(dish => dish.Carbs).ToList();
                    break;
                case "Fat":
                    dishesCopy = Dishes.OrderBy(dish => dish.Fat).ToList();
                    break;
            }
            RefillDishes(dishesCopy);
        }
        private void ShowDishes(Func<Dish, bool>? filter = null)
        {
            List<Dish> dishes;

            if (filter != null)
            {
                dishes = AccountManager.LoginedAccount.Dishes!.Where(filter).ToList();
            }
            else
            {
                dishes = AccountManager.LoginedAccount.Dishes!.ToList();

            }
            RefillDishes(dishes);
        }
        private void RefillDishes(List<Dish> dishes)
        {
            Dishes.Clear();
            foreach (Dish dish in dishes)
            {
                Dishes.Add(dish);
            }
        }
        private void RefillIngredientsOfDishToEditOrDelete(List<string> ingredients)
        {
            IngredientsOfDishToEditOrDelete.Clear();
            foreach (string ingredient in ingredients)
            {
                IngredientsOfDishToEditOrDelete.Add(ingredient);
            }
        }

        public void SaveNewDish(Dish dish)
        {
            // Saving Ingredients
            string modifiedIngredients = "";
            for (int i = 0; i < IngredientsOfDishToEditOrDelete.Count-1; i++)
            {
                modifiedIngredients += $"{IngredientsOfDishToEditOrDelete[i]},";
            }
            modifiedIngredients += IngredientsOfDishToEditOrDelete.Last();
            Dish dishToSave = dish;
            dishToSave.Ingredients = modifiedIngredients;

            // Saving the dish
            Dish? dishFromDb = DbHelper.db.Dishes.FirstOrDefault(d => d.Id == dish.Id);
            if (dishFromDb == null)
            {
                dishToSave.AccountEmail = AccountManager.LoginedAccount.Email;
                DbHelper.db.Dishes.Add(dishToSave);

            }
            else
            {
                DbHelper.db.Dishes.Update(dish);
            }
            DbHelper.db.SaveChanges();
        }
        #endregion

        #region See Recipe Methods
        public void ExecuteSeeRecipeCommand(object dish)
        {
            App.RightSideFrame.Navigate(App.MySeeRecipeWindow);
            App.MySeeRecipeWindow.DataContext = this;
            DishToEditOrDelete = (Dish)dish;

            List<string> newIngredients = DishToEditOrDelete.Ingredients.Split(",").ToList();
            RefillIngredientsOfDishToEditOrDelete(newIngredients);
        }
        #endregion

        #region Add Recipe Methods
        public void ExecuteAddRecipeCommand()
        {
            MessageBox.Show($"Add Recipe");
            App.RightSideFrame.Navigate(App.MyAddEditRecipeWindow);
        }
        #endregion

        #region Edit Recipe Methods
        public void ExecuteEditRecipeCommand(object dish)
        {
            App.RightSideFrame.Navigate(App.MyAddEditRecipeWindow);
            App.MyAddEditRecipeWindow.DataContext = this;
            DishToEditOrDelete = (Dish)dish;

            List<string> newIngredients = DishToEditOrDelete.Ingredients.Split(",").ToList();
            RefillIngredientsOfDishToEditOrDelete(newIngredients);
        }
        #endregion

        #region Remove Recipe Methods
        public void ExecuteRemoveRecipeCommand(object dish)
        {
            MessageBox.Show($"Remove Recipe: {dish.ToString()}");
        }
        #endregion
    }
}
