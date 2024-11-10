﻿using BusinessLogic;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for ThirdSurveyWindow.xaml
    /// </summary>
    public partial class ThirdSurveyWindow : Page
    {
        public ThirdSurveyWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button PressedButton = (Button)sender;
            if (PressedButton == NotVeryActiveButton)
            {
                DietCreator.ActivityLevel = DataAccess.ActivityLevel.Inactive;
                NotVeryActiveButton.Background = System.Windows.Media.Brushes.DarkGray;
                App.SurviesFrame.Navigate(App.SurveyWindow_4);


            }
            else if (PressedButton == ActiveButton)
            {
                DietCreator.ActivityLevel = DataAccess.ActivityLevel.Medium;
                ActiveButton.Background = System.Windows.Media.Brushes.DarkGray;
                App.SurviesFrame.Navigate(App.SurveyWindow_4);
            }
            else if (PressedButton == VeryActiveButton)
            {
                DietCreator.ActivityLevel = DataAccess.ActivityLevel.Active;
                VeryActiveButton.Background = System.Windows.Media.Brushes.DarkGray;
                App.SurviesFrame.Navigate(App.SurveyWindow_4);
            }
        }
    }
}
