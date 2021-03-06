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
using System.Windows.Shapes;

namespace GameOfLight
{
    /// <summary>
    /// Interaction logic for MainMenuWindow.xaml
    /// </summary>
    public partial class MainMenuWindow : Window
    {
        public MainMenuWindow()
        {
            InitializeComponent();
        }

        private void BtnExitClick(object sender, RoutedEventArgs e)
        {
            Application app = Application.Current;
            app.Shutdown(); 
        }

        private void BtnResumeClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key.ToString() == "Escape")
            {
                Close();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LevelsWindow LW = new LevelsWindow();
            LW.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            RecordsWindow RW = new RecordsWindow();
            RW.ShowDialog();
        }

    }
}
