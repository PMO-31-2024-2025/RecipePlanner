﻿using System;
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
    /// Interaction logic for SecondSurveyWindow.xaml
    /// </summary>
    public partial class SecondSurveyWindow : Page
    {
        public SecondSurveyWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button PressedButton = (Button)sender;
            if (PressedButton == LessThan1000Button)
            {

            }
            else if (PressedButton == UpTo3000Button)
            {

            }
            else if (PressedButton == UpTo7000Button)
            {

            }
            else if (PressedButton == MoreThan7000Button)
            {

            }
            else if (PressedButton == NoIdeaButton)
            {

            }
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            App.SurviesFrame.Navigate(App.SurveyWindow_3);
        }
    }
}
