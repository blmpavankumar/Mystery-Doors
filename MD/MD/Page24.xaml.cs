﻿using System;
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
    public partial class Page24 : PhoneApplicationPage
    {
        public Page24()
        {
            InitializeComponent();
            System.Threading.Thread startupThread =
                           new System.Threading.Thread(new System.Threading.ThreadStart(timeDec));
            startupThread.Start();
        }
        Boolean flag1 = true;
        void timeDec()
        {
            int k = 20, j = 1, m = 0;

            for (int i5 = 0; i5 < 101; i5++)
            {
                System.Threading.Thread.Sleep(1000);

                this.Dispatcher.BeginInvoke(() =>
                {
                    if (flag1)
                    {
                        if (flag4)
                        {
                            string s1;
                            s1 = textBlock8.Text;
                            int num = int.Parse(s1);
                            num--;
                            s1 = num.ToString();
                            textBlock8.Text = s1;
                            //int q = int.Parse(s1);
                            if (i5 == 100)
                            {
                                flag1 = false;
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
        int m = 2, i = 3;
        Boolean flag = true;
        Boolean flag2 = true;
        Boolean flag3 = true;
        Boolean flag4 = true;
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            if (flag)
            {
                string s1;
                s1 = textBox1.Text;
                if (s1 == "96542")
                {
                    textBlock4.Visibility = Visibility.Collapsed;
                    textBlock5.Visibility = Visibility.Collapsed;
                    button3.Content = "continue"; flag = false; flag4 = false;
                    textBlock2.Text = "You got it Right. All 7 letters are unlocked...Press Continue";
                    textBlock15.Text = "A";
                    textBlock16.Text = "P";
                    textBlock17.Text = "C";
                }
                else
                {
                    textBlock6.Text = "Sorry You are wrong !!!";
                    textBox1.Text = "";
                    if (m != 0)
                    {

                        if (m == 2)
                        {
                            textBlock6.Text = "Sorry You are wrong !!!";
                            textBlock5.Text = "2"; m--;
                        }
                        else if (m == 1)
                        {
                            textBlock6.Text = "Sorry You are wrong again !!!";
                            textBlock5.Text = "1"; m--;
                        }
                    }
                    else
                    {
                        if (flag2)
                        {
                            if (flag3)
                            {
                                image2.Visibility = Visibility.Collapsed;
                                textBlock6.Text = "You lost a life !!! ";
                                textBlock5.Text = "3";
                                m = 2;
                                flag3 = false;
                            }
                            else
                            {
                                image7.Visibility = Visibility.Collapsed;
                                textBlock6.Text = "You lost a second life !!! ";
                                textBlock5.Text = "3";
                                m = 2;

                                flag2 = false;
                            }
                        }
                        else
                        {
                            NavigationService.Navigate(new Uri("/Page35.xaml", UriKind.Relative));
                        }
                    }
                }
            }

            else
            {
                NavigationService.Navigate(new Uri("/Page25.xaml", UriKind.Relative));
            }
        }
    }
}