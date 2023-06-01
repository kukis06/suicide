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
using System.Diagnostics;
using System.Security.AccessControl;
using System.IO;

namespace suicide
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Int64 counter = 0;
        Int64 Mouseclick = 1;
        public Int32 passive = 0;

        public MainWindow()
        {
            InitializeComponent();

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += clickAuto;
            timer.Start();


        }
        private void clickAuto(object sender, EventArgs e)
        {
            aktivni.Content = counter.ToString();
            counter += passive;
            Debug.WriteLine(counter + "+" + passive + "+" + Mouseclick);
        }


        public void Button_Click(object sender, RoutedEventArgs e)
        {
            counter += Mouseclick;
            aktivni.Content = counter.ToString();
        }


        private void click_plus(object sender, RoutedEventArgs e)
        {
            Mouseclick = (Mouseclick * 2);
        }

        private void Upgrade(object sender, RoutedEventArgs e)
        {
            Upgrady Upgrades = new Upgrady();
            Upgrades.Show();
        }




        private void Save(object sender, EventArgs e)
        {
            if (true)
            {
            TextWriter txt = new StreamWriter("C:\\Users\\Petr\\source\\repos\\kukis06\\suicide\\suicide\\bin\\Debug\\net6.0-windows\\Save.txt");
            txt.Write(aktivni.Content);
            txt.Close();
            }
            else
            {

            }
        }



        private void klikplus1pass(object sender, RoutedEventArgs e)
        {
            if(counter >= 100)
            {
                counter -= 100;
                passive++;
                aktivni.Content = counter.ToString();
            }
        }

        private void klikplus5pass(object sender, RoutedEventArgs e)
        {
            if (counter >= 170)
            {
                counter -= 170;
                passive+= 5;
                aktivni.Content = counter.ToString();
            }
        }
        private void klikplus10pass(object sender, RoutedEventArgs e)
        {
            if (counter >= 289)
            {
                counter -= 289;
                passive += 10;
                aktivni.Content = counter.ToString();
            }
        }

        private void klikplus20pass(object sender, RoutedEventArgs e)
        {
            if (counter >= 491) 
            { 
                counter -= 491;
                passive += 20;
                aktivni.Content = counter.ToString();
            }
        }

        private void klikplus40pass(object sender, RoutedEventArgs e)
        {
            if (counter >= 835) 
            { 
                counter -= 835;
                passive += 40;
                aktivni.Content = counter.ToString();
            }
        }

        private void klikplus80pass(object sender, RoutedEventArgs e)
        {
            if (counter >= 1420) 
            { 
                counter -= 1420;
                passive += 80;
                aktivni.Content = counter.ToString();
            }
        }

        private void klikplus160pass(object sender, RoutedEventArgs e)
        {
            if (counter >= 2414) 
            {
                counter -= 2414;
                passive += 160;
                aktivni.Content = counter.ToString();
            }
        }

        private void klikplus320pass(object sender, RoutedEventArgs e)
        {
            if (counter >= 4103) 
            {
                counter -= 4103;
                passive +=320;
                aktivni.Content = counter.ToString();
            }
        }
        private void klikplus640pass(object sender, RoutedEventArgs e)
        {
            if (counter >= 6976) 
            { 
                counter -= 6976;
                passive += 640;
                aktivni.Content = counter.ToString();
            }
        }

        private void klikplus1280pass(object sender, RoutedEventArgs e)
        {
            if (counter >= 11859)
            {
                counter -= 11859;
                passive += 1280;
                aktivni.Content = counter.ToString();
            }
        }

        private void klikplus2560pass(object sender, RoutedEventArgs e)
        {
            if (counter >= 20160)
            {
                counter -= 20160;
                passive += 2560;
                aktivni.Content = counter.ToString();
            }
        }

        private void klikplus5120pass(object sender, RoutedEventArgs e)
        {
            if (counter >= 34272)
            {
                counter -= 34272;
                passive += 5120;
                aktivni.Content = counter.ToString();
            }
        }

        private void klikplus10240pass(object sender, RoutedEventArgs e)
        {
            if (counter >= 58262)
            {
                counter -= 58262;
                passive += 10240;
                aktivni.Content = counter.ToString();
            }
        }

        private void klikplus20480pass(object sender, RoutedEventArgs e)
        {
            if (counter >= 99046)
            {
                counter -= 99046;
                passive += 20480;
                aktivni.Content = counter.ToString();
            }
        }

        private void klikplus40960pass(object sender, RoutedEventArgs e)
        {
            if (counter >= 168378)
            {
                counter -= 168378;
                passive += 40960;
                aktivni.Content = counter.ToString();
            }
        }

        private void klikplus81920pass(object sender, RoutedEventArgs e)
        {
            if (counter >= 286242)
            {
                counter -= 286242;
                passive += 81920;
                aktivni.Content = counter.ToString();
            }
        }

        private void klikplus163840pass(object sender, RoutedEventArgs e)
        {
            if (counter >= 486612)
            {
                counter -= 486612;
                passive += 163840;
                aktivni.Content = counter.ToString();
            }
        }

        private void klikplus327680pass(object sender, RoutedEventArgs e)
        {
            if (counter >= 827240)
            {
                counter -= 827240;
                passive += 327680;
                aktivni.Content = counter.ToString();
            }
        }

        void endgame(object sender, EventArgs e)
        {
            if (counter >= 1000000000000000000) //milion
            {
                Endgamos endgamos = new Endgamos();
                endgamos.Show();
            }
        }


    }  
}
