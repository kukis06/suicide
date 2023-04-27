using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Data.SQLite;
using System.Windows.Shapes;
using System.Reflection.Metadata;

namespace suicide
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int counter = 0;
        private static object txtData;

        public MainWindow()
        {
            InitializeComponent();

        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            counter++;
            aktivni.Content = counter.ToString();
        }

        private void click_plus(object sender, RoutedEventArgs e) 
        {
            
        }
    }
}
