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
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Xml;
using static suicide.MainWindow;

namespace suicide
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string cesta = "saveFile.xml";

        Promenny promenny;
        public MainWindow()
        {
            InitializeComponent();
            promenny = new Promenny();

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += clickAuto;
            timer.Start();


        }
        private void clickAuto(object sender, EventArgs e)
        {
            aktivni.Content = promenny.Counter.ToString();
            promenny.Counter += promenny.Passive;
            Debug.WriteLine(promenny.Counter + "+" + promenny.Passive + "+" + promenny.Mouseclick1);
        }


        public void Button_Click(object sender, RoutedEventArgs e)
        {
            promenny.Counter += promenny.Mouseclick1;
            aktivni.Content = promenny.Counter.ToString();
        }


        private void click_plus(object sender, RoutedEventArgs e)
        {
            promenny.Mouseclick1 = (promenny.Mouseclick1 * 2);
        }

        private void Upgrade(object sender, RoutedEventArgs e)
        {
            Upgrady Upgrades = new Upgrady();
            Upgrades.Show();
        }

        public class Promenny
        {
            Int64 counter = 0;
            Int64 Mouseclick = 1;
            Int64 passive = 0;

            public long Counter { get => counter; set => counter = value; }
            public long Mouseclick1 { get => Mouseclick; set => Mouseclick = value; }
            public int Passive { get => (int)passive; set => passive = value; }
        }


        private void Save(object sender, EventArgs e)
        {
            SaveData();
            void SaveData()
            {
                XmlSerializer serializer = new XmlSerializer(promenny.GetType());
                using (StreamWriter sw = new StreamWriter(cesta))
                {
                    serializer.Serialize(sw, promenny);
                }
            }

        }
        private void restore(object sender, RoutedEventArgs e)
        {
            RestoreData();
            void RestoreData()
            {
                XmlSerializer serializer = new XmlSerializer(promenny.GetType());
                if (File.Exists(cesta))
                {
                    using (StreamReader sr = new StreamReader(cesta))
                    {
                        promenny = (Promenny)serializer.Deserialize(sr);
                    }

                }
                //error message, no saveFile.xml detected
                else
                {
                    MessageBox.Show("cesta nelze najit", "Error");
                }
            }
        }



        #region steal
        private void klikplus1pass(object sender, RoutedEventArgs e)
        {
            if(promenny.Counter >= 100)
            {
                promenny.Counter -= 100;
                promenny.Passive++;
                aktivni.Content = promenny.Counter.ToString();
            }
        }

        private void klikplus5pass(object sender, RoutedEventArgs e)
        {
            if (promenny.Counter >= 170)
            {
                promenny.Counter -= 170;
                promenny.Passive += 5;
                aktivni.Content = promenny.Counter.ToString();
            }
        }
        private void klikplus10pass(object sender, RoutedEventArgs e)
        {
            if (promenny.Counter >= 289)
            {
                promenny.Counter -= 289;
                promenny.Passive += 10;
                aktivni.Content = promenny.Counter.ToString();
            }
        }

        private void klikplus20pass(object sender, RoutedEventArgs e)
        {
            if (promenny.Counter >= 491) 
            {
                promenny.Counter -= 491;
                promenny.Passive += 20;
                aktivni.Content = promenny.Counter.ToString();
            }
        }

        private void klikplus40pass(object sender, RoutedEventArgs e)
        {
            if (promenny.Counter >= 835) 
            {
                promenny.Counter -= 835;
                promenny.Passive += 40;
                aktivni.Content = promenny.Counter.ToString();
            }
        }

        private void klikplus80pass(object sender, RoutedEventArgs e)
        {
            if (promenny.Counter >= 1420) 
            {
                promenny.Passive += 80;
                aktivni.Content = promenny.Counter.ToString();
            }
        }

        private void klikplus160pass(object sender, RoutedEventArgs e)
        {
            if (promenny.Counter >= 2414)
            {
                promenny.Counter -= 2414;
                promenny.Passive += 160;
                aktivni.Content = promenny.Counter.ToString();
            }
        }

        private void klikplus320pass(object sender, RoutedEventArgs e)
        {
            if (promenny.Counter >= 4103)
            {
                promenny.Counter -= 4103;
                promenny.Passive +=320;
                aktivni.Content = promenny.Counter.ToString();
            }
        }
        private void klikplus640pass(object sender, RoutedEventArgs e)
        {
            if (promenny.Counter >= 6976) 
            {
                promenny.Counter -= 6976;
                promenny.Passive += 640;
                aktivni.Content = promenny.Counter.ToString();
            }
        }

        private void klikplus1280pass(object sender, RoutedEventArgs e)
        {
            if (promenny.Counter >= 11859)
            {
                promenny.Counter -= 11859;
                promenny.Passive += 1280;
                aktivni.Content = promenny.Counter.ToString();
            }
        }

        private void klikplus2560pass(object sender, RoutedEventArgs e)
        {
            if (promenny.Counter >= 20160)
            {
                promenny.Counter -= 20160;
                promenny.Passive += 2560;
                aktivni.Content = promenny.Counter.ToString();
            }
        }

        private void klikplus5120pass(object sender, RoutedEventArgs e)
        {
            if (promenny.Counter >= 34272)
            {
                promenny.Counter -= 34272;
                promenny.Passive += 5120;
                aktivni.Content = promenny.Counter.ToString();
            }
        }

        private void klikplus10240pass(object sender, RoutedEventArgs e)
        {
            if (promenny.Counter >= 58262)
            {
                promenny.Counter -= 58262;
                promenny.Passive += 10240;
                aktivni.Content = promenny.Counter.ToString();
            }
        }

        private void klikplus20480pass(object sender, RoutedEventArgs e)
        {
            if (promenny.Counter >= 99046)
            {
                promenny.Counter -= 99046;
                promenny.Passive += 20480;
                aktivni.Content = promenny.Counter.ToString();
            }
        }

        private void klikplus40960pass(object sender, RoutedEventArgs e)
        {
            if (promenny.Counter >= 168378)
            {
                promenny.Counter -= 168378;
                promenny.Passive += 40960;
                aktivni.Content = promenny.Counter.ToString();
            }
        }

        private void klikplus81920pass(object sender, RoutedEventArgs e)
        {
            if (promenny.Counter >= 286242)
            {
                promenny.Counter -= 286242;
                promenny.Passive += 81920;
                aktivni.Content = promenny.Counter.ToString();
            }
        }

        private void klikplus163840pass(object sender, RoutedEventArgs e)
        {
            if (promenny.Counter >= 486612)
            {
                promenny.Counter -= 486612;
                promenny.Passive += 163840;
                aktivni.Content = promenny.Counter.ToString();
            }
        }

        private void klikplus327680pass(object sender, RoutedEventArgs e)
        {
            if (promenny.Counter >= 827240)
            {
                promenny.Counter -= 827240;
                promenny.Passive += 327680;
                aktivni.Content = promenny.Counter.ToString();
            }
        }
        #endregion steal

        void endgame(object sender, EventArgs e)
        {
            if (promenny.Counter >= 1000000000000000000) //milion
            {
                Endgamos endgamos = new Endgamos();
                endgamos.Show();
            }
        }

    }  
}
