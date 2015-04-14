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
           // mmm();
            if (e.Key.ToString() == "Escape")
            {
                WindowBlur.Radius = 20;
                MainMenuWindow MMW = new MainMenuWindow();
                MMW.ShowDialog();
                WindowBlur.Radius = 0;
            }
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        static void mmm()
        {
            using (var db = new DBaseContext())
            {
                //int n = 1;
                //string s = "asdf";
                //var Level = new Level(n, s);
                //db.Levels.Add(Level);
                //db.SaveChanges();
                var query = from b in db.Levels
                            orderby b.Name
                            select b;
                foreach (var item in query)
                {
                  //db.Levels.Remove(item);
                    MessageBox.Show(item.Name);
                }

            }
        }
    }
}
