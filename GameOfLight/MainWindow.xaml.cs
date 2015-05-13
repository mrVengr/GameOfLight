using GameOfLight.Lib;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.Entity;

namespace GameOfLight
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key.ToString() == "Escape")
            {
                mmm();
                WindowBlur.Radius = 20;
                MainMenuWindow MMW = new MainMenuWindow();
                MMW.ShowDialog();
                WindowBlur.Radius = 0;
            }
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        public void mmm()
        {
            //
            //string str = "QuickStart";
            //Level level = new Level(q, str);
            //level.SaveToDB();
            //foreach (var level in Level.LoadAllFromDB())
            //{
            //    MessageBox.Show(level.Name);
            //}
            
        }

    }
}
