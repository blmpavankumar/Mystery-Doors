using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace MD
{
    public partial class Page16 : PhoneApplicationPage
    {
        public Page16()
        {
            InitializeComponent();
            System.Threading.Thread startupThread =
                             new System.Threading.Thread(new System.Threading.ThreadStart(timeDec));
            startupThread.Start();
        }
        Boolean flag = true;
        Boolean flag3 = true;
        void timeDec()
        {
            int k = 20, j = 1, m = 0;
            
            for (int i = 0; i < 121; i++)
            {
                System.Threading.Thread.Sleep(1000);

                this.Dispatcher.BeginInvoke(() =>
                {
                    if (flag)
                    {
                        if (flag3)
                        {
                            string s1;
                            s1 = textBlock7.Text;
                            int num = int.Parse(s1);
                            num--;
                            s1 = num.ToString();
                            textBlock7.Text = s1;
                            //int q = int.Parse(s1);
                            if (i == 120)
                            {
                                flag = false;
                            }
                        }
                        else
                        {
                            
                        }
                    }
                    else
                    {
                       // NavigationService.Navigate(new Uri("/Page36.xaml", UriKind.Relative));
                    }
                });
            }
            //    doStuff3();
        }
        private void image1_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Page17.xaml", UriKind.Relative));
        }
        int i = 3, m = 2;
        Boolean flag1 = true;
        Boolean flag2 = true;
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            string s1;
            s1 = textBox1.Text;
            if (s1 == "moral support")
            {
                flag3 = false;
                button1.Visibility = Visibility;
                textBlock10.Text = "E";
                textBlock11.Text = "C";
                textBlock2.Visibility = Visibility.Collapsed;
                textBlock3.Visibility = Visibility.Collapsed;
                textBlock5.Text = "You got it Right. 2 of 6 letters are unlocked...Press Continue";
            }
            else
            {
                textBlock5.Text = "Sorry You are wrong !!!";
                if (flag1 == false)
                {

                    
                }
                textBox1.Text = "";
                if (m != 0)
                {

                    if (m == 2)
                    {
                        textBlock5.Text = "Sorry You are wrong !!!";
                        textBlock3.Text = "2"; m--;
                    }
                    else if (m == 1)
                    {
                        textBlock5.Text = "Sorry You are wrong again !!!";
                        textBlock3.Text = "1"; m--;
                    }
                }
                else
                {
                    if (flag2)
                    {
                        image3.Visibility = Visibility.Collapsed;
                        textBlock5.Text = "You lost a life !!! ";
                        textBlock3.Text = "3";
                        m = 2;
                        flag2 = false;
                    }
                    else
                    {
                        NavigationService.Navigate(new Uri("/Page35.xaml", UriKind.Relative));
                    }
                }
            }
        }
    }
}