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
using suicide.Model;
using System.Windows.Threading;
using System.Diagnostics.Metrics;

namespace suicide
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Int64 counter = 0;
        int clickPower = 1;
        int passive = 0;

        public MainWindow()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += clickAuto;
            timer.Start();
        }
        private void clickAuto(object sender, RoutedEventArgs e)
        {
            aktivni.Content = counter.ToString();
            counter += passive;
        }


        public void Button_Click(object sender, RoutedEventArgs e)
        {
            counter += clickPower;
            aktivni.Content = counter.ToString();
        }


        private void click_plus(object sender, RoutedEventArgs e)
        {
            clickPower++;
        }
        private void clickAuto1(object sender, RoutedEventArgs e)
        {
            passive++;
        }















        private void Upgrade(object sender, RoutedEventArgs e)
        {
            Upgrady Upgrades = new Upgrady();
            Upgrades.Show();
        }


        private void endgame(object sender, EventArgs e)
        {
            if (counter >= 1000000) //milion
            {
                Endgamos endgamos = new Endgamos();
                endgamos.Show();
            }
        }

    }  
}
